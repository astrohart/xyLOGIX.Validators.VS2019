using System.Diagnostics;
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
        /// Empty, <see langword="static" /> constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static UUIDValidator() { }

        /// <summary>
        /// Empty, private constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        private UUIDValidator() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Validators.Interfaces.IUUIDValidator" />
        /// interface.
        /// </summary>
        public static IUUIDValidator Instance { [DebuggerStepThrough] get; } = new UUIDValidator();

        /// <summary>
        /// Determines whether the contents of the specified <paramref name="uuid" /> has a
        /// valid format.
        /// </summary>
        /// <param name="uuid">
        /// (Required.) A <see cref="T:System.String" /> containing a universally-unique
        /// identifier corresponding to an account on the <c>Coinbase (Advanced Trade)</c>
        /// trading platform, whose format is to be checked.
        /// </param>
        /// <param name="silent">
        /// (Required.) A <see cref="T:System.Boolean" />  indicating whether logging
        /// messages emitted by this method are to be suppressed.
        /// <para />
        /// The default value of this parameter is <see langword="false" />.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="uuid" /> has
        /// a valid format; <see langword="false" /> otherwise.
        /// </returns>
        [Log(AttributeExclude = true)]
        public bool IsValid(string uuid, bool silent = false)
        {
            var result = true;

            try
            {
                if (!silent) DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "UUIDValidator.IsValid: Checking whether the argument of the 'uuid' parameter is a blank or null string..."
                );

                if (string.IsNullOrWhiteSpace(uuid))
                    throw new ArgumentException(
                        Resources.Error_UUID_CannotBeBlank, nameof(uuid)
                    );

                if (!silent) DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "UUIDValidator.IsValid: Checking whether the 'uuid' parameter is set to the Zero UUID, i.e., 00000000-0000-0000-0000-000000000000..."
                );

                if (Guid.Empty.ToString("D")
                        .Equals(uuid))
                    throw new ArgumentException(
                        Resources.Error_UUID_CannotBeZeroGUID
                    );

                if (!silent) DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "UUIDValidator.IsValid: Checking whether the argument of the 'uuid' parameter is of a valid format, e.g., 'a49bf1b0-debd-46d7-b32f-d7db7da00380'..."
                );

                if (!uuid.IsValidLowercaseGuidWithNoBraces())
                    throw new FormatException(
                        Resources.Error_UUID_InvalidFormat
                    );

                if (!silent) DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "UUIDValidator.IsValid: *** SUCCESS *** The argument of the 'uuid' parameter is of a valid format."
                );
            }
            catch (Exception ex)
            {
                if (!silent) DebugUtils.WriteLine(
                    DebugLevel.Error, $"*** ERROR *** {ex.Message}"
                );

                result = false;
            }

            if (!silent) DebugUtils.WriteLine(
                DebugLevel.Debug, $"UUIDValidator.IsValid: Result = {result}"
            );

            return result;
        }
    }
}
