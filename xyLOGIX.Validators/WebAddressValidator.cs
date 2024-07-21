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
    public class WebAddressValidator : IWebAddressValidator
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static WebAddressValidator() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected WebAddressValidator() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Validators.Interfaces.IWebAddressValidator" />
        /// interface.
        /// </summary>
        public static IWebAddressValidator Instance { [DebuggerStepThrough] get; } =
            new WebAddressValidator();

        /// <summary>
        /// Determines whether the contents of the specified <paramref name="webAddress" />
        /// has a valid format.
        /// </summary>
        /// <param name="webAddress">
        /// (Required.) A <see cref="T:System.String" />
        /// containing a Web address whose format is to be checked.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified
        /// <paramref name="webAddress" /> has a valid format; <see langword="false" />
        /// otherwise.
        /// </returns>
        public bool IsValid([NotLogged] string webAddress)
        {
            var result = true;

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** INFO: Checking whether the value of the 'webAddress' parameter is blank..."
                );

                if (string.IsNullOrWhiteSpace(webAddress))
                    throw new ArgumentException(
                        Resources.Error_WebAddress_IsBlank, nameof(webAddress)
                    );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** SUCCESS *** The parameter 'webAddress' is not blank.  Continuing..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "WebAddressValidator.IsValid: Attempting to validate the format of the Web address 'webAddress'..."
                );

                if (!Regex.IsMatch(webAddress, Regexes.WebAddress))
                    throw new FormatException(
                        Resources.Error_WebAddress_InvalidFormat
                    );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "WebAddressValidator.IsValid: *** SUCCESS *** The argument of the 'webAddress' parameter appears to be of a valid format."
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
                $"WebAddressValidator.IsValid: Result = {result}"
            );

            return result;
        }
    }
}