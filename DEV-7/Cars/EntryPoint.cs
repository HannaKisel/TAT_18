using System;

namespace Cars
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      try
      {
        Menu menu = new Menu();
        menu.GetActionsMenu();
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}