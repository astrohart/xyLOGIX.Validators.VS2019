using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using xyLOGIX.Core.Debug;
using xyLOGIX.Validators.Interfaces;

namespace xyLOGIX.Validators.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see
    ///     cref="T:xyLOGIX.Validators.Interfaces.IAssetSymbolValidator" />
    /// interface.
    /// </summary>
    public static class GetAssetSymbolValidator
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the
        /// <see
        ///     cref="T:xyLOGIX.Validators.Factories.GetAssetSymbolValidator" />
        /// class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance
        /// being created or before any static members are referenced.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static GetAssetSymbolValidator() { }

        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Validators.Interfaces.IAssetSymbolValidator" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Validators.Interfaces.IAssetSymbolValidator" />
        /// interface.
        /// </returns>
        [return: NotLogged]
        [DebuggerStepThrough]
        public static IAssetSymbolValidator SoleInstance()
        {
            IAssetSymbolValidator result;

            try
            {
                result = AssetSymbolValidator.Instance;
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