using System;

namespace Cars
{
  class Menu
  {
    CommandInvoker commandInvoker = new CommandInvoker();

    public void GetActionsMenu()
    {
      string action;
      do
      {
        Console.WriteLine("Enter'add car' to add needed options.");
        Console.WriteLine("Enter 'check storage' to get information about produced cars waiting in storage");
        Console.WriteLine("Enter 'show cars in storage' to take out the available cars.");
        Console.WriteLine("Enter 'exit' to exit from the program.");
        action = Console.ReadLine();
        Console.Clear();
      }
      while (CommandSwitcher(action));
    }

    private bool CommandSwitcher(string action)
    {
      bool key = true;
      switch (action)
      {
        case "add car":
          commandInvoker.SetCommand(new AddNewCarToCatalog());
          commandInvoker.Run();
          break;
        case "check storage":
          commandInvoker.SetCommand(new CheckCarStorageAction());
          commandInvoker.Run();
          break;
        case "show cars in storage":
          commandInvoker.SetCommand(new ShowCarsInStorage());
          commandInvoker.Run();
          break;
        case "exit":
          key = false;
          break;
        default:
          Console.Clear();
          Console.WriteLine("We don't know this command. Please try again.");
          GetActionsMenu();
          break;
      }
      return key;
    }
  }
}