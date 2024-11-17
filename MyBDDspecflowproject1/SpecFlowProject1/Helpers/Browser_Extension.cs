using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Helpers
{
    internal class Browser_Extension
    {
        public static void SetupChromebrowser()
        {
            Properties_Collection.Driver = new ChromeDriver();
            Properties_Collection.Driver.Navigate().GoToUrl(Properties_Collection.flipkartURL);
        }
    }
}
