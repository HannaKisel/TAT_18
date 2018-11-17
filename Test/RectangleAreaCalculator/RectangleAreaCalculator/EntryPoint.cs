using System;

namespace RectangleAreaCalculator
{
  public class EntryPoint
  {
    static void Main(string[] args)
    {
      try
      {
        AreaCalculator areaCalculator = new AreaCalculator(double.Parse(args[0]), double.Parse(args[1]));
        Console.WriteLine(areaCalculator.CalculateArea());
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}