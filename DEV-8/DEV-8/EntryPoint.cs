using System;

namespace DEV_8
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      try
      {
        Menu menu = new Menu();
        menu.GetMenu();
      }
      catch (Exception exception)
      {
        Console.WriteLine(exception.Message);
      }
    }
  }
}