using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VK
{
  public class FriendsPage
  {
    // private readonly By Message = By.XPath("//span[contains(text(),'Сообщения')]");
    private readonly By Friend = By.XPath("//div[@class='friends_field friends_field_title']");
    public IWebDriver Driver { get; private set; }

   public FriendsPage (IWebDriver driver)
    {
      Driver = driver;
    }

    public FriendsPage GoToFriendPage()
    {
      // ReadOnlyCollection<IWebElement> myFriends = Driver.FindElements(Friend);
      WaitForElement(Friend);
      Driver.FindElements(Friend).First().Click();
      return this;
    }

    private void WaitForElement(By locator)
    {
      new WebDriverWait(Driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(locator));
    }
  }
}
