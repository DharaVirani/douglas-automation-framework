using AventStack.ExtentReports;
using Reqnroll;
using NUnit.Framework;
using System;

namespace DouglasAutomation.Hooks
{
    [Binding]
    public class ExtentHooks
    {
        private static ExtentReports extent;
        private static ExtentTest test;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            extent = Helpers.ExtentManager.GetInstance();
        }

        [BeforeScenario]
        public void BeforeScenario(ScenarioContext scenarioContext)
        {
            test = extent.CreateTest(scenarioContext.ScenarioInfo.Title);
            scenarioContext["extentTest"] = test;
        }

        [AfterStep]
        public void AfterEachStep(ScenarioContext scenarioContext)
        {
            var stepType = scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();
            var stepText = scenarioContext.StepContext.StepInfo.Text;

            var currentTest = (ExtentTest)scenarioContext["extentTest"];

            if (scenarioContext.TestError == null)
                currentTest.Log(Status.Pass, $"{stepType}: {stepText}");
            else
                currentTest.Log(Status.Fail, $"{stepType}: {stepText}<br>{scenarioContext.TestError.Message}");
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            extent.Flush();
        }
    }
}
