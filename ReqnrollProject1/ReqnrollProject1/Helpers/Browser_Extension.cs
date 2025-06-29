using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqnrollProject1.Helpers
{
    internal class Browser_Extension
    {
        public static void InitiateChromeBrowser()
        {
           Properties_Collection.Driver = new ChromeDriver();
           Properties_Collection.Driver.Manage().Window.Maximize();
           //Properties_Collection.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            
        }


    }
}
