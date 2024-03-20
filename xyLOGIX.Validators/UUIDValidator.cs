using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;
using xyLOGIX.Validators.Interfaces;
using xyLOGIX.Validators.Properties;

namespace xyLOGIX.Validators
{
    /// <summary>
    /// Validates the format of strings containing a universally-unique identifier
    /// (UUID) of a resource on the <c>Coinbase (Advanced Trade)</c> trading platform.
    /// </summary>
    public class UUIDValidator : IUUIDValidator
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static UUIDValidator() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected UUIDValidator() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Validators.Interfaces.IUUIDValidator" />
        /// interface.
        /// </summary>
        public static IUUIDValidator Instance { get; } = new UUIDValidator();

        /// <summary>
        /// Determines whether the contents of the specified <paramref name="uuid" /> has a
        /// valid format.
        /// </summary>
        /// <param name="uuid">
        /// (Required.) A <see cref="T:System.String" /> containing a universally-unique
        /// identifier corresponding to an account on the <c>Coinbase (Advanced Trade)</c>
        /// trading platform, whose format is to be checked.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="uuid" /> has
        /// a valid format; <see langword="false" /> otherwise.
        /// </returns>
        public bool IsValid([NotLogged] string uuid)
        {
            var result = true;

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "UUIDValidator.IsValid: Checking whether the argument of the 'uuid' parameter is a blank or null string..."
                );

                if (string.IsNullOrWhiteSpace(uuid))
                    throw new ArgumentException(
                        Resources.Error_UUID_CannotBeBlank, nameof(uuid)
                    );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "UUIDValidator.IsValid: Checking whether the argument of the 'uuid' parameter is of a valid format, e.g., 'a49bf1b0-debd-46d7-b32f-d7db7da00380'..."
                );

                if (!uuid.IsValidLowercaseGuidWithNoBraces())
                    throw new FormatException(
                        Resources.Error_UUID_InvalidFormat
                    );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "UUIDValidator.IsValid: *** SUCCESS *** The argument of the 'uuid' parameter is of a valid format."
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
                DebugLevel.Debug, $"UUIDValidator.IsValid: Result = {result}"
            );

            return result;
        }
    }
}