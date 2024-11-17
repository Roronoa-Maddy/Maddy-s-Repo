using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Helpers
{
    internal class Properties_Collection
    {
        public static IWebDriver Driver { get; set; }
        public static string flipkartURL
        {
            get
            {
                return "https://www.flipkart.com/";
            }
        }
            
    }
}
