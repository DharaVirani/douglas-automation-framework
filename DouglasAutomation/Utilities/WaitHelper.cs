using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace DouglasAutomation.Utilities
{
    public static class WaitHelper
    {
        public static IWebElement WaitUntilVisible(IWebDriver driver, By locator, int timeoutSeconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutSeconds));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }

        public static IWebElement WaitUntilClickable(IWebDriver driver, By locator, int timeoutSeconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutSeconds));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
        }
    }
}

