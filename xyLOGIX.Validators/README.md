<a name='assembly'></a>
# xyLOGIX.Validators

## Contents

- [Resources](#T-xyLOGIX-Validators-Properties-Resources 'xyLOGIX.Validators.Properties.Resources')
  - [Culture](#P-xyLOGIX-Validators-Properties-Resources-Culture 'xyLOGIX.Validators.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Validators-Properties-Resources-ResourceManager 'xyLOGIX.Validators.Properties.Resources.ResourceManager')
- [ValidatorBase\`1](#T-xyLOGIX-Validators-ValidatorBase`1 'xyLOGIX.Validators.ValidatorBase`1')
  - [#ctor(objectToValidate)](#M-xyLOGIX-Validators-ValidatorBase`1-#ctor-`0- 'xyLOGIX.Validators.ValidatorBase`1.#ctor(`0)')
  - [ErrorMessage](#P-xyLOGIX-Validators-ValidatorBase`1-ErrorMessage 'xyLOGIX.Validators.ValidatorBase`1.ErrorMessage')
  - [IsValid](#P-xyLOGIX-Validators-ValidatorBase`1-IsValid 'xyLOGIX.Validators.ValidatorBase`1.IsValid')
  - [ObjectToValidate](#P-xyLOGIX-Validators-ValidatorBase`1-ObjectToValidate 'xyLOGIX.Validators.ValidatorBase`1.ObjectToValidate')
  - [Validate()](#M-xyLOGIX-Validators-ValidatorBase`1-Validate 'xyLOGIX.Validators.ValidatorBase`1.Validate')

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

<a name='P-xyLOGIX-Validators-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-xyLOGIX-Validators-ValidatorBase`1'></a>
## ValidatorBase\`1 `type`

##### Namespace

xyLOGIX.Validators

##### Summary

Serves as the common base class for all validator objects.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TObject | Type of the object whose instances are to be
validated.  Can be either a concrete instance or an interface. |

<a name='M-xyLOGIX-Validators-ValidatorBase`1-#ctor-`0-'></a>
### #ctor(objectToValidate) `constructor`

##### Summary

Constructs a new instance of [ValidatorBase](#T-xyLOGIX-Validators-ValidatorBase 'xyLOGIX.Validators.ValidatorBase')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| objectToValidate | [\`0](#T-`0 '`0') | (Required.) Reference to an instance of the object to be validated. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required
parameter, `objectToValidate`, is passed a
`null` value. |

<a name='P-xyLOGIX-Validators-ValidatorBase`1-ErrorMessage'></a>
### ErrorMessage `property`

##### Summary

When implemented by a class, gets or sets the error message text
generated when the condition being validated fails.

##### Returns

The error message to generate.

<a name='P-xyLOGIX-Validators-ValidatorBase`1-IsValid'></a>
### IsValid `property`

##### Summary

When implemented by a class, gets or sets a value indicating whether
the user-entered content in the specified control passes validation.

##### Returns

`true` if the content is valid; otherwise,
`false`.

<a name='P-xyLOGIX-Validators-ValidatorBase`1-ObjectToValidate'></a>
### ObjectToValidate `property`

##### Summary

Gets a reference to the object instance whose data is to be validated.

<a name='M-xyLOGIX-Validators-ValidatorBase`1-Validate'></a>
### Validate() `method`

##### Summary

When implemented by a class, evaluates the condition it checks and
updates the [IsValid](#P-xyLOGIX-Validators-Interfaces-IValidator-IsValid 'xyLOGIX.Validators.Interfaces.IValidator.IsValid')
property.

##### Parameters

This method has no parameters.
