namespace xyLOGIX.Validators.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that is
    /// responsible for validating the format of email addresses.
    /// </summary>
    public interface IEmailAddressValidator : IDataValidator
    {
        /// <summary>
        /// Determines whether the contents of the specified <paramref name="emailAddress" /> has a
        /// valid format.
        /// </summary>
        /// <param name="emailAddress">
        /// (Required.) A <see cref="T:System.String" /> containing a
        /// universally-unique identifier whose format is to be checked.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="emailAddress" /> has
        /// a valid format; <see langword="false" /> otherwise.
        /// </returns>
        bool IsValid(string emailAddress);
    }
}