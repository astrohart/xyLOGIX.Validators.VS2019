using PostSharp.Patterns.Diagnostics;

namespace xyLOGIX.Validators.Interfaces
{
    /// <summary>
    /// Defines a service that validates whether a
    /// <see cref="T:System.String" /> is a correctly formatted Windows filename
    /// wildcard (glob) pattern.
    /// </summary>
    public interface IFileWildcardValidator
    {
        /// <summary>
        /// Determines whether the specified <paramref name="pattern" /> is a
        /// valid Windows filename wildcard (glob) pattern.
        /// </summary>
        /// <param name="pattern">
        /// A <see cref="T:System.String" /> containing the wildcard
        /// pattern to validate.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the value is a valid wildcard pattern;
        /// otherwise, <see langword="false" />.
        /// </returns>
        bool IsValid([NotLogged] string pattern);

        /// <summary>
        /// Determines whether the specified <paramref name="pattern" /> is a
        /// valid Windows filename wildcard (glob) pattern.
        /// </summary>
        /// <param name="pattern">
        /// A <see cref="T:System.String" /> containing the wildcard
        /// pattern to validate.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the value is a valid wildcard pattern;
        /// otherwise, <see langword="false" />.
        /// </returns>
        [Log(AttributeExclude = true)]
        bool IsValidSilent([NotLogged] string pattern);

        /// <summary>
        /// Attempts to validate the specified <paramref name="pattern" /> and, if
        /// invalid, returns a concise reason.
        /// </summary>
        /// <param name="pattern">
        /// A <see cref="T:System.String" /> containing the wildcard
        /// pattern to validate.
        /// </param>
        /// <param name="error">
        /// On return, receives a <see cref="T:System.String" />
        /// describing why validation failed, or an empty string if validation succeeded.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the value is a valid wildcard pattern;
        /// otherwise, <see langword="false" />.
        /// </returns>
        bool TryValidate(string pattern, out string error);

        /// <summary>
        /// Attempts to validate the specified <paramref name="pattern" /> and, if
        /// invalid, returns a concise reason.
        /// </summary>
        /// <param name="pattern">
        /// A <see cref="T:System.String" /> containing the wildcard
        /// pattern to validate.
        /// </param>
        /// <param name="error">
        /// On return, receives a <see cref="T:System.String" />
        /// describing why validation failed, or an empty string if validation succeeded.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the value is a valid wildcard pattern;
        /// otherwise, <see langword="false" />.
        /// </returns>
        [Log(AttributeExclude = true)]
        bool TryValidateSilent(
            [NotLogged] string pattern,
            [NotLogged] out string error
        );
    }
}