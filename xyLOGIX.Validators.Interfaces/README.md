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
- [IFileWildcardValidator](#T-xyLOGIX-Validators-Interfaces-IFileWildcardValidator 'xyLOGIX.Validators.Interfaces.IFileWildcardValidator')
  - [IsValid(pattern)](#M-xyLOGIX-Validators-Interfaces-IFileWildcardValidator-IsValid-System-String- 'xyLOGIX.Validators.Interfaces.IFileWildcardValidator.IsValid(System.String)')
  - [TryValidate(pattern,error)](#M-xyLOGIX-Validators-Interfaces-IFileWildcardValidator-TryValidate-System-String,System-String@- 'xyLOGIX.Validators.Interfaces.IFileWildcardValidator.TryValidate(System.String,System.String@)')
- [IObjectValidator](#T-xyLOGIX-Validators-Interfaces-IObjectValidator 'xyLOGIX.Validators.Interfaces.IObjectValidator')
  - [ErrorMessage](#P-xyLOGIX-Validators-Interfaces-IObjectValidator-ErrorMessage 'xyLOGIX.Validators.Interfaces.IObjectValidator.ErrorMessage')
  - [IsValid](#P-xyLOGIX-Validators-Interfaces-IObjectValidator-IsValid 'xyLOGIX.Validators.Interfaces.IObjectValidator.IsValid')
  - [Validate()](#M-xyLOGIX-Validators-Interfaces-IObjectValidator-Validate 'xyLOGIX.Validators.Interfaces.IObjectValidator.Validate')
- [IPathnameValidator](#T-xyLOGIX-Validators-Interfaces-IPathnameValidator 'xyLOGIX.Validators.Interfaces.IPathnameValidator')
  - [IsValidFilePath(pathname)](#M-xyLOGIX-Validators-Interfaces-IPathnameValidator-IsValidFilePath-System-String- 'xyLOGIX.Validators.Interfaces.IPathnameValidator.IsValidFilePath(System.String)')
  - [IsValidFilePathSilent(pathname)](#M-xyLOGIX-Validators-Interfaces-IPathnameValidator-IsValidFilePathSilent-System-String- 'xyLOGIX.Validators.Interfaces.IPathnameValidator.IsValidFilePathSilent(System.String)')
  - [IsValidFolderPath(pathname)](#M-xyLOGIX-Validators-Interfaces-IPathnameValidator-IsValidFolderPath-System-String- 'xyLOGIX.Validators.Interfaces.IPathnameValidator.IsValidFolderPath(System.String)')
  - [IsValidFolderPathSilent(pathname)](#M-xyLOGIX-Validators-Interfaces-IPathnameValidator-IsValidFolderPathSilent-System-String- 'xyLOGIX.Validators.Interfaces.IPathnameValidator.IsValidFolderPathSilent(System.String)')
- [IProjectPathnameValidator](#T-xyLOGIX-Validators-Interfaces-IProjectPathnameValidator 'xyLOGIX.Validators.Interfaces.IProjectPathnameValidator')
  - [IsValid(pathname)](#M-xyLOGIX-Validators-Interfaces-IProjectPathnameValidator-IsValid-System-String- 'xyLOGIX.Validators.Interfaces.IProjectPathnameValidator.IsValid(System.String)')
  - [IsValidSilent(pathname)](#M-xyLOGIX-Validators-Interfaces-IProjectPathnameValidator-IsValidSilent-System-String- 'xyLOGIX.Validators.Interfaces.IProjectPathnameValidator.IsValidSilent(System.String)')
- [IRFC3339TimestampFormatValidator](#T-xyLOGIX-Validators-Interfaces-IRFC3339TimestampFormatValidator 'xyLOGIX.Validators.Interfaces.IRFC3339TimestampFormatValidator')
  - [IsValid(value)](#M-xyLOGIX-Validators-Interfaces-IRFC3339TimestampFormatValidator-IsValid-System-String- 'xyLOGIX.Validators.Interfaces.IRFC3339TimestampFormatValidator.IsValid(System.String)')
- [ISolutionPathnameValidator](#T-xyLOGIX-Validators-Interfaces-ISolutionPathnameValidator 'xyLOGIX.Validators.Interfaces.ISolutionPathnameValidator')
  - [IsValid(pathname)](#M-xyLOGIX-Validators-Interfaces-ISolutionPathnameValidator-IsValid-System-String- 'xyLOGIX.Validators.Interfaces.ISolutionPathnameValidator.IsValid(System.String)')
  - [IsValidSilent(pathname)](#M-xyLOGIX-Validators-Interfaces-ISolutionPathnameValidator-IsValidSilent-System-String- 'xyLOGIX.Validators.Interfaces.ISolutionPathnameValidator.IsValidSilent(System.String)')
- [ITCPPortValidator](#T-xyLOGIX-Validators-Interfaces-ITCPPortValidator 'xyLOGIX.Validators.Interfaces.ITCPPortValidator')
  - [IsValid(port)](#M-xyLOGIX-Validators-Interfaces-ITCPPortValidator-IsValid-System-String- 'xyLOGIX.Validators.Interfaces.ITCPPortValidator.IsValid(System.String)')
  - [IsValid(port)](#M-xyLOGIX-Validators-Interfaces-ITCPPortValidator-IsValid-System-Int32- 'xyLOGIX.Validators.Interfaces.ITCPPortValidator.IsValid(System.Int32)')
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

<a name='T-xyLOGIX-Validators-Interfaces-IFileWildcardValidator'></a>
## IFileWildcardValidator `type`

##### Namespace

xyLOGIX.Validators.Interfaces

##### Summary

Defines a service that validates whether a
[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') is a correctly formatted Windows filename
wildcard (glob) pattern.

<a name='M-xyLOGIX-Validators-Interfaces-IFileWildcardValidator-IsValid-System-String-'></a>
### IsValid(pattern) `method`

##### Summary

Determines whether the specified `pattern` is a
valid Windows filename wildcard (glob) pattern.

##### Returns

`true` if the value is a valid wildcard pattern;
otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the wildcard
pattern to validate. |

<a name='M-xyLOGIX-Validators-Interfaces-IFileWildcardValidator-TryValidate-System-String,System-String@-'></a>
### TryValidate(pattern,error) `method`

##### Summary

Attempts to validate the specified `pattern` and, if
invalid, returns a concise reason.

##### Returns

`true` if the value is a valid wildcard pattern;
otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pattern | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the wildcard
pattern to validate. |
| error | [System.String@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String@ 'System.String@') | On return, receives a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
describing why validation failed, or an empty string if validation succeeded. |

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

<a name='T-xyLOGIX-Validators-Interfaces-IPathnameValidator'></a>
## IPathnameValidator `type`

##### Namespace

xyLOGIX.Validators.Interfaces

##### Summary

Defines the publicly-exposed events, methods and properties of object(s) that
validate the format of [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') values that purport to
contain pathnames..

<a name='M-xyLOGIX-Validators-Interfaces-IPathnameValidator-IsValidFilePath-System-String-'></a>
### IsValidFilePath(pathname) `method`

##### Summary

Validates that the specified file `pathname` is of a valid
format on the Windows operating system.

##### Returns

`true` if the specified `pathname` is a
properly-formatted file pathname; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the fully-qualified
pathname that is to be examined. |

##### Remarks

Disallows trailing backslashes.



If the value of the `pathname` parameter is the
`null`, blank, or [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty')[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'), then this method returns
`false`.

<a name='M-xyLOGIX-Validators-Interfaces-IPathnameValidator-IsValidFilePathSilent-System-String-'></a>
### IsValidFilePathSilent(pathname) `method`

##### Summary

Validates that the specified file `pathname` is of a valid
format on the Windows operating system.

##### Returns

`true` if the specified `pathname` is a
properly-formatted file pathname; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the fully-qualified
pathname that is to be examined. |

##### Remarks

Disallows trailing backslashes.



If the value of the `pathname` parameter is the
`null`, blank, or [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty')[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'), then this method returns
`false`.

<a name='M-xyLOGIX-Validators-Interfaces-IPathnameValidator-IsValidFolderPath-System-String-'></a>
### IsValidFolderPath(pathname) `method`

##### Summary

Validates that the specified folder `pathname` is of
a valid format on the Windows operating system.

##### Returns

`true` depending whether the specified
`pathname` contains text whose format is valid for a
filesystem pathname of a folder on the Windows operating system;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing
the data that is to be examined. |

<a name='M-xyLOGIX-Validators-Interfaces-IPathnameValidator-IsValidFolderPathSilent-System-String-'></a>
### IsValidFolderPathSilent(pathname) `method`

##### Summary

Validates that the specified folder `pathname` is of a valid
format on the Windows operating system.

##### Returns

`true` if the specified `pathname` is a
properly-formatted folder pathname; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the fully-qualified
pathname that is to be examined. |

##### Remarks

This method allows the value of the `pathname` parameter to
have trailing backslashes.



If the value of the `pathname` parameter is the
`null`, blank, or [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty')[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'), then this method returns
`false`.

<a name='T-xyLOGIX-Validators-Interfaces-IProjectPathnameValidator'></a>
## IProjectPathnameValidator `type`

##### Namespace

xyLOGIX.Validators.Interfaces

##### Summary

Defines the publicly-exposed events, methods and properties of an object that
validates [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')(s) that purport to contain the
fully-qualified pathname of a project (`*.*proj`) file that is used within
modern version(s) of Visual Studio.

<a name='M-xyLOGIX-Validators-Interfaces-IProjectPathnameValidator-IsValid-System-String-'></a>
### IsValid(pathname) `method`

##### Summary

Validates that the specified project (`*.*proj`) file
`pathname` is of a valid format on the Windows operating
system, and that it is a valid pathname of a project (`*.*proj`) file.

##### Returns

`true` if the specified `pathname` is a
properly-formatted file pathname; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the fully-qualified
pathname that is to be examined. |

##### Remarks

Disallows trailing backslashes.



If the value of the `pathname` parameter is the
`null`, blank, or [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty')[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'), then this method returns
`false`.

<a name='M-xyLOGIX-Validators-Interfaces-IProjectPathnameValidator-IsValidSilent-System-String-'></a>
### IsValidSilent(pathname) `method`

##### Summary

Validates that the specified project (`*.*proj`) file
`pathname` is of a valid format on the Windows operating
system, and that it is a valid pathname of a project (`*.*proj`) file.

##### Returns

`true` if the specified `pathname` is a
properly-formatted file pathname; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the fully-qualified
pathname that is to be examined. |

##### Remarks

This overload refrains from any logging.



Disallows trailing backslashes.



If the value of the `pathname` parameter is the
`null`, blank, or [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty')[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'), then this method returns
`false`.

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

<a name='T-xyLOGIX-Validators-Interfaces-ISolutionPathnameValidator'></a>
## ISolutionPathnameValidator `type`

##### Namespace

xyLOGIX.Validators.Interfaces

##### Summary

Defines the publicly-exposed events, methods and properties of an object that
validates [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')(s) that purport to contain the
fully-qualified pathname of a Visual Studio Solution (`*.sln`) file(s).

<a name='M-xyLOGIX-Validators-Interfaces-ISolutionPathnameValidator-IsValid-System-String-'></a>
### IsValid(pathname) `method`

##### Summary

Validates that the specified Visual Studio Solution (`*.sln`)
`pathname` is of a valid format on the Windows operating
system, and that it is a valid pathname of a Visual Studio Solution (
`*.sln`) file.

##### Returns

`true` if the specified `pathname` is a
properly-formatted file pathname; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the fully-qualified
pathname that is to be examined. |

##### Remarks

Disallows trailing backslashes.



If the value of the `pathname` parameter is the
`null`, blank, or [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty')[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'), then this method returns
`false`.

<a name='M-xyLOGIX-Validators-Interfaces-ISolutionPathnameValidator-IsValidSilent-System-String-'></a>
### IsValidSilent(pathname) `method`

##### Summary

Validates that the specified Visual Studio Solution (`*.sln`)
`pathname` is of a valid format on the Windows operating
system, and that it is a valid pathname of a Visual Studio Solution (
`*.sln`) file.

##### Returns

`true` if the specified `pathname` is a
properly-formatted file pathname; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the fully-qualified
pathname that is to be examined. |

##### Remarks

This overload silently validates the specified `pathname`.



No logging is performed.



If the value of the `pathname` parameter is the
`null`, blank, or [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty')[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'), then this method returns
`false`.

<a name='T-xyLOGIX-Validators-Interfaces-ITCPPortValidator'></a>
## ITCPPortValidator `type`

##### Namespace

xyLOGIX.Validators.Interfaces

##### Summary

Defines the publicly-exposed events, methods and properties of a TCP Port
Number validator.

<a name='M-xyLOGIX-Validators-Interfaces-ITCPPortValidator-IsValid-System-String-'></a>
### IsValid(port) `method`

##### Summary

Determines whether the specified [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'), that
represents the TCP `port` number using ASCII characters, is
(a) parsable as an integer and (b) is in the range of valid values.

##### Returns

`true` if the specified `port` is
parsable as an integer, and in the range `1`-`65535` (inclusive);
otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| port | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains
the ASCII representation of a TCP port number. |

<a name='M-xyLOGIX-Validators-Interfaces-ITCPPortValidator-IsValid-System-Int32-'></a>
### IsValid(port) `method`

##### Summary

Determines whether the specified TCP `port` number is in the
range of valid values.

##### Returns

`true` if the specified `port` is in the
range `1`-`65535` (inclusive); otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| port | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) An [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') that set to the TCP port number
that is to be validated. |

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
