using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace DouglasAutomation.Reports
{
    public static class ExtentManager
    {
        private static ExtentReports extent;
        private static ExtentTest test;

        public static void CreateExtentInstance()
        {
            if (extent == null)
            {
                string reportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports");
                Directory.CreateDirectory(reportPath);

                var reporter = new ExtentSparkReporter(Path.Combine(reportPath, "ExtentReport.html"));
                extent = new ExtentReports();
                extent.AttachReporter(reporter);
            }
        }

        public static void CreateTest(string testName)
        {
            test = extent.CreateTest(testName);
        }

        public static void LogStep(string message)
        {
            test?.Log(Status.Info, message);
        }

        public static void FlushReport()
        {
            extent?.Flush();
        }
    }
}

