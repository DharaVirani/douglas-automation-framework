using Reqnroll;

[Binding]
public class DouglasSteps
{
    private HomePage home;
    private CookiePopupPage cookie;
    private ParfumPage parfum;

    public DouglasSteps()
    {
        home = new HomePage();
        cookie = new CookiePopupPage();
        parfum = new ParfumPage();
    }

    [Given(@"I navigate to the Douglas homepage")]
    public void GivenINavigateToDouglas()
    {
        DriverFactory.Driver.Navigate().GoToUrl("https://www.douglas.de/de");
    }

    [Given(@"I accept the cookie consent")]
    public void AcceptCookies()
    {
        cookie.AcceptCookies();
    }

    [When(@"I click on the ""(.*)"" category")]
    public void ClickParfum(string category)
    {
        home.ClickCategory(category);
    }

    [When(@"I apply filters: ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
    public void ApplyFilters(string highlight, string brand, string type, string gift, string gender)
    {
        parfum.ExpandFilterSection("Highlights");
        parfum.ClickFilter(highlight);

        parfum.ExpandFilterSection("Marke");
        parfum.ClickFilter(brand);

        parfum.ExpandFilterSection("Produktart");
        parfum.ClickFilter(type);

        parfum.ExpandFilterSection("Geschenk");
        parfum.ClickFilter(gift);

        parfum.ExpandFilterSection("Für wen");
        parfum.ClickFilter(gender);
    }


    [Then(@"I should see the filtered list of products")]
    public void VerifyFilteredResults()
    {
        Assert.IsTrue(parfum.AreResultsDisplayed());
    }
}
