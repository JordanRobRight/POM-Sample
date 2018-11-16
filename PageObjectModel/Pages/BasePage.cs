using OpenQA.Selenium;
using PageObjectModel.Utils.Selenium;
using System;
using static PageObjectModel.Utils.Selenium.Driver;
using static PageObjectModel.Utils.Selenium.Settings;

namespace PageObjectModel.Pages
{
    public class BasePage :Page
    {
        public IWebDriver Driver { get; internal set; }

        public void NavigateMainEnterPoint()
        {
            var baseUrl = BaseUrl;
            Browser().Navigate().GoToUrl(baseUrl);
            Browser().Manage().Window.Maximize();
            Console.WriteLine(WelcomeMessage);
        }
    }
}
