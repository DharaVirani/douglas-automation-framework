using OpenQA.Selenium;

public class HomePage : BasePage
{
    private readonly string categoryLinkXPath = "//a[text()='{0}']";

    public void ClickCategory(string category)
    {
        var locator = By.XPath(string.Format(categoryLinkXPath, category));
        Find(locator).Click();
        Console.WriteLine($"✅ Clicked category: {category}");
    }
}

