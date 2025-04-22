using Reqnroll;
using NUnit.Framework;
using DouglasAutomation.Hooks;
using DouglasAutomation.Pages;

namespace DouglasAutomation.DouglasStepDefination
{
    [Binding]
    public class ParfumSteps
    {
        private readonly BasePage _basePage;
        private readonly HomePage _homePage;
        private readonly ParfumPage _parfumPage;

        public ParfumSteps()
        {
            var driver = ReqnrollHooks.Driver;

            _basePage = new BasePage(driver);
            _homePage = new HomePage(driver);
            _parfumPage = new ParfumPage(driver);
        }

        [Given("I am on the Douglas homepage")]
        public void GivenIAmOnTheDouglasHomepage()
        {
            ReqnrollHooks.Driver.Navigate().GoToUrl("https://www.douglas.de/de");
        }

        [Given("I accept the cookie policy")]
        public void GivenIAcceptTheCookiePolicy()
        {
            _basePage.AcceptCookies();  //Calling the method from your BasePage class
        }

        [When("I click on the \"Parfum\" tab")]
        public void WhenIClickOnTheTab()
        {
            _homePage.ClickPerfumeTab();
        }

        [When("I apply the filter \\\"(.*)\\\" with value \\\"(.*)\\\"")]
        public void WhenIApplyTheFilterWithValue(string filterType, string filterValue)
        {
            _parfumPage.ApplyFilter(filterType, filterValue);
        }

        [Then("I should see filtered results")]
        public void ThenIShouldSeeFilteredResults()
        {
            Assert.IsTrue(_parfumPage.HasResults(), "No products were found for the applied filter.");
        }


    }

}
