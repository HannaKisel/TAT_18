using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSearcher
{
  /// <summary>
  /// This class contains methods that allow you to perform some manipulations on the list of models
  /// </summary>
  class CarDictionaryHandler
  {
    /// <summary>
    /// This class sorts the list of models by decreasing the number of copies
    /// </summary>
    /// <param name="DictionaryOfModelsWithQuantity"></param>
    /// <returns></returns>
    public List<KeyValuePair<string, string>> SortCarDictionaryInDescendingOrder(Dictionary<string, string> DictionaryOfModelsWithQuantity)
    {
      return (from u in DictionaryOfModelsWithQuantity
              orderby int.Parse(u.Value)
              descending
              select u).ToList();
    }

    /// <summary>
    /// This class displays a list of available cars on the console
    /// </summary>
    /// <param name="sortedCarsByCount"></param>
    public void DisplayListOfModelsInConsole(List<KeyValuePair<string, string>> modelsList)
    {
      Console.WriteLine("\n All available cars on the site with the selected car brand");
      foreach (var model in modelsList)
      {
        Console.WriteLine("{0}: {1}", model.Key, model.Value);
      }
    }
  }
}