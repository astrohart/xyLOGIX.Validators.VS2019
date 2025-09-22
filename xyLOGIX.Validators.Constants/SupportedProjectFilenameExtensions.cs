using System.Diagnostics;
using PostSharp.Patterns.Diagnostics;

namespace xyLOGIX.Validators.Constants
{
    /// <summary>
    /// Value(s) for the filename extension(s) of the project (<c>.*proj</c>) file(s)
    /// that are supported by modern version(s) of the Visual Studio IDE.
    /// </summary>
    public static class SupportedProjectFilenameExtensions
    {
        /// <summary>
        /// Gets the list of valid project filename extensions.
        /// </summary>
        public static readonly string[] Extensions =
        {
            ".csproj", ".vbproj", ".fsproj"
        };

        /// <summary>
        /// Initializes <see langword="static" /> data or performs actions that
        /// need to be performed once only for the
        /// <see cref="T:SupportedProjectFilenameExtensions" />
        /// class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance
        /// being created or before any <see langword="static" /> members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static SupportedProjectFilenameExtensions() { }
    }
}