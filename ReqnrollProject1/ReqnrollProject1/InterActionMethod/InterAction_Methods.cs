using Microsoft.VisualBasic;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using ReqnrollProject1.Helpers;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTable = System.Data.DataTable;

namespace ReqnrollProject1.InterActionMethod
{
    internal class InterAction_Methods
    {
       public  WebDriverWait wait = new WebDriverWait(Properties_Collection.Driver, TimeSpan.FromSeconds(10));
        public static void VerifyUserAbleToNavigateToDemoQA()
        {
            String title = Properties_Collection.Driver.Title.ToString();
            Assert.AreEqual(title, "DEMOQA", "Not Able To Reach the DemoQA Site");

        }

        public static void UserClicksOnElementsOptions()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Properties_Collection.Driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", UI_Locators.Elements);
            UI_Locators.Elements.Click();

            //UI_Locators.Elements.Click();
            String URL = Properties_Collection.Driver.Url;
            Assert.AreEqual(URL, "https://demoqa.com/elements", "Not Able To reach the ElementsPage");

        }

        public static void UserClicksOnWebTablesOption()
        {
            UI_Locators.Web_Tables.Click();
        }

        public static void ReadUiWebTables()
        {
            DataTable Uitable = new DataTable();


            IList<IWebElement> Web_Tables_title = Properties_Collection.Driver.FindElements(By.XPath("/html/body/div[2]/div/div/div/div[2]/div[2]/div[3]/div[1]/div[1]/div/div/div[1]"));
            foreach (IWebElement table in Web_Tables_title)
            {

                string title = table.Text.Trim();
                Uitable.Columns.Add(title);
            }

            IList<IWebElement> Web_tables_data = Properties_Collection.Driver.FindElements(By.XPath("/html/body/div[2]/div/div/div/div[2]/div[2]/div[3]/div[1]/div[2]/div/div"));
            foreach (IWebElement data in Web_tables_data)
            {

                string[] rowvalue = new string[Uitable.Columns.Count];
                IList<IWebElement> allcells = data.FindElements(By.XPath("div"));
                //foreach (IWebElement cell in allcells)
                //{

                //    int value = allcells.IndexOf(cell);
                //    rowvalue[allcells.IndexOf(cell)] = cell.Text;
                //}
                for (int i = 0; i < allcells.Count; i++)
                {
                    rowvalue[i] = allcells[i].Text;
                }


                Uitable.Rows.Add(rowvalue);
            }
        }

        public static void AddDetailsInRegistrationForm()
        {
            // UI_Locators uiLocators = new UI_Locators();
            try
            {
                UI_Locators.AddRegistration.Clear();
            }
            catch (Exception x)
            {
                Console.WriteLine("Not able to find The Element" + " " + x);
            }


            UI_Locators.Regfrom_FirstName.SendKeys("Roronoa");
            UI_Locators.RegFrom_LastName.SendKeys("Zoro");
            UI_Locators.RegForm_Email.SendKeys("RoronoaZoro@mail.com");
            UI_Locators.RegForm_Age.SendKeys("20");
            UI_Locators.RegFrom_Salary.SendKeys("100000");
            UI_Locators.RegForm_Department.SendKeys("SwordsMan");

            WebDriverWait wait = new WebDriverWait(Properties_Collection.Driver, TimeSpan.FromSeconds(10));
            // Ensure the XPath is correct

            IWebElement a = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("")));
            IWebElement b = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("")));
        }


        

        public static void UserSelectRespectiveDate(string date)
        {
            UI_Locators.SelectDateBox.Click();
            WebDriverWait wait = new WebDriverWait(Properties_Collection.Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementToBeClickable(UI_Locators.NextMonth));
            IWebElement Date = Properties_Collection.Driver.FindElement(By.XPath("//div[contains(text(),'30')]"));
            Date.Click();


            Actions act = new Actions(Properties_Collection.Driver);
            act.ScrollToElement(UI_Locators.DateandTime);
            wait.Until(ExpectedConditions.ElementToBeClickable(UI_Locators.DateandTime));
            UI_Locators.DateandTime.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(UI_Locators.NextMonth));
            

            IWebElement Date1 = Properties_Collection.Driver.FindElement(By.XPath("//div[contains(text(),'30')]"));
            Date1.Click();
            IWebElement Time = Properties_Collection.Driver.FindElement(By.XPath("//li[contains(text(),'18:00')]"));
            Time.Click();



        }


        public static void verifytheDateandTime(string date)
        {
            string Date2 = UI_Locators.SelectDateBox.GetAttribute("value").ToString();
            DateTime parsedDate = DateTime.ParseExact(Date2, "MM/dd/yyyy", CultureInfo.InvariantCulture);
            string formatteddate = parsedDate.ToString("dd-MM-yyyy");

            Assert.AreEqual(formatteddate,date, "Values not matched");

        }

    }
}
