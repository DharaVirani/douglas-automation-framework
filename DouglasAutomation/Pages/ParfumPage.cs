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
     public class ParfumPage
    {
        private readonly IWebDriver _driver;

        public ParfumPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private readonly By productList = By.CssSelector(".product-tile");

        public void ApplyFilter(string filterType, string filterValue)
        {
            try
            {
                // Expand the filter section if it's not already open
                IWebElement section = _driver.FindElement(By.XPath($"//div[@class='facet__title' and normalize-space(text())='{filterType}']"));
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", section);
                section.Click();
                Thread.Sleep(1000); // wait for items to load

                // Click on the actual filter value (checkbox or label)
                IWebElement filterOption = _driver.FindElement(By.XPath($"//label[.//span[normalize-space(text())='{filterValue}']]"));
                filterOption.Click();
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine($"Filter '{filterType}' with value '{filterValue}' not found: {ex.Message}");
                throw;
            }
        }

        public bool HasResults()
        {
            return _driver.FindElements(productList).Count > 0;
        }
    }
}
