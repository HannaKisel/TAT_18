using System;

namespace DEV_8
{
  /// <summary>
  /// This class contains methods for providing menus to the user
  /// </summary>
  class Menu
  {
    CommandReciever commandReciever = new CommandReciever();
    
    /// <summary>
    /// This metod gets menu
    /// </summary>
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
          commandReciever.AddUser();
          break;
        case "Get average age":
          Console.WriteLine("Average age is ");
          commandReciever.GetAverageAge();
          break;
        case "Get elder":
          Console.WriteLine("Elder user is ");
          commandReciever.GetEldestUser();
          break;
        case "Get popular woman name":
          commandReciever.GetPopularWomanName();
          break;
        default:
          Console.Clear();
          Console.WriteLine("We don't know this command. Please try again.");
          break;
      }
      return key;
    }
  }
}