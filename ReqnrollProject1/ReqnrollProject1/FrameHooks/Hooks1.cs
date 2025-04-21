using Reqnroll;
using ReqnrollProject1.Helpers;

namespace ReqnrollProject1.FrameHooks
{
    [Binding]
    public sealed class Hooks1
    {
        // For additional details on Reqnroll hooks see https://go.reqnroll.net/doc-hooks

        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
           
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            Browser_Extension.InitiateChromeBrowser();
            Properties_Collection.Driver.Navigate().GoToUrl(Properties_Collection.DemoQAURl);
        }


        [AfterScenario]
        public void AfterScenario()
        {
            Properties_Collection.Driver.Close();
            Properties_Collection.Driver.Quit();
            Properties_Collection.Driver.Manage().Cookies.DeleteAllCookies();
        }
    }
}