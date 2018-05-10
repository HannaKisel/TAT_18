using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace CarSercher
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      IWebDriver driver = new ChromeDriver();
      driver.Manage().Window.Maximize();
      driver.Navigate().GoToUrl("https://av.by/");
      Console.Clear();
      HomePage homePage = new HomePage(driver);
      homePage.ClosePopUpIfExist().ClickOnShowAllMarksButton();
      MarkPage markPage = homePage.ClickOnCarMark("Audi");
      Dictionary<string, string> modelsList = markPage.CreateDictionaryCar();
      CarDictionaryHandler carDictionary = new CarDictionaryHandler();
      List<KeyValuePair<string, string>> sortedCarsByCount = carDictionary.SortCarDictionaryInDescendingOrder(modelsList);
      carDictionary.DisplayListOfModelsInConsole(sortedCarsByCount);
    }
  }
}