<a name='assembly'></a>
# xyLOGIX.Validators.Factories

## Contents

- [GetAssetSymbolValidator](#T-xyLOGIX-Validators-Factories-GetAssetSymbolValidator 'xyLOGIX.Validators.Factories.GetAssetSymbolValidator')
  - [#cctor()](#M-xyLOGIX-Validators-Factories-GetAssetSymbolValidator-#cctor 'xyLOGIX.Validators.Factories.GetAssetSymbolValidator.#cctor')
  - [SoleInstance()](#M-xyLOGIX-Validators-Factories-GetAssetSymbolValidator-SoleInstance 'xyLOGIX.Validators.Factories.GetAssetSymbolValidator.SoleInstance')
- [GetDateRangeValidator](#T-xyLOGIX-Validators-Factories-GetDateRangeValidator 'xyLOGIX.Validators.Factories.GetDateRangeValidator')
  - [#cctor()](#M-xyLOGIX-Validators-Factories-GetDateRangeValidator-#cctor 'xyLOGIX.Validators.Factories.GetDateRangeValidator.#cctor')
  - [SoleInstance()](#M-xyLOGIX-Validators-Factories-GetDateRangeValidator-SoleInstance 'xyLOGIX.Validators.Factories.GetDateRangeValidator.SoleInstance')
- [GetDnsHostnameValidator](#T-xyLOGIX-Validators-Factories-GetDnsHostnameValidator 'xyLOGIX.Validators.Factories.GetDnsHostnameValidator')
  - [#cctor()](#M-xyLOGIX-Validators-Factories-GetDnsHostnameValidator-#cctor 'xyLOGIX.Validators.Factories.GetDnsHostnameValidator.#cctor')
  - [SoleInstance()](#M-xyLOGIX-Validators-Factories-GetDnsHostnameValidator-SoleInstance 'xyLOGIX.Validators.Factories.GetDnsHostnameValidator.SoleInstance')
- [GetEmailAddressValidator](#T-xyLOGIX-Validators-Factories-GetEmailAddressValidator 'xyLOGIX.Validators.Factories.GetEmailAddressValidator')
  - [#cctor()](#M-xyLOGIX-Validators-Factories-GetEmailAddressValidator-#cctor 'xyLOGIX.Validators.Factories.GetEmailAddressValidator.#cctor')
  - [SoleInstance()](#M-xyLOGIX-Validators-Factories-GetEmailAddressValidator-SoleInstance 'xyLOGIX.Validators.Factories.GetEmailAddressValidator.SoleInstance')
- [GetFileWildcardValidator](#T-xyLOGIX-Validators-Factories-GetFileWildcardValidator 'xyLOGIX.Validators.Factories.GetFileWildcardValidator')
  - [#cctor()](#M-xyLOGIX-Validators-Factories-GetFileWildcardValidator-#cctor 'xyLOGIX.Validators.Factories.GetFileWildcardValidator.#cctor')
  - [SoleInstance()](#M-xyLOGIX-Validators-Factories-GetFileWildcardValidator-SoleInstance 'xyLOGIX.Validators.Factories.GetFileWildcardValidator.SoleInstance')
- [GetPathnameValidator](#T-xyLOGIX-Validators-Factories-GetPathnameValidator 'xyLOGIX.Validators.Factories.GetPathnameValidator')
  - [SoleInstance()](#M-xyLOGIX-Validators-Factories-GetPathnameValidator-SoleInstance 'xyLOGIX.Validators.Factories.GetPathnameValidator.SoleInstance')
- [GetProjectPathnameValidator](#T-xyLOGIX-Validators-Factories-GetProjectPathnameValidator 'xyLOGIX.Validators.Factories.GetProjectPathnameValidator')
  - [SoleInstance()](#M-xyLOGIX-Validators-Factories-GetProjectPathnameValidator-SoleInstance 'xyLOGIX.Validators.Factories.GetProjectPathnameValidator.SoleInstance')
- [GetRF3339TimestampFormatValidator](#T-xyLOGIX-Validators-Factories-GetRF3339TimestampFormatValidator 'xyLOGIX.Validators.Factories.GetRF3339TimestampFormatValidator')
  - [#cctor()](#M-xyLOGIX-Validators-Factories-GetRF3339TimestampFormatValidator-#cctor 'xyLOGIX.Validators.Factories.GetRF3339TimestampFormatValidator.#cctor')
  - [SoleInstance()](#M-xyLOGIX-Validators-Factories-GetRF3339TimestampFormatValidator-SoleInstance 'xyLOGIX.Validators.Factories.GetRF3339TimestampFormatValidator.SoleInstance')
- [GetSolutionPathnameValidator](#T-xyLOGIX-Validators-Factories-GetSolutionPathnameValidator 'xyLOGIX.Validators.Factories.GetSolutionPathnameValidator')
  - [SoleInstance()](#M-xyLOGIX-Validators-Factories-GetSolutionPathnameValidator-SoleInstance 'xyLOGIX.Validators.Factories.GetSolutionPathnameValidator.SoleInstance')
- [GetTCPPortValidator](#T-xyLOGIX-Validators-Factories-GetTCPPortValidator 'xyLOGIX.Validators.Factories.GetTCPPortValidator')
  - [#cctor()](#M-xyLOGIX-Validators-Factories-GetTCPPortValidator-#cctor 'xyLOGIX.Validators.Factories.GetTCPPortValidator.#cctor')
  - [SoleInstance()](#M-xyLOGIX-Validators-Factories-GetTCPPortValidator-SoleInstance 'xyLOGIX.Validators.Factories.GetTCPPortValidator.SoleInstance')
- [GetUUIDValidator](#T-xyLOGIX-Validators-Factories-GetUUIDValidator 'xyLOGIX.Validators.Factories.GetUUIDValidator')
  - [#cctor()](#M-xyLOGIX-Validators-Factories-GetUUIDValidator-#cctor 'xyLOGIX.Validators.Factories.GetUUIDValidator.#cctor')
  - [SoleInstance()](#M-xyLOGIX-Validators-Factories-GetUUIDValidator-SoleInstance 'xyLOGIX.Validators.Factories.GetUUIDValidator.SoleInstance')
- [GetVersionStringValidator](#T-xyLOGIX-Validators-Factories-GetVersionStringValidator 'xyLOGIX.Validators.Factories.GetVersionStringValidator')
  - [#cctor()](#M-xyLOGIX-Validators-Factories-GetVersionStringValidator-#cctor 'xyLOGIX.Validators.Factories.GetVersionStringValidator.#cctor')
  - [SoleInstance()](#M-xyLOGIX-Validators-Factories-GetVersionStringValidator-SoleInstance 'xyLOGIX.Validators.Factories.GetVersionStringValidator.SoleInstance')
- [GetWebAddressValidator](#T-xyLOGIX-Validators-Factories-GetWebAddressValidator 'xyLOGIX.Validators.Factories.GetWebAddressValidator')
  - [#cctor()](#M-xyLOGIX-Validators-Factories-GetWebAddressValidator-#cctor 'xyLOGIX.Validators.Factories.GetWebAddressValidator.#cctor')
  - [SoleInstance()](#M-xyLOGIX-Validators-Factories-GetWebAddressValidator-SoleInstance 'xyLOGIX.Validators.Factories.GetWebAddressValidator.SoleInstance')
- [ObjectValidatorFactoryBase\`1](#T-xyLOGIX-Validators-Factories-ObjectValidatorFactoryBase`1 'xyLOGIX.Validators.Factories.ObjectValidatorFactoryBase`1')
  - [Object(objectToValidate)](#M-xyLOGIX-Validators-Factories-ObjectValidatorFactoryBase`1-Object-`0- 'xyLOGIX.Validators.Factories.ObjectValidatorFactoryBase`1.Object(`0)')
- [Resources](#T-xyLOGIX-Validators-Factories-Properties-Resources 'xyLOGIX.Validators.Factories.Properties.Resources')
  - [Culture](#P-xyLOGIX-Validators-Factories-Properties-Resources-Culture 'xyLOGIX.Validators.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Validators-Factories-Properties-Resources-ResourceManager 'xyLOGIX.Validators.Factories.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Validators-Factories-GetAssetSymbolValidator'></a>
## GetAssetSymbolValidator `type`

##### Namespace

xyLOGIX.Validators.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IAssetSymbolValidator](#T-xyLOGIX-Validators-Interfaces-IAssetSymbolValidator 'xyLOGIX.Validators.Interfaces.IAssetSymbolValidator')
interface.

<a name='M-xyLOGIX-Validators-Factories-GetAssetSymbolValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the
[GetAssetSymbolValidator](#T-xyLOGIX-Validators-Factories-GetAssetSymbolValidator 'xyLOGIX.Validators.Factories.GetAssetSymbolValidator')
class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance
being created or before any static members are referenced.

<a name='M-xyLOGIX-Validators-Factories-GetAssetSymbolValidator-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IAssetSymbolValidator](#T-xyLOGIX-Validators-Interfaces-IAssetSymbolValidator 'xyLOGIX.Validators.Interfaces.IAssetSymbolValidator')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IAssetSymbolValidator](#T-xyLOGIX-Validators-Interfaces-IAssetSymbolValidator 'xyLOGIX.Validators.Interfaces.IAssetSymbolValidator')
interface.

##### Parameters

This method has no parameters.

<a name='T-xyLOGIX-Validators-Factories-GetDateRangeValidator'></a>
## GetDateRangeValidator `type`

##### Namespace

xyLOGIX.Validators.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IDateRangeValidator](#T-xyLOGIX-Validators-Interfaces-IDateRangeValidator 'xyLOGIX.Validators.Interfaces.IDateRangeValidator')
interface.

<a name='M-xyLOGIX-Validators-Factories-GetDateRangeValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the
[GetDateRangeValidator](#T-xyLOGIX-Validators-Factories-GetDateRangeValidator 'xyLOGIX.Validators.Factories.GetDateRangeValidator')
class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance
being created or before any static members are referenced.

<a name='M-xyLOGIX-Validators-Factories-GetDateRangeValidator-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IDateRangeValidator](#T-xyLOGIX-Validators-Interfaces-IDateRangeValidator 'xyLOGIX.Validators.Interfaces.IDateRangeValidator')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IDateRangeValidator](#T-xyLOGIX-Validators-Interfaces-IDateRangeValidator 'xyLOGIX.Validators.Interfaces.IDateRangeValidator')
interface.

##### Parameters

This method has no parameters.

<a name='T-xyLOGIX-Validators-Factories-GetDnsHostnameValidator'></a>
## GetDnsHostnameValidator `type`

##### Namespace

xyLOGIX.Validators.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IDnsHostnameValidator](#T-xyLOGIX-Validators-Interfaces-IDnsHostnameValidator 'xyLOGIX.Validators.Interfaces.IDnsHostnameValidator') interface.

<a name='M-xyLOGIX-Validators-Factories-GetDnsHostnameValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed
once only for the [GetDnsHostnameValidator](#T-xyLOGIX-Validators-Factories-GetDnsHostnameValidator 'xyLOGIX.Validators.Factories.GetDnsHostnameValidator') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance
being created or before any static members are referenced.

<a name='M-xyLOGIX-Validators-Factories-GetDnsHostnameValidator-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IDnsHostnameValidator](#T-xyLOGIX-Validators-Interfaces-IDnsHostnameValidator 'xyLOGIX.Validators.Interfaces.IDnsHostnameValidator') interface, and returns a reference to
it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IDnsHostnameValidator](#T-xyLOGIX-Validators-Interfaces-IDnsHostnameValidator 'xyLOGIX.Validators.Interfaces.IDnsHostnameValidator') interface.

##### Parameters

This method has no parameters.

<a name='T-xyLOGIX-Validators-Factories-GetEmailAddressValidator'></a>
## GetEmailAddressValidator `type`

##### Namespace

xyLOGIX.Validators.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IEmailAddressValidator](#T-xyLOGIX-Validators-Interfaces-IEmailAddressValidator 'xyLOGIX.Validators.Interfaces.IEmailAddressValidator')
interface.

<a name='M-xyLOGIX-Validators-Factories-GetEmailAddressValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the
[GetEmailAddressValidator](#T-xyLOGIX-Validators-Factories-GetEmailAddressValidator 'xyLOGIX.Validators.Factories.GetEmailAddressValidator')
class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance
being created or before any static members are referenced.

<a name='M-xyLOGIX-Validators-Factories-GetEmailAddressValidator-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IEmailAddressValidator](#T-xyLOGIX-Validators-Interfaces-IEmailAddressValidator 'xyLOGIX.Validators.Interfaces.IEmailAddressValidator')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IEmailAddressValidator](#T-xyLOGIX-Validators-Interfaces-IEmailAddressValidator 'xyLOGIX.Validators.Interfaces.IEmailAddressValidator')
interface.

##### Parameters

This method has no parameters.

<a name='T-xyLOGIX-Validators-Factories-GetFileWildcardValidator'></a>
## GetFileWildcardValidator `type`

##### Namespace

xyLOGIX.Validators.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IFileWildcardValidator](#T-xyLOGIX-Validators-Interfaces-IFileWildcardValidator 'xyLOGIX.Validators.Interfaces.IFileWildcardValidator')
interface.

<a name='M-xyLOGIX-Validators-Factories-GetFileWildcardValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes `static` data or performs actions that
need to be performed once only for the
[GetFileWildcardValidator](#T-xyLOGIX-Validators-Factories-GetFileWildcardValidator 'xyLOGIX.Validators.Factories.GetFileWildcardValidator') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance
being created or before any `static` members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-xyLOGIX-Validators-Factories-GetFileWildcardValidator-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IFileWildcardValidator](#T-xyLOGIX-Validators-Interfaces-IFileWildcardValidator 'xyLOGIX.Validators.Interfaces.IFileWildcardValidator')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IFileWildcardValidator](#T-xyLOGIX-Validators-Interfaces-IFileWildcardValidator 'xyLOGIX.Validators.Interfaces.IFileWildcardValidator')
interface.

##### Parameters

This method has no parameters.

<a name='T-xyLOGIX-Validators-Factories-GetPathnameValidator'></a>
## GetPathnameValidator `type`

##### Namespace

xyLOGIX.Validators.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IPathnameValidator](#T-xyLOGIX-Validators-Interfaces-IPathnameValidator 'xyLOGIX.Validators.Interfaces.IPathnameValidator') interface.

<a name='M-xyLOGIX-Validators-Factories-GetPathnameValidator-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IPathnameValidator](#T-xyLOGIX-Validators-Interfaces-IPathnameValidator 'xyLOGIX.Validators.Interfaces.IPathnameValidator') interface,
and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IPathnameValidator](#T-xyLOGIX-Validators-Interfaces-IPathnameValidator 'xyLOGIX.Validators.Interfaces.IPathnameValidator') interface.

##### Parameters

This method has no parameters.

<a name='T-xyLOGIX-Validators-Factories-GetProjectPathnameValidator'></a>
## GetProjectPathnameValidator `type`

##### Namespace

xyLOGIX.Validators.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IProjectPathnameValidator](#T-xyLOGIX-Validators-Interfaces-IProjectPathnameValidator 'xyLOGIX.Validators.Interfaces.IProjectPathnameValidator')
interface.

<a name='M-xyLOGIX-Validators-Factories-GetProjectPathnameValidator-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IProjectPathnameValidator](#T-xyLOGIX-Validators-Interfaces-IProjectPathnameValidator 'xyLOGIX.Validators.Interfaces.IProjectPathnameValidator')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IProjectPathnameValidator](#T-xyLOGIX-Validators-Interfaces-IProjectPathnameValidator 'xyLOGIX.Validators.Interfaces.IProjectPathnameValidator')
interface.

##### Parameters

This method has no parameters.

<a name='T-xyLOGIX-Validators-Factories-GetRF3339TimestampFormatValidator'></a>
## GetRF3339TimestampFormatValidator `type`

##### Namespace

xyLOGIX.Validators.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IRFC3339TimestampFormatValidator](#T-xyLOGIX-Validators-Interfaces-IRFC3339TimestampFormatValidator 'xyLOGIX.Validators.Interfaces.IRFC3339TimestampFormatValidator')
interface.

<a name='M-xyLOGIX-Validators-Factories-GetRF3339TimestampFormatValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the
[GetRF3339TimestampFormatValidator](#T-xyLOGIX-Validators-Factories-GetRF3339TimestampFormatValidator 'xyLOGIX.Validators.Factories.GetRF3339TimestampFormatValidator')
class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance
being created or before any static members are referenced.

<a name='M-xyLOGIX-Validators-Factories-GetRF3339TimestampFormatValidator-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IRFC3339TimestampFormatValidator](#T-xyLOGIX-Validators-Interfaces-IRFC3339TimestampFormatValidator 'xyLOGIX.Validators.Interfaces.IRFC3339TimestampFormatValidator')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IRFC3339TimestampFormatValidator](#T-xyLOGIX-Validators-Interfaces-IRFC3339TimestampFormatValidator 'xyLOGIX.Validators.Interfaces.IRFC3339TimestampFormatValidator')
interface.

##### Parameters

This method has no parameters.

<a name='T-xyLOGIX-Validators-Factories-GetSolutionPathnameValidator'></a>
## GetSolutionPathnameValidator `type`

##### Namespace

xyLOGIX.Validators.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[ISolutionPathnameValidator](#T-xyLOGIX-Validators-Interfaces-ISolutionPathnameValidator 'xyLOGIX.Validators.Interfaces.ISolutionPathnameValidator')
interface.

<a name='M-xyLOGIX-Validators-Factories-GetSolutionPathnameValidator-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[ISolutionPathnameValidator](#T-xyLOGIX-Validators-Interfaces-ISolutionPathnameValidator 'xyLOGIX.Validators.Interfaces.ISolutionPathnameValidator')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[ISolutionPathnameValidator](#T-xyLOGIX-Validators-Interfaces-ISolutionPathnameValidator 'xyLOGIX.Validators.Interfaces.ISolutionPathnameValidator')
interface.

##### Parameters

This method has no parameters.

<a name='T-xyLOGIX-Validators-Factories-GetTCPPortValidator'></a>
## GetTCPPortValidator `type`

##### Namespace

xyLOGIX.Validators.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[ITCPPortValidator](#T-xyLOGIX-Validators-Interfaces-ITCPPortValidator 'xyLOGIX.Validators.Interfaces.ITCPPortValidator') interface.

<a name='M-xyLOGIX-Validators-Factories-GetTCPPortValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed
once only for the [GetTCPPortValidator](#T-xyLOGIX-Validators-Factories-GetTCPPortValidator 'xyLOGIX.Validators.Factories.GetTCPPortValidator') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance
being created or before any static members are referenced.

<a name='M-xyLOGIX-Validators-Factories-GetTCPPortValidator-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[ITCPPortValidator](#T-xyLOGIX-Validators-Interfaces-ITCPPortValidator 'xyLOGIX.Validators.Interfaces.ITCPPortValidator') interface, and returns a reference to
it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[ITCPPortValidator](#T-xyLOGIX-Validators-Interfaces-ITCPPortValidator 'xyLOGIX.Validators.Interfaces.ITCPPortValidator') interface.

##### Parameters

This method has no parameters.

<a name='T-xyLOGIX-Validators-Factories-GetUUIDValidator'></a>
## GetUUIDValidator `type`

##### Namespace

xyLOGIX.Validators.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IUUIDValidator](#T-xyLOGIX-Validators-Interfaces-IUUIDValidator 'xyLOGIX.Validators.Interfaces.IUUIDValidator')
interface.

<a name='M-xyLOGIX-Validators-Factories-GetUUIDValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the
[GetUUIDValidator](#T-xyLOGIX-Validators-Factories-GetUUIDValidator 'xyLOGIX.Validators.Factories.GetUUIDValidator')
class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance
being created or before any static members are referenced.

<a name='M-xyLOGIX-Validators-Factories-GetUUIDValidator-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IUUIDValidator](#T-xyLOGIX-Validators-Interfaces-IUUIDValidator 'xyLOGIX.Validators.Interfaces.IUUIDValidator')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IUUIDValidator](#T-xyLOGIX-Validators-Interfaces-IUUIDValidator 'xyLOGIX.Validators.Interfaces.IUUIDValidator')
interface.

##### Parameters

This method has no parameters.

<a name='T-xyLOGIX-Validators-Factories-GetVersionStringValidator'></a>
## GetVersionStringValidator `type`

##### Namespace

xyLOGIX.Validators.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IVersionStringValidator](#T-xyLOGIX-Validators-Interfaces-IVersionStringValidator 'xyLOGIX.Validators.Interfaces.IVersionStringValidator')
interface.

<a name='M-xyLOGIX-Validators-Factories-GetVersionStringValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed
once only for the
[GetVersionStringValidator](#T-xyLOGIX-Validators-Factories-GetVersionStringValidator 'xyLOGIX.Validators.Factories.GetVersionStringValidator') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance
being created or before any static members are referenced.

<a name='M-xyLOGIX-Validators-Factories-GetVersionStringValidator-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IVersionStringValidator](#T-xyLOGIX-Validators-Interfaces-IVersionStringValidator 'xyLOGIX.Validators.Interfaces.IVersionStringValidator')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IVersionStringValidator](#T-xyLOGIX-Validators-Interfaces-IVersionStringValidator 'xyLOGIX.Validators.Interfaces.IVersionStringValidator')
interface.

##### Parameters

This method has no parameters.

<a name='T-xyLOGIX-Validators-Factories-GetWebAddressValidator'></a>
## GetWebAddressValidator `type`

##### Namespace

xyLOGIX.Validators.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IWebAddressValidator](#T-xyLOGIX-Validators-Interfaces-IWebAddressValidator 'xyLOGIX.Validators.Interfaces.IWebAddressValidator')
interface.

<a name='M-xyLOGIX-Validators-Factories-GetWebAddressValidator-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the
[GetWebAddressValidator](#T-xyLOGIX-Validators-Factories-GetWebAddressValidator 'xyLOGIX.Validators.Factories.GetWebAddressValidator')
class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance
being created or before any static members are referenced.

<a name='M-xyLOGIX-Validators-Factories-GetWebAddressValidator-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IWebAddressValidator](#T-xyLOGIX-Validators-Interfaces-IWebAddressValidator 'xyLOGIX.Validators.Interfaces.IWebAddressValidator')
interface, and returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IWebAddressValidator](#T-xyLOGIX-Validators-Interfaces-IWebAddressValidator 'xyLOGIX.Validators.Interfaces.IWebAddressValidator')
interface.

##### Parameters

This method has no parameters.

<a name='T-xyLOGIX-Validators-Factories-ObjectValidatorFactoryBase`1'></a>
## ObjectValidatorFactoryBase\`1 `type`

##### Namespace

xyLOGIX.Validators.Factories

##### Summary

Creates new instance(s) of object(s) that implement the
[IObjectValidator](#T-xyLOGIX-Validators-Interfaces-IObjectValidator 'xyLOGIX.Validators.Interfaces.IObjectValidator') interface, and
returns references to them.

<a name='M-xyLOGIX-Validators-Factories-ObjectValidatorFactoryBase`1-Object-`0-'></a>
### Object(objectToValidate) `method`

##### Summary

Creates a new instance of an object that implements the
[IObjectValidator](#T-xyLOGIX-Validators-Interfaces-IObjectValidator 'xyLOGIX.Validators.Interfaces.IObjectValidator') interface and
returns a reference to it, for the `objectToValidate`
specified.

##### Returns

Reference to an instance of an object that implements the
[IObjectValidator](#T-xyLOGIX-Validators-Interfaces-IObjectValidator 'xyLOGIX.Validators.Interfaces.IObjectValidator') interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| objectToValidate | [\`0](#T-`0 '`0') | (Required.) Reference to an instance of the
object whose properties' values are to be validated. |

<a name='T-xyLOGIX-Validators-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Validators.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Validators-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Validators-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
