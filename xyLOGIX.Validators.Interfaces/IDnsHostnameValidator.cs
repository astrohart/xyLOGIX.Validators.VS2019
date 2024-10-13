namespace xyLOGIX.Validators.Interfaces
{
    /// <summary>
    /// TODO: Add interface documentation here.
    /// </summary>
    public interface IDnsHostnameValidator
    {
        /// <summary>
        /// Validates if the given <paramref name="host" /> address is either a valid IPv4
        /// address or a valid DNS address.
        /// </summary>
        /// <param name="host">
        /// (Required.) A <see cref="T:System.String" /> containing the
        /// address of the host to be validated.
        /// </param>
        /// <returns><see langword="true" /> if valid, otherwise <see langword="false" />.</returns>
        bool IsValid(string host);
    }
}