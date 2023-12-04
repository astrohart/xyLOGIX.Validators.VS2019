using PostSharp.Patterns.Model;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Validators.Events;
using xyLOGIX.Validators.Interfaces;
using xyLOGIX.Validators.Properties;

namespace xyLOGIX.Validators
{
    /// <summary> Serves as the common base class for all validator objects. </summary>
    /// <typeparam name="TObject">
    /// Type of the object whose instances are to be
    /// validated.  Can be either a concrete instance or an interface.
    /// </typeparam>
    [Log(AttributeExclude = true)]
    public abstract class ObjectValidatorBase<TObject> : IObjectValidator
        where TObject : class
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:xyLOGIX.Validators.ObjectValidatorBase" /> and returns a reference
        /// to it.
        /// </summary>
        /// <param name="objectToValidate">
        /// (Required.) Reference to an instance of the
        /// object to be validated.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="objectToValidate" />, is passed a
        /// <see langword="null" /> value.
        /// </exception>
        protected ObjectValidatorBase(TObject objectToValidate)
            => ObjectToValidate = objectToValidate ??
                                  throw new ArgumentNullException(
                                      nameof(objectToValidate)
                                  );

        /// <summary>
        /// When implemented by a class, gets or sets the error message text
        /// generated when the condition being validated fails.
        /// </summary>
        /// <returns>The error message to generate.</returns>
        public string ErrorMessage { get; protected set; }

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
        /// Gets a reference to the object instance whose data is to be
        /// validated.
        /// </summary>
        protected TObject ObjectToValidate { get; }

        /// <summary> Occurs when validation has failed. </summary>
        [WeakEvent]
        public event ValidationFailedEventHandler ValidationFailed;

        /// <summary> Occurs when validation has succeeded. </summary>
        [WeakEvent]
        public event ValidationSucceededEventHandler ValidationSucceeded;

        /// <summary>
        /// When implemented by a class, evaluates the condition it checks and
        /// updates the
        /// <see cref="P:xyLOGIX.Validators.Interfaces.IObjectValidator.IsValid" />
        /// property.
        /// </summary>
        public virtual void Validate()
        {
            if (ObjectToValidate == null)
                OnValidationFailed(
                    new ValidationFailedEventArgs(
                        Resources.Error_ObjectToValidatePropertyHasNotBeenSet
                    )
                );
        }

        /// <summary>
        /// Raises the
        /// <see cref="E:xyLOGIX.Validators.ObjectValidatorBase.ValidationFailed" /> event.
        /// </summary>
        /// <param name="e">
        /// (Required.) An
        /// <see cref="T:xyLOGIX.Validators.Events.ValidationFailedEventArgs" /> that
        /// contains the event data.
        /// </param>
        protected virtual void OnValidationFailed(ValidationFailedEventArgs e)
        {
            IsValid = false;
            ErrorMessage = e.ErrorMessage;
            ValidationFailed?.Invoke(this, e);
        }

        /// <summary>
        /// Raises the
        /// <see cref="E:xyLOGIX.Validators.ObjectValidatorBase.ValidationSucceeded" />
        /// event.
        /// </summary>
        protected virtual void OnValidationSucceeded()
            => ValidationSucceeded?.Invoke(
                this, new ValidationSucceededEventArgs()
            );
    }
}
