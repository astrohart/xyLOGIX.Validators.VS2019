using PostSharp.Patterns.Diagnostics;
using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using xyLOGIX.Core.Debug;
using xyLOGIX.Validators.Interfaces;

namespace xyLOGIX.Validators
{
    /// <summary>
    /// Validates the format of <see cref="T:System.String" /> value(s) that are
    /// supposed to contain valid filesystem pathnames for the Windows operating
    /// system.
    /// </summary>
    public class PathnameValidator : IPathnameValidator
    {
        /// <summary>
        /// Reference to an instance of
        /// <see cref="T:System.Text.RegularExpressions.Regex" /> that is a compiled regex
        /// pattern to match <c>"C:\folder\path"</c> or <c>--root="\\server\share\path"</c>
        /// with or without quotes.
        /// </summary>
        /// <remarks>
        /// This particular regex supports both drive-letter paths and UNC
        /// pathnames.
        /// </remarks>
        private static readonly Regex Path = new Regex(
            @"^(""?)(\\{2}[^\\]+\\[^""\s]+|[a-zA-Z]:\\[^""\s]*)(""?)$",
            RegexOptions.Compiled
        );

        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static PathnameValidator() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected PathnameValidator() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:xyLOGIX.Validators.Interfaces.IPathnameValidator" /> interface.
        /// </summary>
        public static IPathnameValidator
            Instance { [DebuggerStepThrough] get; } = new PathnameValidator();

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
        public bool IsValidFolderPath(string pathname)
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(pathname)) return result;

                var match = Path.Match(pathname);
                if (match == null) return result;

                result = match.Success;
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