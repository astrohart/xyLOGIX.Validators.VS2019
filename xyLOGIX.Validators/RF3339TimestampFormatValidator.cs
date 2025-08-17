using System.Diagnostics;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Text.RegularExpressions;
using xyLOGIX.Core.Debug;
using xyLOGIX.Validators.Constants;
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
        /// Empty, <see langword="static" /> constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static RF3339TimestampFormatValidator() { }

        /// <summary>
        /// Empty, <see langword="private" /> constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        private RF3339TimestampFormatValidator() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Validators.Interfaces.IRFC3339TimestampFormatValidator" />
        /// interface.
        /// </summary>
        public static IRFC3339TimestampFormatValidator Instance { [DebuggerStepThrough] get; } =
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
            var result = true;

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** INFO: Checking whether the value of the 'value' parameter is blank..."
                );

                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException(
                        "Value cannot be null or whitespace.", nameof(value)
                    );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** SUCCESS *** The parameter 'value' is not blank.  Continuing..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "RF3339TimestampFormatValidator.IsValid: Validating whether the argument of the 'value' parameter is of the proper format..."
                );

                if (!Regex.IsMatch(value, Regexes.RFC3339Timestamp))
                    throw new FormatException(
                        "The value supplied does not match the format of a valid RFC 3339 timestamp."
                    );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "RF3339TimestampFormatValidator.IsValid: *** SUCCESS *** The argument of the 'value' parameter appears to be of a proper format."
                );
            }
            catch (Exception ex)
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error, $"*** ERROR *** {ex.Message}"
                );

                result = false;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"RF3339TimestampFormatValidator.IsValid: Result = {result}"
            );

            return result;
        }
    }
}