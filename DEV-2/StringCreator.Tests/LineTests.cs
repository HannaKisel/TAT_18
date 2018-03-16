using System;
using Xunit;

namespace StringCreator.Tests
{
  public class LineTests
  {
    [Theory]
    [InlineData("")]
    public void GetSymbolsByEvenPositions_EmptyLine_ArgumentException(string currentLine)
    {
      Assert.Throws<ArgumentException>(() => new Line(currentLine).GetSymbolsByEvenPositions());
    }

    [Theory]
    [InlineData("0123456789", "02468")]
    [InlineData("a", "a")]
    public void GetSymbolsByEvenPositions_Line_CorrectResult(string currentLine, string expected)
    {
      Assert.Equal(expected, new Line(currentLine).GetSymbolsByEvenPositions());
    }
  }
}