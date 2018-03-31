using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Cars
{
  public class Catalog
  {
    public List<CarOptions> Cars { get; private set; }
    private string carsJson;
    private const string pathToJsonFileWithCars = @"C:\Users\user\source\repos\Cars\Catalog.json";

    public Catalog()
    {
      Cars = new List<CarOptions>();
    }

    public void AddToCatalog(CarOptions car)
    {
      Cars.Add(car);
      carsJson = JsonConvert.SerializeObject(Cars);
      File.WriteAllText(pathToJsonFileWithCars, carsJson);
    }

    public List<CarOptions> GetCatalog()
    {
      return JsonConvert.DeserializeObject<List<CarOptions>>(File.ReadAllText(pathToJsonFileWithCars));
    }
  }
}