using System;
using System.Collections.Generic;

namespace MyCarSorter
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      List<Car> Cars = new List<Car>();
      Cars.Add(new Car("Rtu", "mi", 13));
      Cars.Add(new Car("Chaika", "mi", 19));
      Cars.Add(new Car("Makovik", "Nika", 19));
      Cars.Add(new Car("Maroz", "Vitaly", 32));
      Cars.Add(new Car("Maroz", "Sasha", 7));
            
      Cars.Sort(delegate (Car x, Car y)
      {
        if (x.Brand == null && y.Brand == null) return 0;
        else if (x.Brand == null) return -1;
        else if (y.Brand == null) return 1;
        else return x.Brand.CompareTo(y.Brand); ;
      });
      Console.WriteLine("Sorted by Brand with delegate");
      foreach (Car car in Cars)
      {
        Console.WriteLine(car.Brand + " - " + car.Model + " - " + car.Volume);
      }
      Console.WriteLine();

      Sorter sorter = new Sorter();
      Cars.Sort(sorter.CompareByModel);
      Console.WriteLine("Sorted by Model");
      foreach (Car car in Cars)
      {
        Console.WriteLine(car.Brand + " - " + car.Model + " - " + car.Volume);
      }
      Console.WriteLine();

      Console.WriteLine("Sorted by Volume with interface \"IComparer<Car>\"");
      CompareByVolume compareByVolume = new CompareByVolume();// This class compares cars with the interface
      Cars.Sort(compareByVolume);                           //  cars with the interface "IComparer<Car>"
      foreach (Car car in Cars)
      {
        Console.WriteLine(car.Brand + " - " + car.Model + " - " + car.Volume);
      }
      Console.WriteLine();
    }
  }
}