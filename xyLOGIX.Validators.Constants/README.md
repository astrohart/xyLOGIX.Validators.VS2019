<a name='assembly'></a>
# xyLOGIX.Validators.Constants

## Contents

- [Regexes](#T-xyLOGIX-Validators-Constants-Regexes 'xyLOGIX.Validators.Constants.Regexes')
  - [ThreePartVersion](#F-xyLOGIX-Validators-Constants-Regexes-ThreePartVersion 'xyLOGIX.Validators.Constants.Regexes.ThreePartVersion')
  - [EmailAddress](#P-xyLOGIX-Validators-Constants-Regexes-EmailAddress 'xyLOGIX.Validators.Constants.Regexes.EmailAddress')
  - [RFC3339Timestamp](#P-xyLOGIX-Validators-Constants-Regexes-RFC3339Timestamp 'xyLOGIX.Validators.Constants.Regexes.RFC3339Timestamp')
  - [WebAddress](#P-xyLOGIX-Validators-Constants-Regexes-WebAddress 'xyLOGIX.Validators.Constants.Regexes.WebAddress')
  - [#cctor()](#M-xyLOGIX-Validators-Constants-Regexes-#cctor 'xyLOGIX.Validators.Constants.Regexes.#cctor')
- [Resources](#T-xyLOGIX-Validators-Constants-Properties-Resources 'xyLOGIX.Validators.Constants.Properties.Resources')
  - [Culture](#P-xyLOGIX-Validators-Constants-Properties-Resources-Culture 'xyLOGIX.Validators.Constants.Properties.Resources.Culture')
  - [Regex_EmailAddress](#P-xyLOGIX-Validators-Constants-Properties-Resources-Regex_EmailAddress 'xyLOGIX.Validators.Constants.Properties.Resources.Regex_EmailAddress')
  - [Regex_RFC3339_Timestamp](#P-xyLOGIX-Validators-Constants-Properties-Resources-Regex_RFC3339_Timestamp 'xyLOGIX.Validators.Constants.Properties.Resources.Regex_RFC3339_Timestamp')
  - [Regex_WebAddress](#P-xyLOGIX-Validators-Constants-Properties-Resources-Regex_WebAddress 'xyLOGIX.Validators.Constants.Properties.Resources.Regex_WebAddress')
  - [ResourceManager](#P-xyLOGIX-Validators-Constants-Properties-Resources-ResourceManager 'xyLOGIX.Validators.Constants.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Validators-Constants-Regexes'></a>
## Regexes `type`

##### Namespace

xyLOGIX.Validators.Constants

##### Summary

Values for regular expressions to be utilized when pattern-matching.

<a name='F-xyLOGIX-Validators-Constants-Regexes-ThreePartVersion'></a>
### ThreePartVersion `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a regular expression used to
validate a three-part version string, i.e., `0.2.5`.

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
