using System;
using IC_TimeMaterialPage.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace IC_TimeMaterialPage
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indicating user that the test is starting
            Console.WriteLine("Initiating Test...");

            //Initiating browser
            IWebDriver driver = new ChromeDriver();

            //Creting Page Objects
            /*
            HomePage homePage = new HomePage();
            LoginPage loginPage = new LoginPage();
            TMPage tmPage = new TMPage();
            */

            //login
            LoginPage.logIn(driver);

            //Navigate to TM
            HomePage.goToTM(driver);

            //Create TM
            TMPage.CreateTM(driver);

            //Edit TM
            TMPage.EditTM(driver);

            //Delete TM
            TMPage.DeleteTM(driver);
        }
    }
}
