using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using xyLOGIX.Core.Debug;
using xyLOGIX.Validators.Interfaces;

namespace xyLOGIX.Validators
{
    /// <summary>
    /// Validates the fully-qualified pathname(s) of project (<c>*.*proj</c>) file(s)
    /// that are utilized within modern version(s) of the Visual Studio IDE.
    /// </summary>
    public class ProjectPathnameValidator : IProjectPathnameValidator
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static ProjectPathnameValidator() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        private ProjectPathnameValidator()
        { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:xyLOGIX.Validators.Interfaces.IProjectPathnameValidator" />
        /// interface.
        /// </summary>
        public static IProjectPathnameValidator Instance
        {
            [DebuggerStepThrough]
            get;
        } = new ProjectPathnameValidator();

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.Validators.Interfaces.IPathnameValidator" /> interface.
        /// </summary>
        private static IPathnameValidator ThePathnameValidator
        {
            [DebuggerStepThrough]
            get;
        } = PathnameValidator.Instance;

        /// <summary>
        /// Validates that the specified project (<c>*.*proj</c>) file
        /// <paramref name="pathname" /> is of a valid format on the Windows operating
        /// system, and that it is a valid pathname of a project (<c>*.*proj</c>) file.
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
        public bool IsValid([NotLogged] string pathname)
        {
            var result = false;

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** ProjectPathnameValidator.IsValid: Checking whether the specified pathname is a properly-formatted file path..."
                );

                // Check to see whether the specified pathname is a properly-formatted file path.
                // If this is not the case, then write an error message to the log file,
                // and then terminate the execution of this method.
                if (!ThePathnameValidator.IsValidFilePath(pathname))
                {
                    // The specified pathname is NOT a properly-formatted file path.  This is not desirable.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "*** ERROR *** The specified pathname is NOT a properly-formatted file path.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"*** ProjectPathnameValidator.IsValid: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "ProjectPathnameValidator.IsValid: *** SUCCESS *** The specified pathname is a properly-formatted file path.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "ProjectPathnameValidator.IsValid *** INFO: Checking whether the value of the parameter, 'pathname', is blank..."
                );

                // Check whether the value of the parameter, 'pathname', is blank.
                // If this is so, then emit an error message to the log file, and
                // then terminate the execution of this method.
                if (string.IsNullOrWhiteSpace(pathname))
                {
                    // The parameter, 'pathname' was either passed a null value, or it is blank.  This is not desirable.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "ProjectPathnameValidator.IsValid: The parameter, 'pathname', was either passed a null value, or it is blank. Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"ProjectPathnameValidator.IsValid: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** SUCCESS *** The parameter 'pathname', is not blank.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** ProjectPathnameValidator.IsValid: Checking whether the pathname ends with the phrase, 'proj'..."
                );

                // Check to see whether the pathname ends with the phrase, 'proj'.
                // If this is not the case, then write an error message to the log file,
                // and then terminate the execution of this method.
                if (!pathname.EndsWith(
                        "proj", StringComparison.OrdinalIgnoreCase
                    ))
                {
                    // The pathname does NOT end with 'proj'.  This is not desirable.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "*** ERROR *** The pathname does NOT end with 'proj'.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"*** ProjectPathnameValidator.IsValid: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "ProjectPathnameValidator.IsValid: *** SUCCESS *** The pathname ends with the phrase, 'proj'.  Proceeding..."
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
                $"ProjectPathnameValidator.IsValid: Result = {result}"
            );

            return result;
        }
    }
}