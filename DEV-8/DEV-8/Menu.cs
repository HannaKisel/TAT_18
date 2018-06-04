using System;

namespace DEV_8
{
  class Menu
  {
    CommandReceiver commandReciever = new CommandReceiver();
    CommandInvoker commandInvoker = new CommandInvoker();

    public void GetMenu()
    {
      string action;
      do
      {
        Console.WriteLine("Available commands:\n" +
       "1) press \"Add user\"- to add new user\n" +
       "2) press \"Get elder\"- to get elder user\n" +
       "3) press \"Get average age\"- to get everage age of users\n" +
       "4) press \"Get popular woman name\"- to get the most popular womans name");
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
        case "Add user":
          commandInvoker.SetCommand(new AddUserCommand());
          break;
        case "Get average age":
          Console.WriteLine("Average age is ");
          commandInvoker.SetCommand(new GetAverageAgeCommand());
          break;
        case "Get elder":
          Console.WriteLine("Elder user is ");
          commandInvoker.SetCommand(new GetOldestPersonCommand());
          break;
        case "Get popular woman name":
          commandInvoker.SetCommand(new GetMostPopularWomanNameCommand());
          break;
        default:
          Console.Clear();
          Console.WriteLine("We don't know this command. Please try again.");
          break;
      }
      commandInvoker.Run();
      return key;
    }
  }
}