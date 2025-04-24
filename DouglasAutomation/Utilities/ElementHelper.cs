using OpenQA.Selenium;

namespace DouglasAutomation.Utilities
{
    public static class ElementHelper
    {
        public static void ScrollIntoView(IWebDriver driver, IWebElement element)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        public static void HighlightElement(IWebDriver driver, IWebElement element)
        {
            var js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].style.border='3px solid red'", element);
        }
    }
}
