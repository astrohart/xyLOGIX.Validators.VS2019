using xyLOGIX.Validators.Events;

namespace xyLOGIX.Validators.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a
    /// <c>Validator</c> object.
    /// </summary>
    /// <remarks>
    /// These objects examine the values of the properties of other objects
    /// and then decide if the object's properties' values are valid.
    /// </remarks>
    public interface IObjectValidator
    {
        /// <summary>
        /// When implemented by a class, gets or sets the error message text
        /// generated when the condition being validated fails.
        /// </summary>
        /// <returns>The error message to generate.</returns>
        string ErrorMessage { get; }

        /// <summary>
        /// When implemented by a class, gets or sets a value indicating whether
        /// the user-entered content in the specified control passes validation.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the content is valid; otherwise,
        /// <see langword="false" />.
        /// </returns>
        bool IsValid { get; }

        /// <summary> Occurs when validation has failed. </summary>
        event ValidationFailedEventHandler ValidationFailed;

        /// <summary> Occurs when validation has succeeded. </summary>
        event ValidationSucceededEventHandler ValidationSucceeded;

        /// <summary>
        /// When implemented by a class, evaluates the condition it checks and
        /// updates the
        /// <see cref="P:xyLOGIX.Validators.Interfaces.IObjectValidator.IsValid" />
        /// property.
        /// </summary>
        void Validate();
    }
}