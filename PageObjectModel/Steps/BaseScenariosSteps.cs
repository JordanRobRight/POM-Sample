using System;
using PageObjectModel.Pages;
using PageObjectModel.Utils.Selenium;
using TechTalk.SpecFlow;

namespace PageObjectModel.Steps
{
    [Binding]
    public sealed class BaseScenariosSteps : BaseSteps
    {
        [Then(@"I see ""(.*)"" in the PageSource")]
        public void ThenISeeInThePageSource(string expectedText)
        {
            InstanceOf<BasePage>().ValidateTextInPageSource(expectedText);
        }



        [Then(@"I see the page url contains ""(.*)""")]
        public void ThenISeeThePageUrlContains(string expectedUrl)
        {
            InstanceOf<BasePage>().ValidatePageTitle(expectedUrl);
        }


        [Then(@"I see the page title contains ""(.*)""")]
        public void ThenISeeThePageTitleContains(string expectedTitle)
        {
            InstanceOf<BasePage>().ValidatePageTitle(expectedTitle);
        }



        [Given(@"I navigate to the homepage")]
        public void GivenINavigateToTheHomepage() => InstanceOf<BasePage>().NavigateMainEnterPoint();

    }
}
