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
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "AssetSymbolValidator.IsValid: Checking whether the argument of the 'symbol' parameter is blank..."
                );

                if (string.IsNullOrWhiteSpace(symbol))
                    throw new ArgumentException(
                        Resources.Error_AssetSymbol_IsBlank, nameof(symbol)
                    );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "AssetSymbolValidator.IsValid: *** SUCCESS *** We've determined that the argument of the 'symbol' parameter is not blank.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "AssetSymbolValidator.IsValid: Checking whether the argument of the 'symbol' parameter is of a valid format..."
                );

                if (!symbol.IsValidAssetSymbol())
                    throw new FormatException(
                        Resources.Error_AssetSymbol_InvalidFormat
                    );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "AssetSymbolValidator.IsValid: *** SUCCESS *** The argument of the 'symbol' parameter is of a valid format."
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
                $"AssetSymbolValidator.IsValid: Result = {result}"
            );

            return result;
        }
    }
}