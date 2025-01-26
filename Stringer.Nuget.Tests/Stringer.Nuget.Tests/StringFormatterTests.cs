namespace Stringer.Nuget.Tests
{
    [TestFixture]
    public class StringFormatterTests
    {
        [Test]
        public void ReverseString_ShouldReverseCorrectly()
        {
            // Arrange
            string input = "hello";
            string expected = "olleh";

            // Act
            string result = StringFormatter.ReverseString(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ReverseString_ShouldHandleEmptyString()
        {
            // Arrange
            string input = "";
            string expected = "";

            // Act
            string result = StringFormatter.ReverseString(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ReverseString_ShouldHandleNullInput()
        {
            // Act
            string result = StringFormatter.ReverseString(null);

            // Assert
            Assert.That(result, Is.Null);
        }

        [Test]
        public void ReverseString_ShouldHandleSingleCharacter()
        {
            // Arrange
            string input = "a";
            string expected = "a";

            // Act
            string result = StringFormatter.ReverseString(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ReverseString_ShouldHandlePalindrome()
        {
            // Arrange
            string input = "racecar";
            string expected = "racecar";

            // Act
            string result = StringFormatter.ReverseString(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ReverseString_ShouldHandleSpaces()
        {
            // Arrange
            string input = "abc def";
            string expected = "fed cba";

            // Act
            string result = StringFormatter.ReverseString(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ReverseString_ShouldHandleSpecialCharacters()
        {
            // Arrange
            string input = "!@#123";
            string expected = "321#@!";

            // Act
            string result = StringFormatter.ReverseString(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }

}