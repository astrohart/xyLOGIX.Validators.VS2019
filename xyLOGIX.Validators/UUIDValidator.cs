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
                if (string.IsNullOrWhiteSpace(uuid))
                    throw new ArgumentException(
                        Resources.Error_UUID_CannotBeBlank, nameof(uuid)
                    );

                if (!uuid.IsValidLowercaseGuidWithNoBraces())
                    throw new FormatException(
                        string.Format(Resources.Error_UUID_InvalidFormat, uuid)
                    );
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