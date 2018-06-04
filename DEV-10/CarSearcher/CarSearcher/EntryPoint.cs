using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace CarSearcher
{
  class EntryPoint
  {
    const string siteUrl = "https://av.by/";

    static void Main(string[] args)
    {
      try
      {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl(siteUrl);
        HomePage homePage = new HomePage(driver);
        homePage.ClosePopUpIfExist().ClickOnShowAllMarksButton();
        MarkPage markPage = homePage.NavigateToNewMarkPage(args[0]);
        Dictionary<string, string> modelsList = markPage.CreateDictionaryCar();
        CarDictionaryHandler carDictionary = new CarDictionaryHandler();
        List<KeyValuePair<string, string>> sortedCarsByCount = carDictionary.SortCarDictionaryInDescendingOrder(modelsList);
        carDictionary.DisplayListOfModelsInConsole(sortedCarsByCount);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}