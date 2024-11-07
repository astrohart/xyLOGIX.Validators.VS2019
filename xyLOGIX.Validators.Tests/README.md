<a name='assembly'></a>
# xyLOGIX.Validators.Tests

## Contents

- [PathnameValidatorTests](#T-xyLOGIX-Validators-Tests-PathnameValidatorTests 'xyLOGIX.Validators.Tests.PathnameValidatorTests')
  - [CorrectFolderPathname](#F-xyLOGIX-Validators-Tests-PathnameValidatorTests-CorrectFolderPathname 'xyLOGIX.Validators.Tests.PathnameValidatorTests.CorrectFolderPathname')
  - [CorrectFolderPathnameWithQuotes](#F-xyLOGIX-Validators-Tests-PathnameValidatorTests-CorrectFolderPathnameWithQuotes 'xyLOGIX.Validators.Tests.PathnameValidatorTests.CorrectFolderPathnameWithQuotes')
  - [PathnameValidator](#P-xyLOGIX-Validators-Tests-PathnameValidatorTests-PathnameValidator 'xyLOGIX.Validators.Tests.PathnameValidatorTests.PathnameValidator')
  - [Test_CorrectPathname_IsValidated()](#M-xyLOGIX-Validators-Tests-PathnameValidatorTests-Test_CorrectPathname_IsValidated 'xyLOGIX.Validators.Tests.PathnameValidatorTests.Test_CorrectPathname_IsValidated')
- [Resources](#T-xyLOGIX-Validators-Tests-Properties-Resources 'xyLOGIX.Validators.Tests.Properties.Resources')
  - [Culture](#P-xyLOGIX-Validators-Tests-Properties-Resources-Culture 'xyLOGIX.Validators.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Validators-Tests-Properties-Resources-ResourceManager 'xyLOGIX.Validators.Tests.Properties.Resources.ResourceManager')
- [VersionStringValidatorTests](#T-xyLOGIX-Validators-Tests-VersionStringValidatorTests 'xyLOGIX.Validators.Tests.VersionStringValidatorTests')
  - [VersionStringValidator](#P-xyLOGIX-Validators-Tests-VersionStringValidatorTests-VersionStringValidator 'xyLOGIX.Validators.Tests.VersionStringValidatorTests.VersionStringValidator')
  - [IsValid_InputWithDotAtEnd_ReturnsFalse()](#M-xyLOGIX-Validators-Tests-VersionStringValidatorTests-IsValid_InputWithDotAtEnd_ReturnsFalse 'xyLOGIX.Validators.Tests.VersionStringValidatorTests.IsValid_InputWithDotAtEnd_ReturnsFalse')
  - [IsValid_InputWithDotAtStart_ReturnsFalse()](#M-xyLOGIX-Validators-Tests-VersionStringValidatorTests-IsValid_InputWithDotAtStart_ReturnsFalse 'xyLOGIX.Validators.Tests.VersionStringValidatorTests.IsValid_InputWithDotAtStart_ReturnsFalse')
  - [IsValid_InputWithLessThanThreeNumbersSeparatedByDots_ReturnsFalse()](#M-xyLOGIX-Validators-Tests-VersionStringValidatorTests-IsValid_InputWithLessThanThreeNumbersSeparatedByDots_ReturnsFalse 'xyLOGIX.Validators.Tests.VersionStringValidatorTests.IsValid_InputWithLessThanThreeNumbersSeparatedByDots_ReturnsFalse')
  - [IsValid_InputWithMoreThanThreeNumbersSeparatedByDots_ReturnsFalse()](#M-xyLOGIX-Validators-Tests-VersionStringValidatorTests-IsValid_InputWithMoreThanThreeNumbersSeparatedByDots_ReturnsFalse 'xyLOGIX.Validators.Tests.VersionStringValidatorTests.IsValid_InputWithMoreThanThreeNumbersSeparatedByDots_ReturnsFalse')
  - [IsValid_InputWithNonNumericCharactersAndNumbersSeparatedByDots_ReturnsFalse()](#M-xyLOGIX-Validators-Tests-VersionStringValidatorTests-IsValid_InputWithNonNumericCharactersAndNumbersSeparatedByDots_ReturnsFalse 'xyLOGIX.Validators.Tests.VersionStringValidatorTests.IsValid_InputWithNonNumericCharactersAndNumbersSeparatedByDots_ReturnsFalse')
  - [IsValid_InputWithNonNumericCharacters_ReturnsFalse()](#M-xyLOGIX-Validators-Tests-VersionStringValidatorTests-IsValid_InputWithNonNumericCharacters_ReturnsFalse 'xyLOGIX.Validators.Tests.VersionStringValidatorTests.IsValid_InputWithNonNumericCharacters_ReturnsFalse')
  - [IsValid_InputWithThreeNumbersSeparatedByDots_ReturnsTrue()](#M-xyLOGIX-Validators-Tests-VersionStringValidatorTests-IsValid_InputWithThreeNumbersSeparatedByDots_ReturnsTrue 'xyLOGIX.Validators.Tests.VersionStringValidatorTests.IsValid_InputWithThreeNumbersSeparatedByDots_ReturnsTrue')

<a name='T-xyLOGIX-Validators-Tests-PathnameValidatorTests'></a>
## PathnameValidatorTests `type`

##### Namespace

xyLOGIX.Validators.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[PathnameValidator](#T-xyLOGIX-Validators-PathnameValidator 'xyLOGIX.Validators.PathnameValidator') class.

<a name='F-xyLOGIX-Validators-Tests-PathnameValidatorTests-CorrectFolderPathname'></a>
### CorrectFolderPathname `constants`

##### Summary

A properly-formatted pathname on the Windows filesystem.

<a name='F-xyLOGIX-Validators-Tests-PathnameValidatorTests-CorrectFolderPathnameWithQuotes'></a>
### CorrectFolderPathnameWithQuotes `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that is the same as
[CorrectFolderPathname](#F-xyLOGIX-Validators-Tests-PathnameValidatorTests-CorrectFolderPathname 'xyLOGIX.Validators.Tests.PathnameValidatorTests.CorrectFolderPathname')
, but surrounded by quotation marks.

<a name='P-xyLOGIX-Validators-Tests-PathnameValidatorTests-PathnameValidator'></a>
### PathnameValidator `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IPathnameValidator](#T-xyLOGIX-Validators-Interfaces-IPathnameValidator 'xyLOGIX.Validators.Interfaces.IPathnameValidator') interface.

<a name='M-xyLOGIX-Validators-Tests-PathnameValidatorTests-Test_CorrectPathname_IsValidated'></a>
### Test_CorrectPathname_IsValidated() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='T-xyLOGIX-Validators-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Validators.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Validators-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Validators-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-xyLOGIX-Validators-Tests-VersionStringValidatorTests'></a>
## VersionStringValidatorTests `type`

##### Namespace

xyLOGIX.Validators.Tests

##### Summary

Unit tests for the methods and properties of the
[VersionStringValidator](#T-xyLOGIX-Validators-VersionStringValidator 'xyLOGIX.Validators.VersionStringValidator') class.

<a name='P-xyLOGIX-Validators-Tests-VersionStringValidatorTests-VersionStringValidator'></a>
### VersionStringValidator `property`

##### Summary

Gets a reference to the sole instance of the object that implements the
[IVersionStringValidator](#T-xyLOGIX-Validators-Interfaces-IVersionStringValidator 'xyLOGIX.Validators.Interfaces.IVersionStringValidator')
interface.

<a name='M-xyLOGIX-Validators-Tests-VersionStringValidatorTests-IsValid_InputWithDotAtEnd_ReturnsFalse'></a>
### IsValid_InputWithDotAtEnd_ReturnsFalse() `method`

##### Summary

Asserts that a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that ends with a dot (`.`)
will not be validated.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Validators-Tests-VersionStringValidatorTests-IsValid_InputWithDotAtStart_ReturnsFalse'></a>
### IsValid_InputWithDotAtStart_ReturnsFalse() `method`

##### Summary

Asserts that a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that starts with a dot (`.`)
will not be validated.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Validators-Tests-VersionStringValidatorTests-IsValid_InputWithLessThanThreeNumbersSeparatedByDots_ReturnsFalse'></a>
### IsValid_InputWithLessThanThreeNumbersSeparatedByDots_ReturnsFalse() `method`

##### Summary

Asserts that a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') with less than three (3) numbers,
each separated by a dot (`.`), will not be validated.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Validators-Tests-VersionStringValidatorTests-IsValid_InputWithMoreThanThreeNumbersSeparatedByDots_ReturnsFalse'></a>
### IsValid_InputWithMoreThanThreeNumbersSeparatedByDots_ReturnsFalse() `method`

##### Summary

Asserts that a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') with more than three (3) numbers,
separated by dots (`.`), will not be validated.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Validators-Tests-VersionStringValidatorTests-IsValid_InputWithNonNumericCharactersAndNumbersSeparatedByDots_ReturnsFalse'></a>
### IsValid_InputWithNonNumericCharactersAndNumbersSeparatedByDots_ReturnsFalse() `method`

##### Summary

Asserts that a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') with both non-numeric characters
and numbers, separated by dots (`.`), will not be validated.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Validators-Tests-VersionStringValidatorTests-IsValid_InputWithNonNumericCharacters_ReturnsFalse'></a>
### IsValid_InputWithNonNumericCharacters_ReturnsFalse() `method`

##### Summary

Asserts that a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') with non-numeric characters will
not be validated.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Validators-Tests-VersionStringValidatorTests-IsValid_InputWithThreeNumbersSeparatedByDots_ReturnsTrue'></a>
### IsValid_InputWithThreeNumbersSeparatedByDots_ReturnsTrue() `method`

##### Summary

Asserts that a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing three (3) numbers,
separated by dots (`.`), will be validated.

##### Parameters

This method has no parameters.
