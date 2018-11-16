using OpenQA.Selenium;
using PageObjectModel.Utils.Selenium;
﻿using NUnit.Framework;
using OpenQA.Selenium;
using System;
using static PageObjectModel.Utils.Selenium.Driver;
using static PageObjectModel.Utils.Selenium.Settings;

namespace PageObjectModel.Pages
{
    public class BasePage :Page
    {
        public IWebDriver Driver { get; internal set; }
        public string GetTitle => Driver.Title;
        public string GetUrl => Driver.Url;
        public string GetText => Driver.PageSource;



        public void ValidateTextInPageSource(string expectedText)
        {
            var textToValidate = Driver.Title.Contains(expectedText);
            Assert.IsTrue(textToValidate, ":: This is not the expected url");
            Console.WriteLine("::the text {0} in the PageSource is", GetText);
        }

        public void ValidatePageUrl(string expectedUrl)
        {
            var urlToValidate = Driver.Title.Contains(expectedUrl);
            Assert.IsTrue(urlToValidate, ":: This is not the expected url");
            Console.WriteLine("::the title of the website is" + GetUrl);
        }


        public void ValidatePageTitle(string expectedTitle)
        {
            var titleToValidate = Driver.Title.Contains(expectedTitle);
            Assert.IsTrue(titleToValidate, ":: This is not the expected title");
            Console.WriteLine("::the title of the website is" + GetTitle);
        }

        public void NavigateMainEnterPoint()
        {
            var baseUrl = BaseUrl;
            Browser().Navigate().GoToUrl(baseUrl);
            
            const string url = "https://www.wikipedia.org/";
            Browser().Navigate().GoToUrl(url);
            Browser().Manage().Window.Maximize();
            Console.WriteLine(WelcomeMessage);
        }
    }
}
