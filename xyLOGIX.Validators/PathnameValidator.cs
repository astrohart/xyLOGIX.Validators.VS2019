using PostSharp.Patterns.Diagnostics;
using PostSharp.Patterns.Threading;
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
        /// This pattern supports both drive-letter paths and UNC pathnames.
        /// </summary>
        /// <remarks>
        /// This regex allows an optional trailing backslash, checks for illegal
        /// characters,
        /// and excludes reserved device names.
        /// </remarks>
        [ExplicitlySynchronized] private static readonly Regex Path = new Regex(
            Resources.Regex_FolderPathname, RegexOptions.Compiled
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
        /// Validates that the specified folder <paramref name="pathname" /> is of
        /// a valid format on the Windows operating system.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> containing
        /// the data that is to be examined.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="pathname" />
        /// contains text whose format is valid for a filesystem pathname of a folder
        /// on the Windows operating system; <see langword="false" /> otherwise.
        /// </returns>
        public bool IsValidFolderPath(string pathname)
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(pathname))
                    return result;

                var match = Path.Match(pathname);
                if (match == null) return result;
                result = match.Success;
                if (!result) return result;

                // Check for reserved device names in each segment
                var pathWithoutQuotes = match.Groups["path"].Value;
                var pathSegments = pathWithoutQuotes.Split('\\');

                foreach (var segment in pathSegments)
                {
                    if (string.IsNullOrWhiteSpace(segment)) continue;
                    if (!IsReservedDeviceName(segment)) continue;

                    result = true;
                    break;
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return true;
        }

        /// <summary>
        /// Checks if the specified <paramref name="segment" /> is a reserved device name.
        /// </summary>
        /// <param name="segment">A path segment to check.</param>
        /// <returns>
        /// <see langword="true" /> if the <paramref name="segment" /> is a reserved device
        /// name; <see langword="false" /> otherwise.
        /// </returns>
        [Log(AttributeExclude = true)]
        private static bool IsReservedDeviceName(string segment)
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(segment)) return result;
                if (!segment.IsAlphaNumericUppercase()) return result;

                foreach (var reservedName in ReservedDeviceNames)
                {
                    if (string.IsNullOrWhiteSpace(reservedName)) continue;
                    if (!segment.Equals(
                            reservedName, StringComparison.OrdinalIgnoreCase
                        ))
                        continue;

                    result = true;
                    break;
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }
    }
}