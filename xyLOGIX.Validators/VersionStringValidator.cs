using PostSharp.Patterns.Diagnostics;
using System;
using System.Text.RegularExpressions;
using xyLOGIX.Core.Debug;
using xyLOGIX.Validators.Constants;
using xyLOGIX.Validators.Interfaces;

namespace xyLOGIX.Validators
{
    /// <summary>
    /// Validates the format of software version strings.
    /// </summary>
    public class VersionStringValidator : IVersionStringValidator
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static VersionStringValidator() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected VersionStringValidator() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:xyLOGIX.Validators.Interfaces.IVersionStringValidator" />
        /// interface.
        /// </summary>
        public static IVersionStringValidator Instance { get; } =
            new VersionStringValidator();

        /// <summary>
        /// Determines whether the contents of the specified
        /// <paramref name="versionString" /> have a valid format.
        /// </summary>
        /// <param name="versionString">
        /// (Required.) A <see cref="T:System.String" /> containing a software version
        /// string whose format is to be checked.
        /// </param>
        /// <remarks>
        /// If the value of the <paramref name="versionString" /> parameter is a
        /// <see langword="null" /> reference or is the
        /// <see cref="F:System.String.Empty" /> value, or a value containing only
        /// whitespace, then the method returns <see langword="false" /> without performing
        /// any additional validation.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="versionString" /> has
        /// a valid format; <see langword="false" /> otherwise.
        /// </returns>
        public bool IsValid(string versionString)
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(versionString)) return result;

                // Regex pattern to match three numbers separated by dots
                result = Regex.IsMatch(versionString, Regexes.ThreePartVersion);
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