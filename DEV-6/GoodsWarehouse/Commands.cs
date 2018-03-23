using System;
using System.Collections.Generic;

namespace GoodsWarehouse
{
  /// <summary>
  /// In this class all possible commands are implemented
  /// </summary>
  class Commands
  {
    /// <summary>
    /// This method gives the number of entered commodity types
    /// </summary>
    /// <param name="command"></param>
    /// <param name="items"></param>
    public void GetCountTypes(string command, List<Item> items)
    {
      Console.WriteLine(items.Count);
    }

    /// <summary>
    /// This method gives the total number of goods entered
    /// </summary>
    /// <param name="command"></param>
    /// <param name="items"></param>
    public void GetCountAll(string command, List<Item> items)
    {
      int totalCount = 0;
      foreach (Item item in items)
      {
        totalCount += item.Amount;
      }
      Console.WriteLine(totalCount);
    }

    /// <summary>
    /// this method gives the average cost of goods
    /// </summary>
    /// <param name="command"></param>
    /// <param name="items"></param>
    public void GetAveragePrice(string command, List<Item> items)
    {
      double totalPrice = 0;
      foreach (Item item in items)
      {
        totalPrice += item.CostOfOneUnit;
      }
      double averagePrice = totalPrice / items.Count;
      Console.WriteLine(averagePrice);
    }

    /// <summary>
    /// This method gives the average cost of a certain type of goods
    /// </summary>
    /// <param name="command"></param>
    /// <param name="items"></param>
    /// <param name="type"></param>
    public void GetAveragePriceOfTheType(string command, List<Item> items, string type)
    {
      double totalPriceForOneType = 0;
      int typeCount = 0;
      foreach (Item item in items)
      {
        if (type.Equals(item.Type))
        {
          totalPriceForOneType += item.CostOfOneUnit;
          typeCount++;
        }
      }
      if (typeCount == 0)
      {
        throw new FormatException("Type is absent");
      }
      double averagePriceForOneType = totalPriceForOneType / typeCount;
      Console.WriteLine(averagePriceForOneType);
    }
  }
}