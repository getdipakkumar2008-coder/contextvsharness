using HarnessEngineeringAdd;
using Xunit;

namespace HarnessEngineeringAdd.Tests;

public class CalculatorTests
{
    private readonly Calculator _calculator = new();

    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(-2, -3, -5)]
    [InlineData(-5, 5, 0)]
    [InlineData(0, 0, 0)]
    [InlineData(2.5, 2.5, 5.0)]
    public void Add_ReturnsExpectedSum(double a, double b, double expected)
    {
        double result = _calculator.Add(a, b);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(5, 3, 2)]
    [InlineData(-2, -3, 1)]
    [InlineData(-5, 5, -10)]
    [InlineData(0, 0, 0)]
    [InlineData(5.5, 2.5, 3.0)]
    public void Subtract_ReturnsExpectedDifference(double a, double b, double expected)
    {
        double result = _calculator.Subtract(a, b);
        Assert.Equal(expected, result);
    }
}
