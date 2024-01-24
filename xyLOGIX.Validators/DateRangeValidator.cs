using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Validators.Interfaces;

namespace xyLOGIX.Validators
{
    /// <summary>
    /// Runs rules on date ranges to verify that they are valid.
    /// </summary>
    public class DateRangeValidator : IDateRangeValidator
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static DateRangeValidator() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected DateRangeValidator() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Validators.Interfaces.IDateRangeValidator" />
        /// interface.
        /// </summary>
        public static IDateRangeValidator Instance { get; } =
            new DateRangeValidator();

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
        public bool IsValid(DateTime start, DateTime end)
        {
            var result = false;

            try
            {
                if (start == default && end == default)
                {
                    /*
                     * OKAY, if both the start and end dates are their
                     * default value, just silently fail here.  All this
                     * means is that they aren't being used as search query
                     * parameters.
                     */

                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        $"DateRangeValidator.IsValid: The value '{default(DateTime)}' was passed for both the 'start' and the 'end' parameters.  This means they aren't being used for a search."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"DateRangeValidator.IsValid: Result = {result}"
                    );

                    return
                        result; // silently return FALSE here, do not throw an exception
                }

                if (start != default && end != default && end <= start)
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"DateRangeValidator.IsValid: *** ERROR *** The end date, '{end}', is BEFORE or THE SAME AS the start date, '{start}'.  This is illogical.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"DateRangeValidator.IsValid: Result = {result}"
                    );

                    return result;
                }

                result = (start == default && end != default) ||
                         (start != default && end == default) || end > start;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"DateRangeValidator.IsValid: Result = {result}"
            );

            return result;
        }
    }
}