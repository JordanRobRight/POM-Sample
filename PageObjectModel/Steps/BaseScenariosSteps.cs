using System;
using PageObjectModel.Pages;
using PageObjectModel.Utils.Selenium;
using TechTalk.SpecFlow;

namespace PageObjectModel.Steps
{
    [Binding]
    public sealed class BaseScenariosSteps : BaseSteps
    {


        [Given(@"I navigate to the homepage")]
        public void GivenINavigateToTheHomepage() => InstanceOf<BasePage>().NavigateMainEnterPoint();

    }
}
