using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace PageObjectModel.Utils.Selenium
{
    [Binding]
    internal class Driver
    {
        internal static IWebDriver Browser()=> DriverController.Instance.WebDriver;

      
    }
}
