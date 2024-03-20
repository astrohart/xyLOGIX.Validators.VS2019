using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;
using xyLOGIX.Validators.Interfaces;
using xyLOGIX.Validators.Properties;

namespace xyLOGIX.Validators
{
    /// <summary>
    /// Validates the format of strings containing an asset symbol, such as for a stock
    /// or cryptocurrency.
    /// </summary>
    public class AssetSymbolValidator : IAssetSymbolValidator
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static AssetSymbolValidator() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected AssetSymbolValidator() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Validators.Interfaces.IAssetSymbolValidator" />
        /// interface.
        /// </summary>
        public static IAssetSymbolValidator Instance { get; } =
            new AssetSymbolValidator();

        /// <summary>
        /// Determines whether the contents of the specified <paramref name="symbol" /> has
        /// a
        /// valid format.
        /// </summary>
        /// <param name="symbol">
        /// (Required.) A <see cref="T:System.String" /> containing an asset symbol whose
        /// format is to be checked.
        /// </param>
        /// <remarks>
        /// This method returns <see langword="false" /> if the
        /// <paramref name="symbol" /> passed is a <see langword="null" /> reference, the
        /// <see cref="F:System.String.Empty" /> value, or a <see cref="T:System.String" />
        /// that contains only whitespace characters.
        /// <para />
        /// Valid asset symbols are <see cref="T:System.String" />s that contain no
        /// whitespace, having only letters (both upper- and lower-case) and digits.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="symbol" /> has a valid
        /// format; <see langword="false" /> otherwise.
        /// </returns>
        public bool IsValid([NotLogged] string symbol)
        {
            var result = true;

            try
            {
                // Dump the parameter symbol to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"AssetSymbolValidator.IsValid: symbol = '{symbol}'"
                );

                if (string.IsNullOrWhiteSpace(symbol))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "*** ERROR *** The value of the 'symbol' parameter cannot be blank."
                    );

                    throw new ArgumentException(
                        Resources.Error_UUID_CannotBeBlank, nameof(symbol)
                    );
                }

                if (!symbol.IsValidLowercaseGuidWithNoBraces())
                    throw new FormatException(
                        string.Format(
                            Resources.Error_AssetSymbol_InvalidFormat, symbol
                        )
                    );

                /*
                 * If we are here, then the symbol that we were passed
                 * has the correct format.
                 */
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