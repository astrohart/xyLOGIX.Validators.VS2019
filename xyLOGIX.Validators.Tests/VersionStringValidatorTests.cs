using NUnit.Framework;
using NUnit.Framework.Legacy;
using xyLOGIX.Validators.Factories;
using xyLOGIX.Validators.Interfaces;

namespace xyLOGIX.Validators.Tests
{
    /// <summary>
    /// Unit tests for the methods and properties of the
    /// <see cref="T:xyLOGIX.Validators.VersionStringValidator" /> class.
    /// </summary>
    [TestFixture]
    public class VersionStringValidatorTests
    {
        /// <summary>
        /// Gets a reference to the sole instance of the object that implements the
        /// <see cref="T:xyLOGIX.Validators.Interfaces.IVersionStringValidator" />
        /// interface.
        /// </summary>
        private static IVersionStringValidator VersionStringValidator { get; } =
            GetVersionStringValidator.SoleInstance();

        /// <summary>
        /// Asserts that a <see cref="T:System.String" /> that ends with a dot (<c>.</c>)
        /// will not be validated.
        /// </summary>
        [Test]
        public void IsValid_InputWithDotAtEnd_ReturnsFalse()
        {
            // Arrange
            var input = "123.456.";

            // Act
            var result = VersionStringValidator.IsValid(input);

            // Assert
            ClassicAssert.IsFalse(result);
        }

        /// <summary>
        /// Asserts that a <see cref="T:System.String" /> that starts with a dot (<c>.</c>)
        /// will not be validated.
        /// </summary>
        [Test]
        public void IsValid_InputWithDotAtStart_ReturnsFalse()
        {
            // Arrange
            var input = ".123.456";

            // Act
            var result = VersionStringValidator.IsValid(input);

            // Assert
            ClassicAssert.IsFalse(result);
        }

        /// <summary>
        /// Asserts that a <see cref="T:System.String" /> with less than three (3) numbers,
        /// each separated by a dot (<c>.</c>), will not be validated.
        /// </summary>
        [Test]
        public void
            IsValid_InputWithLessThanThreeNumbersSeparatedByDots_ReturnsFalse()
        {
            // Arrange
            var input = "123.456";

            // Act
            var result = VersionStringValidator.IsValid(input);

            // Assert
            ClassicAssert.IsFalse(result);
        }

        /// <summary>
        /// Asserts that a <see cref="T:System.String" /> with more than three (3) numbers,
        /// separated by dots (<c>.</c>), will not be validated.
        /// </summary>
        [Test]
        public void
            IsValid_InputWithMoreThanThreeNumbersSeparatedByDots_ReturnsFalse()
        {
            // Arrange
            var input = "123.456.789.101";

            // Act
            var result = VersionStringValidator.IsValid(input);

            // Assert
            ClassicAssert.IsFalse(result);
        }

        /// <summary>
        /// Asserts that a <see cref="T:System.String" /> with non-numeric characters will
        /// not be validated.
        /// </summary>
        [Test]
        public void IsValid_InputWithNonNumericCharacters_ReturnsFalse()
        {
            // Arrange
            var input = "abc.def.ghi";

            // Act
            var result = VersionStringValidator.IsValid(input);

            // Assert
            ClassicAssert.IsFalse(result);
        }

        /// <summary>
        /// Asserts that a <see cref="T:System.String" /> with both non-numeric characters
        /// and numbers, separated by dots (<c>.</c>), will not be validated.
        /// </summary>
        [Test]
        public void
            IsValid_InputWithNonNumericCharactersAndNumbersSeparatedByDots_ReturnsFalse()
        {
            // Arrange
            var input = "abc.123.def";

            // Act
            var result = VersionStringValidator.IsValid(input);

            // Assert
            ClassicAssert.IsFalse(result);
        }

        /// <summary>
        /// Asserts that a <see cref="T:System.String" /> containing three (3) numbers,
        /// separated by dots (<c>.</c>), will be validated.
        /// </summary>
        [Test]
        public void IsValid_InputWithThreeNumbersSeparatedByDots_ReturnsTrue()
        {
            // Arrange
            var input = "123.456.789";

            // Act
            var result = VersionStringValidator.IsValid(input);

            // Assert
            ClassicAssert.IsTrue(result);
        }
    }
}