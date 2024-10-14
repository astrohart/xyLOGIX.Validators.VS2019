namespace xyLOGIX.Validators.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed events, methods and properties of a TCP Port
    /// Number validator.
    /// </summary>
    public interface ITCPPortValidator
    {
        /// <summary>
        /// Determines whether the specified <see cref="T:System.String" />, that
        /// represents the TCP <paramref name="port" /> number using ASCII characters, is
        /// (a) parsable as an integer and (b) is in the range of valid values.
        /// </summary>
        /// <param name="port">
        /// (Required.) A <see cref="T:System.String" /> that contains
        /// the ASCII representation of a TCP port number.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="port" /> is
        /// parsable as an integer, and in the range <c>1</c>-<c>65535</c> (inclusive);
        /// otherwise, <see langword="false" />.
        /// </returns>
        bool IsValid(string port);

        /// <summary>
        /// Determines whether the specified TCP <paramref name="port" /> number is in the
        /// range of valid values.
        /// </summary>
        /// <param name="port">
        /// (Required.) An <see cref="T:System.Int32" /> that set to the TCP port number
        /// that is to be validated.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="port" /> is in the
        /// range <c>1</c>-<c>65535</c> (inclusive); otherwise, <see langword="false" />.
        /// </returns>
        bool IsValid(int port);
    }
}