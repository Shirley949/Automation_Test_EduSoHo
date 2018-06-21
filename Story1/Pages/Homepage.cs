using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Firefox;

namespace Story1
{
    public class Homepage
    {
        
        static string url = "http://lyratesting2.co.nz/login";

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/header/nav/div/ul/li[2]/a")]
        private IWebElement loginLink;

        public void Goto()
        {
            
            Browser.Goto(url);
        }

        public void Close()
        {
            Browser.Close();
        }
     
    }
}
