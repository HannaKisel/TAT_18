using System;

namespace GoodsWarehouse
{
  class EntryPoint
  {
    const string EXIT = "exit";

    static void Main()
    {
      do
      {
        try
        {
          int addProduct = 1;
          while (addProduct == 1)
          {
            Console.WriteLine("Enter the product and its data ");
            ItemReader itemReader = new ItemReader();
            Item newItem = itemReader.GetNewItem();
            Storage.Instance.AddItem(newItem);
            Console.WriteLine();
            Console.WriteLine("Do you wanna add another one? If yep press 1, no-any number");
            addProduct = int.Parse(Console.ReadLine());
          }
          Menu menu = new Menu();
          menu.DisplayMenu();
          bool continueInputCommands = true;
          while (continueInputCommands == true)
          {
            string command = Console.ReadLine();
            if (command.Equals(EXIT))
            {
              return;
            }
            else
            {
              CommandsInvoker commandsInvoker = new CommandsInvoker();
              commandsInvoker.GetCommand(command, Storage.Instance.items);
            }
          }
        }
        catch (FormatException ex)
        {
          Console.WriteLine(ex.Message);
        }
      }
      while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
  }
}