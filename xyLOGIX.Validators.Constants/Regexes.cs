using PostSharp.Patterns.Diagnostics;
using System.Diagnostics;
using System.Text.RegularExpressions;
using xyLOGIX.Validators.Constants.Properties;

namespace xyLOGIX.Validators.Constants
{
    /// <summary>
    /// Values for regular expressions to be utilized when pattern-matching.
    /// </summary>
    public static class Regexes
    {
        /// <summary>
        /// A regular expression pattern that matches a period (<c>.</c>) followed
        /// by one or more whitespace characters, except when the whitespace is immediately
        /// followed by a <c>&lt;para /&gt;</c> tag.
        /// <para />
        /// This is used to ensure paragraph breaks are correctly inserted in XML
        /// documentation comments.
        /// </summary>
        public const string InsertXmlParaBreaksPattern = @"\.\s+(?!<para\s*/>)";

        /// <summary>
        /// A regular expression pattern that matches all newline variations
        /// (<c>\r\n</c>, <c>\n</c>, and <c>\r</c>) to facilitate normalization of line
        /// breaks in text processing.
        /// </summary>
        public const string NormalizeLineBreaksPattern = @"\r\n?|\n";

        /// <summary>
        /// A regular expression pattern that matches a <c>&lt;para /&gt;</c> tag with
        /// any surrounding whitespace, ensuring that paragraph breaks in XML documentation
        /// comments are properly formatted.
        /// </summary>
        /// <remarks>
        /// This pattern is used to normalize paragraph breaks by removing unnecessary
        /// leading and trailing whitespace around <c>&lt;para /&gt;</c> tags, ensuring
        /// that each appears on its own line.
        /// </remarks>
        public const string NormalizeXmlParaBreaksPattern = @"\s*<para\s*/>\s*";

        /// <summary>
        /// A <see cref="T:System.String" /> that contains a regular expression used to
        /// validate a string that is in Pascal case.
        /// </summary>
        public const string PascalCasePattern = @"^[A-Z][a-zA-Z0-9_]*$";

        /// <summary>
        /// A <see cref="T:System.String" /> that contains a regular expression used to
        /// validate a three-part version string, i.e., <c>0.2.5</c>.
        /// </summary>
        public const string ThreePartVersion = @"^\d+\.\d+\.\d+$";

        /// <summary>
        /// Regular expression pattern that ensures a valid C# <see langword="class" />
        /// name.
        /// </summary>
        public static readonly Regex ValidClassNamePattern = new Regex(
            @"^[a-zA-Z_][a-zA-Z0-9_]*$", RegexOptions.Compiled
        );

        /// <summary>
        /// Regular expression pattern that ensures a valid C# <see langword="enum" />
        /// name.
        /// </summary>
        public static readonly Regex ValidEnumNamePattern = new Regex(
            @"^[a-zA-Z_][a-zA-Z0-9_]*$", RegexOptions.Compiled
        );

        /// <summary>
        /// The regex pattern used to validate method parameter names.
        /// </summary>
        public static readonly Regex ValidMethodParameterNamePattern =
            new Regex("^@?[a-zA-Z_][a-zA-Z0-9_]*$", RegexOptions.Compiled);

        /// <summary>
        /// Regular expression pattern that ensures a valid C#
        /// <see langword="namespace" /> name.
        /// </summary>
        public static readonly Regex ValidNamespaceNamePattern = new Regex(
            @"^[a-zA-Z_][a-zA-Z0-9_]*$", RegexOptions.Compiled
        );

        /// <summary>
        /// A regular expression pattern that tokenizes text for XML documentation comment
        /// formatting,
        /// ensuring that words, spaces, and self-closing XML tags such as
        /// <c>&lt;para /&gt;</c>
        /// remain intact
        /// as distinct tokens.
        /// </summary>
        public const string XmlDocCommentTokenizationPattern =
            @"<para\s*/>|[^\s<]+|<[^<>]+>";

        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:xyLOGIX.Validators.Constants.Regexes" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static Regexes() { }

        /// <summary>
        /// A <see cref="T:System.String" /> that contains a regular expression used to
        /// validate the format of an email address.
        /// </summary>
        public static string EmailAddress { [DebuggerStepThrough] get; } =
            Resources.Regex_EmailAddress;

        /// <summary>
        /// A <see cref="T:System.String" /> that contains a regular expression used to
        /// validate the format of a <c>RFC 3339</c> timestamp.
        /// </summary>
        public static string RFC3339Timestamp { [DebuggerStepThrough] get; } =
            Resources.Regex_RFC3339_Timestamp;

        /// <summary>
        /// A <see cref="T:System.String" /> that contains a regular expression used to
        /// validate the format of an email address.
        /// </summary>
        public static string WebAddress { [DebuggerStepThrough] get; } =
            Resources.Regex_WebAddress;
    }
}