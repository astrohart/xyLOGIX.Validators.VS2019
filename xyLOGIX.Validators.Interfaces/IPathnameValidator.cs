﻿namespace xyLOGIX.Validators.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed events, methods and properties of object(s) that
    /// validate the format of <see cref="T:System.String" /> values that purport to
    /// contain pathnames..
    /// </summary>
    public interface IPathnameValidator
    {
        /// <summary>
        /// Validates that the specified <paramref name="pathname" /> is of a valid format
        /// on the Windows operating system.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> containing
        /// the data that is to be examined.
        /// </param>
        /// <returns>
        /// <see langword="true" /> depending whether the specified
        /// <paramref name="pathname" /> contains text whose format is valid for a
        /// filesystem pathname on the Windows operating system; <see langword="false" />
        /// otherwise.
        /// </returns>
        bool IsValidFolderPath(string pathname);
    }
}