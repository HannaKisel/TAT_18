using System;
using System.Collections.Generic;

namespace GoodsWarehouse
{
  /// <summary>
  /// This class contains a method that selects the required command
  /// </summary>
  class CommandsInvoker
  {
    /// <summary>
    /// method that selects the required command
    /// </summary>
    /// <param name="command">command that was introduced</param>
    /// <param name="items">container of goods</param>
    public void GetCommand(string command, List<Item> items)
    {
      Commands commands = new Commands();
      switch (command)
      {
        case "count types":
          commands.GetCountTypes(command, items);
          break;
        case "count all":
          commands.GetCountAll(command, items);
          break;
        case "average price":
          commands.GetAveragePrice(command, items);
          break;
        case "average price type":
          Console.Write("Enter type ");
          string type = Console.ReadLine();
          commands.GetAveragePriceOfTheType(command, items, type);
          break;
        default:
          throw new FormatException("String is empty");
      }
    }
  }
}