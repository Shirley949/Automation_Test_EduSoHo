using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Story1
{
    public class Login
    {
        [FindsBy(How = How.Id, Using = "login_username")]
        private IWebElement username;

        [FindsBy(How = How.Id, Using = "login_password")]
        private IWebElement password;

        [FindsBy(How = How.ClassName, Using = "btn-primary")]
        private IWebElement submit;

        [FindsBy(How = How.ClassName, Using = "avatar-xs")]
        private IWebElement image;

        [FindsBy(How = How.CssSelector, Using = "div.controls:nth-child(1) > input:nth-child(1)")]
        private IWebElement rememberCheckbox;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div/div[2]/form/div[1]")]
        private IWebElement errorMessage;

        [FindsBy(How = How.CssSelector, Using = ".user-nav-li-logout > a:nth-child(1)")]
        private IWebElement logOff;

        public void typeUsername()
        {
            username.SendKeys("test001");
        }

        public void typePassword()
        {
            password.SendKeys("Test1234");
        }

        public void typeInvaildUsername()
        {
            username.SendKeys("test0111");
        }

        public void typeInvailPassword()
        {
            password.SendKeys("Test11111234");
        }

        public void save()
        {
            submit.Click();
        }

        public void checkImage()
        {
            //string src = image.GetAttribute("src");
            //if (src == "/files/default/2018/06-19/2001106a8ad7776123.jpg")
            try
            {
                Assert.IsTrue(image.Displayed);
                Console.Write("image is displayed");

            }
            catch (Exception e)
            {
                Console.Write("image is not displayed");
            }
        }

        public void selectRememberMe()
        {
            if (!rememberCheckbox.Selected)
            {
                rememberCheckbox.Click();
            }
        }

        public void checkErrorMessage()
        {
            //string actualError = errorMessage;
            //string expectedError = "用户名或密码错误";
            //Assert.IsTrue(actualError.Contains(expectedError));
            string text = errorMessage.Text;

            Assert.IsTrue(text.Contains("用户名或密码错误"));
        }

        public void logoff()
        {
            Actions action = new Actions(Browser.Driver);
            action.MoveToElement(image).Perform();
            logOff.Click();
        }
    
    }
}
