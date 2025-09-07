using Alphaleonis.Win32.Filesystem;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Linq;

namespace xyLOGIX.Validators.Constants
{
    /// <summary>
    /// Value(s) for the filename extension(s) of the project (<c>*.*proj</c>) file(s)
    /// that are supported by modern version(s) of the Visual Studio IDE.
    /// </summary>
    public class ValidProjectFilenameExtensions
    {
        /// <summary>
        /// Gets the list of valid project filename extensions.
        /// </summary>
        public static readonly string[] Extensions =
        {
            "*.csproj", "*.vbproj", "*.fsproj"
        };
    }
}