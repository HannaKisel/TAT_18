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
      Driver.Navigate().GoToUrl(URLONPROFILE);
    }

    [TestMethod]
    public void TestAbilityToReadMessages()
    {
      AuthorizationPage authorizationPage = new AuthorizationPage(Driver);
      ProfilePage profilePage = authorizationPage.LogIn();
      profilePage.GoToMessagePage().ReadFirstMessage().GoToFriendsPage();
    }

    [TestCleanup]
    public void CleanUp()
    {
      Driver.Close();
    }
  }
}