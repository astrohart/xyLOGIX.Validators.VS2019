using Alphaleonis.Win32.Filesystem;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using xyLOGIX.Validators.Interfaces;

namespace xyLOGIX.Validators
{
    /// <summary>
    /// Provides object(s) and functionality to validate that a
    /// <see cref="T:System.String" /> representing a Windows filename wildcard (glob)
    /// pattern is correctly formatted and not blank.
    /// </summary>
    public sealed class FileWildcardValidator : IFileWildcardValidator
    {
        // Allowed wildcard characters in Windows filename patterns.
        private static readonly char[] _allowedWildcards = { '*', '?' };

        // Disallowed path-related separators/qualifiers for filename-only wildcard patterns.
        private static readonly char[]
            _disallowedPathChars = { '\\', '/', ':' };

        // Invalid filename chars excluding '*' and '?' (which are valid wildcards).
        private static readonly char[] _invalidFileNameCharsExcludingWildcards =
            Path.GetInvalidFileNameChars()
                .Where(c => !_allowedWildcards.Contains(c))
                .ToArray();

        // Reserved DOS device names (case-insensitive) that cannot be used as plain filenames.
        private static readonly string[] _reservedDeviceNames =
        {
            "CON", "PRN", "AUX", "NUL", "COM1", "COM2", "COM3", "COM4",
            "COM5", "COM6", "COM7", "COM8", "COM9", "LPT1", "LPT2", "LPT3",
            "LPT4", "LPT5", "LPT6", "LPT7", "LPT8", "LPT9"
        };

        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static FileWildcardValidator() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        private FileWildcardValidator() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:xyLOGIX.Validators.Interfaces.IFileWildcardValidator" />
        /// interface.
        /// </summary>
        public static IFileWildcardValidator Instance
        {
            [DebuggerStepThrough] get;
        } = new FileWildcardValidator();

        /// <summary>
        /// Determines whether the specified <paramref name="pattern" /> is a
        /// valid Windows filename wildcard (glob) pattern.
        /// </summary>
        /// <param name="pattern">
        /// A <see cref="T:System.String" /> containing the wildcard
        /// pattern to validate.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the value is a valid wildcard pattern;
        /// otherwise, <see langword="false" />.
        /// </returns>
        public bool IsValid([NotLogged] string pattern)
        {
            var result = false;

            try
            {
                result = TryValidate(pattern, out _);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(
                    $"FileWildcardValidator.IsValid: Exception: {ex}"
                );
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Determines whether the specified <paramref name="pattern" /> is a
        /// valid Windows filename wildcard (glob) pattern.
        /// </summary>
        /// <param name="pattern">
        /// A <see cref="T:System.String" /> containing the wildcard
        /// pattern to validate.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the value is a valid wildcard pattern;
        /// otherwise, <see langword="false" />.
        /// </returns>
        [Log(AttributeExclude = true)]
        public bool IsValidSilent([NotLogged] string pattern)
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(pattern))
                    return result;

                result = TryValidate(pattern, out _);
            }
            catch
            {
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Attempts to validate the specified <paramref name="pattern" /> and, if
        /// invalid, returns a concise reason.
        /// </summary>
        /// <param name="pattern">
        /// A <see cref="T:System.String" /> containing the wildcard
        /// pattern to validate.
        /// </param>
        /// <param name="error">
        /// On return, receives a <see cref="T:System.String" />
        /// describing why validation failed, or an empty string if validation succeeded.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the value is a valid wildcard pattern;
        /// otherwise, <see langword="false" />.
        /// </returns>
        public bool TryValidate(string pattern, out string error)
        {
            var result = false;
            error = "";

            try
            {
                if (string.IsNullOrWhiteSpace(pattern))
                {
                    error = "Pattern is null, empty, or whitespace.";
                    return result;
                }

                // Disallow "." and ".." which are path tokens, not filenames.
                if (pattern == "." || pattern == "..")
                {
                    error = "Pattern must be a filename, not a path token.";
                    return result;
                }

                // Filename-only: no directory separators or drive qualifiers.
                if (pattern.IndexOfAny(_disallowedPathChars) >= 0)
                {
                    error =
                        "Pattern must not contain path separators or drive qualifiers.";
                    return result;
                }

                // No invalid filename characters (except '*' and '?' which act as wildcards).
                if (pattern.IndexOfAny(
                        _invalidFileNameCharsExcludingWildcards
                    ) >= 0)
                {
                    error = "Pattern contains invalid filename character(s).";
                    return result;
                }

                // If there are no wildcards, disallow pure reserved device names (with or without extension).
                if (!ContainsWildcard(pattern) &&
                    IsReservedDosDeviceName(pattern))
                {
                    error = "Pattern matches a reserved DOS device name.";
                    return result;
                }

                // Convert to a regex and ensure it compiles (guards edge cases).
                if (BuildRegexFromWildcard(pattern) == null)
                {
                    error =
                        "Pattern could not be converted into a valid regular expression.";
                    return result;
                }

                result = true;
                error = "";
            }
            catch (Exception ex)
            {
                Debug.WriteLine(
                    $"FileWildcardValidator.TryValidate: Exception: {ex}"
                );
                result = false;
                error = "An exception occurred during validation.";
            }

            return result;
        }

        /// <summary>
        /// Attempts to validate the specified <paramref name="pattern" /> and, if
        /// invalid, returns a concise reason.
        /// </summary>
        /// <param name="pattern">
        /// A <see cref="T:System.String" /> containing the wildcard
        /// pattern to validate.
        /// </param>
        /// <param name="error">
        /// On return, receives a <see cref="T:System.String" />
        /// describing why validation failed, or an empty string if validation succeeded.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the value is a valid wildcard pattern;
        /// otherwise, <see langword="false" />.
        /// </returns>
        [Log(AttributeExclude = true)]
        public bool TryValidateSilent([NotLogged] string pattern,
            [NotLogged]  out string error)
        {
            var result = false;
            error = "";

            try
            {
                if (string.IsNullOrWhiteSpace(pattern))
                {
                    error = "Pattern is null, empty, or whitespace.";
                    return result;
                }

                // Disallow "." and ".." which are path tokens, not filenames.
                if (pattern == "." || pattern == "..")
                {
                    error = "Pattern must be a filename, not a path token.";
                    return result;
                }

                // Filename-only: no directory separators or drive qualifiers.
                if (pattern.IndexOfAny(_disallowedPathChars) >= 0)
                {
                    error =
                        "Pattern must not contain path separators or drive qualifiers.";
                    return result;
                }

                // No invalid filename characters (except '*' and '?' which act as wildcards).
                if (pattern.IndexOfAny(
                        _invalidFileNameCharsExcludingWildcards
                    ) >= 0)
                {
                    error = "Pattern contains invalid filename character(s).";
                    return result;
                }

                // If there are no wildcards, disallow pure reserved device names (with or without extension).
                if (!ContainsWildcard(pattern) &&
                    IsReservedDosDeviceName(pattern))
                {
                    error = "Pattern matches a reserved DOS device name.";
                    return result;
                }

                // Convert to a regex and ensure it compiles (guards edge cases).
                if (BuildRegexFromWildcard(pattern) == null)
                {
                    error =
                        "Pattern could not be converted into a valid regular expression.";
                    return result;
                }

                result = true;
                error = "";
            }
            catch
            {
                result = false;
                error = "An exception occurred during validation.";
            }

            return result;
        }

        [DebuggerStepThrough]
        private static Regex BuildRegexFromWildcard(string pattern)
        {
            Regex result = null;

            try
            {
                var regexPattern = "^" + Regex.Escape(pattern)
                                              .Replace(@"\*", ".*")
                                              .Replace(@"\?", ".") + "$";

                result = new Regex(regexPattern, RegexOptions.IgnoreCase);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(
                    $"FileWildcardValidator.BuildRegexFromWildcard: Exception: {ex}"
                );
                result = null;
            }

            return result;
        }

        [DebuggerStepThrough]
        private static bool ContainsWildcard(string pattern)
        {
            var result = false;

            try
            {
                if (string.IsNullOrEmpty(pattern))
                    return result;

                result = pattern.IndexOf('*') >= 0 || pattern.IndexOf('?') >= 0;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(
                    $"FileWildcardValidator.ContainsWildcard: Exception: {ex}"
                );
                result = false;
            }

            return result;
        }

        [DebuggerStepThrough]
        private static bool IsReservedDosDeviceName(string name)
        {
            var result = false;

            try
            {
                if (string.IsNullOrEmpty(name))
                    return result;

                // Compare base filename without extension.
                var baseName = name;
                var lastDot = name.LastIndexOf('.');
                if (lastDot > 0)
                    baseName = name.Substring(0, lastDot);

                result = _reservedDeviceNames.Any(r => string.Equals(
                        r, baseName, StringComparison.OrdinalIgnoreCase
                    )
                );
            }
            catch (Exception ex)
            {
                Debug.WriteLine(
                    $"FileWildcardValidator.IsReservedDosDeviceName: Exception: {ex}"
                );
                result = false;
            }

            return result;
        }
    }
}