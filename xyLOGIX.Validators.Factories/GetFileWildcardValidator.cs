using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using xyLOGIX.Core.Debug;
using xyLOGIX.Validators.Interfaces;

namespace xyLOGIX.Validators.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:xyLOGIX.Validators.Interfaces.IFileWildcardValidator" />
    /// interface.
    /// </summary>
    public static class GetFileWildcardValidator
    {
        /// <summary>
        /// Initializes <see langword="static" /> data or performs actions that
        /// need to be performed once only for the
        /// <see cref="T:xyLOGIX.Validators.Factories.GetFileWildcardValidator" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance
        /// being created or before any <see langword="static" /> members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static GetFileWildcardValidator() { }

        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:xyLOGIX.Validators.Interfaces.IFileWildcardValidator" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:xyLOGIX.Validators.Interfaces.IFileWildcardValidator" />
        /// interface.
        /// </returns>
        [DebuggerStepThrough]
        [return: NotLogged]
        public static IFileWildcardValidator SoleInstance()
        {
            IFileWildcardValidator result;

            try
            {
                result = FileWildcardValidator.Instance;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = default;
            }

            return result;
        }
    }
}