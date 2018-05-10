using OpenQA.Selenium;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CarSercher
{
  /// <summary>
  /// This class contains methods that work with the selected brand page
  /// </summary>
  class MarkPage
  {
    private By Models = By.XPath("//ul[@class='brandslist']//span");
    private By ModelsCount = By.XPath("//ul[@class='brandslist']//small");
    private List<string> modelsList;
    private List<string> modelsCountsList;
    public IWebDriver Driver { get; private set; }

    public MarkPage(IWebDriver driver)
    {
      Driver = driver;
    }

    /// <summary>
    /// The method collects all the brands to list
    /// </summary>
    /// <returns></returns>
    public MarkPage GetModelsNames()
    {
      ReadOnlyCollection<IWebElement> elementsList = Driver.FindElements(Models);
      modelsList = new List<string>();
      foreach (IWebElement element in elementsList)
      {
        modelsList.Add(element.Text);
      }
      return this;
    }

    /// <summary> 
    /// The method collects the number of copies of brands to list
    /// </summary>
    /// <returns></returns>
    public MarkPage GetModelsCount()
    {
      ReadOnlyCollection<IWebElement> elementsList = Driver.FindElements(ModelsCount);
      modelsCountsList = new List<string>();
      foreach (IWebElement element in elementsList)
      {
        modelsCountsList.Add(element.Text);
      }
      return this;
    }

    /// <summary>
    /// The method collects all the names and corresponding quantities of copies of brands to dictionary
    /// </summary>
    /// <returns></returns>
    public Dictionary<string, string> CreateDictionaryCar()
    {
      GetModelsCount();
      GetModelsNames();
      Dictionary<string, string> listModelsAndCounts = new Dictionary<string, string>();
      for (int i = 0; i < modelsList.Count; i++)
      {
        listModelsAndCounts.Add(modelsList[i], modelsCountsList[i]);
      }
      return listModelsAndCounts;
    }
  }
}