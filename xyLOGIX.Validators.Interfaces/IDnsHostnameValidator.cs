using PostSharp.Patterns.Diagnostics;

namespace xyLOGIX.Validators.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed events, methods and properties of an object that
    /// validates the contents of <see cref="T:System.String" /> variables that purport
    /// to contain a valid hostname for use with Windows Sockets to establish either a
    /// TCP or UDP connection to a remote host..
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
        bool IsValid([NotLogged] string host);
    }
}