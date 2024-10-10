namespace xyLOGIX.Validators.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that is
    /// responsible for validating the format of Web addresses.
    /// </summary>
    public interface IWebAddressValidator : IDataValidator
    {
        /// <summary>
        /// Determines whether the contents of the specified <paramref name="webAddress" />
        /// has a valid format.
        /// </summary>
        /// <param name="webAddress">
        /// (Required.) A <see cref="T:System.String" />
        /// containing a Web address whose format is to be checked.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified
        /// <paramref name="webAddress" /> has a valid format; <see langword="false" />
        /// otherwise.
        /// </returns>
        bool IsValid(string webAddress);
    }
}