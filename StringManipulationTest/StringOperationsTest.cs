using Xunit;
using Microsoft.Extensions.Logging;
using Moq;

namespace StringManipulation.Tests;

public class StringOperationsTest
{
    [Fact(Skip = "This test is skipped")]
    public void ConcatenateStrings()
    {
        // Arrange
        var strOperations = new StringOperations();

        // Act
        var result = strOperations.ConcatenateStrings("Hello", "World");

        // Assert
        Assert.Equal("Hello World", result);
        Assert.NotNull(result);
        Assert.NotEmpty(result);
    }

    [Fact]
    public void IsPalindrome()
    {
        // Arrange
        var strOperations = new StringOperations();

        // Act
        var result = strOperations.IsPalindrome("madam");

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPalindrome_False()
    {
        // Arrange
        var strOperations = new StringOperations();

        // Act
        var result = strOperations.IsPalindrome("hello");

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void QuantityInWords()
    {
        // Arrange
        var strOperations = new StringOperations();

        // Act
        var result = strOperations.QuantintyInWords("cat", 10);

        // Assert
        Assert.StartsWith("ten", result);
        Assert.Contains("cat", result);
    }

    [Fact]
    public void GetStringLength_Exception()
    {
        // Arrange
        var strOperations = new StringOperations();

        // Assert
        Assert.ThrowsAny<ArgumentNullException>(() => strOperations.GetStringLength(null));
    }

    [Theory]
    [InlineData("V", 5)]
    [InlineData("X", 10)]
    public void FromRomanToNumber(string romanNumber, int expected)
    {
        // Arrange
        var strOperations = new StringOperations();

        // Act
        var result = strOperations.FromRomanToNumber(romanNumber);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact(Skip = "This test is skipped")]
    public void CountOccurrences()
    {
        // Arrange
        var mockLogger = new Mock<ILogger<StringOperations>>();
        var strOperations = new StringOperations();

        // Act
        var result = strOperations.CountOccurrences("hello", 'l');

        // Assert
        Assert.Equal(2, result);
    }

    // [Fact(Skip = "This test is skipped")]
    // public void ReadFile()
    // {
    //     // Arrange
    //     var strOperations = new StringOperations();
    //     var mockFileReader = new Mock<IFileReaderConector>();

    //     mockFileReader.Setup(x => x.ReadFile("file.txt")).Returns("Reading file");

    //     // Act
    //     var result = strOperations.ReadFile(mockFileReader.Object, "file.txt");

    //     // Assert
    //     Assert.Equal("Reading file", result);
    // }
}