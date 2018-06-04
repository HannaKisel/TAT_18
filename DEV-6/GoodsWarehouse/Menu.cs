using System;

namespace GoodsWarehouse
{
  /// <summary>
  /// this class has a method for implementing the menu
  /// </summary>
  class Menu
  {
    /// <summary>
    /// This method displays a menu
    /// </summary>
    public void DisplayMenu()
    {
      Console.WriteLine("Available commands: ");
      Console.WriteLine("  count types - display the number of product types");
      Console.WriteLine("  count all - display count of products;");
      Console.WriteLine("  average price - display average price of all products;");
      Console.WriteLine("  average price type - display average product type price;");
      Console.WriteLine("  exit - quit the program\n");
    }
  }
}