namespace DuckPipeline.Tests;

using Xunit;

public class DuckTests
{
    [Theory]
    [InlineData("Kalle", "Kalle quacks!")]
    [InlineData("Donald", "Donald quacks!")]
    [InlineData("Daisy", "Daisy quacks!")]
    public void Quack_ReturnsCorrectText(string name, string expected)
    {
        // Arrange
        Duck duck = new() { Name = name };

        // Act
        string result = duck.Quack();

        // Assert
        Assert.Equal(expected, result);
    }
}