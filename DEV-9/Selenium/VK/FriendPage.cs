using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VK
{
  public class FriendPage
  {
    public IWebDriver Driver { get; private set; }

    public FriendPage(IWebDriver driver)
    {
      Driver = driver;
    }


  }
}
