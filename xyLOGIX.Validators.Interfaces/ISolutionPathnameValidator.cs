using PostSharp.Patterns.Diagnostics;

namespace xyLOGIX.Validators.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed events, methods and properties of an object that
    /// validates <see cref="T:System.String" />(s) that purport to contain the
    /// fully-qualified pathname of a Visual Studio Solution (<c>*.sln</c>) file(s).
    /// </summary>
    public interface ISolutionPathnameValidator : IDataValidator
    {
        /// <summary>
        /// Validates that the specified Visual Studio Solution (<c>*.sln</c>)
        /// <paramref name="pathname" /> is of a valid format on the Windows operating
        /// system, and that it is a valid pathname of a Visual Studio Solution (
        /// <c>*.sln</c>) file.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> containing the fully-qualified
        /// pathname that is to be examined.
        /// </param>
        /// <remarks>
        /// Disallows trailing backslashes.
        /// <para />
        /// If the value of the <paramref name="pathname" /> parameter is the
        /// <see langword="null" />, blank, or <see cref="F:System.String.Empty" />
        /// <see cref="T:System.String" />, then this method returns
        /// <see langword="false" />.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="pathname" /> is a
        /// properly-formatted file pathname; <see langword="false" /> otherwise.
        /// </returns>
        bool IsValid([NotLogged] string pathname);
    }
}