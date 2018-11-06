using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using PageObjectModel.Utils.Selenium;

namespace PageObjectModel.Utils.Hooks
{
    [Binding]
    internal static class TestRunHooks
    {
        [AfterTestRun]
        internal static void AfterTestRun()
        {
            if (!ScenarioContext.Current.ScenarioInfo.Tags.Contains("Debug"))
                DriverController.Instance.StopWebDriver();
        }
    }
}
