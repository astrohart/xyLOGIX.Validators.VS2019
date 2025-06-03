using Alphaleonis.Win32.Filesystem;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;
using xyLOGIX.Validators.Actions;
using xyLOGIX.Validators.Constants;
using xyLOGIX.Validators.Interfaces;
using xyLOGIX.Validators.Properties;

namespace xyLOGIX.Validators
{
    /// <summary>
    /// Validates the format of <see cref="T:System.String" /> value(s) that are
    /// supposed to contain valid filesystem pathnames for the Windows operating
    /// system.
    /// </summary>
    public class PathnameValidator : IPathnameValidator
    {
        /// <summary>
        /// Array of reserved Windows device names that are not allowed in any path
        /// segment.
        /// </summary>
        private static readonly string[] ReservedDeviceNames =
        {
            "CON", "PRN", "AUX", "NUL", "COM1", "COM2", "COM3", "COM4",
            "COM5", "COM6", "COM7", "COM8", "COM9", "LPT1", "LPT2", "LPT3",
            "LPT4", "LPT5", "LPT6", "LPT7", "LPT8", "LPT9"
        };

        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static PathnameValidator() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected PathnameValidator() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:xyLOGIX.Validators.Interfaces.IPathnameValidator" /> interface.
        /// </summary>
        public static IPathnameValidator
            Instance { [DebuggerStepThrough] get; } = new PathnameValidator();

        /// <summary>
        /// Regex pattern to match valid Windows pathnames.
        /// </summary>
        /// <remarks>
        /// Supports both drive-letter paths and UNC pathnames.
        /// <para />
        /// Allows folder and file names that start with a dot (<c>.</c>).
        /// </remarks>
        private static Regex PathPattern { [DebuggerStepThrough] get; } =
            new Regex(
                Resources.Regex_PathnameValidator_PathPattern,
                RegexOptions.Compiled
            );

        /// <summary>
        /// Validates that the specified file <paramref name="pathname" /> is of a valid
        /// format on the Windows operating system.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> containing the fully-qualified
        /// pathname that is to be examined.
        /// </param>
        /// <remarks>
        /// Disallows trailing backslashes.
        /// <para />
        /// If the value of the <paramref name="pathname" /> parameter is the
        /// <see langword="null" />, blank, or <see cref="F:System.String.Empty" />
        /// <see cref="T:System.String" />, then this method returns
        /// <see langword="false" />.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="pathname" /> is a
        /// properly-formatted file pathname; <see langword="false" /> otherwise.
        /// </returns>
        public bool IsValidFilePath([NotLogged] string pathname)
            => IsValidPath(pathname, false);

        /// <summary>
        /// Validates that the specified folder <paramref name="pathname" /> is of a valid
        /// format on the Windows operating system.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> containing the fully-qualified
        /// pathname that is to be examined.
        /// </param>
        /// <remarks>
        /// This method allows the value of the <paramref name="pathname" /> parameter to
        /// have trailing backslashes.
        /// <para />
        /// If the value of the <paramref name="pathname" /> parameter is the
        /// <see langword="null" />, blank, or <see cref="F:System.String.Empty" />
        /// <see cref="T:System.String" />, then this method returns
        /// <see langword="false" />.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="pathname" /> is a
        /// properly-formatted folder pathname; <see langword="false" /> otherwise.
        /// </returns>
        public bool IsValidFolderPath([NotLogged] string pathname)
            => IsValidPath(pathname, true);

        /// <summary>
        /// Checks if the specified <paramref name="segment" /> is a reserved device name.
        /// </summary>
        /// <param name="segment">
        /// (Required.) A <see cref="T:System.String" /> containing the pathname segment to
        /// check.
        /// </param>
        /// <remarks>
        /// If the value of the <paramref name="segment" /> parameter is the
        /// <see langword="null" />, blank, or <see cref="F:System.String.Empty" />
        /// <see cref="T:System.String" />, then this method returns
        /// <see langword="false" />.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="segment" />
        /// is a reserved device name; <see langword="false" /> otherwise.
        /// </returns>
        [Log(AttributeExclude = true)]
        private static bool IsReservedDeviceName(string segment)
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(segment)) return result;

                result = segment.EqualsAnyOfNoCase(ReservedDeviceNames) || Path
                    .GetFileNameWithoutExtension(segment)
                    .EqualsAnyOfNoCase(ReservedDeviceNames);
            }
            catch (Exception ex)
            {
                DebugUtils.LogException(ex);
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Validates that the specified <paramref name="pathname" /> is of
        /// a valid format on the Windows operating system.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> containing the fully-qualified
        /// pathname that is to be examined.
        /// </param>
        /// <param name="allowTrailingBackslash">
        /// (Required.) <see langword="true" /> to allow the specified
        /// <paramref name="pathname" /> to end with a trailing backslash;
        /// <see langword="false" /> otherwise.
        /// </param>
        /// <remarks>
        /// Generally, the pathnames of folders are allowed to end with a trailing
        /// backslash; however, the pathnames of file(s) are not.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="pathname" /> is a
        /// properly-formatted pathname; <see langword="false" /> otherwise.
        /// </returns>
        private bool IsValidPath(
            [NotLogged] string pathname,
            bool allowTrailingBackslash
        )
        {
            var result = false;

            try
            {
                // Return false if the pathname is null, blank, or empty
                if (string.IsNullOrWhiteSpace(pathname))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "*** ERROR *** The pathname is null, blank, or empty."
                    );

                    return result;
                }

                // The pathname must be an absolute path.
                if (!pathname.IsAbsolutePath())
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** The pathname, '{pathname}', is not an absolute path."
                    );

                    return result;
                }

                // ✅ NEW FIX: Enforce MAX_PATH limits
                var maxPathLength = Is.LongPathSupportEnabled()
                    ? MaxPathLength.NTFS
                    : MaxPathLength.Legacy;
                if (pathname.Length > maxPathLength)
                {
                    DebugUtils.WriteLine(DebugLevel.Error, $"*** ERROR *** The pathname, '{pathname}', exceeds the maximum length of {maxPathLength} characters for the {Determine.TheFileSystemTypeInUse().AsString()} file system.");

                    return result; // Immediately fail validation if too long
                }
            

                // ✅ Allow paths ending in ".", "..", or " " (Command Prompt allows these)
                if (!allowTrailingBackslash && pathname.EndsWith("\\"))
                    return result;

                // Match the input against the PathPattern regex
                var match = PathPattern.Match(pathname);
                if (!match.Success)
                    return
                        result; // Failed to match file or folder pathname regex.

                // Check for reserved device names in each '\'-delineated pathname segment
                var pathSegments = pathname.Split('\\');

                if (pathSegments == null) return result;
                if (pathSegments.Length <= 0) return result;

                foreach (var segment in pathSegments)
                {
                    if (string.IsNullOrWhiteSpace(segment)) continue;
                    if (IsReservedDeviceName(segment))
                        return false; // Immediately fail validation
                }

                // ✅ If we got here, the pathname is valid per Windows behavior
                result = true;
            }
            catch (Exception ex)
            {
                // Dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"PathnameValidator.IsValidPath: Result = {result}"
            );

            return result;
        }
    }
}