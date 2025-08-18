using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using xyLOGIX.Validators.Interfaces;

namespace xyLOGIX.Validators
{
    /// <summary>
    /// Runs rules on date ranges to verify that they are valid.
    /// </summary>
    public class DateRangeValidator : IDateRangeValidator
    {
        /// <summary>
        /// Empty, <see langword="static" /> constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static DateRangeValidator() { }

        /// <summary>
        /// Empty, private constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        private DateRangeValidator() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Validators.Interfaces.IDateRangeValidator" />
        /// interface.
        /// </summary>
        public static IDateRangeValidator Instance
        {
            [DebuggerStepThrough] get;
        } = new DateRangeValidator();

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
        [Log(AttributeExclude = true)]
        public bool IsValid(DateTime start, DateTime end)
        {
            var result = false;

            try
            {
                if (start == default && end == default) return result;
                if (start != default && end != default && end <= start)
                    return result;

                result = (start == default && end != default) ||
                         (start != default && end == default) || end > start;
            }
            catch
            {
                //Ignore.
                result = false;
            }

            return result;
        }
    }
}