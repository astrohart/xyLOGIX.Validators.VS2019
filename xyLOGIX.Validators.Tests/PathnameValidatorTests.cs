using Alphaleonis.Win32.Filesystem;
using NUnit.Framework;
using System;
using System.Diagnostics;
using xyLOGIX.Tests.Logging;

namespace xyLOGIX.Validators.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see cref="T:xyLOGIX.Validators.PathnameValidator" /> class.
    /// </summary>
    [TestFixture]
    public class PathnameValidatorTests : LoggingTestBase
    {
        /// <summary>
        /// A properly-formatted pathname on the Windows filesystem.
        /// </summary>
        private static readonly string CorrectFolderPathname = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
            @"source\repos\astrohart\xyLOGIX.Validators.2019"
        );

        /// <summary>
        /// Tests the <see cref="IPathnameValidator.IsValidFolderPath" /> method
        /// to ensure it returns <see langword="false" /> when provided with a folder path
        /// that exceeds the maximum path length allowed by the Windows operating system.
        /// </summary>
        [Test]
        public void IsValidFolderPath_ExceedsMaxPathLength_ReturnsFalse()
        {
            // Determine max allowed path length based on system settings
            var maxPathLength = Is.LongPathSupportEnabled()
                ? MaxPathLength.NTFS
                : MaxPathLength.Legacy;

            // Generate a path that exceeds the current limit
            var longPath = @"C:\" + new string('A', maxPathLength + 1) + @"\";

            // Assert that it is invalid
            Assert.That(!PathnameValidator.IsValidFolderPath(longPath));
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.Validators.Interfaces.IPathnameValidator" /> interface.
        /// </summary>
        private static IPathnameValidator PathnameValidator
        {
            [DebuggerStepThrough] get;
        } = GetPathnameValidator.SoleInstance();

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:xyLOGIX.Validators.Interfaces.IPathnameValidator.IsValidFolderPath" />
        /// method returns <see langword="true" /> when provided with a correctly-formatted
        /// folder pathname as input.
        /// </summary>
        [Test]
        public void Test_CorrectPathname_IsValidated()
            => Assert.That(
                PathnameValidator.IsValidFolderPath(CorrectFolderPathname)
            );

        /// <summary>
        /// Tests the
        /// <see
        ///     cref="M:xyLOGIX.Validators.Interfaces.IPathnameValidator.IsValidFolderPath" />
        /// method to ensure it returns <see langword="false" /> when provided with
        /// pathnames that are incorrectly formatted for Windows operating system
        /// requirements.
        /// </summary>
        /// <remarks>
        /// This unit test is designed to validate that the method correctly
        /// rejects paths containing prohibited characters, malformed formats, or reserved
        /// device names.
        /// </remarks>
        /// <param name="invalidPath">
        /// (Required.) A <see cref="T:System.String" />
        /// containing an invalid pathname intended for testing. Examples include names
        /// with restricted characters such as <c>*</c>, <c>?</c>, <c>|</c>, or reserved
        /// device names.
        /// </param>
        /// <seealso
        ///     cref="M:xyLOGIX.Validators.Interfaces.IPathnameValidator.IsValidFolderPath" />
        [Test,
         TestCase(
             "C:\\folder\\sub*folder",
             Description = "Invalid path with '*' character"
         ),
         TestCase(
             "C:\\folder<subfolder>",
             Description = "Invalid path with '<' character"
         ),
         TestCase(
             "C:\\folder|subfolder",
             Description = "Invalid path with '|' character"
         ),
         TestCase(
             "C:\\folder\\sub?folder",
             Description = "Invalid path with '?' character"
         ),
         TestCase("\\folder\\subfolder", Description = "Missing drive letter"),
         TestCase(
             "C:folder\\subfolder",
             Description = "Missing backslash after drive letter"
         ),
         TestCase("\\\\server\\", Description = "UNC path missing share name"),
         TestCase(
             "C:\\folder\\NUL\\file.txt",
             Description = "Path with reserved name 'NUL'"
         ),
         TestCase(
             "C:/folder/subfolder",
             Description = "Path with forward slashes instead of backslashes"
         ), TestCase("", Description = "Empty path"),
         TestCase("   ", Description = "Whitespace-only path")]
        public void IsValidFolderPath_InvalidPaths_ReturnsFalse(
            string invalidPath
        )
            => Assert.That(!PathnameValidator.IsValidFolderPath(invalidPath));

        /// <summary>
        /// Tests the <see cref="IPathnameValidator.IsValidFolderPath" />
        /// method to ensure it returns <see langword="true" /> when provided with
        /// valid folder pathnames.
        /// </summary>
        /// <param name="validPath">
        /// (Required.) A <see cref="T:System.String" /> containing a valid pathname
        /// intended for testing.
        /// Examples include root drive paths, alternate drive paths, UNC paths, and folder
        /// names starting with a dot.
        /// </param>
        /// <seealso cref="IPathnameValidator.IsValidFolderPath" />
        [Test, TestCase("C:\\", Description = "Valid root drive path"),
         TestCase("D:\\", Description = "Valid alternate drive path"),
         TestCase("\\\\server\\share\\", Description = "Valid UNC path"),
         TestCase(
             "C:\\.config\\", Description = "Valid folder starting with dot"
         )]
        public void IsValidFolderPath_ValidPaths_ReturnsTrue(string validPath)
            => Assert.That(PathnameValidator.IsValidFolderPath(validPath));

        /// <summary>
        /// Tests the <see cref="IPathnameValidator.IsValidFolderPath" /> method
        /// to ensure it returns <see langword="false" /> when provided with
        /// drive letters only, such as <c>C:</c> or <c>D:</c>.
        /// </summary>
        /// <param name="invalidPath">
        /// (Required.) A <see cref="T:System.String" />
        /// containing an invalid pathname that includes drive letters only.
        /// </param>
        /// <seealso cref="IPathnameValidator.IsValidFolderPath" />
        [Test, TestCase("C:", Description = "Drive letter without backslash"),
         TestCase(
             "D:", Description = "Alternate drive letter without backslash"
         )]
        public void IsValidFolderPath_DriveLetterOnly_ReturnsFalse(
            string invalidPath
        )
            => Assert.That(!PathnameValidator.IsValidFolderPath(invalidPath));

        /// <summary>
        /// Tests the <see cref="IPathnameValidator.IsValidFolderPath" /> method
        /// to ensure it returns <see langword="false" /> when provided with pathnames that
        /// are reserved device names, such as <c>PRN</c>, <c>AUX</c>, <c>LPT1</c>, or
        /// <c>COM3</c>.
        /// </summary>
        /// <param name="invalidPath">
        /// (Required.) A <see cref="T:System.String" />
        /// containing an invalid pathname that includes reserved device names such as
        /// <c>PRN</c>, <c>AUX</c>, <c>LPT1</c>, or <c>COM3</c>.
        /// </param>
        /// <seealso cref="IPathnameValidator.IsValidFolderPath" />
        [Test,
         TestCase(
             "C:\\folder\\PRN\\", Description = "Path with reserved name 'PRN'"
         ),
         TestCase(
             "C:\\folder\\AUX\\", Description = "Path with reserved name 'AUX'"
         ),
         TestCase(
             "C:\\folder\\LPT1\\",
             Description = "Path with reserved name 'LPT1'"
         ),
         TestCase(
             "C:\\folder\\COM3\\",
             Description = "Path with reserved name 'COM3'"
         )]
        public void IsValidFolderPath_ReservedDeviceNames_ReturnsFalse(
            string invalidPath
        )
            => Assert.That(!PathnameValidator.IsValidFolderPath(invalidPath));

        /// <summary>
        /// Tests the <see cref="IPathnameValidator.IsValidFilePath" /> method
        /// to ensure it returns <see langword="true" /> when provided with
        /// valid file pathnames.
        /// </summary>
        /// <param name="validPath">
        /// (Required.) A <see cref="T:System.String" /> containing a valid pathname
        /// intended for testing.
        /// Examples include valid file paths, hidden files, UNC file paths, files with
        /// trailing dots, and files with no extension.
        /// </param>
        /// <seealso cref="IPathnameValidator.IsValidFilePath" />
        [Test,
         TestCase("C:\\folder\\file.txt", Description = "Valid file path"),
         TestCase("C:\\folder\\.config", Description = "Valid hidden file"),
         TestCase(
             "\\\\server\\share\\file.log", Description = "Valid UNC file path"
         ),
         TestCase(
             "C:\\folder\\file.", Description = "Valid file with trailing dot"
         ),
         TestCase(
             "C:\\folder\\file", Description = "Valid file with no extension"
         )]
        public void IsValidFilePath_ValidPaths_ReturnsTrue(string validPath)
            => Assert.That(PathnameValidator.IsValidFilePath(validPath));

        /// <summary>
        /// Tests the <see cref="IPathnameValidator.IsValidFilePath" /> method
        /// to ensure it returns <see langword="false" /> when provided with
        /// invalid file pathnames.
        /// </summary>
        /// <param name="invalidPath">
        /// (Required.) A <see cref="T:System.String" /> containing an invalid pathname
        /// intended for testing. Examples include file paths with trailing backslashes,
        /// paths with forward slashes, files with reserved names, folder root paths,
        /// empty paths, and whitespace-only paths.
        /// </param>
        /// <seealso cref="IPathnameValidator.IsValidFilePath" />
        [Test,
         TestCase(
             "C:\\folder\\file.txt\\",
             Description = "File path with trailing backslash"
         ),
         TestCase(
             "C:/folder/file.txt",
             Description = "File path with forward slashes"
         ),
         TestCase(
             "C:\\folder\\AUX.txt",
             Description = "File with reserved name 'AUX'"
         ),
         TestCase("C:\\", Description = "Folder root path in file validation"),
         TestCase("", Description = "Empty path"),
         TestCase("   ", Description = "Whitespace-only path")]
        public void IsValidFilePath_InvalidPaths_ReturnsFalse(
            string invalidPath
        )
            => Assert.That(!PathnameValidator.IsValidFilePath(invalidPath));

        /// <summary>
        /// Tests the <see cref="IPathnameValidator.IsValidFolderPath" /> method
        /// to ensure it returns <see langword="true" /> when provided with pathnames that
        /// end with a space or period, as Windows allows these.
        /// </summary>
        /// <param name="validPath">
        /// (Required.) A <see cref="T:System.String" />
        /// containing a valid pathname that ends with a space or period.
        /// </param>
        /// <seealso cref="IPathnameValidator.IsValidFolderPath" />
        [Test,
         TestCase(
             "C:\\folder\\ ",
             Description = "Path ending with space (Windows allows)"
         ),
         TestCase(
             "C:\\folder\\.",
             Description = "Path ending with period (Windows allows)"
         )]
        public void IsValidFolderPath_PathsEndingWithSpaceOrPeriod_ReturnsTrue(
            string validPath
        )
            => Assert.That(PathnameValidator.IsValidFolderPath(validPath));
    }
}