using System;

namespace CountDaysFromChristBirthday
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      try
      {
        Console.WriteLine("Enter day in format dd.mm.year");
        DateTime date = DateTime.Parse(Console.ReadLine());
        ChristService.DaysCounter dateCounter = new ChristService.DaysCounter();
        Console.WriteLine(dateCounter.CountDays(date));
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}