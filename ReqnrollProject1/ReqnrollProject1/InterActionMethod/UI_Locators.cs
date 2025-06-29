using OpenQA.Selenium;
using ReqnrollProject1.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqnrollProject1.InterActionMethod
{
    internal class UI_Locators
    {
        UI_Locators uiLocators = new UI_Locators();
        public static IWebElement Elements
        {
            get
            {
                //return Properties_Collection.Driver.FindElement(By.Id("nonExistingId"));
                return Properties_Collection.Driver.FindElement(By.XPath("//h5[text()='Elements']"));
            }
        }

        public static IWebElement Web_Tables
        {
            get
            {
                return Properties_Collection.Driver.FindElement(By.XPath("//span[text()='Web Tables']"));
            }
        }

        internal static IWebElement AddRegistration
        {
            get
            {
                //return Properties_Collection.Driver.FindElement(By.Id("elementId"));
                return Properties_Collection.Driver.FindElement(By.XPath("//button[@id='addNewRecordButton']"));
            }
        }

        internal static IWebElement Regfrom_FirstName
        {
            get
            {
                return Properties_Collection.Driver.FindElement(By.XPath("//input[@id='firstName']"));
            }
        }

        public static IWebElement RegFrom_LastName
        {
            get
            {
                return Properties_Collection.Driver.FindElement(By.XPath("//input[@id='lastName']"));
            }
        }

        public static IWebElement RegForm_Email
        {
            get
            {
                return Properties_Collection.Driver.FindElement(By.XPath("//input[@id='userEmail']"));
            }
        }

        public static IWebElement RegForm_Age
        {
            get
            {
                return Properties_Collection.Driver.FindElement(By.XPath("//input[@id='age']"));
            }
        }

        public static IWebElement RegFrom_Salary
        {
            get
            {
                return Properties_Collection.Driver.FindElement(By.XPath("//input[@id='salary']"));
            }
        }

        public static IWebElement RegForm_Department
        {
            get
            {
                return Properties_Collection.Driver.FindElement(By.XPath("//input[@id='department']"));
            }
        }

        public static IWebElement regFrom_Submit
        {
            get
            {
                return Properties_Collection.Driver.FindElement(By.XPath("//button[text()='Submit']"));
            }
        }


        public static IWebElement Widgets
        {
            get
            {
                return Properties_Collection.Driver.FindElement(By.XPath("//*[contains(text(),'Widgets')]"));
            }
        }

        public static IWebElement DatePicker
        {
            get
            {
                return Properties_Collection.Driver.FindElement(By.XPath("//span[text()='Date Picker']"));
            }
        }

        public static IWebElement SelectDateBox
        {
            get
            {
                return Properties_Collection.Driver.FindElement(By.XPath("//input[@id='datePickerMonthYearInput']"));
            }
        }

        public static IWebElement NextMonth
        {
            get
            {
                return Properties_Collection.Driver.FindElement(By.XPath("//*[contains(text(),'Next Month')]"));
            }
        }


        public static IWebElement DateandTime
        {
            get
            {
                return Properties_Collection.Driver.FindElement(By.XPath("//input[@id='dateAndTimePickerInput']"));
            }
        }
    }
}
