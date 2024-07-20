using PostSharp.Patterns.Diagnostics;
using xyLOGIX.Validators.Interfaces;

namespace xyLOGIX.Validators.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see
    ///     cref="T:xyLOGIX.Validators.Interfaces.IDateRangeValidator" />
    /// interface.
    /// </summary>
    public static class GetDateRangeValidator
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the
        /// <see
        ///     cref="T:xyLOGIX.Validators.Factories.GetDateRangeValidator" />
        /// class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance
        /// being created or before any static members are referenced.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static GetDateRangeValidator() { }

        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Validators.Interfaces.IDateRangeValidator" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Validators.Interfaces.IDateRangeValidator" />
        /// interface.
        /// </returns>
        public static IDateRangeValidator SoleInstance()
            => DateRangeValidator.Instance;
    }
}