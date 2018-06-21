using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;

namespace Story1
{
    public static class Pages
    {
        public static Homepage Homepage
        {
            get
            {
                var homePage = new Homepage();
                PageFactory.InitElements(Browser.DriverContext, homePage);
                return homePage;
            }
        }
        public static Login Login
        {
            get
            {
                var login = new Login();
                PageFactory.InitElements(Browser.DriverContext, login);
                return login;
            }
        }
    }
}
