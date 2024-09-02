using Xunit;

namespace StringManipulation.Tests;

public class StringOperationsTest
{
    [Fact]
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
}