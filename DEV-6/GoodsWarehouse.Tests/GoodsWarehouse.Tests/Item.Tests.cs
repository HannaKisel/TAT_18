using NUnit.Framework;
using System;

namespace GoodsWarehouse.Tests
{
  [TestFixture]
  public class StorageTests
  {
    [Test, TestCase("Type", "Name", 2, -2)]
    [TestCase("Type", "Name", -3, 2)]
    public void Item_CreatNewItem_ExceptionExpected(string type, string name, int amount, float costOfOneUnit)
    {
      Assert.Throws<FormatException>(() => new Item(type, name, amount, costOfOneUnit));
    }
  }
}