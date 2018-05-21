using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace VK
{
  public class ProfilePage
  {
    private IWebDriver webDriver;
    private readonly By Message = By.XPath("//span[contains(text(),'Сообщения')]");
    private readonly By FirstDialogue = By.XPath("//div[@class='nim-dialog--cw'][1]");
    private readonly By ReadCurrentMessage = By.XPath("//div[@class='ui_clean_list im-mess-stack--mess _im_stack_messages']");
   
    public ProfilePage(IWebDriver webdriver)
    {
      this.webDriver = webdriver;
    }

    public MessagesPage GoToMessagePage()
    {
      WaitForElement(Message);
      webDriver.FindElement(Message).Click();
      WaitForElement(Message);
      return new MessagesPage(webDriver);
    }

    private void WaitForElement(By locator)
    {
      new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(locator));
    }
  }
}