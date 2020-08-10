using System;
using OpenQA.Selenium;

namespace IC_TimeMaterialPage.Pages
{
    class LoginPage
    {
        public static void logIn(IWebDriver driver)
        {
            //Going to TurnUp log-in page and maximazing window
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2fTimeMaterial");
            driver.Manage().Window.Maximize();

            //Entering log-in credentials
            driver.FindElement(By.Id("UserName")).SendKeys("hari");
            driver.FindElement(By.Id("Password")).SendKeys("123123");

            //Clicking log-in button
            driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]")).Click();

            //Find an element after log-in
            IWebElement dropdown_greeting_menu = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            //Validate if the element is there
            if (dropdown_greeting_menu.Text == "Hello hari!")
            {
                Console.WriteLine("Login Test passed!");
            }
            else
            {
                Console.WriteLine("Login Test failed...");
            }
        }
    }
}
