using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace xyLOGIX.Validators.Constants
{
    /// <summary>
    /// Value(s) that represent reserved C# keywords for various purposes.
    /// </summary>
    public static class ReservedCSharpKeywords
    {
        /// <summary>
        /// An array of strings that contain the reserved C# keywords that cannot be used
        /// as identifiers or as part of identifiers.
        /// </summary>
        public static readonly string[] ForIdentifiers =
        {
            "abstract", "as", "base", "bool", "break", "byte", "case",
            "catch", "char", "checked", "class", "const", "continue",
            "decimal", "default", "delegate", "do", "double", "else",
            "enum", "event", "explicit", "extern", "false", "finally",
            "fixed", "float", "for", "foreach", "goto", "if", "implicit",
            "in", "int", "interface", "internal", "is", "lock", "long",
            "namespace", "new", "null", "object", "operator", "out",
            "override", "params", "private", "protected", "public",
            "readonly", "ref", "return", "sbyte", "sealed", "short",
            "sizeof", "stackalloc", "static", "string", "struct", "switch",
            "this", "throw", "true", "try", "typeof", "uint", "ulong",
            "unchecked", "unsafe", "ushort", "using", "virtual", "void",
            "volatile", "while"
        };

        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:xyLOGIX.Validators.Constants.ReservedCSharpKeywords" />
        /// class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static ReservedCSharpKeywords() { }

        /// <summary>
        /// Determines whether the specified <paramref name="value" /> exactly matches a
        /// reserved C# 7.3 keyword in the
        /// <see
        ///     cref="F:xyLOGIX.Validators.Constants.ReservedCSharpKeywords.ForIdentifiers" />
        /// collection.
        /// </summary>
        /// <param name="value">
        /// (Required.) A <see cref="T:System.String" /> containing the text that is to be
        /// examined.
        /// </param>
        /// <remarks>
        /// If the argument of the <paramref name="value" /> parameter is
        /// <see langword="null" />, blank, or the <see cref="F:System.String.Empty" />
        /// value, then this method returns <see langword="false" />.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="value" />
        /// matches a reserved C# 7.3 keyword; otherwise, <see langword="false" />.
        /// </returns>
        public static bool Contains([NotLogged] string value)
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(value)) return result;

                foreach (var element in ForIdentifiers)
                {
                    if (!value.Equals(element)) continue;

                    result = true;
                    break;
                }
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