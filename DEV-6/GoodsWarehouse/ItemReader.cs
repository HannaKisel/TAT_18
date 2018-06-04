using System;

namespace GoodsWarehouse
{
  class ItemReader
  {
    public Item GetNewItem()
    {
      Console.WriteLine("Enter the type of the product");
      string type = Console.ReadLine();
      Console.WriteLine("Enter the name of the product");
      string name = Console.ReadLine();
      Console.WriteLine("Enter the amount of the product");
      int amount = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter the cost of one unit of the product");
      float costOfOneUnit = float.Parse(Console.ReadLine());
      return new Item(type, name, amount, costOfOneUnit);
    }
  }
}