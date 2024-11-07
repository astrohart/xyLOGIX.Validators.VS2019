using Alphaleonis.Win32.Filesystem;
using NUnit.Framework;
using System;
using System.Diagnostics;
using xyLOGIX.Tests.Logging;
using xyLOGIX.Validators.Factories;
using xyLOGIX.Validators.Interfaces;

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
        /// A <see cref="T:System.String" /> that is the same as
        /// <see
        ///     cref="F:xyLOGIX.Validators.Tests.PathnameValidatorTests.CorrectFolderPathname" />
        /// , but surrounded by quotation marks.
        /// </summary>
        private static readonly string CorrectFolderPathnameWithQuotes =
            $"\"{CorrectFolderPathname}\"";

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
    }
}