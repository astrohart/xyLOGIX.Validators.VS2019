namespace xyLOGIX.Validators.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that runs
    /// validation logic to determine whether strings are formatted with valid UTC RFC
    /// 3339 timestamps.
    /// </summary>
    public interface IRFC3339TimestampFormatValidator
    {
        /// <summary>
        /// Determines whether a <see cref="T:System.String" /> containing a UTC date and
        /// time is formatted in a valid fashion per the requirements of RFC 3339.
        /// </summary>
        /// <param name="value">
        /// (Required.) A <see cref="T:System.String" /> containing the value to be
        /// examined.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="value" /> is
        /// in a valid format; <see langword="false" /> otherwise.
        /// </returns>
        bool IsValid(string value);
    }
}