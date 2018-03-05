using System;

namespace StringCreator
{
  class EntryPoint
  {
    private const string LENGTHERROR = "This sring is empty. Try again or press Esc to exit.";
    private const string RESTARTMESSAGE = "For exit press Esc or press any key to continue.";

    static void Main(string[] args)
    {
      do
      {
        try
        {
          Console.Write("Enter string: ");
          string currentLine = Console.ReadLine();
          Line line = new Line(currentLine);
          Console.WriteLine(line.GetSymbolsByEvenPositions());
        }
        catch (ArgumentException)
        {
          Console.WriteLine(LENGTHERROR);
          continue;
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.Message);
        }
        Console.WriteLine();
      }
      while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
  }
}