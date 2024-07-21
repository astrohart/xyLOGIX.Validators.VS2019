using System.Diagnostics;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Text.RegularExpressions;
using xyLOGIX.Core.Debug;
using xyLOGIX.Validators.Constants;
using xyLOGIX.Validators.Interfaces;
using xyLOGIX.Validators.Properties;

namespace xyLOGIX.Validators
{
    /// <summary>
    /// Validates the format of strings containing a universally-unique identifier
    /// (UUID) of a resource on the <c>Coinbase (Advanced Trade)</c> trading platform.
    /// </summary>
    public class EmailAddressValidator : IEmailAddressValidator
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static EmailAddressValidator() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected EmailAddressValidator() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Validators.Interfaces.IEmailAddressValidator" />
        /// interface.
        /// </summary>
        public static IEmailAddressValidator Instance { [DebuggerStepThrough] get; } =
            new EmailAddressValidator();

        /// <summary>
        /// Determines whether the contents of the specified
        /// <paramref name="emailAddress" /> has a valid format.
        /// </summary>
        /// <param name="emailAddress">
        /// (Required.) A <see cref="T:System.String" />
        /// containing an email address whose format is to be checked.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified
        /// <paramref name="emailAddress" /> has a valid format; <see langword="false" />
        /// otherwise.
        /// </returns>
        public bool IsValid([NotLogged] string emailAddress)
        {
            var result = true;

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** INFO: Checking whether the value of the 'emailAddress' parameter is blank..."
                );

                if (string.IsNullOrWhiteSpace(emailAddress))
                    throw new ArgumentException(
                        Resources.Error_EmailAddress_IsBlank,
                        nameof(emailAddress)
                    );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** SUCCESS *** The parameter 'emailAddress' is not blank.  Continuing..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "EmailAddressValidator.IsValid: Attempting to validate the format of the value of the 'emailAddress' parameter..."
                );

                if (!Regex.IsMatch(emailAddress, Regexes.EmailAddress))
                    throw new FormatException(
                        Resources.Error_EmailAddress_InvalidFormat
                    );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "EmailAddressValidator.IsValid: *** SUCCESS *** It is apparent that the value of the 'emailAddress' parameter is of a valid format."
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
                $"EmailAddressValidator.IsValid: Result = {result}"
            );

            return result;
        }
    }
}