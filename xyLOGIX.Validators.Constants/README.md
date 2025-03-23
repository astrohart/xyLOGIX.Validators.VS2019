<a name='assembly'></a>
# xyLOGIX.Validators.Constants

## Contents

- [MaxPathLength](#T-xyLOGIX-Validators-Constants-MaxPathLength 'xyLOGIX.Validators.Constants.MaxPathLength')
  - [Legacy](#F-xyLOGIX-Validators-Constants-MaxPathLength-Legacy 'xyLOGIX.Validators.Constants.MaxPathLength.Legacy')
  - [NTFS](#F-xyLOGIX-Validators-Constants-MaxPathLength-NTFS 'xyLOGIX.Validators.Constants.MaxPathLength.NTFS')
- [Regexes](#T-xyLOGIX-Validators-Constants-Regexes 'xyLOGIX.Validators.Constants.Regexes')
  - [AcronymPattern](#F-xyLOGIX-Validators-Constants-Regexes-AcronymPattern 'xyLOGIX.Validators.Constants.Regexes.AcronymPattern')
  - [InitialCapsWordPattern](#F-xyLOGIX-Validators-Constants-Regexes-InitialCapsWordPattern 'xyLOGIX.Validators.Constants.Regexes.InitialCapsWordPattern')
  - [InsertXmlParaBreaksPattern](#F-xyLOGIX-Validators-Constants-Regexes-InsertXmlParaBreaksPattern 'xyLOGIX.Validators.Constants.Regexes.InsertXmlParaBreaksPattern')
  - [NormalizeLineBreaksPattern](#F-xyLOGIX-Validators-Constants-Regexes-NormalizeLineBreaksPattern 'xyLOGIX.Validators.Constants.Regexes.NormalizeLineBreaksPattern')
  - [NormalizeXmlParaBreaksPattern](#F-xyLOGIX-Validators-Constants-Regexes-NormalizeXmlParaBreaksPattern 'xyLOGIX.Validators.Constants.Regexes.NormalizeXmlParaBreaksPattern')
  - [PascalCasePattern](#F-xyLOGIX-Validators-Constants-Regexes-PascalCasePattern 'xyLOGIX.Validators.Constants.Regexes.PascalCasePattern')
  - [ThreePartVersion](#F-xyLOGIX-Validators-Constants-Regexes-ThreePartVersion 'xyLOGIX.Validators.Constants.Regexes.ThreePartVersion')
  - [ValidClassNamePattern](#F-xyLOGIX-Validators-Constants-Regexes-ValidClassNamePattern 'xyLOGIX.Validators.Constants.Regexes.ValidClassNamePattern')
  - [ValidEnumNamePattern](#F-xyLOGIX-Validators-Constants-Regexes-ValidEnumNamePattern 'xyLOGIX.Validators.Constants.Regexes.ValidEnumNamePattern')
  - [ValidMethodParameterNamePattern](#F-xyLOGIX-Validators-Constants-Regexes-ValidMethodParameterNamePattern 'xyLOGIX.Validators.Constants.Regexes.ValidMethodParameterNamePattern')
  - [ValidNamespaceNamePattern](#F-xyLOGIX-Validators-Constants-Regexes-ValidNamespaceNamePattern 'xyLOGIX.Validators.Constants.Regexes.ValidNamespaceNamePattern')
  - [XmlDocCommentTokenizationPattern](#F-xyLOGIX-Validators-Constants-Regexes-XmlDocCommentTokenizationPattern 'xyLOGIX.Validators.Constants.Regexes.XmlDocCommentTokenizationPattern')
  - [EmailAddress](#P-xyLOGIX-Validators-Constants-Regexes-EmailAddress 'xyLOGIX.Validators.Constants.Regexes.EmailAddress')
  - [RFC3339Timestamp](#P-xyLOGIX-Validators-Constants-Regexes-RFC3339Timestamp 'xyLOGIX.Validators.Constants.Regexes.RFC3339Timestamp')
  - [WebAddress](#P-xyLOGIX-Validators-Constants-Regexes-WebAddress 'xyLOGIX.Validators.Constants.Regexes.WebAddress')
  - [#cctor()](#M-xyLOGIX-Validators-Constants-Regexes-#cctor 'xyLOGIX.Validators.Constants.Regexes.#cctor')
- [ReservedCSharpKeywords](#T-xyLOGIX-Validators-Constants-ReservedCSharpKeywords 'xyLOGIX.Validators.Constants.ReservedCSharpKeywords')
  - [ForIdentifiers](#F-xyLOGIX-Validators-Constants-ReservedCSharpKeywords-ForIdentifiers 'xyLOGIX.Validators.Constants.ReservedCSharpKeywords.ForIdentifiers')
  - [#cctor()](#M-xyLOGIX-Validators-Constants-ReservedCSharpKeywords-#cctor 'xyLOGIX.Validators.Constants.ReservedCSharpKeywords.#cctor')
  - [Contains(value)](#M-xyLOGIX-Validators-Constants-ReservedCSharpKeywords-Contains-System-String- 'xyLOGIX.Validators.Constants.ReservedCSharpKeywords.Contains(System.String)')
- [Resources](#T-xyLOGIX-Validators-Constants-Properties-Resources 'xyLOGIX.Validators.Constants.Properties.Resources')
  - [Culture](#P-xyLOGIX-Validators-Constants-Properties-Resources-Culture 'xyLOGIX.Validators.Constants.Properties.Resources.Culture')
  - [Regex_EmailAddress](#P-xyLOGIX-Validators-Constants-Properties-Resources-Regex_EmailAddress 'xyLOGIX.Validators.Constants.Properties.Resources.Regex_EmailAddress')
  - [Regex_RFC3339_Timestamp](#P-xyLOGIX-Validators-Constants-Properties-Resources-Regex_RFC3339_Timestamp 'xyLOGIX.Validators.Constants.Properties.Resources.Regex_RFC3339_Timestamp')
  - [Regex_WebAddress](#P-xyLOGIX-Validators-Constants-Properties-Resources-Regex_WebAddress 'xyLOGIX.Validators.Constants.Properties.Resources.Regex_WebAddress')
  - [ResourceManager](#P-xyLOGIX-Validators-Constants-Properties-Resources-ResourceManager 'xyLOGIX.Validators.Constants.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Validators-Constants-MaxPathLength'></a>
## MaxPathLength `type`

##### Namespace

xyLOGIX.Validators.Constants

##### Summary

Value(s) for the length(s) of pathname(s) that are considered to be the maximum
length(s).

<a name='F-xyLOGIX-Validators-Constants-MaxPathLength-Legacy'></a>
### Legacy `constants`

##### Summary

Maximum length of a pathname in the Windows operating system according to the
legacy value of `MAX_PATH`.

<a name='F-xyLOGIX-Validators-Constants-MaxPathLength-NTFS'></a>
### NTFS `constants`

##### Summary

Maximum length of a pathname in the Windows operating system according to the
NTFS value.

<a name='T-xyLOGIX-Validators-Constants-Regexes'></a>
## Regexes `type`

##### Namespace

xyLOGIX.Validators.Constants

##### Summary

Values for regular expressions to be utilized when pattern-matching.

<a name='F-xyLOGIX-Validators-Constants-Regexes-AcronymPattern'></a>
### AcronymPattern `constants`

##### Summary

A regular expression pattern that matches an entire string consisting only of
uppercase letters.
This pattern is useful for identifying acronyms (e.g., "NASA", "AI", "RADAR")
that appear as
standalone words without any lowercase letters.

This pattern ensures that the input string contains only uppercase letters from
A to Z
and does not include numbers, spaces, or lowercase characters.

<a name='F-xyLOGIX-Validators-Constants-Regexes-InitialCapsWordPattern'></a>
### InitialCapsWordPattern `constants`

##### Summary

A regular expression pattern that matches words in an initial-caps formatted
string.
This pattern identifies:

The matched words can be used to transform an initial-caps string into a
space-separated phrase
while preserving acronyms.

<a name='F-xyLOGIX-Validators-Constants-Regexes-InsertXmlParaBreaksPattern'></a>
### InsertXmlParaBreaksPattern `constants`

##### Summary

A regular expression pattern that matches a period (`.`) followed
by one or more whitespace characters, except when the whitespace is immediately
followed by a `<para />` tag.



This is used to ensure paragraph breaks are correctly inserted in XML
documentation comments.

<a name='F-xyLOGIX-Validators-Constants-Regexes-NormalizeLineBreaksPattern'></a>
### NormalizeLineBreaksPattern `constants`

##### Summary

A regular expression pattern that matches all newline variations
(`\r\n`, `\n`, and `\r`) to facilitate normalization of line
breaks in text processing.

<a name='F-xyLOGIX-Validators-Constants-Regexes-NormalizeXmlParaBreaksPattern'></a>
### NormalizeXmlParaBreaksPattern `constants`

##### Summary

A regular expression pattern that matches a `<para />` tag with
any surrounding whitespace, ensuring that paragraph breaks in XML documentation
comments are properly formatted.

##### Remarks

This pattern is used to normalize paragraph breaks by removing unnecessary
leading and trailing whitespace around `<para />` tags, ensuring
that each appears on its own line.

<a name='F-xyLOGIX-Validators-Constants-Regexes-PascalCasePattern'></a>
### PascalCasePattern `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a regular expression used to
validate a string that is in Pascal case.

<a name='F-xyLOGIX-Validators-Constants-Regexes-ThreePartVersion'></a>
### ThreePartVersion `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a regular expression used to
validate a three-part version string, i.e., `0.2.5`.

<a name='F-xyLOGIX-Validators-Constants-Regexes-ValidClassNamePattern'></a>
### ValidClassNamePattern `constants`

##### Summary

Regular expression pattern that ensures a valid C# `class`
name.

<a name='F-xyLOGIX-Validators-Constants-Regexes-ValidEnumNamePattern'></a>
### ValidEnumNamePattern `constants`

##### Summary

Regular expression pattern that ensures a valid C# `enum`
name.

<a name='F-xyLOGIX-Validators-Constants-Regexes-ValidMethodParameterNamePattern'></a>
### ValidMethodParameterNamePattern `constants`

##### Summary

The regex pattern used to validate method parameter names.

<a name='F-xyLOGIX-Validators-Constants-Regexes-ValidNamespaceNamePattern'></a>
### ValidNamespaceNamePattern `constants`

##### Summary

Regular expression pattern that ensures a valid C#
`namespace` name.

<a name='F-xyLOGIX-Validators-Constants-Regexes-XmlDocCommentTokenizationPattern'></a>
### XmlDocCommentTokenizationPattern `constants`

##### Summary

A regular expression pattern that tokenizes text for XML documentation comment
formatting,
ensuring that words, spaces, and self-closing XML tags such as
`<para />`
remain intact
as distinct tokens.

<a name='P-xyLOGIX-Validators-Constants-Regexes-EmailAddress'></a>
### EmailAddress `property`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a regular expression used to
validate the format of an email address.

<a name='P-xyLOGIX-Validators-Constants-Regexes-RFC3339Timestamp'></a>
### RFC3339Timestamp `property`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a regular expression used to
validate the format of a `RFC 3339` timestamp.

<a name='P-xyLOGIX-Validators-Constants-Regexes-WebAddress'></a>
### WebAddress `property`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a regular expression used to
validate the format of an email address.

<a name='M-xyLOGIX-Validators-Constants-Regexes-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [Regexes](#T-xyLOGIX-Validators-Constants-Regexes 'xyLOGIX.Validators.Constants.Regexes') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='T-xyLOGIX-Validators-Constants-ReservedCSharpKeywords'></a>
## ReservedCSharpKeywords `type`

##### Namespace

xyLOGIX.Validators.Constants

##### Summary

Value(s) that represent reserved C# keywords for various purposes.

<a name='F-xyLOGIX-Validators-Constants-ReservedCSharpKeywords-ForIdentifiers'></a>
### ForIdentifiers `constants`

##### Summary

An array of strings that contain the reserved C# keywords that cannot be used
as identifiers or as part of identifiers.

<a name='M-xyLOGIX-Validators-Constants-ReservedCSharpKeywords-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [ReservedCSharpKeywords](#T-xyLOGIX-Validators-Constants-ReservedCSharpKeywords 'xyLOGIX.Validators.Constants.ReservedCSharpKeywords')
class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-xyLOGIX-Validators-Constants-ReservedCSharpKeywords-Contains-System-String-'></a>
### Contains(value) `method`

##### Summary

Determines whether the specified `value` exactly matches a
reserved C# 7.3 keyword in the
[ForIdentifiers](#F-xyLOGIX-Validators-Constants-ReservedCSharpKeywords-ForIdentifiers 'xyLOGIX.Validators.Constants.ReservedCSharpKeywords.ForIdentifiers')
collection.

##### Returns

`true` if the specified `value`
matches a reserved C# 7.3 keyword; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the text that is to be
examined. |

##### Remarks

If the argument of the `value` parameter is
`null`, blank, or the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty')
value, then this method returns `false`.

<a name='T-xyLOGIX-Validators-Constants-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Validators.Constants.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Validators-Constants-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Validators-Constants-Properties-Resources-Regex_EmailAddress'></a>
### Regex_EmailAddress `property`

##### Summary

Looks up a localized string similar to ^([a-zA-Z0-9._%-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,})$.

<a name='P-xyLOGIX-Validators-Constants-Properties-Resources-Regex_RFC3339_Timestamp'></a>
### Regex_RFC3339_Timestamp `property`

##### Summary

Looks up a localized string similar to (?:[1-9]\d{3}-(?:(?:0[1-9]|1[0-2])-(?:0[1-9]|1\d|2[0-8])|(?:0[13-9]|1[0-2])-(?:29|30)|(?:0[13578]|1[02])-31)|(?:[1-9]\d(?:0[48]|[2468][048]|[13579][26])|(?:[2468][048]|[13579][26])00)-02-29)T(?:[01]\d|2[0-3]):[0-5]\d:[0-5]\d(?:Z|[+-][01]\d:[0-5]\d).

<a name='P-xyLOGIX-Validators-Constants-Properties-Resources-Regex_WebAddress'></a>
### Regex_WebAddress `property`

##### Summary

Looks up a localized string similar to ^(http(s):\/\/.)[-a-zA-Z0-9@:%._\+~#=]{2,256}\.[a-z]{2,6}\b([-a-zA-Z0-9@:%_\+.~#?&//=]*)$.

<a name='P-xyLOGIX-Validators-Constants-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
