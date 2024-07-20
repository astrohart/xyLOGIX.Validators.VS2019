namespace xyLOGIX.Validators.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that is
    /// responsible for validating the format of version strings.
    /// </summary>
    public interface IVersionStringValidator : IDataValidator
    {
        /// <summary>
        /// Determines whether the contents of the specified
        /// <paramref name="versionString" /> have a valid format.
        /// </summary>
        /// <param name="versionString">
        /// (Required.) A <see cref="T:System.String" /> containing a software version
        /// string whose format is to be checked.
        /// </param>
        /// <remarks>
        /// If the value of the <paramref name="versionString" /> parameter is a
        /// <see langword="null" /> reference or is the
        /// <see cref="F:System.String.Empty" /> value, or a value containing only
        /// whitespace, then the method returns <see langword="false" /> without performing
        /// any additional validation.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="versionString" /> has
        /// a valid format; <see langword="false" /> otherwise.
        /// </returns>
        bool IsValid(string versionString);
    }
}