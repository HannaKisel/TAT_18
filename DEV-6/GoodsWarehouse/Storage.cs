using System.Collections.Generic;

namespace GoodsWarehouse
{
  /// <summary>
  /// this class stores the entered goods
  /// </summary>
  class Storage
  {
    public List<Item> items = new List<Item>();
    private static Storage currentInstance;

    private Storage() { }

    public static Storage Instance
    {
      get
      {
        if (currentInstance != null)
        {
          return currentInstance;
        }
        else
        {
          currentInstance = new Storage();
          return currentInstance;
        }
      }
    }

    /// <summary>
    /// method adds new goods to the warehouse
    /// </summary>
    /// <param name="item">added goods</param>
    public void AddItem(Item item)
    {
      items.Add(item);
    }
  }
}