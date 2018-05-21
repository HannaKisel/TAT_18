using System;

namespace RectangleAreaCalculator
{
  /// <summary>
  /// Class containing a method that counts the area of a rectangle
  /// </summary>
  public class AreaCalculator
  {
    private double lenght;
    private double width;

    public double Length
    {
      get
      {
        return lenght;
      }
      set
      {
        if (value < 0.0)
        {
          throw new ArgumentException();
        }
        lenght = value;
      }
    }

    public double Width
    {
      get
      {
        return width;
      }
      set
      {
        if (value < 0.0)
        {
          throw new ArgumentException();
        }
        width = value;
      }
    }

    public AreaCalculator(double length, double width)
    {
      Length = length;
      Width = width;
    }

    /// <summary>
    /// Method considers the area of a rectangle
    /// </summary>
    /// <returns></returns>
    public double CalculateArea()
    {
      return Length * Width;
    }
  }
}