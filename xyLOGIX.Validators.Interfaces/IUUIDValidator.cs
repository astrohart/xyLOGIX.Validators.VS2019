namespace xyLOGIX.Validators.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that is
    /// responsible for validating the format of universally-unique identifiers.
    /// </summary>
    public interface IUUIDValidator : IDataValidator
    {
        /// <summary>
        /// Determines whether the contents of the specified <paramref name="uuid" /> has a
        /// valid format.
        /// </summary>
        /// <param name="uuid">
        /// (Required.) A <see cref="T:System.String" /> containing a
        /// universally-unique identifier whose format is to be checked.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="uuid" /> has
        /// a valid format; <see langword="false" /> otherwise.
        /// </returns>
        bool IsValid(string uuid);
    }
}