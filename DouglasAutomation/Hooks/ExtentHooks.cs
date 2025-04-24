using AventStack.ExtentReports;
using Reqnroll;
using OpenQA.Selenium;
using DouglasAutomation.Reports;

namespace DouglasAutomation.Hooks
{
    [Binding]
    public class ExtentHooks
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            ExtentManager.CreateExtentInstance();  // Start reporting
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            DriverFactory.InitializeDriver("chrome");
            DriverFactory.Driver.Manage().Window.Maximize();

            ExtentManager.CreateTest(ScenarioContext.Current.ScenarioInfo.Title);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            ExtentManager.FlushReport();          
            DriverFactory.QuitDriver();          
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            ExtentManager.FlushReport();

            // Automatically open the report after all tests (optional)
            string reportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", "ExtentReport.html");
            if (File.Exists(reportPath))
            {
                // This opens it in File Explorer, you can change "explorer" to "chrome" if needed
                System.Diagnostics.Process.Start("explorer", reportPath);
            }
        }

    }
}
