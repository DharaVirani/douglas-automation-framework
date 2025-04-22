using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;

namespace DouglasAutomation.Drivers
{
     class DriverFactory
    {
        private static IWebDriver _driver;

           public static IWebDriver GetDriver(string browser = "chrome")
           {
            return browser.ToLower() switch
            {
                "firefox" => new FirefoxDriver(),
                "edge" => new EdgeDriver(),
                _ => new ChromeDriver(),
            };
           }
        

        public static void QuitDriver()
        {
            if (_driver != null)
            {
                _driver.Quit();
                _driver = null;
            }
        }
    }
}

