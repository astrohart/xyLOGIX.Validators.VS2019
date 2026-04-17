<a name='assembly'></a>
# xyLOGIX.Validators.Events

## Contents

- [Resources](#T-xyLOGIX-Validators-Events-Properties-Resources 'xyLOGIX.Validators.Events.Properties.Resources')
  - [Culture](#P-xyLOGIX-Validators-Events-Properties-Resources-Culture 'xyLOGIX.Validators.Events.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Validators-Events-Properties-Resources-ResourceManager 'xyLOGIX.Validators.Events.Properties.Resources.ResourceManager')
- [ValidationFailedEventArgs](#T-xyLOGIX-Validators-Events-ValidationFailedEventArgs 'xyLOGIX.Validators.Events.ValidationFailedEventArgs')
  - [#ctor(errorMessage)](#M-xyLOGIX-Validators-Events-ValidationFailedEventArgs-#ctor-System-String- 'xyLOGIX.Validators.Events.ValidationFailedEventArgs.#ctor(System.String)')
  - [ErrorMessage](#P-xyLOGIX-Validators-Events-ValidationFailedEventArgs-ErrorMessage 'xyLOGIX.Validators.Events.ValidationFailedEventArgs.ErrorMessage')
  - [#cctor()](#M-xyLOGIX-Validators-Events-ValidationFailedEventArgs-#cctor 'xyLOGIX.Validators.Events.ValidationFailedEventArgs.#cctor')
- [ValidationFailedEventHandler](#T-xyLOGIX-Validators-Events-ValidationFailedEventHandler 'xyLOGIX.Validators.Events.ValidationFailedEventHandler')
- [ValidationSucceededEventArgs](#T-xyLOGIX-Validators-Events-ValidationSucceededEventArgs 'xyLOGIX.Validators.Events.ValidationSucceededEventArgs')
  - [#ctor()](#M-xyLOGIX-Validators-Events-ValidationSucceededEventArgs-#ctor 'xyLOGIX.Validators.Events.ValidationSucceededEventArgs.#ctor')
  - [#cctor()](#M-xyLOGIX-Validators-Events-ValidationSucceededEventArgs-#cctor 'xyLOGIX.Validators.Events.ValidationSucceededEventArgs.#cctor')
- [ValidationSucceededEventHandler](#T-xyLOGIX-Validators-Events-ValidationSucceededEventHandler 'xyLOGIX.Validators.Events.ValidationSucceededEventHandler')

<a name='T-xyLOGIX-Validators-Events-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Validators.Events.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Validators-Events-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Validators-Events-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-xyLOGIX-Validators-Events-ValidationFailedEventArgs'></a>
## ValidationFailedEventArgs `type`

##### Namespace

xyLOGIX.Validators.Events

##### Summary

Provides information for ValidationFailed event handlers.

##### Remarks

Such events normally are raised when we failed to validate an
object's properties' values according to a given set of rules.

<a name='M-xyLOGIX-Validators-Events-ValidationFailedEventArgs-#ctor-System-String-'></a>
### #ctor(errorMessage) `constructor`

##### Summary

Constructs a new instance of
[ValidationFailedEventArgs](#T-xyLOGIX-Validators-Events-ValidationFailedEventArgs 'xyLOGIX.Validators.Events.ValidationFailedEventArgs') and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| errorMessage | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the error message to
be generated. |

<a name='P-xyLOGIX-Validators-Events-ValidationFailedEventArgs-ErrorMessage'></a>
### ErrorMessage `property`

##### Summary

Gets a string explaining why the validation failed.

<a name='M-xyLOGIX-Validators-Events-ValidationFailedEventArgs-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [ValidationFailedEventArgs](#T-xyLOGIX-Validators-Events-ValidationFailedEventArgs 'xyLOGIX.Validators.Events.ValidationFailedEventArgs')
class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='T-xyLOGIX-Validators-Events-ValidationFailedEventHandler'></a>
## ValidationFailedEventHandler `type`

##### Namespace

xyLOGIX.Validators.Events

##### Summary

Represents a handler for a ValidationFailed event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:xyLOGIX.Validators.Events.ValidationFailedEventHandler](#T-T-xyLOGIX-Validators-Events-ValidationFailedEventHandler 'T:xyLOGIX.Validators.Events.ValidationFailedEventHandler') | Reference to the instance of the object that raised the
event. |

##### Remarks

This delegate merely specifies the signature of all methods that
handle the ValidationFailed event.

<a name='T-xyLOGIX-Validators-Events-ValidationSucceededEventArgs'></a>
## ValidationSucceededEventArgs `type`

##### Namespace

xyLOGIX.Validators.Events

##### Summary

Provides information for ValidationSucceeded event handlers.

<a name='M-xyLOGIX-Validators-Events-ValidationSucceededEventArgs-#ctor'></a>
### #ctor() `constructor`

##### Summary

Creates a new instance of
[ValidationSucceededEventArgs](#T-xyLOGIX-Validators-Events-ValidationSucceededEventArgs 'xyLOGIX.Validators.Events.ValidationSucceededEventArgs') and
returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='M-xyLOGIX-Validators-Events-ValidationSucceededEventArgs-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [ValidationSucceededEventArgs](#T-xyLOGIX-Validators-Events-ValidationSucceededEventArgs 'xyLOGIX.Validators.Events.ValidationSucceededEventArgs')
class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.

<a name='T-xyLOGIX-Validators-Events-ValidationSucceededEventHandler'></a>
## ValidationSucceededEventHandler `type`

##### Namespace

xyLOGIX.Validators.Events

##### Summary

Represents a handler for a ValidationSucceeded event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:xyLOGIX.Validators.Events.ValidationSucceededEventHandler](#T-T-xyLOGIX-Validators-Events-ValidationSucceededEventHandler 'T:xyLOGIX.Validators.Events.ValidationSucceededEventHandler') | Reference to the instance of the object that raised the
event. |

##### Remarks

This delegate merely specifies the signature of all methods that
handle the ValidationSucceeded event.
