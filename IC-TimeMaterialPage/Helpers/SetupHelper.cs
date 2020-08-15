using System;
using IC_TimeMaterialPage.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace IC_TimeMaterialPage.Helpers
{
    class SetupHelper
    {
        public static IWebDriver driver;

        [OneTimeSetUp]
        public static void LoginPageSetup()
        {
            //Indicating user that the test is starting
            Console.WriteLine("Initiating Test...");

            //Initiating browser
            driver = new ChromeDriver();

            //Creting Page Objects
            /*
            HomePage homePage = new HomePage();
            LoginPage loginPage = new LoginPage();
            TMPage tmPage = new TMPage();
            */

            //login
            LoginPage.logIn(driver);

        }

        [OneTimeTearDown]
        public static void FinishTest()
        {
            //driver.Close();
        }
    }
}
