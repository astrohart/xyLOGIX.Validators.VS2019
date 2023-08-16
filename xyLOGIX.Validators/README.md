<a name='assembly'></a>
# xyLOGIX.Validators

## Contents

- [ObjectValidatorBase\`1](#T-xyLOGIX-Validators-ObjectValidatorBase`1 'xyLOGIX.Validators.ObjectValidatorBase`1')
  - [#ctor(objectToValidate)](#M-xyLOGIX-Validators-ObjectValidatorBase`1-#ctor-`0- 'xyLOGIX.Validators.ObjectValidatorBase`1.#ctor(`0)')
  - [ErrorMessage](#P-xyLOGIX-Validators-ObjectValidatorBase`1-ErrorMessage 'xyLOGIX.Validators.ObjectValidatorBase`1.ErrorMessage')
  - [IsValid](#P-xyLOGIX-Validators-ObjectValidatorBase`1-IsValid 'xyLOGIX.Validators.ObjectValidatorBase`1.IsValid')
  - [ObjectToValidate](#P-xyLOGIX-Validators-ObjectValidatorBase`1-ObjectToValidate 'xyLOGIX.Validators.ObjectValidatorBase`1.ObjectToValidate')
  - [OnValidationFailed(e)](#M-xyLOGIX-Validators-ObjectValidatorBase`1-OnValidationFailed-xyLOGIX-Validators-Events-ValidationFailedEventArgs- 'xyLOGIX.Validators.ObjectValidatorBase`1.OnValidationFailed(xyLOGIX.Validators.Events.ValidationFailedEventArgs)')
  - [OnValidationSucceeded()](#M-xyLOGIX-Validators-ObjectValidatorBase`1-OnValidationSucceeded 'xyLOGIX.Validators.ObjectValidatorBase`1.OnValidationSucceeded')
  - [Validate()](#M-xyLOGIX-Validators-ObjectValidatorBase`1-Validate 'xyLOGIX.Validators.ObjectValidatorBase`1.Validate')
- [Resources](#T-xyLOGIX-Validators-Properties-Resources 'xyLOGIX.Validators.Properties.Resources')
  - [Culture](#P-xyLOGIX-Validators-Properties-Resources-Culture 'xyLOGIX.Validators.Properties.Resources.Culture')
  - [Error_ObjectToValidatePropertyHasNotBeenSet](#P-xyLOGIX-Validators-Properties-Resources-Error_ObjectToValidatePropertyHasNotBeenSet 'xyLOGIX.Validators.Properties.Resources.Error_ObjectToValidatePropertyHasNotBeenSet')
  - [ResourceManager](#P-xyLOGIX-Validators-Properties-Resources-ResourceManager 'xyLOGIX.Validators.Properties.Resources.ResourceManager')

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
[ObjectValidatorBase](#T-xyLOGIX-Validators-ObjectValidatorBase 'xyLOGIX.Validators.ObjectValidatorBase')
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

Gets a reference to the object instance whose data is to be validated.

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

<a name='P-xyLOGIX-Validators-Properties-Resources-Error_ObjectToValidatePropertyHasNotBeenSet'></a>
### Error_ObjectToValidatePropertyHasNotBeenSet `property`

##### Summary

Looks up a localized string similar to The ObjectToValidate property has not been set..

<a name='P-xyLOGIX-Validators-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
