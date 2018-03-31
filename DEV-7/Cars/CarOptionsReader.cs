using System;

namespace Cars
{
  public class CarOptionsReader
  {
    public CarOptions GetOrder()
    {
      CarOptions newCar = new CarOptions();
      Console.WriteLine("Enter the options you are interested in otherwise, type -");
      Console.WriteLine("Enter brand");
      newCar.Brand = Console.ReadLine();
      Console.WriteLine("Enter model");
      newCar.Model = Console.ReadLine();
      Console.WriteLine("Enter type of body (estate, sedan, minivan, coupe);");
      newCar.CarcaseType = Console.ReadLine();
      Console.WriteLine("Enter type of transmission (manual, automatic);");
      newCar.TransmissionType = Console.ReadLine();
      Console.WriteLine("Enter type of engine (gasoline, diesel, electro);");
      newCar.EngineType = Console.ReadLine();
      Console.WriteLine("Enter volume");
      newCar.EngineSize = Console.ReadLine();
      Console.WriteLine("Enter power");
      newCar.EnginePower = Console.ReadLine();
      Console.WriteLine("Enter climate control: air conditioning, climate control, -");
      newCar.ClimateControle = Console.ReadLine();
      Console.WriteLine("Enter type of interior (leather, fabric, combined)");
      newCar.CabinType = Console.ReadLine();
      return newCar;
    }
  }
}