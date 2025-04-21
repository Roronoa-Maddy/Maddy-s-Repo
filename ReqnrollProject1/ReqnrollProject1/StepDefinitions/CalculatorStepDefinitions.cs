using ReqnrollProject1.InterActionMethod;

namespace ReqnrollProject1.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
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


    }
}
