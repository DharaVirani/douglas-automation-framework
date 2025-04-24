using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

public class DriverFactory
{
    public static IWebDriver Driver;


    public static void InitializeDriver(string browser)
    {
        if (Driver == null)
        {
            if (browser.ToLower() == "chrome")
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--remote-allow-origins=*"); // Fix if needed

                Driver = new ChromeDriver(options);
            }

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
    }


    public static void QuitDriver()
    {
        Driver?.Quit();
    }
}
