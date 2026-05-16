using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
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
        /// Empty, <see langword="static" /> constructor to prohibit direct allocation of
        /// this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static VersionStringValidator() { }

        /// <summary>
        /// Empty, private constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        private VersionStringValidator() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:xyLOGIX.Validators.Interfaces.IVersionStringValidator" />
        /// interface.
        /// </summary>
        public static IVersionStringValidator Instance
        {
            [DebuggerStepThrough] get;
        } = new VersionStringValidator();

        /// <summary>
        /// Determines whether the specified <paramref name="versionString" /> is parseable
        /// as a three- or four-component version string by
        /// <see cref="T:System.Version" />.
        /// </summary>
        /// <param name="versionString">
        /// (Required.) A <see cref="T:System.String" /> containing the version string to
        /// be validated.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if <paramref name="versionString" /> can be parsed by
        /// <see cref="T:System.Version" /> and has either three or four components;
        /// <see langword="false" /> otherwise.
        /// </returns>
        /// <remarks>
        /// This method emits detailed diagnostic log output at each validation step,
        /// including informational, warning, error, and debug messages, to aid in
        /// troubleshooting version string parsing failures.
        /// <para />
        /// If <paramref name="versionString" /> is <see langword="null" />, empty, or
        /// consists only of whitespace, then this method returns
        /// <see langword="true" />, because a blank version string is considered valid
        /// (i.e., the field is simply not set).
        /// <para />
        /// If <paramref name="versionString" /> is not blank, then it must be parseable by
        /// <see cref="T:System.Version" /> and must have at least three components
        /// (Major.Minor.Build); a two-component version string (Major.Minor only, where
        /// <c>Build == -1</c>) is considered invalid.
        /// <para />
        /// A valid version string must have exactly three components (Major.Minor.Build)
        /// or four components (Major.Minor.Build.Revision) as parsed by
        /// <see cref="T:System.Version" />.
        /// </remarks>
        public bool IsValid([NotLogged] string versionString)
        {
            var result = false;

            try
            {
                /*
                 * It is valid for the specified version string to be null, whitespace only,
                 * or the string.Empty value. However, if the version string is not null, whitespace only, or the
                 * string.Empty value, then it must be parseable as a three- or four-component version string by
                 * System.Version.  If the version string is not null, whitespace only, or the
                 * string.Empty value, but it is not parseable as a three- or four-component version string by
                 * System.Version, then this method returns false.
                 */

                result = true;

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "VersionStringValidator.IsValid *** INFO: Checking whether the value of the parameter, 'versionString', is blank..."
                );

                // Check whether the value of the parameter, 'versionString', is blank.
                // If this is so, then emit an FYI message to the log file, and
                // then terminate the execution of this method.
                if (string.IsNullOrWhiteSpace(versionString))
                {
                    // The parameter, 'versionString' was either passed a null value, or it is blank.  There is nothing to do.
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        "VersionStringValidator.IsValid: *** FYI *** The parameter, 'versionString' was either passed a null value, or it is blank.  It is valid for this parameter to be blank.  Nothing to do..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"VersionStringValidator.IsValid: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** SUCCESS *** The parameter, 'versionString', is not blank.  Proceeding..."
                );

                result = false;

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"VersionStringValidator.IsValid: *** FYI *** Attempting to parse the version string, '{versionString}', using System.Version.TryParse..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** VersionStringValidator.IsValid: Checking whether the specified version string can be parsed as a three- or four-component version..."
                );

                // Check to see whether the specified version string can be parsed as a three- or four-component version.
                // If this is not the case, then write an error message to the log file,
                // and then terminate the execution of this method.
                if (!Version.TryParse(versionString, out var parsed))
                {
                    // The specified version string appears NOT to be parseable as a three- or four-component application version string.  This is not desirable.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "*** ERROR *** The specified version string appears NOT to be parseable as a three- or four-component application version string.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"*** VersionStringValidator.IsValid: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "VersionStringValidator.IsValid: *** SUCCESS *** The specified version string can be parsed as a three- or four-component version.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "VersionStringValidator.IsValid: Checking whether the variable, 'parsed', has a null reference for a value..."
                );

                // Check to see if the variable, parsed, is null.  If it is, send an error
                // to the log file, and then terminate the execution of this method,
                // returning the default return value.
                if (parsed == null)
                {
                    // the variable parsed is required to have a valid object reference.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "VersionStringValidator.IsValid: *** ERROR ***  The variable, 'parsed', has a null reference.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"*** VersionStringValidator.IsValid: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                // We can use the variable, parsed, because it's not set to a null reference.
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "VersionStringValidator.IsValid: *** SUCCESS *** The variable, 'parsed', has a valid object reference for its value.  Proceeding..."
                );

                // A three-component version has Revision == -1 and Build >= 0.
                // A four-component version has both Build >= 0 and Revision >= 0.
                // A two-component version has Build == -1; that is not valid here.
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "VersionStringValidator.IsValid: Checking whether the Build component is a non-negative value..."
                );

                // Check to see whether the Build component is a non-negative value.
                // If this is not the case, then write an error message to the log file,
                // and then terminate the execution of this method.
                if (parsed.Build.IsNegative())
                {
                    // The Build component is a negative value.  This is not desirable.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "*** ERROR *** The Build component is a negative value.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"*** VersionStringValidator.IsValid: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "VersionStringValidator.IsValid: *** SUCCESS *** The Build component is a non-negative value.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"VersionStringValidator.IsValid: *** FYI *** It appears that the specified version string, '{versionString}', has a valid format."
                );

                /*
                 * If we made it this far with no Exception(s) getting caught, then
                 * assume that the operation(s) succeeded.
                 */

                result = true;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"VersionStringValidator.IsValid: Result = {result}"
            );

            return result;                
        }
    }
}