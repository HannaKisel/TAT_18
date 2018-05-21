using System;

namespace HelloWorld
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello, world!\nAnd hi again!");
      Random random = new Random();
      int exclamationNumber = random.Next(5, 50);
      for (int i = 0; i < exclamationNumber; i++)
      {
        Console.Write("!");
      }
    }
  }
}