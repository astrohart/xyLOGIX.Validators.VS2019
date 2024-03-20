namespace xyLOGIX.Validators.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that is
    /// responsible for validating the format of asset symbols.
    /// </summary>
    public interface IAssetSymbolValidator : IDataValidator
    {
        /// <summary>
        /// Determines whether the contents of the specified <paramref name="symbol" /> has
        /// a
        /// valid format.
        /// </summary>
        /// <param name="symbol">
        /// (Required.) A <see cref="T:System.String" /> containing an asset symbol whose
        /// format is to be checked.
        /// </param>
        /// <remarks>
        /// This method returns <see langword="false" /> if the
        /// <paramref name="symbol" /> passed is a <see langword="null" /> reference, the
        /// <see cref="F:System.String.Empty" /> value, or a <see cref="T:System.String" />
        /// that contains only whitespace characters.
        /// <para />
        /// Valid asset symbols are <see cref="T:System.String" />s that contain no
        /// whitespace, having only letters (both upper- and lower-case) and digits.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="symbol" /> has a valid
        /// format; <see langword="false" /> otherwise.
        /// </returns>
        bool IsValid(string symbol);
    }
}