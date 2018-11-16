<<<<<<< HEAD
﻿using OpenQA.Selenium;
using PageObjectModel.Utils.Selenium;
=======
>>>>>>> 8585aea5b6045b14c8d9ec8d4fccb514bc99ae79
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
<<<<<<< HEAD
            var baseUrl = BaseUrl;
            Browser().Navigate().GoToUrl(baseUrl);
=======
>>>>>>> 8585aea5b6045b14c8d9ec8d4fccb514bc99ae79
            Browser().Manage().Window.Maximize();
            Console.WriteLine(WelcomeMessage);
        }
    }
}
