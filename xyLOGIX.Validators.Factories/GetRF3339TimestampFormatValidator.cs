using System.Diagnostics;
using PostSharp.Patterns.Diagnostics;
using xyLOGIX.Validators.Interfaces;

namespace xyLOGIX.Validators.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see
    ///     cref="T:xyLOGIX.Validators.Interfaces.IRFC3339TimestampFormatValidator" />
    /// interface.
    /// </summary>
    public static class GetRF3339TimestampFormatValidator
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the
        /// <see
        ///     cref="T:xyLOGIX.Validators.Factories.GetRF3339TimestampFormatValidator" />
        /// class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance
        /// being created or before any static members are referenced.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static GetRF3339TimestampFormatValidator() { }

        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Validators.Interfaces.IRFC3339TimestampFormatValidator" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Validators.Interfaces.IRFC3339TimestampFormatValidator" />
        /// interface.
        /// </returns>
        public static IRFC3339TimestampFormatValidator SoleInstance()
            => RF3339TimestampFormatValidator.Instance;
    }
}