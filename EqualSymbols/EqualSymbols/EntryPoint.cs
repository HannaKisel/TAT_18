using System;

namespace EqualSymbols
{
  class EntryPoint
  {
    static void Main()
    {
      Console.Write("Enter character sequence: ");
      try
      {
        string characterSequence = Console.ReadLine();
        WorkerWithString workerWithString = new WorkerWithString();
        int maxRepetitions = workerWithString.DetermineMaxOfRepetitions(characterSequence);
        Console.WriteLine("Maximum symbol repetition = " + maxRepetitions);
      }
      catch (FormatException)
      {
        Console.WriteLine("FormatException");
      }
    }
  }
}