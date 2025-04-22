using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace DouglasAutomation.Pages
{
     public class HomePage
    {
        private readonly IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        private readonly By searchBox = By.Id("search");  // example of another locator
        private readonly By loginButton = By.XPath("//button[text()='Login']");
      

        public void ClickPerfumeTab()
        {
            _driver.FindElement(By.LinkText("Parfum")).Click();
        }

    }
}
