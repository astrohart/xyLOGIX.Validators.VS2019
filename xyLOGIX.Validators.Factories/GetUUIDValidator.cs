using PostSharp.Patterns.Diagnostics;
using xyLOGIX.Validators.Interfaces;

namespace xyLOGIX.Validators.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see
    ///     cref="T:xyLOGIX.Validators.Interfaces.IUUIDValidator" />
    /// interface.
    /// </summary>
    public static class GetUUIDValidator
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the
        /// <see
        ///     cref="T:xyLOGIX.Validators.Factories.GetUUIDValidator" />
        /// class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance
        /// being created or before any static members are referenced.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static GetUUIDValidator() { }

        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Validators.Interfaces.IUUIDValidator" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Validators.Interfaces.IUUIDValidator" />
        /// interface.
        /// </returns>
        public static IUUIDValidator SoleInstance()
            => UUIDValidator.Instance;
    }
}