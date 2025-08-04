using Alphaleonis.Win32.Filesystem;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using xyLOGIX.Core.Debug;
using xyLOGIX.Validators.Interfaces;

namespace xyLOGIX.Validators
{
    /// <summary>
    /// Validates <see cref="T:System.String" />(s) that purport to contain the
    /// fully-qualified pathname of a Visual Studio Solution (<c>*.sln</c>) file.
    /// </summary>
    public class SolutionPathnameValidator : ISolutionPathnameValidator
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static SolutionPathnameValidator() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected SolutionPathnameValidator() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:xyLOGIX.Validators.Interfaces.ISolutionPathnameValidator" />
        /// interface.
        /// </summary>
        public static ISolutionPathnameValidator Instance
        {
            [DebuggerStepThrough] get;
        } = new SolutionPathnameValidator();

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.Validators.Interfaces.IPathnameValidator" /> interface.
        /// </summary>
        private static IPathnameValidator ThePathnameValidator
        {
            [DebuggerStepThrough] get;
        } = PathnameValidator.Instance;

        /// <summary>
        /// Validates that the specified Visual Studio Solution (<c>*.sln</c>)
        /// <paramref name="pathname" /> is of a valid format on the Windows operating
        /// system, and that it is a valid pathname of a Visual Studio Solution (
        /// <c>*.sln</c>) file.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> containing the fully-qualified
        /// pathname that is to be examined.
        /// </param>
        /// <remarks>
        /// If the value of the <paramref name="pathname" /> parameter is the
        /// <see langword="null" />, blank, or <see cref="F:System.String.Empty" />
        /// <see cref="T:System.String" />, then this method returns
        /// <see langword="false" />.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="pathname" /> is a
        /// properly-formatted file pathname; <see langword="false" /> otherwise.
        /// </returns>
        public bool IsValid(string pathname)
        {
            var result = false;

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** SolutionPathnameValidator.IsValid: Checking whether the specified pathname is a properly-formatted file path..."
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
                        $"*** SolutionPathnameValidator.IsValid: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "SolutionPathnameValidator.IsValid: *** SUCCESS *** The specified pathname is a properly-formatted file path.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"SolutionPathnameValidator.IsValid *** INFO: Checking whether the file having the pathname, '{pathname}', has the filename extension, '.sln'..."
                );

                // Check whether a file having the path, 'pathname', has the filename extension,
                // '.sln'. If it does not, then write an error message to the log file, and 
                // then terminate the execution of this method, returning the default return
                // value.
                if (!".sln".Equals(
                        Path.GetExtension(pathname.ToLowerInvariant())
                    ))
                {
                    // The file having the pathname, '{pathname}', does NOT have the filename 
                    // extension of '.sln'.  This is not desirable.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"SolutionPathnameValidator.IsValid: *** ERROR *** The file having the pathname, '{pathname}', does NOT have the filename extension of '.sln'.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"SolutionPathnameValidator.IsValid: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"SolutionPathnameValidator.IsValid: *** SUCCESS *** The file having the pathname, '{pathname}', has the filename extension, '.sln'.  Proceeding..."
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
                $"SolutionPathnameValidator.IsValid: Result = {result}"
            );

            return result;
        }
    }
}