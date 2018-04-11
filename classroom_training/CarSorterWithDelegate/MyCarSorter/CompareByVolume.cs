using System.Collections.Generic;

namespace MyCarSorter
{
  /// <summary>
  /// this class compares cars by brand using the interface "IComparer<Car>"
  /// </summary>
  class CompareByVolume : IComparer<Car>
  {
    /// <summary>
    /// This method compares cars by brand using the interface "IComparer<Car>"
    /// </summary>
    /// <param name="firstCar"></param>
    /// <param name="secondCar"></param>
    /// <returns></returns>
    public int Compare(Car firstCar, Car secondCar)
    {
      if (firstCar.Volume == null)
      {
        if (secondCar.Volume == null)
        {
          return 0;
        }
        else
        {
          return -1;
        }
      }
      else
      {
        if (secondCar.Volume == null)
        {
          return 1;
        }
        else
        {
          return firstCar.Volume.CompareTo(secondCar.Volume);
        }
      }
    }
  }
}