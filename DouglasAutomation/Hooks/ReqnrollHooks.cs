using Reqnroll;
using DouglasAutomation.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace DouglasAutomation.Hooks
{
    [Binding]
    public class ReqnrollHooks
    {
        public static IWebDriver Driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            Driver = DriverFactory.GetDriver("chrome");
            Driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            DriverFactory.QuitDriver();
        }
    }
}

