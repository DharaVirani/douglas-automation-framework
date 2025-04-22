using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DouglasAutomation.Pages
{
    public class BasePage
    {
        private readonly IWebDriver _driver;

        // -------------------------------
        // 🔹 LOCATORS
        // -------------------------------
        private readonly By acceptCookiesBtn = By.XPath("//button[@data-testid='uc-accept-all-button']");
        // -------------------------------
        // CONSTRUCTOR
        // -------------------------------
        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        // -------------------------------
        // ACTION METHODS
        // -------------------------------

        public void AcceptCookies()
        {
            try
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
                IWebElement shadowRoot = (IWebElement)js.ExecuteScript(@"return document.querySelector('#usercentrics-root').shadowRoot.querySelector('button[data-testid=""uc-accept-all-button""]');");

                if (shadowRoot.Displayed)
                {
                    shadowRoot.Click();
                    Thread.Sleep(1000); // wait for modal to disappear
                }
                WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
                wait.Until(d => !IsCookieBarVisible(d));

                Thread.Sleep(500);
            }
            catch (Exception ex)
            {
                
            }
        }

        private bool IsCookieBarVisible(IWebDriver driver)
        {
            try
            {
                var cookieBar = driver.FindElement(By.CssSelector(".cookie-bar"));
                return cookieBar.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }


        }
}

