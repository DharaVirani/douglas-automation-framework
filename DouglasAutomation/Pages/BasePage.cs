using OpenQA.Selenium;

public class BasePage
{
    protected IWebDriver Driver => DriverFactory.Driver;

    protected IWebElement Find(By locator)
    {
        try
        {
            return Driver.FindElement(locator);
        }
        catch (NoSuchElementException ex)
        {
            throw;
        }
    }
}
