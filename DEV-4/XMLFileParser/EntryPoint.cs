using System;
using System.Collections;
using System.IO;

namespace XMLFileParser
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      string containsOfFile = File.ReadAllText(args[0]);
      FileParser fileParser = new FileParser();

      /*
      FileComtainsManipulator fileComtainsManipulator = new FileComtainsManipulator(args[0]);
      ArrayList array = fileComtainsManipulator.ReadFromFile();
      /*Console.Write("Contains of file:");
      foreach (string el in array)
      {
        Console.WriteLine(el);
      }

      FileParser fileParser = new FileParser();
      string rootEl=fileParser.FindTheRootElement(array);
      /* Console.WriteLine("hhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh"+array[1]);
      Console.WriteLine("Root El=" + rootEl);*/
    }
  }
}