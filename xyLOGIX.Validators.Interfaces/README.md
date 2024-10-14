<a name='assembly'></a>
# xyLOGIX.Validators.Interfaces

## Contents

- [IAssetSymbolValidator](#T-xyLOGIX-Validators-Interfaces-IAssetSymbolValidator 'xyLOGIX.Validators.Interfaces.IAssetSymbolValidator')
  - [IsValid(symbol)](#M-xyLOGIX-Validators-Interfaces-IAssetSymbolValidator-IsValid-System-String- 'xyLOGIX.Validators.Interfaces.IAssetSymbolValidator.IsValid(System.String)')
- [IDataValidator](#T-xyLOGIX-Validators-Interfaces-IDataValidator 'xyLOGIX.Validators.Interfaces.IDataValidator')
- [IDateRangeValidator](#T-xyLOGIX-Validators-Interfaces-IDateRangeValidator 'xyLOGIX.Validators.Interfaces.IDateRangeValidator')
  - [IsValid(start,end)](#M-xyLOGIX-Validators-Interfaces-IDateRangeValidator-IsValid-System-DateTime,System-DateTime- 'xyLOGIX.Validators.Interfaces.IDateRangeValidator.IsValid(System.DateTime,System.DateTime)')
- [IDnsHostnameValidator](#T-xyLOGIX-Validators-Interfaces-IDnsHostnameValidator 'xyLOGIX.Validators.Interfaces.IDnsHostnameValidator')
  - [IsValid(host)](#M-xyLOGIX-Validators-Interfaces-IDnsHostnameValidator-IsValid-System-String- 'xyLOGIX.Validators.Interfaces.IDnsHostnameValidator.IsValid(System.String)')
- [IEmailAddressValidator](#T-xyLOGIX-Validators-Interfaces-IEmailAddressValidator 'xyLOGIX.Validators.Interfaces.IEmailAddressValidator')
  - [IsValid(emailAddress)](#M-xyLOGIX-Validators-Interfaces-IEmailAddressValidator-IsValid-System-String- 'xyLOGIX.Validators.Interfaces.IEmailAddressValidator.IsValid(System.String)')
- [IObjectValidator](#T-xyLOGIX-Validators-Interfaces-IObjectValidator 'xyLOGIX.Validators.Interfaces.IObjectValidator')
  - [ErrorMessage](#P-xyLOGIX-Validators-Interfaces-IObjectValidator-ErrorMessage 'xyLOGIX.Validators.Interfaces.IObjectValidator.ErrorMessage')
  - [IsValid](#P-xyLOGIX-Validators-Interfaces-IObjectValidator-IsValid 'xyLOGIX.Validators.Interfaces.IObjectValidator.IsValid')
  - [Validate()](#M-xyLOGIX-Validators-Interfaces-IObjectValidator-Validate 'xyLOGIX.Validators.Interfaces.IObjectValidator.Validate')
- [IRFC3339TimestampFormatValidator](#T-xyLOGIX-Validators-Interfaces-IRFC3339TimestampFormatValidator 'xyLOGIX.Validators.Interfaces.IRFC3339TimestampFormatValidator')
  - [IsValid(value)](#M-xyLOGIX-Validators-Interfaces-IRFC3339TimestampFormatValidator-IsValid-System-String- 'xyLOGIX.Validators.Interfaces.IRFC3339TimestampFormatValidator.IsValid(System.String)')
- [IUUIDValidator](#T-xyLOGIX-Validators-Interfaces-IUUIDValidator 'xyLOGIX.Validators.Interfaces.IUUIDValidator')
  - [IsValid(uuid,silent)](#M-xyLOGIX-Validators-Interfaces-IUUIDValidator-IsValid-System-String,System-Boolean- 'xyLOGIX.Validators.Interfaces.IUUIDValidator.IsValid(System.String,System.Boolean)')
- [IVersionStringValidator](#T-xyLOGIX-Validators-Interfaces-IVersionStringValidator 'xyLOGIX.Validators.Interfaces.IVersionStringValidator')
  - [IsValid(versionString)](#M-xyLOGIX-Validators-Interfaces-IVersionStringValidator-IsValid-System-String- 'xyLOGIX.Validators.Interfaces.IVersionStringValidator.IsValid(System.String)')
- [IWebAddressValidator](#T-xyLOGIX-Validators-Interfaces-IWebAddressValidator 'xyLOGIX.Validators.Interfaces.IWebAddressValidator')
  - [IsValid(webAddress)](#M-xyLOGIX-Validators-Interfaces-IWebAddressValidator-IsValid-System-String- 'xyLOGIX.Validators.Interfaces.IWebAddressValidator.IsValid(System.String)')
- [Resources](#T-xyLOGIX-Validators-Interfaces-Properties-Resources 'xyLOGIX.Validators.Interfaces.Properties.Resources')
  - [Culture](#P-xyLOGIX-Validators-Interfaces-Properties-Resources-Culture 'xyLOGIX.Validators.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Validators-Interfaces-Properties-Resources-ResourceManager 'xyLOGIX.Validators.Interfaces.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Validators-Interfaces-IAssetSymbolValidator'></a>
## IAssetSymbolValidator `type`

##### Namespace

xyLOGIX.Validators.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an object that is
responsible for validating the format of asset symbols.

<a name='M-xyLOGIX-Validators-Interfaces-IAssetSymbolValidator-IsValid-System-String-'></a>
### IsValid(symbol) `method`

##### Summary

Determines whether the contents of the specified `symbol` has
a
valid format.

##### Returns

`true` if the specified `symbol` has a valid
format; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| symbol | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing an asset symbol whose
format is to be checked. |

##### Remarks

This method returns `false` if the
`symbol` passed is a `null` reference, the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value, or a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
that contains only whitespace characters.



Valid asset symbols are [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')s that contain no
whitespace, having only letters (both upper- and lower-case) and digits.

<a name='T-xyLOGIX-Validators-Interfaces-IDataValidator'></a>
## IDataValidator `type`

##### Namespace

xyLOGIX.Validators.Interfaces

##### Summary

Defines the publicly-exposed methods and properties that are in common to all
data validators.

<a name='T-xyLOGIX-Validators-Interfaces-IDateRangeValidator'></a>
## IDateRangeValidator `type`

##### Namespace

xyLOGIX.Validators.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an object that runs
rules on date ranges to verify that they are valid.

<a name='M-xyLOGIX-Validators-Interfaces-IDateRangeValidator-IsValid-System-DateTime,System-DateTime-'></a>
### IsValid(start,end) `method`

##### Summary

Validates that the `end` and `start` dates
passed are not equal, and that `end` follows
`start`.

##### Returns

`true` if the date range is valid;
`false` otheriwse.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| start | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | (Required.) A [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value that
indicates the start of the time interval. |
| end | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | (Required.) A [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') value that
indicates the end of the time interval. |

##### Remarks

This method returns `true` if either `start`
or `end` are set to the value
`January 1, 0001 at 00:00:00`; but they cannot both be set to this value,
otherwise then the method returns `false`.

<a name='T-xyLOGIX-Validators-Interfaces-IDnsHostnameValidator'></a>
## IDnsHostnameValidator `type`

##### Namespace

xyLOGIX.Validators.Interfaces

##### Summary

Defines the publicly-exposed events, methods and properties of an object that
validates the contents of [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') variables that purport
to contain a valid hostname for use with Windows Sockets to establish either a
TCP or UDP connection to a remote host..

<a name='M-xyLOGIX-Validators-Interfaces-IDnsHostnameValidator-IsValid-System-String-'></a>
### IsValid(host) `method`

##### Summary

Validates if the given `host` address is either a valid IPv4
address or a valid DNS address.

##### Returns

`true` if valid, otherwise `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| host | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the
address of the host to be validated. |

<a name='T-xyLOGIX-Validators-Interfaces-IEmailAddressValidator'></a>
## IEmailAddressValidator `type`

##### Namespace

xyLOGIX.Validators.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an object that is
responsible for validating the format of email addresses.

<a name='M-xyLOGIX-Validators-Interfaces-IEmailAddressValidator-IsValid-System-String-'></a>
### IsValid(emailAddress) `method`

##### Summary

Determines whether the contents of the specified `emailAddress` has a
valid format.

##### Returns

`true` if the specified `emailAddress` has
a valid format; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| emailAddress | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing a
universally-unique identifier whose format is to be checked. |

<a name='T-xyLOGIX-Validators-Interfaces-IObjectValidator'></a>
## IObjectValidator `type`

##### Namespace

xyLOGIX.Validators.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a
`Validator` object.

##### Remarks

These objects examine the values of the properties of other objects
and then decide if the object's properties' values are valid.

<a name='P-xyLOGIX-Validators-Interfaces-IObjectValidator-ErrorMessage'></a>
### ErrorMessage `property`

##### Summary

When implemented by a class, gets or sets the error message text
generated when the condition being validated fails.

##### Returns

The error message to generate.

<a name='P-xyLOGIX-Validators-Interfaces-IObjectValidator-IsValid'></a>
### IsValid `property`

##### Summary

When implemented by a class, gets or sets a value indicating whether
the user-entered content in the specified control passes validation.

##### Returns

`true` if the content is valid; otherwise,
`false`.

<a name='M-xyLOGIX-Validators-Interfaces-IObjectValidator-Validate'></a>
### Validate() `method`

##### Summary

When implemented by a class, evaluates the condition it checks and
updates the
[IsValid](#P-xyLOGIX-Validators-Interfaces-IObjectValidator-IsValid 'xyLOGIX.Validators.Interfaces.IObjectValidator.IsValid')
property.

##### Parameters

This method has no parameters.

<a name='T-xyLOGIX-Validators-Interfaces-IRFC3339TimestampFormatValidator'></a>
## IRFC3339TimestampFormatValidator `type`

##### Namespace

xyLOGIX.Validators.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an object that runs
validation logic to determine whether strings are formatted with valid UTC RFC
3339 timestamps.

<a name='M-xyLOGIX-Validators-Interfaces-IRFC3339TimestampFormatValidator-IsValid-System-String-'></a>
### IsValid(value) `method`

##### Summary

Determines whether a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing a UTC date and
time is formatted in a valid fashion per the requirements of RFC 3339.

##### Returns

`true` if the specified `value` is
in a valid format; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the value to be
examined. |

<a name='T-xyLOGIX-Validators-Interfaces-IUUIDValidator'></a>
## IUUIDValidator `type`

##### Namespace

xyLOGIX.Validators.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an object that is
responsible for validating the format of universally-unique identifiers.

<a name='M-xyLOGIX-Validators-Interfaces-IUUIDValidator-IsValid-System-String,System-Boolean-'></a>
### IsValid(uuid,silent) `method`

##### Summary

Determines whether the contents of the specified `uuid` has a
valid format.

##### Returns

`true` if the specified `uuid` has
a valid format; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uuid | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing a universally-unique
identifier corresponding to an account on the `Coinbase (Advanced Trade)`
trading platform, whose format is to be checked. |
| silent | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') indicating whether logging
messages emitted by this method are to be suppressed.



The default value of this parameter is `false`. |

<a name='T-xyLOGIX-Validators-Interfaces-IVersionStringValidator'></a>
## IVersionStringValidator `type`

##### Namespace

xyLOGIX.Validators.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an object that is
responsible for validating the format of version strings.

<a name='M-xyLOGIX-Validators-Interfaces-IVersionStringValidator-IsValid-System-String-'></a>
### IsValid(versionString) `method`

##### Summary

Determines whether the contents of the specified
`versionString` have a valid format.

##### Returns

`true` if the specified `versionString` has
a valid format; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| versionString | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing a software version
string whose format is to be checked. |

##### Remarks

If the value of the `versionString` parameter is a
`null` reference or is the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value, or a value containing only
whitespace, then the method returns `false` without performing
any additional validation.

<a name='T-xyLOGIX-Validators-Interfaces-IWebAddressValidator'></a>
## IWebAddressValidator `type`

##### Namespace

xyLOGIX.Validators.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an object that is
responsible for validating the format of Web addresses.

<a name='M-xyLOGIX-Validators-Interfaces-IWebAddressValidator-IsValid-System-String-'></a>
### IsValid(webAddress) `method`

##### Summary

Determines whether the contents of the specified `webAddress`
has a valid format.

##### Returns

`true` if the specified
`webAddress` has a valid format; `false`
otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| webAddress | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
containing a Web address whose format is to be checked. |

<a name='T-xyLOGIX-Validators-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Validators.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Validators-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Validators-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
