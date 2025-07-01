namespace GameCore.Tests;

public class CalculatorTests
{
    private readonly Calculator _calculator;

    public CalculatorTests()
    {
        _calculator = new Calculator();
    }

    [Fact]
    public void Sum_TwoPositiveIntegers_ReturnsCorrectSum()
    {
        // Arrange
        int a = 5;
        int b = 3;
        int expected = 8;

        // Act
        int result = _calculator.Sum(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Sum_TwoNegativeIntegers_ReturnsCorrectSum()
    {
        // Arrange
        int a = -5;
        int b = -3;
        int expected = -8;

        // Act
        int result = _calculator.Sum(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Sum_PositiveAndNegativeInteger_ReturnsCorrectSum()
    {
        // Arrange
        int a = 10;
        int b = -4;
        int expected = 6;

        // Act
        int result = _calculator.Sum(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Sum_MultipleIntegers_ReturnsCorrectSum()
    {
        // Arrange
        int[] numbers = { 1, 2, 3, 4, 5 };
        int expected = 15;

        // Act
        int result = _calculator.Sum(numbers);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Sum_EmptyArray_ReturnsZero()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();
        int expected = 0;

        // Act
        int result = _calculator.Sum(numbers);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Sum_TwoDecimals_ReturnsCorrectSum()
    {
        // Arrange
        decimal a = 5.5m;
        decimal b = 3.2m;
        decimal expected = 8.7m;

        // Act
        decimal result = _calculator.Sum(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Sum_ListOfDecimals_ReturnsCorrectSum()
    {
        // Arrange
        var numbers = new List<decimal> { 1.1m, 2.2m, 3.3m, 4.4m };
        decimal expected = 11.0m;

        // Act
        decimal result = _calculator.Sum(numbers);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(1, 1, 2)]
    [InlineData(100, 200, 300)]
    [InlineData(-50, 50, 0)]
    public void Sum_VariousIntegerInputs_ReturnsExpectedResults(int a, int b, int expected)
    {
        // Act
        int result = _calculator.Sum(a, b);

        // Assert
        Assert.Equal(expected, result);
    }
}
