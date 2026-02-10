using Xunit;
using MyLibrary;

namespace MyLibrary.Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_TwoNumbers_ReturnsSum()
    {
        var result = Calculator.Add(2, 3);
        Assert.Equal(5, result);
    }
}