using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;
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
        /// Regex pattern to match valid Windows pathnames.
        /// </summary>
        /// <remarks>
        /// Supports both drive-letter paths and UNC pathnames.
        /// <para />
        /// Allows folder and file names that start with a dot (<c>.</c>).
        /// </remarks>
        private static readonly Regex PathPattern = new Regex(
            Resources.Regex_PathnameValidator_PathPattern, RegexOptions.Compiled
        );

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
        /// Gets a reference to the singleton instance of the validator.
        /// </summary>
        public static IPathnameValidator
            Instance
        { [DebuggerStepThrough] get; } = new PathnameValidator();

        /// <summary>
        /// Validates that the specified file <paramref name="pathname" /> is of
        /// a valid format on the Windows operating system.
        /// Disallows trailing backslashes.
        /// </summary>
        public bool IsValidFilePath(string pathname)
            => IsValidPath(pathname, false);

        /// <summary>
        /// Validates that the specified folder <paramref name="pathname" /> is of
        /// a valid format on the Windows operating system.
        /// Allows trailing backslashes.
        /// </summary>
        public bool IsValidFolderPath([NotLogged] string pathname)
            => IsValidPath(pathname, true);

        /// <summary>
        /// Checks if the specified <paramref name="segment" /> is a reserved device name.
        /// </summary>
        /// <param name="segment">
        /// (Required.) A <see cref="T:System.String" /> containing the pathname segment to check.
        /// </param>
        private static bool IsReservedDeviceName([NotLogged] string segment)
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(segment)) return result;

                result = segment.EqualsAnyOfNoCase(ReservedDeviceNames);
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
        private bool IsValidPath(string pathname, bool allowTrailingBackslash)
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(pathname))
                    return result;

                if (!allowTrailingBackslash && pathname.EndsWith("\\"))
                    return result;

                var match = PathPattern.Match(pathname);
                if (!match.Success)
                    return result;

                // Check for reserved device names in each segment
                var pathSegments = pathname.Split('\\');
                foreach (var segment in pathSegments)
                {
                    if (string.IsNullOrWhiteSpace(segment)) continue;
                    if (IsReservedDeviceName(segment)) return false;
                }

                result = true;
            }
            catch (Exception ex)
            {
                DebugUtils.LogException(ex);
                result = false;
            }

            return result;
        }
    }
}