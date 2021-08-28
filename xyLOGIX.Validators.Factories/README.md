<a name='assembly'></a>
# xyLOGIX.Validators.Factories

## Contents

- [ObjectValidatorFactoryBase\`1](#T-xyLOGIX-Validators-Factories-ObjectValidatorFactoryBase`1 'xyLOGIX.Validators.Factories.ObjectValidatorFactoryBase`1')
  - [Object(objectToValidate)](#M-xyLOGIX-Validators-Factories-ObjectValidatorFactoryBase`1-Object-`0- 'xyLOGIX.Validators.Factories.ObjectValidatorFactoryBase`1.Object(`0)')
- [Resources](#T-xyLOGIX-Validators-Factories-Properties-Resources 'xyLOGIX.Validators.Factories.Properties.Resources')
  - [Culture](#P-xyLOGIX-Validators-Factories-Properties-Resources-Culture 'xyLOGIX.Validators.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Validators-Factories-Properties-Resources-ResourceManager 'xyLOGIX.Validators.Factories.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Validators-Factories-ObjectValidatorFactoryBase`1'></a>
## ObjectValidatorFactoryBase\`1 `type`

##### Namespace

xyLOGIX.Validators.Factories

##### Summary

Creates new instances of objects that implement the
[IObjectValidator](#T-xyLOGIX-Validators-Interfaces-IObjectValidator 'xyLOGIX.Validators.Interfaces.IObjectValidator') interface, and
returns references to them.

<a name='M-xyLOGIX-Validators-Factories-ObjectValidatorFactoryBase`1-Object-`0-'></a>
### Object(objectToValidate) `method`

##### Summary

Creates a new instance of an object that implements the
[IObjectValidator](#T-xyLOGIX-Validators-Interfaces-IObjectValidator 'xyLOGIX.Validators.Interfaces.IObjectValidator') interface and
returns a reference to it, for the `objectToValidate` specified.

##### Returns

Reference to an instance of an object that implements the
[IObjectValidator](#T-xyLOGIX-Validators-Interfaces-IObjectValidator 'xyLOGIX.Validators.Interfaces.IObjectValidator') interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| objectToValidate | [\`0](#T-`0 '`0') | (Required.) Reference to an instance of the object whose properties' values are to be validated. |

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
