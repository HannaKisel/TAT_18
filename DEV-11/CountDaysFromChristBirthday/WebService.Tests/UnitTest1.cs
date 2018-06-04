using System;
using Xunit;
using ChristWebService;

namespace WebService.Tests
{
  public class UnitTest1
  {
    [Theory]
    [InlineData(1, 1, 0001, 1)]
    public void CountDaysTest(int day, int month, int year, int expected)
    {
      DateTime date = new DateTime(year, month, day);
      DaysCounter days = new DaysCounter(); 
      int received = days.CountDays(date);
      Assert.Equal(expected, received);
    }
  }
}