using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqnrollProject1.Helpers
{
    internal class Properties_Collection
    {
        public static IWebDriver Driver { get; set; }
        public static string DemoQAURl
        {
            get
            {
                return "https://demoqa.com/";
            }
        }

    }
}
