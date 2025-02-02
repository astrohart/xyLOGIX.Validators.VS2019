using PostSharp.Patterns.Diagnostics;

namespace xyLOGIX.Validators.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed events, methods and properties of object(s) that
    /// validate the format of <see cref="T:System.String" /> values that purport to
    /// contain pathnames..
    /// </summary>
    public interface IPathnameValidator : IDataValidator
    {
        /// <summary>
        /// Validates that the specified file <paramref name="pathname" /> is of a valid
        /// format on the Windows operating system.
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
        bool IsValidFilePath([NotLogged] string pathname);

        /// <summary>
        /// Validates that the specified folder <paramref name="pathname" /> is of
        /// a valid format on the Windows operating system.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> containing
        /// the data that is to be examined.
        /// </param>
        /// <returns>
        /// <see langword="true" /> depending whether the specified
        /// <paramref name="pathname" /> contains text whose format is valid for a
        /// filesystem pathname of a folder on the Windows operating system;
        /// <see langword="false" /> otherwise.
        /// </returns>
        bool IsValidFolderPath(string pathname);
    }
}