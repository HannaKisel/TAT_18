using System;

namespace EqualSymbols
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      try
      {
        Sequence sequence = new Sequence(args[0]);
        int maxRepetitions = sequence.DetermineMaxOfRepetitions();
        Console.WriteLine("Maximum symbol repetition = " + maxRepetitions);
      }
      catch (FormatException)
      {
        Console.WriteLine("FormatException");
      }
    }
  }
}