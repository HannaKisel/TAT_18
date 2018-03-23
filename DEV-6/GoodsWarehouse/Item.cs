using System;
using System.Text;

namespace GoodsWarehouse
{
  /// <summary>
  /// This class describes the units of the product
  /// </summary>
  public class Item
  {
    private string type;
    private string name;
    private int amount;
    private float costOfOneUnit;

    public string Type
    {
      get => type;
      set
      {
        if (value.Length > 0 || string.Empty.Equals(value))
        {
          type = value;
        }
        else
        {
          throw new FormatException("String is empty");
        }
      }
    }
    public string Name
    {
      get => name;
      set
      {
        if (value.Length > 0 || string.Empty.Equals(value))
        {
          name = value;
        }
        else
        {
          throw new FormatException("String is empty");
        }
      }
    }
    public int Amount
    {
      get
      {
        return amount;
      }
      set
      {
        if (value <= 0)
        {
          throw new FormatException("Amount should be positive");
        }
        amount = value;
      }
    }

    public float CostOfOneUnit
    {
      get
      {
        return costOfOneUnit;
      }
      set
      {
        if (value < 0.0)
        {
          throw new FormatException("Cost should be above 0");
        }
        costOfOneUnit = value;
      }
    }

    public Item(string type, string name, int amount, float costOfOneUnit)
    {
      Type = type;
      Name = name;
      Amount = amount;
      CostOfOneUnit = costOfOneUnit;
    }

    /// <summary>
    /// A method that allows you to display all the characteristics of a unit of a product
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      StringBuilder goods = new StringBuilder();
      goods.AppendLine("\nType : " + Type + "\nName : " + Name + "\nCount : " + amount + "\nPrice for one : " + costOfOneUnit);
      return goods.ToString();
    }
  }
}