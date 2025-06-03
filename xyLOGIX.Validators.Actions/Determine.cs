using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using xyLOGIX.Core.Debug;
using xyLOGIX.Validators.Constants;

namespace xyLOGIX.Validators.Actions
{
    /// <summary>
    /// Exposes static method(s) that are used to determine whether a given value is
    /// valid or not, or to make other determination(s) from various data value(s).
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class Determine
    {
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
        [DebuggerStepThrough]
        public static FileSystemType TheFileSystemTypeInUse()
        {
            var result = FileSystemType.Unknown;

            try
            {
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

            return result;
        }
    }
}