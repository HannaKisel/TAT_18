using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using VK;

namespace Selenium
{
  [TestClass]
  public class TestsForVk
  {
    const string URLONPROFILE = "https://vk.com/nuta249";
    public IWebDriver Driver { get; private set; }

    [TestInitialize]
    public void TestInit()
    {
      Driver = new ChromeDriver();
      Driver.Manage().Window.Maximize();
    }

    [TestMethod]
    public void TestAbilityToReadMessages()
    {
      Driver.Navigate().GoToUrl(URLONPROFILE);
      AuthorizationPage authorizationPage = new AuthorizationPage(Driver);
      ProfilePage profilePage = authorizationPage.LogIn();
      profilePage.GoToMessagePage().ReadFirstMessage();
    }

    [TestCleanup]
    public void CleanUp()
    {
      Driver.Close();
    }
  }
}