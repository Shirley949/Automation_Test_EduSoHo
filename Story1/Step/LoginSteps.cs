using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Story1;
using TechTalk.SpecFlow;

namespace Story1.Step
{
    

    [Binding]
    public class LoginSteps : BaseStepDefinitions
    {
        [Given(@"I Open the Login page")]
        public void GivenOpenTheLoginPage()
        {
            Pages.Homepage.Goto();
        }

        [When(@"I have entered Username")]
        public void ThenIHaveEnteredUsername()
        {
            Pages.Login.typeUsername();
        }

        [Then(@"I have entered the Password")]
        public void ThenIHaveEnteredThePassword()
        {
            Pages.Login.typePassword();
        }

        [Then(@"I select the remember me checkbox")]
        public void ThenISelectTheRememberMeCheckbox()
        {
            Pages.Login.selectRememberMe();
        }

        [Then(@"login is successful, avatar is seen")]
        public void ThenLoginIsSuccessfulAvatarIsSeen()
        {
            Pages.Login.save();
            Pages.Login.checkImage();
        }

        [When(@"I have entered InvaildUsername")]
        public void WhenIHaveEnteredInvaildUsername()
        {
            Pages.Login.typeInvaildUsername();
        }

        [Then(@"I have entered the InvaildPassword")]
        public void ThenIHaveEnteredTheInvaildPassword()
        {
            Pages.Login.typeInvailPassword();
        }

        [Then(@"login is unsuccessful, error message is seen")]
        public void ThenLoginIsUnsuccessfulErrorMessageIsSeen()
        {
            Pages.Login.save();
            Pages.Login.checkErrorMessage();
        }

        [Then(@"log off and close the browser")]
        public void ThenLogOffAndCloseTheBrowser()
        {
            Pages.Login.logoff();
        }
    }
    public class BaseStepDefinitions
    {
        private IWebDriver drive;
        [BeforeScenario]
        public void BeforeScenario()
        {
            // BeforeScenario code
            Browser.NewDrive();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            // AfterScenario code
            Pages.Homepage.Close();
        }
    }
}
