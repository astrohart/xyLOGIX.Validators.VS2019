using System;

namespace xyLOGIX.Validators.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that runs
    /// rules on date ranges to verify that they are valid.
    /// </summary>
    public interface IDateRangeValidator : IDataValidator
    {
        /// <summary>
        /// Validates that the <paramref name="end" /> and <paramref name="start" /> dates
        /// passed are not equal, and that <paramref name="end" /> follows
        /// <paramref name="start" />.
        /// </summary>
        /// <param name="start">
        /// (Required.) A <see cref="T:System.DateTime" /> value that
        /// indicates the start of the time interval.
        /// </param>
        /// <param name="end">
        /// (Required.) A <see cref="T:System.DateTime" /> value that
        /// indicates the end of the time interval.
        /// </param>
        /// <remarks>
        /// This method returns <see langword="true" /> if either <paramref name="start" />
        /// or <paramref name="end" /> are set to the value
        /// <c>January 1, 0001 at 00:00:00</c>; but they cannot both be set to this value,
        /// otherwise then the method returns <see langword="false" />.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the date range is valid;
        /// <see langword="false" /> otheriwse.
        /// </returns>
        bool IsValid(DateTime start, DateTime end);
    }
}