using OpenQA.Selenium;
using ReqnrollProject1.Helpers;
using ReqnrollProject1.InterActionMethod;

namespace ReqnrollProject1.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        IJavaScriptExecutor js = (IJavaScriptExecutor)Properties_Collection.Driver;
        // For additional details on Reqnroll step definitions see https://go.reqnroll.net/doc-stepdef

        [Given("User Able to Navigate DemoQA")]
        public void GivenUserAbleToNavigateDemoQA()
        {
          InterAction_Methods.VerifyUserAbleToNavigateToDemoQA();
        }

        [When("User Clicks on Element Option")]
        public void WhenUserClicksOnElementOption()
        {
           InterAction_Methods.UserClicksOnElementsOptions();
        
        }
        [Then("User Clicks on WebTable from Left Side Options")]
        public void ThenUserClicksOnWebTableFromLeftSideOptions()
        {
            InterAction_Methods.UserClicksOnWebTablesOption();
           
        }
        [Then("Read the Web tables data from UI")]
        public void ThenReadTheWebTablesDataFromUI()
        {
            InterAction_Methods.ReadUiWebTables();
        }

        [Then("Add Details in Registration form")]
        public void ThenAddDetailsInRegistrationForm()
        {
            InterAction_Methods.AddDetailsInRegistrationForm();
        }
        [Then("User Submits the Registration form")]
        public void ThenUserSubmitsTheRegistrationForm()
        {
            UI_Locators.regFrom_Submit.Click();
        }
        [When("User Clicks on Widgets Option")]
        public void WhenUserClicksOnWidgetsOption()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Properties_Collection.Driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", UI_Locators.Widgets);
            UI_Locators.Widgets.Click();
        }

        [Then("User Clicks on DatePicker from Left side options")]
        public void ThenUserClicksOnDatePickerFromLeftSideOptions()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Properties_Collection.Driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", UI_Locators.DatePicker);
            UI_Locators.DatePicker.Click();
        }
        [Then("User Select the Repective date {string}")]
        public void ThenUserSelectTheRepectiveDate(string date)
        {
            InterAction_Methods.UserSelectRespectiveDate(date);
        }

        [Then("Verify Repective date {string}")]
        public void ThenVerifyRepectiveDate(string date)
        {
            InterAction_Methods.verifytheDateandTime(date);
        }



    }
}
