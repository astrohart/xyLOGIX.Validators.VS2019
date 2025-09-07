<a name='assembly'></a>
# xyLOGIX.Validators

## Contents

- [AssetSymbolValidator](#T-xyLOGIX-Validators-AssetSymbolValidator 'xyLOGIX.Validators.AssetSymbolValidator')
  - [#ctor()](#M-xyLOGIX-Validators-AssetSymbolValidator-#ctor 'xyLOGIX.Validators.AssetSymbolValidator.#ctor')
  - [Instance](#P-xyLOGIX-Validators-AssetSymbolValidator-Instance 'xyLOGIX.Validators.AssetSymbolValidator.Instance')
  - [#cctor()](#M-xyLOGIX-Validators-AssetSymbolValidator-#cctor 'xyLOGIX.Validators.AssetSymbolValidator.#cctor')
  - [IsValid(symbol)](#M-xyLOGIX-Validators-AssetSymbolValidator-IsValid-System-String- 'xyLOGIX.Validators.AssetSymbolValidator.IsValid(System.String)')
- [DateRangeValidator](#T-xyLOGIX-Validators-DateRangeValidator 'xyLOGIX.Validators.DateRangeValidator')
  - [#ctor()](#M-xyLOGIX-Validators-DateRangeValidator-#ctor 'xyLOGIX.Validators.DateRangeValidator.#ctor')
  - [Instance](#P-xyLOGIX-Validators-DateRangeValidator-Instance 'xyLOGIX.Validators.DateRangeValidator.Instance')
  - [#cctor()](#M-xyLOGIX-Validators-DateRangeValidator-#cctor 'xyLOGIX.Validators.DateRangeValidator.#cctor')
  - [IsValid(start,end)](#M-xyLOGIX-Validators-DateRangeValidator-IsValid-System-DateTime,System-DateTime- 'xyLOGIX.Validators.DateRangeValidator.IsValid(System.DateTime,System.DateTime)')
- [DnsHostnameValidator](#T-xyLOGIX-Validators-DnsHostnameValidator 'xyLOGIX.Validators.DnsHostnameValidator')
  - [#ctor()](#M-xyLOGIX-Validators-DnsHostnameValidator-#ctor 'xyLOGIX.Validators.DnsHostnameValidator.#ctor')
  - [DNS_PATTERN](#F-xyLOGIX-Validators-DnsHostnameValidator-DNS_PATTERN 'xyLOGIX.Validators.DnsHostnameValidator.DNS_PATTERN')
  - [Instance](#P-xyLOGIX-Validators-DnsHostnameValidator-Instance 'xyLOGIX.Validators.DnsHostnameValidator.Instance')
  - [TheDnsRegex](#P-xyLOGIX-Validators-DnsHostnameValidator-TheDnsRegex 'xyLOGIX.Validators.DnsHostnameValidator.TheDnsRegex')
  - [#cctor()](#M-xyLOGIX-Validators-DnsHostnameValidator-#cctor 'xyLOGIX.Validators.DnsHostnameValidator.#cctor')
  - [IsValid(host)](#M-xyLOGIX-Validators-DnsHostnameValidator-IsValid-System-String- 'xyLOGIX.Validators.DnsHostnameValidator.IsValid(System.String)')
  - [IsValidDnsAddress(dnsAddress)](#M-xyLOGIX-Validators-DnsHostnameValidator-IsValidDnsAddress-System-String- 'xyLOGIX.Validators.DnsHostnameValidator.IsValidDnsAddress(System.String)')
- [EmailAddressValidator](#T-xyLOGIX-Validators-EmailAddressValidator 'xyLOGIX.Validators.EmailAddressValidator')
  - [#ctor()](#M-xyLOGIX-Validators-EmailAddressValidator-#ctor 'xyLOGIX.Validators.EmailAddressValidator.#ctor')
  - [Instance](#P-xyLOGIX-Validators-EmailAddressValidator-Instance 'xyLOGIX.Validators.EmailAddressValidator.Instance')
  - [#cctor()](#M-xyLOGIX-Validators-EmailAddressValidator-#cctor 'xyLOGIX.Validators.EmailAddressValidator.#cctor')
  - [IsValid(emailAddress)](#M-xyLOGIX-Validators-EmailAddressValidator-IsValid-System-String- 'xyLOGIX.Validators.EmailAddressValidator.IsValid(System.String)')
- [FileWildcardValidator](#T-xyLOGIX-Validators-FileWildcardValidator 'xyLOGIX.Validators.FileWildcardValidator')
  - [#ctor()](#M-xyLOGIX-Validators-FileWildcardValidator-#ctor 'xyLOGIX.Validators.FileWildcardValidator.#ctor')
  - [Instance](#P-xyLOGIX-Validators-FileWildcardValidator-Instance 'xyLOGIX.Validators.FileWildcardValidator.Instance')
  - [#cctor()](#M-xyLOGIX-Validators-FileWildcardValidator-#cctor 'xyLOGIX.Validators.FileWildcardValidator.#cctor')
  - [IsValid(pattern)](#M-xyLOGIX-Validators-FileWildcardValidator-IsValid-System-String- 'xyLOGIX.Validators.FileWildcardValidator.IsValid(System.String)')
  - [TryValidate(pattern,error)](#M-xyLOGIX-Validators-FileWildcardValidator-TryValidate-System-String,System-String@- 'xyLOGIX.Validators.FileWildcardValidator.TryValidate(System.String,System.String@)')
- [ObjectValidatorBase\`1](#T-xyLOGIX-Validators-ObjectValidatorBase`1 'xyLOGIX.Validators.ObjectValidatorBase`1')
  - [#ctor(objectToValidate)](#M-xyLOGIX-Validators-ObjectValidatorBase`1-#ctor-`0- 'xyLOGIX.Validators.ObjectValidatorBase`1.#ctor(`0)')
  - [ErrorMessage](#P-xyLOGIX-Validators-ObjectValidatorBase`1-ErrorMessage 'xyLOGIX.Validators.ObjectValidatorBase`1.ErrorMessage')
  - [IsValid](#P-xyLOGIX-Validators-ObjectValidatorBase`1-IsValid 'xyLOGIX.Validators.ObjectValidatorBase`1.IsValid')
  - [ObjectToValidate](#P-xyLOGIX-Validators-ObjectValidatorBase`1-ObjectToValidate 'xyLOGIX.Validators.ObjectValidatorBase`1.ObjectToValidate')
  - [OnValidationFailed(e)](#M-xyLOGIX-Validators-ObjectValidatorBase`1-OnValidationFailed-xyLOGIX-Validators-Events-ValidationFailedEventArgs- 'xyLOGIX.Validators.ObjectValidatorBase`1.OnValidationFailed(xyLOGIX.Validators.Events.ValidationFailedEventArgs)')
  - [OnValidationSucceeded()](#M-xyLOGIX-Validators-ObjectValidatorBase`1-OnValidationSucceeded 'xyLOGIX.Validators.ObjectValidatorBase`1.OnValidationSucceeded')
  - [Validate()](#M-xyLOGIX-Validators-ObjectValidatorBase`1-Validate 'xyLOGIX.Validators.ObjectValidatorBase`1.Validate')
- [PathnameValidator](#T-xyLOGIX-Validators-PathnameValidator 'xyLOGIX.Validators.PathnameValidator')
  - [#ctor()](#M-xyLOGIX-Validators-PathnameValidator-#ctor 'xyLOGIX.Validators.PathnameValidator.#ctor')
  - [ReservedDeviceNames](#F-xyLOGIX-Validators-PathnameValidator-ReservedDeviceNames 'xyLOGIX.Validators.PathnameValidator.ReservedDeviceNames')
  - [Instance](#P-xyLOGIX-Validators-PathnameValidator-Instance 'xyLOGIX.Validators.PathnameValidator.Instance')
  - [PathPattern](#P-xyLOGIX-Validators-PathnameValidator-PathPattern 'xyLOGIX.Validators.PathnameValidator.PathPattern')
  - [#cctor()](#M-xyLOGIX-Validators-PathnameValidator-#cctor 'xyLOGIX.Validators.PathnameValidator.#cctor')
  - [IsReservedDeviceName(segment)](#M-xyLOGIX-Validators-PathnameValidator-IsReservedDeviceName-System-String- 'xyLOGIX.Validators.PathnameValidator.IsReservedDeviceName(System.String)')
  - [IsValidFilePath(pathname)](#M-xyLOGIX-Validators-PathnameValidator-IsValidFilePath-System-String- 'xyLOGIX.Validators.PathnameValidator.IsValidFilePath(System.String)')
  - [IsValidFolderPath(pathname)](#M-xyLOGIX-Validators-PathnameValidator-IsValidFolderPath-System-String- 'xyLOGIX.Validators.PathnameValidator.IsValidFolderPath(System.String)')
  - [IsValidPath(pathname,allowTrailingBackslash)](#M-xyLOGIX-Validators-PathnameValidator-IsValidPath-System-String,System-Boolean- 'xyLOGIX.Validators.PathnameValidator.IsValidPath(System.String,System.Boolean)')
- [ProjectPathnameValidator](#T-xyLOGIX-Validators-ProjectPathnameValidator 'xyLOGIX.Validators.ProjectPathnameValidator')
  - [#ctor()](#M-xyLOGIX-Validators-ProjectPathnameValidator-#ctor 'xyLOGIX.Validators.ProjectPathnameValidator.#ctor')
  - [Instance](#P-xyLOGIX-Validators-ProjectPathnameValidator-Instance 'xyLOGIX.Validators.ProjectPathnameValidator.Instance')
  - [ThePathnameValidator](#P-xyLOGIX-Validators-ProjectPathnameValidator-ThePathnameValidator 'xyLOGIX.Validators.ProjectPathnameValidator.ThePathnameValidator')
  - [#cctor()](#M-xyLOGIX-Validators-ProjectPathnameValidator-#cctor 'xyLOGIX.Validators.ProjectPathnameValidator.#cctor')
  - [IsValid(pathname)](#M-xyLOGIX-Validators-ProjectPathnameValidator-IsValid-System-String- 'xyLOGIX.Validators.ProjectPathnameValidator.IsValid(System.String)')
- [RF3339TimestampFormatValidator](#T-xyLOGIX-Validators-RF3339TimestampFormatValidator 'xyLOGIX.Validators.RF3339TimestampFormatValidator')
  - [#ctor()](#M-xyLOGIX-Validators-RF3339TimestampFormatValidator-#ctor 'xyLOGIX.Validators.RF3339TimestampFormatValidator.#ctor')
  - [Instance](#P-xyLOGIX-Validators-RF3339TimestampFormatValidator-Instance 'xyLOGIX.Validators.RF3339TimestampFormatValidator.Instance')
  - [#cctor()](#M-xyLOGIX-Validators-RF3339TimestampFormatValidator-#cctor 'xyLOGIX.Validators.RF3339TimestampFormatValidator.#cctor')
  - [IsValid(value)](#M-xyLOGIX-Validators-RF3339TimestampFormatValidator-IsValid-System-String- 'xyLOGIX.Validators.RF3339TimestampFormatValidator.IsValid(System.String)')
- [Resources](#T-xyLOGIX-Validators-Properties-Resources 'xyLOGIX.Validators.Properties.Resources')
  - [Culture](#P-xyLOGIX-Validators-Properties-Resources-Culture 'xyLOGIX.Validators.Properties.Resources.Culture')
  - [Error_AssetSymbol_InvalidFormat](#P-xyLOGIX-Validators-Properties-Resources-Error_AssetSymbol_InvalidFormat 'xyLOGIX.Validators.Properties.Resources.Error_AssetSymbol_InvalidFormat')
  - [Error_AssetSymbol_IsBlank](#P-xyLOGIX-Validators-Properties-Resources-Error_AssetSymbol_IsBlank 'xyLOGIX.Validators.Properties.Resources.Error_AssetSymbol_IsBlank')
  - [Error_EmailAddress_InvalidFormat](#P-xyLOGIX-Validators-Properties-Resources-Error_EmailAddress_InvalidFormat 'xyLOGIX.Validators.Properties.Resources.Error_EmailAddress_InvalidFormat')
  - [Error_EmailAddress_IsBlank](#P-xyLOGIX-Validators-Properties-Resources-Error_EmailAddress_IsBlank 'xyLOGIX.Validators.Properties.Resources.Error_EmailAddress_IsBlank')
  - [Error_ObjectToValidatePropertyHasNotBeenSet](#P-xyLOGIX-Validators-Properties-Resources-Error_ObjectToValidatePropertyHasNotBeenSet 'xyLOGIX.Validators.Properties.Resources.Error_ObjectToValidatePropertyHasNotBeenSet')
  - [Error_UUID_CannotBeBlank](#P-xyLOGIX-Validators-Properties-Resources-Error_UUID_CannotBeBlank 'xyLOGIX.Validators.Properties.Resources.Error_UUID_CannotBeBlank')
  - [Error_UUID_CannotBeZeroGUID](#P-xyLOGIX-Validators-Properties-Resources-Error_UUID_CannotBeZeroGUID 'xyLOGIX.Validators.Properties.Resources.Error_UUID_CannotBeZeroGUID')
  - [Error_UUID_InvalidFormat](#P-xyLOGIX-Validators-Properties-Resources-Error_UUID_InvalidFormat 'xyLOGIX.Validators.Properties.Resources.Error_UUID_InvalidFormat')
  - [Error_WebAddress_InvalidFormat](#P-xyLOGIX-Validators-Properties-Resources-Error_WebAddress_InvalidFormat 'xyLOGIX.Validators.Properties.Resources.Error_WebAddress_InvalidFormat')
  - [Error_WebAddress_IsBlank](#P-xyLOGIX-Validators-Properties-Resources-Error_WebAddress_IsBlank 'xyLOGIX.Validators.Properties.Resources.Error_WebAddress_IsBlank')
  - [Regex_FolderPathname](#P-xyLOGIX-Validators-Properties-Resources-Regex_FolderPathname 'xyLOGIX.Validators.Properties.Resources.Regex_FolderPathname')
  - [Regex_PathnameValidator_PathPattern](#P-xyLOGIX-Validators-Properties-Resources-Regex_PathnameValidator_PathPattern 'xyLOGIX.Validators.Properties.Resources.Regex_PathnameValidator_PathPattern')
  - [ResourceManager](#P-xyLOGIX-Validators-Properties-Resources-ResourceManager 'xyLOGIX.Validators.Properties.Resources.ResourceManager')
- [SolutionPathnameValidator](#T-xyLOGIX-Validators-SolutionPathnameValidator 'xyLOGIX.Validators.SolutionPathnameValidator')
  - [#ctor()](#M-xyLOGIX-Validators-SolutionPathnameValidator-#ctor 'xyLOGIX.Validators.SolutionPathnameValidator.#ctor')
  - [Instance](#P-xyLOGIX-Validators-SolutionPathnameValidator-Instance 'xyLOGIX.Validators.SolutionPathnameValidator.Instance')
  - [ThePathnameValidator](#P-xyLOGIX-Validators-SolutionPathnameValidator-ThePathnameValidator 'xyLOGIX.Validators.SolutionPathnameValidator.ThePathnameValidator')
  - [#cctor()](#M-xyLOGIX-Validators-SolutionPathnameValidator-#cctor 'xyLOGIX.Validators.SolutionPathnameValidator.#cctor')
  - [IsValid(pathname)](#M-xyLOGIX-Validators-SolutionPathnameValidator-IsValid-System-String- 'xyLOGIX.Validators.SolutionPathnameValidator.IsValid(System.String)')
- [TCPPortValidator](#T-xyLOGIX-Validators-TCPPortValidator 'xyLOGIX.Validators.TCPPortValidator')
  - [#ctor()](#M-xyLOGIX-Validators-TCPPortValidator-#ctor 'xyLOGIX.Validators.TCPPortValidator.#ctor')
  - [Instance](#P-xyLOGIX-Validators-TCPPortValidator-Instance 'xyLOGIX.Validators.TCPPortValidator.Instance')
  - [#cctor()](#M-xyLOGIX-Validators-TCPPortValidator-#cctor 'xyLOGIX.Validators.TCPPortValidator.#cctor')
  - [IsValid(port)](#M-xyLOGIX-Validators-TCPPortValidator-IsValid-System-String- 'xyLOGIX.Validators.TCPPortValidator.IsValid(System.String)')
  - [IsValid(port)](#M-xyLOGIX-Validators-TCPPortValidator-IsValid-System-Int32- 'xyLOGIX.Validators.TCPPortValidator.IsValid(System.Int32)')
  - [PortNumberIsInCorrectRange(portNumber)](#M-xyLOGIX-Validators-TCPPortValidator-PortNumberIsInCorrectRange-System-Int32- 'xyLOGIX.Validators.TCPPortValidator.PortNumberIsInCorrectRange(System.Int32)')
- [UUIDValidator](#T-xyLOGIX-Validators-UUIDValidator 'xyLOGIX.Validators.UUIDValidator')
  - [#ctor()](#M-xyLOGIX-Validators-UUIDValidator-#ctor 'xyLOGIX.Validators.UUIDValidator.#ctor')
  - [Instance](#P-xyLOGIX-Validators-UUIDValidator-Instance 'xyLOGIX.Validators.UUIDValidator.Instance')
  - [#cctor()](#M-xyLOGIX-Validators-UUIDValidator-#cctor 'xyLOGIX.Validators.UUIDValidator.#cctor')
  - [IsValid(uuid,silent)](#M-xyLOGIX-Validators-UUIDValidator-IsValid-System-String,System-Boolean- 'xyLOGIX.Validators.UUIDValidator.IsValid(System.String,System.Boolean)')
- [VersionStringValidator](#T-xyLOGIX-Validators-VersionStringValidator 'xyLOGIX.Validators.VersionStringValidator')
  - [#ctor()](#M-xyLOGIX-Validators-VersionStringValidator-#ctor 'xyLOGIX.Validators.VersionStringValidator.#ctor')
  - [Instance](#P-xyLOGIX-Validators-VersionStringValidator-Instance 'xyLOGIX.Validators.VersionStringValidator.Instance')
  - [#cctor()](#M-xyLOGIX-Validators-VersionStringValidator-#cctor 'xyLOGIX.Validators.VersionStringValidator.#cctor')
  - [IsValid(versionString)](#M-xyLOGIX-Validators-VersionStringValidator-IsValid-System-String- 'xyLOGIX.Validators.VersionStringValidator.IsValid(System.String)')
- [WebAddressValidator](#T-xyLOGIX-Validators-WebAddressValidator 'xyLOGIX.Validators.WebAddressValidator')
  - [#ctor()](#M-xyLOGIX-Validators-WebAddressValidator-#ctor 'xyLOGIX.Validators.WebAddressValidator.#ctor')
  - [Instance](#P-xyLOGIX-Validators-WebAddressValidator-Instance 'xyLOGIX.Validators.WebAddressValidator.Instance')
  - [#cctor()](#M-xyLOGIX-Validators-WebAddressValidator-#cctor 'xyLOGIX.Validators.WebAddressValidator.#cctor')
  - [IsValid(webAddress)](#M-xyLOGIX-Validators-WebAddressValidator-IsValid-System-String- 'xyLOGIX.Validators.WebAddressValidator.IsValid(System.String)')

<a name='T-xyLOGIX-Validators-AssetSymbolValidator'></a>
## AssetSymbolValidator `type`

##### Namespace

xyLOGIX.Validators

##### Summary

Validates the format of strings containing an asset symbol, such as for a stock
or cryptocurrency.

<a name='M-xyLOGIX-Validators-AssetSymbolValidator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, private constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-xyLOGIX-Validators-AssetSymbolValidator-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IAssetSymbolValidator](#T-xyLOGIX-Validators-Interfaces-IAssetSymbolValidator 'xyLOGIX.Validators.Interfaces.IAssetSymbolValidator')
interface.

<a name='M-xyLOGIX-Validators-AssetSymbolValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, `static` constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Validators-AssetSymbolValidator-IsValid-System-String-'></a>
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

<a name='T-xyLOGIX-Validators-DateRangeValidator'></a>
## DateRangeValidator `type`

##### Namespace

xyLOGIX.Validators

##### Summary

Runs rules on date ranges to verify that they are valid.

<a name='M-xyLOGIX-Validators-DateRangeValidator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, private constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-xyLOGIX-Validators-DateRangeValidator-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IDateRangeValidator](#T-xyLOGIX-Validators-Interfaces-IDateRangeValidator 'xyLOGIX.Validators.Interfaces.IDateRangeValidator')
interface.

<a name='M-xyLOGIX-Validators-DateRangeValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, `static` constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Validators-DateRangeValidator-IsValid-System-DateTime,System-DateTime-'></a>
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

<a name='T-xyLOGIX-Validators-DnsHostnameValidator'></a>
## DnsHostnameValidator `type`

##### Namespace

xyLOGIX.Validators

##### Summary

Validates the contents of [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') variables that purport
to contain a valid hostname for use with Windows Sockets to establish either a
TCP or UDP connection to a remote host.

<a name='M-xyLOGIX-Validators-DnsHostnameValidator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, private constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='F-xyLOGIX-Validators-DnsHostnameValidator-DNS_PATTERN'></a>
### DNS_PATTERN `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the regular-expression pattern to
be utilized for validating DNS hostnames, e.g., `myserver.myexample.com`

<a name='P-xyLOGIX-Validators-DnsHostnameValidator-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IDnsHostnameValidator](#T-xyLOGIX-Validators-Interfaces-IDnsHostnameValidator 'xyLOGIX.Validators.Interfaces.IDnsHostnameValidator') interface.

<a name='P-xyLOGIX-Validators-DnsHostnameValidator-TheDnsRegex'></a>
### TheDnsRegex `property`

##### Summary

Gets a reference to an instance of
[Regex](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.RegularExpressions.Regex 'System.Text.RegularExpressions.Regex') that compiles the
[DNS_PATTERN](#F-xyLOGIX-Validators-DnsHostnameValidator-DNS_PATTERN 'xyLOGIX.Validators.DnsHostnameValidator.DNS_PATTERN') regular
expression.

<a name='M-xyLOGIX-Validators-DnsHostnameValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, `static` constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Validators-DnsHostnameValidator-IsValid-System-String-'></a>
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

<a name='M-xyLOGIX-Validators-DnsHostnameValidator-IsValidDnsAddress-System-String-'></a>
### IsValidDnsAddress(dnsAddress) `method`

##### Summary

Validates whether a given string is a valid DNS address.

##### Returns

`true` if the address is valid, otherwise
`false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dnsAddress | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that
contains the DNS address to be validated. |

<a name='T-xyLOGIX-Validators-EmailAddressValidator'></a>
## EmailAddressValidator `type`

##### Namespace

xyLOGIX.Validators

##### Summary

Validates the format of strings containing a universally-unique identifier
(UUID) of a resource on the `Coinbase (Advanced Trade)` trading platform.

<a name='M-xyLOGIX-Validators-EmailAddressValidator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, private constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-xyLOGIX-Validators-EmailAddressValidator-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IEmailAddressValidator](#T-xyLOGIX-Validators-Interfaces-IEmailAddressValidator 'xyLOGIX.Validators.Interfaces.IEmailAddressValidator')
interface.

<a name='M-xyLOGIX-Validators-EmailAddressValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, `static` constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Validators-EmailAddressValidator-IsValid-System-String-'></a>
### IsValid(emailAddress) `method`

##### Summary

Determines whether the contents of the specified
`emailAddress` has a valid format.

##### Returns

`true` if the specified
`emailAddress` has a valid format; `false`
otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| emailAddress | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')
containing an email address whose format is to be checked. |

<a name='T-xyLOGIX-Validators-FileWildcardValidator'></a>
## FileWildcardValidator `type`

##### Namespace

xyLOGIX.Validators

##### Summary

Provides object(s) and functionality to validate that a
[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') representing a Windows filename wildcard (glob)
pattern is correctly formatted and not blank.

<a name='M-xyLOGIX-Validators-FileWildcardValidator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-xyLOGIX-Validators-FileWildcardValidator-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IFileWildcardValidator](#T-xyLOGIX-Validators-Interfaces-IFileWildcardValidator 'xyLOGIX.Validators.Interfaces.IFileWildcardValidator')
interface.

<a name='M-xyLOGIX-Validators-FileWildcardValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Validators-FileWildcardValidator-IsValid-System-String-'></a>
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

<a name='M-xyLOGIX-Validators-FileWildcardValidator-TryValidate-System-String,System-String@-'></a>
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

<a name='T-xyLOGIX-Validators-ObjectValidatorBase`1'></a>
## ObjectValidatorBase\`1 `type`

##### Namespace

xyLOGIX.Validators

##### Summary

Serves as the common base class for all validator objects.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TObject | Type of the object whose instances are to be
validated.  Can be either a concrete instance or an interface. |

<a name='M-xyLOGIX-Validators-ObjectValidatorBase`1-#ctor-`0-'></a>
### #ctor(objectToValidate) `constructor`

##### Summary

Constructs a new instance of
[ObjectValidatorBase](#T-xyLOGIX-Validators-ObjectValidatorBase 'xyLOGIX.Validators.ObjectValidatorBase') and returns a reference
to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| objectToValidate | [\`0](#T-`0 '`0') | (Required.) Reference to an instance of the
object to be validated. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required
parameter, `objectToValidate`, is passed a
`null` value. |

<a name='P-xyLOGIX-Validators-ObjectValidatorBase`1-ErrorMessage'></a>
### ErrorMessage `property`

##### Summary

When implemented by a class, gets or sets the error message text
generated when the condition being validated fails.

##### Returns

The error message to generate.

<a name='P-xyLOGIX-Validators-ObjectValidatorBase`1-IsValid'></a>
### IsValid `property`

##### Summary

When implemented by a class, gets or sets a value indicating whether
the user-entered content in the specified control passes validation.

##### Returns

`true` if the content is valid; otherwise,
`false`.

<a name='P-xyLOGIX-Validators-ObjectValidatorBase`1-ObjectToValidate'></a>
### ObjectToValidate `property`

##### Summary

Gets a reference to the object instance whose data is to be
validated.

<a name='M-xyLOGIX-Validators-ObjectValidatorBase`1-OnValidationFailed-xyLOGIX-Validators-Events-ValidationFailedEventArgs-'></a>
### OnValidationFailed(e) `method`

##### Summary

Raises the
[](#E-xyLOGIX-Validators-ObjectValidatorBase-ValidationFailed 'xyLOGIX.Validators.ObjectValidatorBase.ValidationFailed') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [xyLOGIX.Validators.Events.ValidationFailedEventArgs](#T-xyLOGIX-Validators-Events-ValidationFailedEventArgs 'xyLOGIX.Validators.Events.ValidationFailedEventArgs') | (Required.) An
[ValidationFailedEventArgs](#T-xyLOGIX-Validators-Events-ValidationFailedEventArgs 'xyLOGIX.Validators.Events.ValidationFailedEventArgs') that
contains the event data. |

<a name='M-xyLOGIX-Validators-ObjectValidatorBase`1-OnValidationSucceeded'></a>
### OnValidationSucceeded() `method`

##### Summary

Raises the
[](#E-xyLOGIX-Validators-ObjectValidatorBase-ValidationSucceeded 'xyLOGIX.Validators.ObjectValidatorBase.ValidationSucceeded')
event.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Validators-ObjectValidatorBase`1-Validate'></a>
### Validate() `method`

##### Summary

When implemented by a class, evaluates the condition it checks and
updates the
[IsValid](#P-xyLOGIX-Validators-Interfaces-IObjectValidator-IsValid 'xyLOGIX.Validators.Interfaces.IObjectValidator.IsValid')
property.

##### Parameters

This method has no parameters.

<a name='T-xyLOGIX-Validators-PathnameValidator'></a>
## PathnameValidator `type`

##### Namespace

xyLOGIX.Validators

##### Summary

Validates the format of [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') value(s) that are
supposed to contain valid filesystem pathnames for the Windows operating
system.

<a name='M-xyLOGIX-Validators-PathnameValidator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, `private` constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='F-xyLOGIX-Validators-PathnameValidator-ReservedDeviceNames'></a>
### ReservedDeviceNames `constants`

##### Summary

Array of reserved Windows device names that are not allowed in any path
segment.

<a name='P-xyLOGIX-Validators-PathnameValidator-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IPathnameValidator](#T-xyLOGIX-Validators-Interfaces-IPathnameValidator 'xyLOGIX.Validators.Interfaces.IPathnameValidator') interface.

<a name='P-xyLOGIX-Validators-PathnameValidator-PathPattern'></a>
### PathPattern `property`

##### Summary

Regex pattern to match valid Windows pathnames.

##### Remarks

Supports both drive-letter paths and UNC pathnames.



Allows folder and file names that start with a dot (`.`).

<a name='M-xyLOGIX-Validators-PathnameValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, `static` constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Validators-PathnameValidator-IsReservedDeviceName-System-String-'></a>
### IsReservedDeviceName(segment) `method`

##### Summary

Checks if the specified `segment` is a reserved device name.

##### Returns

`true` if the specified `segment`
is a reserved device name; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| segment | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the pathname segment to
check. |

##### Remarks

If the value of the `segment` parameter is the
`null`, blank, or [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty')[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'), then this method returns
`false`.

<a name='M-xyLOGIX-Validators-PathnameValidator-IsValidFilePath-System-String-'></a>
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

<a name='M-xyLOGIX-Validators-PathnameValidator-IsValidFolderPath-System-String-'></a>
### IsValidFolderPath(pathname) `method`

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

<a name='M-xyLOGIX-Validators-PathnameValidator-IsValidPath-System-String,System-Boolean-'></a>
### IsValidPath(pathname,allowTrailingBackslash) `method`

##### Summary

Validates that the specified `pathname` is of
a valid format on the Windows operating system.

##### Returns

`true` if the specified `pathname` is a
properly-formatted pathname; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the fully-qualified
pathname that is to be examined. |
| allowTrailingBackslash | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) `true` to allow the specified
`pathname` to end with a trailing backslash;
`false` otherwise. |

##### Remarks

Generally, the pathnames of folders are allowed to end with a trailing
backslash; however, the pathnames of file(s) are not.

<a name='T-xyLOGIX-Validators-ProjectPathnameValidator'></a>
## ProjectPathnameValidator `type`

##### Namespace

xyLOGIX.Validators

##### Summary

Validates the fully-qualified pathname(s) of project (`*.*proj`) file(s)
that are utilized within modern version(s) of the Visual Studio IDE.

<a name='M-xyLOGIX-Validators-ProjectPathnameValidator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, `private` constructor to prohibit direct allocation of
this class.

##### Parameters

This constructor has no parameters.

<a name='P-xyLOGIX-Validators-ProjectPathnameValidator-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IProjectPathnameValidator](#T-xyLOGIX-Validators-Interfaces-IProjectPathnameValidator 'xyLOGIX.Validators.Interfaces.IProjectPathnameValidator')
interface.

<a name='P-xyLOGIX-Validators-ProjectPathnameValidator-ThePathnameValidator'></a>
### ThePathnameValidator `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IPathnameValidator](#T-xyLOGIX-Validators-Interfaces-IPathnameValidator 'xyLOGIX.Validators.Interfaces.IPathnameValidator') interface.

<a name='M-xyLOGIX-Validators-ProjectPathnameValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, `static` constructor to prohibit direct allocation of
this class.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Validators-ProjectPathnameValidator-IsValid-System-String-'></a>
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

<a name='T-xyLOGIX-Validators-RF3339TimestampFormatValidator'></a>
## RF3339TimestampFormatValidator `type`

##### Namespace

xyLOGIX.Validators

##### Summary

Runs validation logic to determine whether strings are formatted with
valid UTC `RFC 3339` timestamps.

<a name='M-xyLOGIX-Validators-RF3339TimestampFormatValidator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, `private` constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-xyLOGIX-Validators-RF3339TimestampFormatValidator-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IRFC3339TimestampFormatValidator](#T-xyLOGIX-Validators-Interfaces-IRFC3339TimestampFormatValidator 'xyLOGIX.Validators.Interfaces.IRFC3339TimestampFormatValidator')
interface.

<a name='M-xyLOGIX-Validators-RF3339TimestampFormatValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, `static` constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Validators-RF3339TimestampFormatValidator-IsValid-System-String-'></a>
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

<a name='T-xyLOGIX-Validators-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Validators.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Validators-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Validators-Properties-Resources-Error_AssetSymbol_InvalidFormat'></a>
### Error_AssetSymbol_InvalidFormat `property`

##### Summary

Looks up a localized string similar to The 'symbol' parameter must be a string containing only upper- or lowercase letters, the digits 0-9, and no other characters and no blank spaces, e.g. '00' or '1INCH' or 'ZRX'.  This is not the case..

<a name='P-xyLOGIX-Validators-Properties-Resources-Error_AssetSymbol_IsBlank'></a>
### Error_AssetSymbol_IsBlank `property`

##### Summary

Looks up a localized string similar to A blank value was passed for the argument of the 'symbol' parameter.  This is not valid, as a non-blank value is required..

<a name='P-xyLOGIX-Validators-Properties-Resources-Error_EmailAddress_InvalidFormat'></a>
### Error_EmailAddress_InvalidFormat `property`

##### Summary

Looks up a localized string similar to The value of the 'emailAddress' parameter is not in a valid format for an email address..

<a name='P-xyLOGIX-Validators-Properties-Resources-Error_EmailAddress_IsBlank'></a>
### Error_EmailAddress_IsBlank `property`

##### Summary

Looks up a localized string similar to A blank text string was passed for the value of the desired email address.  This is not valid..

<a name='P-xyLOGIX-Validators-Properties-Resources-Error_ObjectToValidatePropertyHasNotBeenSet'></a>
### Error_ObjectToValidatePropertyHasNotBeenSet `property`

##### Summary

Looks up a localized string similar to The ObjectToValidate property has not been set..

<a name='P-xyLOGIX-Validators-Properties-Resources-Error_UUID_CannotBeBlank'></a>
### Error_UUID_CannotBeBlank `property`

##### Summary

Looks up a localized string similar to A blank value was passed for the argument of the 'uuid' parameter.  This is not valid, as a non-blank value is required..

<a name='P-xyLOGIX-Validators-Properties-Resources-Error_UUID_CannotBeZeroGUID'></a>
### Error_UUID_CannotBeZeroGUID `property`

##### Summary

Looks up a localized string similar to The UUID passed cannot be equal to the Zero GUID.  We take this to mean the corresponding entity has not been involved in a transaction; however, this value cannot be used for a REST API request..

<a name='P-xyLOGIX-Validators-Properties-Resources-Error_UUID_InvalidFormat'></a>
### Error_UUID_InvalidFormat `property`

##### Summary

Looks up a localized string similar to The value of the 'uuid' parameter must be a GUID but with no braces and all letters in lowercase; e.g., 'e83cdb4e-7b01-4a59-a71c-1220ea6d7892'..

<a name='P-xyLOGIX-Validators-Properties-Resources-Error_WebAddress_InvalidFormat'></a>
### Error_WebAddress_InvalidFormat `property`

##### Summary

Looks up a localized string similar to The value of the 'webAddress' parameter is not in a valid format for a Web address..

<a name='P-xyLOGIX-Validators-Properties-Resources-Error_WebAddress_IsBlank'></a>
### Error_WebAddress_IsBlank `property`

##### Summary

Looks up a localized string similar to The 'webAddress' parameter was passed a blank value as its argument.  This is not valid, as the 'webAddress' is a required value.  Stopping..

<a name='P-xyLOGIX-Validators-Properties-Resources-Regex_FolderPathname'></a>
### Regex_FolderPathname `property`

##### Summary

Looks up a localized string similar to ^(?<quoted>")?(?<path>(\\{2}[^\\/:*?"<>|]+\\[^/:*?"<>|]+|[a-zA-Z]:\\(?:[^\\/:*?"<>|]+\\)*[^\\/:*?"<>|]*))\\?(?(quoted)"|)$.

<a name='P-xyLOGIX-Validators-Properties-Resources-Regex_PathnameValidator_PathPattern'></a>
### Regex_PathnameValidator_PathPattern `property`

##### Summary

Looks up a localized string similar to ^(?:[a-zA-Z]:\\|\\\\[^\\/:*?"<>|]+\\[^\\/:*?"<>|]+\\?)(?:[^\\/:*?"<>|]+\\?)*$.

<a name='P-xyLOGIX-Validators-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-xyLOGIX-Validators-SolutionPathnameValidator'></a>
## SolutionPathnameValidator `type`

##### Namespace

xyLOGIX.Validators

##### Summary

Validates [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')(s) that purport to contain the
fully-qualified pathname of a Visual Studio Solution (`*.sln`) file.

<a name='M-xyLOGIX-Validators-SolutionPathnameValidator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, private constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-xyLOGIX-Validators-SolutionPathnameValidator-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[ISolutionPathnameValidator](#T-xyLOGIX-Validators-Interfaces-ISolutionPathnameValidator 'xyLOGIX.Validators.Interfaces.ISolutionPathnameValidator')
interface.

<a name='P-xyLOGIX-Validators-SolutionPathnameValidator-ThePathnameValidator'></a>
### ThePathnameValidator `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IPathnameValidator](#T-xyLOGIX-Validators-Interfaces-IPathnameValidator 'xyLOGIX.Validators.Interfaces.IPathnameValidator') interface.

<a name='M-xyLOGIX-Validators-SolutionPathnameValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, `static` constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Validators-SolutionPathnameValidator-IsValid-System-String-'></a>
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

If the value of the `pathname` parameter is the
`null`, blank, or [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty')[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'), then this method returns
`false`.

<a name='T-xyLOGIX-Validators-TCPPortValidator'></a>
## TCPPortValidator `type`

##### Namespace

xyLOGIX.Validators

##### Summary

Exposes functionality to validate the values of variables that purport to hold
TCP port numbers.

<a name='M-xyLOGIX-Validators-TCPPortValidator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, `private` constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-xyLOGIX-Validators-TCPPortValidator-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[ITCPPortValidator](#T-xyLOGIX-Validators-Interfaces-ITCPPortValidator 'xyLOGIX.Validators.Interfaces.ITCPPortValidator') interface.

<a name='M-xyLOGIX-Validators-TCPPortValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, `static` constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Validators-TCPPortValidator-IsValid-System-String-'></a>
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

<a name='M-xyLOGIX-Validators-TCPPortValidator-IsValid-System-Int32-'></a>
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

<a name='M-xyLOGIX-Validators-TCPPortValidator-PortNumberIsInCorrectRange-System-Int32-'></a>
### PortNumberIsInCorrectRange(portNumber) `method`

##### Summary

Determines whether the specified `portNumber` is within the
defined range of valid values.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| portNumber | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) An [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') that set to the TCP port number
that is to be validated. |

<a name='T-xyLOGIX-Validators-UUIDValidator'></a>
## UUIDValidator `type`

##### Namespace

xyLOGIX.Validators

##### Summary

Validates the format of strings containing a universally-unique identifier
(UUID) of a resource on the `Coinbase (Advanced Trade)` trading platform.

<a name='M-xyLOGIX-Validators-UUIDValidator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, private constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-xyLOGIX-Validators-UUIDValidator-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IUUIDValidator](#T-xyLOGIX-Validators-Interfaces-IUUIDValidator 'xyLOGIX.Validators.Interfaces.IUUIDValidator')
interface.

<a name='M-xyLOGIX-Validators-UUIDValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, `static` constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Validators-UUIDValidator-IsValid-System-String,System-Boolean-'></a>
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

<a name='T-xyLOGIX-Validators-VersionStringValidator'></a>
## VersionStringValidator `type`

##### Namespace

xyLOGIX.Validators

##### Summary

Validates the format of software version strings.

<a name='M-xyLOGIX-Validators-VersionStringValidator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, private constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-xyLOGIX-Validators-VersionStringValidator-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IVersionStringValidator](#T-xyLOGIX-Validators-Interfaces-IVersionStringValidator 'xyLOGIX.Validators.Interfaces.IVersionStringValidator')
interface.

<a name='M-xyLOGIX-Validators-VersionStringValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, `static` constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Validators-VersionStringValidator-IsValid-System-String-'></a>
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

<a name='T-xyLOGIX-Validators-WebAddressValidator'></a>
## WebAddressValidator `type`

##### Namespace

xyLOGIX.Validators

##### Summary

Validates the format of strings containing a universally-unique identifier
(UUID) of a resource on the `Coinbase (Advanced Trade)` trading platform.

<a name='M-xyLOGIX-Validators-WebAddressValidator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, private constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-xyLOGIX-Validators-WebAddressValidator-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IWebAddressValidator](#T-xyLOGIX-Validators-Interfaces-IWebAddressValidator 'xyLOGIX.Validators.Interfaces.IWebAddressValidator')
interface.

<a name='M-xyLOGIX-Validators-WebAddressValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, `static` constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Validators-WebAddressValidator-IsValid-System-String-'></a>
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
