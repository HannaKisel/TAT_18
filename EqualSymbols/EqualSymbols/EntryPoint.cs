using System;

namespace EqualSymbols
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      //Console.Write("Enter character sequence: ");
      try
      {
        string characterSequence = args[0];
        Sequence sequence = new Sequence(characterSequence);
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