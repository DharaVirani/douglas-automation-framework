using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.IO;

namespace DouglasAutomation.Helpers
{
    public static class ExtentManager
    {
        private static ExtentReports _extent;
        private static ExtentSparkReporter _sparkReporter;

        public static ExtentReports GetInstance()
        {
            if (_extent == null)
            {
                string reportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", "SparkReport.html");
                _sparkReporter = new ExtentSparkReporter(reportPath);

                _extent = new ExtentReports();
                _extent.AttachReporter(_sparkReporter);
            }
            return _extent;
        }
    }
}


