using System;
using System.Collections.Generic;
using System.Linq;

namespace Cars
{
  class CommandReceiver
  {
    public CarOptionsReader carOptionsReader = new CarOptionsReader();
    private Catalog carsCatalog;
    public Catalog CarsCatalog
    {
      get
      {
        if (carsCatalog != null)
        {
          return carsCatalog;
        }
        else
        {
          carsCatalog = new Catalog();
          return carsCatalog;
        }
      }
    }

    public void SetOptions()
    { }

    public void AddCarToCatalog()
    {
      CarsCatalog.AddToCatalog(carOptionsReader.GetOrder());
    }

    public void ShowCars()
    {
      foreach (CarOptions car in CarsCatalog.GetCatalog())
      {
        car.GetOptionsToConsole();
      }
    }

    public void GiveSuitableMachines()
    {
      CarOptions carOptions = carOptionsReader.GetOrder();
      Console.WriteLine("Suitable machines is:");
      IEnumerable<CarOptions> cars = CheckCarStorage(carOptions);
      foreach (CarOptions car in cars)
      {
        car.GetOptionsToConsole();
      }
    }

    private IEnumerable<CarOptions> CheckCarStorage(CarOptions carOptions)
    {
      List<CarOptions> catalog = carsCatalog.GetCatalog();
      var selectedVariants = from item in catalog
                             where ((item.Brand == carOptions.Brand) &&
                             (item.Model == carOptions.Model || item.Model == "-") &&
                             (item.CarcaseType == carOptions.CarcaseType || item.Model == "-") &&
                             (item.TransmissionType == carOptions.TransmissionType || item.Model == "-") &&
                             (item.EngineType == carOptions.EngineType || item.Model == "-") &&
                             (item.EngineSize == carOptions.EngineSize || item.Model == "-") &&
                             (item.EnginePower == carOptions.EnginePower || item.Model == "-") &&
                             (item.ClimateControle == carOptions.ClimateControle || item.Model == "-") &&
                             (item.CabinType == carOptions.CabinType || item.Model == "-"))
                             select item;
      return selectedVariants;
    }
    public void CheckCatalog()
    { }
  }
}