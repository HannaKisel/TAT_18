using NUnit.Framework;
using System;

namespace NumberConverter.Tests
{
  [TestFixture]
  public class NumberHandlerTests
  {
    [Test, TestCase(10, 2, "1010")]
    [TestCase(10, 20, "A")]
    [TestCase(0, 20, "0")]
    [TestCase(49, 10, "49")]
    [TestCase(int.MaxValue, 16, "7FFFFFFF")]
    public void ConvertNumber_TrueValueExpected(int number, int systemBase, string expected)
    {
      Assert.AreEqual(expected, new NumberHandler(number, systemBase).ConvertNumber());
    }

    [Test, TestCase(-10, 20)]
    [TestCase(10, -1)]
    [TestCase(10, 21)]
    public void ConvertNegativeNumber_FalseValueExpected(int number, int systemBase)
    {
      Assert.Throws<ArgumentException>(() => new NumberHandler(number, systemBase).ConvertNumber());
    }
  }
}