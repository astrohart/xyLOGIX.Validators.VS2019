using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Validators.Constants;

namespace xyLOGIX.Validators.Actions
{
    /// <summary>
    /// Exposes static method(s) that are used to determine whether a given value is
    /// valid or not, or to make other determination(s) from various data value(s).
    /// </summary>
    public static class Determine
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:xyLOGIX.Validators.Actions.Determine" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static Determine() { }

        /// <summary>
        /// Attempts to determine the type of file system that is currently in use.
        /// </summary>
        /// <remarks>
        /// This method bases its determination on whether Long Path Support is
        /// enabled.
        /// </remarks>
        /// <returns>
        /// If successful, one of the
        /// <see cref="T:xyLOGIX.Validators.Constants.FileSystemType" /> enumeration
        /// value(s) that identifies the type of file system that is currently in use.
        /// <para />
        /// If the method is unable to determine the type of file system that is
        /// in use, or if another error occurs during the determination of the same, then
        /// the method returns
        /// <see cref="F:xyLOGIX.Validators.Constants.FileSystemType.Unknown" />.
        /// </returns>
        public static FileSystemType TheFileSystemTypeInUse()
        {
            var result = FileSystemType.Unknown;

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** INFO: Attempting to determine the type of file system that is currently in use..."
                );

                result = Is.LongPathSupportEnabled()
                    ? FileSystemType.NTFS
                    : FileSystemType.Legacy;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = FileSystemType.Unknown;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"Determine.TheFileSystemTypeInUse: Result = '{result}'"
            );

            return result;
        }
    }
}