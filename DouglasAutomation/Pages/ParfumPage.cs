using OpenQA.Selenium;

public class ParfumPage : BasePage
{
    private readonly By productList = By.CssSelector(".product-list");
    private readonly string dynamicFilterXPath = "//a[contains(@class,'facet-option') and descendant::span[contains(text(),'{0}')]]";
    private readonly string dynamicSectionXPath = "//div[@data-testid and contains(.,'{0}')]";

    public void ClickFilter(string value)
    {
        try
        {
            IList<IWebElement> elements = DriverFactory.Driver.FindElements(By.XPath(string.Format(dynamicFilterXPath, value)));

            foreach (var el in elements)
            {
                bool isSelected = el.GetAttribute("aria-checked") == "true";
                if (!isSelected)
                {
                    el.Click();
                    Console.WriteLine($"Filter clicked: {value}");
                    Thread.Sleep(1000);
                    return;
                }
            }
        }
        catch (Exception ex)
        {
            
        }
    }

    public void ExpandFilterSection(string sectionName)
    {
        try
        {
            IWebElement section = DriverFactory.Driver.FindElement(By.XPath(string.Format(dynamicSectionXPath, sectionName)));
            section.Click();
        }
        catch (Exception ex)
        {
            
        }
    }

    public bool AreResultsDisplayed()
    {
        return DriverFactory.Driver.FindElement(productList).Displayed;
    }
}
