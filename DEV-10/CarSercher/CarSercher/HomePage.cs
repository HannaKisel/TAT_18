using OpenQA.Selenium;
using System;

namespace CarSercher
{
  /// <summary>
  /// This class contains methods that work with the home page of the site
  /// </summary>
  class HomePage
  {
    private string carMark = "//span[text()='{0}']/parent::a[@href]";
    private By ShowAllMarksButton = By.XPath("//a[@class='js-brands-show-all']");
    private By ClosePopUpButton = By.XPath("//span[@class='survey-popup-close js-survey-popup-close']");
    private By AllBrands = By.XPath("//div[@class='brands']");
    public IWebDriver Driver { get; private set; }

    public HomePage(IWebDriver driver)
    {
      Driver = driver;
    }

    /// <summary>
    /// The method closes pop-up ads, if one exists
    /// </summary>
    /// <returns></returns>
    public HomePage ClosePopUpIfExist()
    {
      IWebElement closePopUpButton = Driver.FindElement(ClosePopUpButton);
      if (closePopUpButton.Displayed)
      {
        closePopUpButton.Click();
      }
      return this;
    }

    /// <summary>
    /// The method presses the button to show all cars
    /// </summary>
    /// <returns></returns>
    public HomePage ClickOnShowAllMarksButton()
    {
      Driver.FindElement(ShowAllMarksButton).Click();
      return this;
    }

    /// <summary>
    /// the method presses the button of the selected car
    /// </summary>
    /// <param name="brand">brand of selected car</param>
    /// <returns></returns>
    public MarkPage ClickOnCarMark(string brand)
    {
      if (Driver.FindElement(By.XPath(String.Format(carMark, brand))).Displayed)
      {
        Driver.FindElement(By.XPath(String.Format(carMark, brand))).Click();
        return new MarkPage(Driver);
      }
      else
      {
        throw new Exception();
      }
    }
  }
}