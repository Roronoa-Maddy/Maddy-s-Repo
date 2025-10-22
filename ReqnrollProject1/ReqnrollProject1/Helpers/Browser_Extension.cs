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
            //string downloadPath = Path.Combine(Directory.GetCurrentDirectory(), "Downloads");
            //Properties_Collection.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            ChromeOptions options = new ChromeOptions();
            string projectRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\.."));
            string downloadPath = Path.Combine(projectRoot, "Automation_Downloads");
            // string downloadPath = Path.Combine(Directory.GetCurrentDirectory(), "Automation_Downloads");
            //Directory.CreateDirectory(downloadPath); // Create folder if it doesn't exist

            // ⭐ SET ALL PREFERENCES FIRST (BEFORE creating driver)
            options.AddUserProfilePreference("download.default_directory", downloadPath);
            options.AddUserProfilePreference("download.prompt_for_download", false);
            options.AddUserProfilePreference("download.directory_upgrade", true);
            options.AddUserProfilePreference("safebrowsing.enabled", false);
            options.AddUserProfilePreference("safebrowsing.disable_download_protection", true);
            options.AddUserProfilePreference("profile.default_content_settings.popups", 0);
            options.AddUserProfilePreference("profile.default_content_setting_values.automatic_downloads", 1);

            // ⭐ CREATE DRIVER LAST (AFTER all preferences are set)
            Properties_Collection.Driver = new ChromeDriver(options);
            Properties_Collection.Driver.Manage().Window.Maximize();


            //i'm going to push a new line from visual studio

        }


    }
}
