using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;

namespace VK
{
  public class MessagesPage
  {
    private IWebDriver webDriver;
   // private readonly By Message = By.XPath("//span[contains(text(),'Сообщения')]");
    private readonly By Dialogs = By.XPath("//div[@class='nim-dialog--cw']");
    private readonly By Messages = By.XPath("//div[@class='im-mess--text wall_module _im_log_body']");
    private readonly By DialogsArea = By.XPath("//ul[@id='im_dialogs']");
    private readonly By Chat = By.XPath("//div[@class='im-page--chat-body']");
    private readonly By Friends = By.XPath("//span[contains(text(),'Друзья')]");

    public MessagesPage(IWebDriver webdriver)
    {
      this.webDriver = webdriver;
    }

    public MessagesPage ReadFirstMessage()
    {
      WaitForElement(DialogsArea);
      webDriver.FindElements(Dialogs).First().Click();
      WaitForElement(Chat);
      string message = webDriver.FindElements(Messages).Last().Text;
      Console.WriteLine(message);
      return this;
    }

    public FriendsPage GoToFriendsPage()
    {
      WaitForElement(Friends);
      webDriver.FindElement(Friends).Click();
      WaitForElement(Friends);
      return new FriendsPage(webDriver);
    }

    private void WaitForElement(By locator)
    {
      new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(locator));
    }
  }
}