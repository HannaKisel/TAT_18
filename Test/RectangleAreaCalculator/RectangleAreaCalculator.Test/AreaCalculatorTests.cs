using System;
using Xunit;

namespace RectangleAreaCalculator.Test
{
  public class AreaCalculatorTests
  {
    [Theory]
    [InlineData(10, 2.3, 23)]
    public void CalculateArea_TrueValueExpected(double length, double width, double expected)
    {
      Assert.Equal(expected, new AreaCalculator(length, width).CalculateArea());
    }

    [Theory]
    [InlineData(10, -7)]
    [InlineData(-10, 7)]
    public void CalculateArea_ArgumentException(double length, double width)
    {
      Assert.Throws<ArgumentException>(() => new AreaCalculator(length, width).CalculateArea());
    }
  }
}