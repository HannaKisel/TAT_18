using System;

namespace NumberConverter
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      try
      {
        int number = int.Parse(args[0]);
        int systemBase = int.Parse(args[1]);
        NumberHandler numberHandler = new NumberHandler(number, systemBase);
        string resultingNumber = numberHandler.ConvertNumber();
        Console.WriteLine("Your number in the " + systemBase + " system is N=" + resultingNumber);
      }
      catch (ArgumentException)
      {
        Console.WriteLine("ArgumentExeption");
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}