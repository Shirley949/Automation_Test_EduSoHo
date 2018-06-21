using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace Story1
{
    public static class Browser
    {
        static IWebDriver webDriver;
        public static void NewDrive()
        {
            webDriver = new FirefoxDriver();
        }
        public static IWebDriver Driver
        {
            get { return webDriver; }
        }

        public static ISearchContext DriverContext
        {
            get { return webDriver; }
        }

        public static void Goto(string url)
        {
           webDriver.Url = url; 
        }

        public static void Close()
        {
            webDriver.Dispose();
        }

    }
}
