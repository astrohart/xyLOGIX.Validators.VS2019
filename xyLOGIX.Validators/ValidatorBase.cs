using System;
using xyLOGIX.Validators.Interfaces;

namespace xyLOGIX.Validators
{
    /// <summary>
    /// Serves as the common base class for all validator objects.
    /// </summary>
    /// <typeparam name="TObject">
    /// Type of the object whose instances are to be
    /// validated.  Can be either a concrete instance or an interface.
    /// </typeparam>
    public abstract class ValidatorBase<TObject> : IValidator
        where TObject : class
    {
        /// <summary>
        /// Constructs a new instance of <see cref="T:xyLOGIX.Validators.ValidatorBase" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="objectToValidate">
        /// (Required.) Reference to an instance of the object to be validated.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="objectToValidate" />, is passed a
        /// <see langword="null" /> value.
        /// </exception>
        protected ValidatorBase(TObject objectToValidate)
            => ObjectToValidate = objectToValidate ??
                                  throw new ArgumentNullException(
                                      nameof(objectToValidate)
                                  );

        /// <summary>
        /// Gets a reference to the object instance whose data is to be validated.
        /// </summary>
        public TObject ObjectToValidate { get; }

        /// <summary>
        /// When implemented by a class, gets or sets a value indicating whether
        /// the user-entered content in the specified control passes validation.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the content is valid; otherwise,
        /// <see langword="false" />.
        /// </returns>
        public bool IsValid { get; protected set; }

        /// <summary>
        /// When implemented by a class, gets or sets the error message text
        /// generated when the condition being validated fails.
        /// </summary>
        /// <returns>The error message to generate.</returns>
        public string ErrorMessage { get; protected set; }

        /// <summary>
        /// When implemented by a class, evaluates the condition it checks and
        /// updates the <see cref="P:xyLOGIX.Validators.Interfaces.IValidator.IsValid" />
        /// property.
        /// </summary>
        public abstract void Validate();
    }
}