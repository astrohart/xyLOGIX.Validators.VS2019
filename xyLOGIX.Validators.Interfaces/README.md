<a name='assembly'></a>
# xyLOGIX.Validators.Interfaces

## Contents

- [IObjectValidator](#T-xyLOGIX-Validators-Interfaces-IObjectValidator 'xyLOGIX.Validators.Interfaces.IObjectValidator')
  - [ErrorMessage](#P-xyLOGIX-Validators-Interfaces-IObjectValidator-ErrorMessage 'xyLOGIX.Validators.Interfaces.IObjectValidator.ErrorMessage')
  - [IsValid](#P-xyLOGIX-Validators-Interfaces-IObjectValidator-IsValid 'xyLOGIX.Validators.Interfaces.IObjectValidator.IsValid')
  - [Validate()](#M-xyLOGIX-Validators-Interfaces-IObjectValidator-Validate 'xyLOGIX.Validators.Interfaces.IObjectValidator.Validate')
- [Resources](#T-xyLOGIX-Validators-Interfaces-Properties-Resources 'xyLOGIX.Validators.Interfaces.Properties.Resources')
  - [Culture](#P-xyLOGIX-Validators-Interfaces-Properties-Resources-Culture 'xyLOGIX.Validators.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Validators-Interfaces-Properties-Resources-ResourceManager 'xyLOGIX.Validators.Interfaces.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Validators-Interfaces-IObjectValidator'></a>
## IObjectValidator `type`

##### Namespace

xyLOGIX.Validators.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a `Validator`
object.

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
updates the [IsValid](#P-xyLOGIX-Validators-Interfaces-IObjectValidator-IsValid 'xyLOGIX.Validators.Interfaces.IObjectValidator.IsValid') property.

##### Parameters

This method has no parameters.

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
