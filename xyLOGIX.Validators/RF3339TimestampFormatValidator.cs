using PostSharp.Patterns.Diagnostics;
using System;
using System.Text.RegularExpressions;
using xyLOGIX.Core.Debug;
using xyLOGIX.Validators.Interfaces;

namespace xyLOGIX.Validators
{
    /// <summary>
    /// Runs validation logic to determine whether strings are formatted with
    /// valid UTC <c>RFC 3339</c> timestamps.
    /// </summary>
    public class
        RF3339TimestampFormatValidator : IRFC3339TimestampFormatValidator
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static RF3339TimestampFormatValidator() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected RF3339TimestampFormatValidator() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see
        ///     cref="T:xyLOGIX.CoinbaseAT.Models.Validators.Interfaces.IRFC3339TimestampFormatValidator" />
        /// interface.
        /// </summary>
        public static IRFC3339TimestampFormatValidator Instance { get; } =
            new RF3339TimestampFormatValidator();

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
        public bool IsValid(string value)
        {
            bool result;

            try
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException(
                        "Value cannot be null or whitespace.", nameof(value)
                    );

                if (!Regex.IsMatch(value, CoinbaseRegexes.RFC3339Timestamp))
                    throw new FormatException(
                        $"The value supplied, '{value}', does not match the format of a valid RFC 3339 timestamp."
                    );

                /*
                 * If we made it here, then the data is in a valid format.
                 */

                result = true;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }
    }
}