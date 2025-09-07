using Alphaleonis.Win32.Filesystem;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;
using xyLOGIX.Validators.Constants;

namespace xyLOGIX.Validators.Actions
{
    public static class Has
    {
        /// <summary>
        /// Initializes <see langword="static" /> data or performs actions that
        /// need to be performed once only for the
        /// <see cref="T:xyLOGIX.Validators.Actions.Has" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance
        /// being created or before any <see langword="static" /> members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static Has() { }

        /// <summary>
        /// Determines whether the specified project (<c>*.*proj</c>) file
        /// <paramref name="pathname" /> has a supported filename extension.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the fully-qualified pathname of the file whose filename extension is
        /// to be examined.
        /// </param>
        /// <remarks>
        /// This method returns <see langword="false" /> if a blank,
        /// <see langword="null" />, or the <see cref="F:System.String.Empty" /> value is
        /// passed to the <paramref name="pathname" /> parameter.
        /// <para />
        /// This method assumes that the value of the <paramref name="pathname" /> is
        /// otherwise a properly-formatted pathname.
        /// <para />
        /// It does not check to see if the file actually exists on disk.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="pathname" />
        /// has a supported filename extension; <see langword="false" /> otherwise.
        /// </returns>
        public static bool ValidExtension([NotLogged] string pathname)
        {
            var result = false;

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "Has.ValidExtension *** INFO: Checking whether the value of the parameter, 'pathname', is blank..."
                );

                // Check whether the value of the parameter, 'pathname', is blank.
                // If this is so, then emit an error message to the log file, and
                // then terminate the execution of this method.
                if (string.IsNullOrWhiteSpace(pathname))
                {
                    // The parameter, 'pathname' was either passed a null value, or it is blank.  This is not desirable.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "Has.ValidExtension: *** ERROR *** The parameter, 'pathname', was either passed a null value, or it is blank. Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"Has.ValidExtension: Result = {result}"
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
                    "Has.ValidExtension: Checking whether the field, 'ValidProjectFilenameExtensions.Extensions', has a null reference for a value..."
                );

                // Check to see if the required field, ValidProjectFilenameExtensions.Extensions, is null. If it is, then send an
                // error to the log file and then quit, returning the default value of the result
                // variable.
                if (ValidProjectFilenameExtensions.Extensions == null)
                {
                    // the field ValidProjectFilenameExtensions.Extensions is required.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "Has.ValidExtension: *** ERROR *** The field, 'ValidProjectFilenameExtensions.Extensions', has a null reference.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"*** Has.ValidExtension: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "Has.ValidExtension: *** SUCCESS *** The field, 'ValidProjectFilenameExtensions.Extensions', has a valid object reference for its value.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "Has.ValidExtension *** INFO: Checking whether the array, 'ValidProjectFilenameExtensions.Extensions', has greater than zero elements..."
                );

                // Check whether the array, 'ValidProjectFilenameExtensions.Extensions', has greater than zero elements.  If it is empty,
                // then write an error message to the log file, and then terminate the execution of this method.
                // It is preferred for the array to have greater than zero elements.
                if (ValidProjectFilenameExtensions.Extensions.Length <= 0)
                {
                    // The array, 'ValidProjectFilenameExtensions.Extensions', has zero elements, and we can't proceed if this is so.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "Has.ValidExtension *** ERROR *** The array, 'ValidProjectFilenameExtensions.Extensions', has zero elements.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"*** Has.ValidExtension: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"Has.ValidExtension *** SUCCESS *** {ValidProjectFilenameExtensions.Extensions.Length} element(s) were found in the 'ValidProjectFilenameExtensions.Extensions' array.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "Has.ValidExtension: Checking whether the file, whose fully-qualified pathname is specified by the parameter, 'pathname', exists..."
                );

                var pathnameExtension = Path.GetExtension(pathname);

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "Has.ValidExtension: Checking whether the variable, 'pathnameExtension', has a null reference for a value, or is blank..."
                );

                // Check to see if the required variable, 'pathnameExtension', is null or blank. If it is,
                // then send an  error to the log file and quit, returning the default value
                // of the result variable.
                if (string.IsNullOrWhiteSpace(pathnameExtension))
                {
                    // the variable pathnameExtension is required.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "Has.ValidExtension: *** ERROR *** The variable, 'pathnameExtension', has a null reference or is blank.  Stopping..."
                    );

                    // log the result
                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"Has.ValidExtension: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"Has.ValidExtension: *** SUCCESS *** {pathnameExtension.Length} B of data appear to be present in the variable, 'pathnameExtension'.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "Has.ValidExtension: Checking whether the file extension, specified by the variable, 'pathnameExtension', is in the list of supported project filename extensions..."
                );

                result = pathnameExtension.EqualsAnyOfNoCase(
                    ValidProjectFilenameExtensions.Extensions
                );

                DebugUtils.WriteLine(
                    result ? DebugLevel.Info : DebugLevel.Error,
                    result
                        ? $"*** SUCCESS *** The filename extension of the path, '{pathname}', is in the list of supported filename extensions for project(s).  Proceeding..."
                        : $"*** ERROR *** FAILED to verify whether the filename extension of the path, '{pathname}', is in the list of supported filename extension(s) for project(s).  Stopping..."
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug, $"Has.ValidExtension: Result = {result}"
            );

            return result;
        }

        /// <summary>
        /// Determines whether the specified project (<c>*.*proj</c>) file
        /// <paramref name="pathname" /> has a supported filename extension.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the fully-qualified pathname of the file whose filename extension is
        /// to be examined.
        /// </param>
        /// <remarks>
        /// This method returns <see langword="false" /> if a blank,
        /// <see langword="null" />, or the <see cref="F:System.String.Empty" /> value is
        /// passed to the <paramref name="pathname" /> parameter.
        /// <para />
        /// This method assumes that the value of the <paramref name="pathname" /> is
        /// otherwise a properly-formatted pathname.
        /// <para />
        /// It does not check to see if the file actually exists on disk.
        /// <para />
        /// This method works in identically the same fashion as the
        /// <see cref="Has.ValidExtension(string)" /> method, except it avoids writing to
        /// the log file whenever possible.
        /// <para />
        /// This overload should be utilized when the application needs to make this
        /// determination as part of a <c>UPDATE_COMMAND_UI</c> handler or otherwise the
        /// application knows that this method is going to be called very frequently.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="pathname" />
        /// has a supported filename extension; <see langword="false" /> otherwise.
        /// </returns>
        [Log(AttributeExclude = true)]
        public static bool ValidExtensionNoLogging([NotLogged] string pathname)
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(pathname)) return result;
                if (ValidProjectFilenameExtensions.Extensions == null)
                    return result;
                if (ValidProjectFilenameExtensions.Extensions.Length <= 0)
                    return result;
                var pathnameExtension = Path.GetExtension(pathname);
                if (string.IsNullOrWhiteSpace(pathnameExtension)) return result;
                result = pathnameExtension.EqualsAnyOfNoCase(
                    ValidProjectFilenameExtensions.Extensions
                );
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