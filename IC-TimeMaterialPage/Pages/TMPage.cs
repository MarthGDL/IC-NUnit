using System;
using System.Threading;
using IC_TimeMaterialPage.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;

namespace IC_TimeMaterialPage.Pages
{
    class TMPage
    {
        public static void CreateTM(IWebDriver driver)
        {
            //Clicking Create button
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();

            //Entering Time details
            string time_code = "Dbot";
            driver.FindElement(By.Id("Code")).SendKeys(time_code);
            driver.FindElement(By.Id("Description")).SendKeys("Time Automatically Created on 08/08/2020");

            /////////////////////////////////////Selecting drop down option////////////////////////////////////////////

            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]")).Click();

            //Clicking Price fieldbox (Because it is using a Kendo format) and then entering string into it
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();
            driver.FindElement(By.XPath("//*[@id='Price']")).SendKeys("2020");

            //Clicking the save button and waiting 1s
            driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();

            //////////////////////////Validating that the creation was successfull////////////////////////////

            //Clicking the "Go to last" button
            WaitHelper.WaitClickble(driver, "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]");
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]")).Click();

            //Asigning the Text of the last element in the last page to a string variable 
            String textvalue = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]")).Text;////*[@id="tmsGrid"]/div[3]/table/tbody/tr[1]/td[5]/a[1]

            //Comparing the Text to the time_code variable
            if (textvalue == time_code)
            {
                Console.WriteLine(time_code + " found, Creation Test passed!");
                Assert.Pass();
            }
            else
            {
                Console.WriteLine(time_code + " not found, Creation Test failed...");
                Assert.Fail();
            }
        }

        public static void EditTM(IWebDriver driver)
        {
            //Clicking the "Go to last" button
            WaitHelper.WaitClickble(driver, "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]");
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]")).Click();

            //Clicking EDIT in the last element in the grid and wait
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]")).Click();

            String time_code_edit = "Ed";
            driver.FindElement(By.Id("Code")).SendKeys(time_code_edit);

            //Clicking the save button and wait
            driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();
            Thread.Sleep(3000);

            //////////////////////////Validating that the edit was successfull////////////////////////////

            //Clicking the "Go to last" button after a wait
            WaitHelper.WaitClickble(driver, "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]");
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]")).Click();

            //Asigning the Text of the last element in the last page to a string variable 
            string textvalue = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]")).Text;////*[@id="tmsGrid"]/div[3]/table/tbody/tr[1]/td[5]/a[1]

            //Comparing the Text to the time_code variable
            if (textvalue == "Dbot" + time_code_edit)
            {
                Console.WriteLine(time_code_edit + " found, Edit Test passed!");
                Assert.Pass();
            }
            else
            {
                Console.WriteLine(time_code_edit + " not found, Edit Test failed...");
                Assert.Fail();
            }
        }

        public static void DeleteTM(IWebDriver driver)
        {
            //Clicking the "Go to last" button after a wait
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]")).Click();

            //Clicking DELETE in the last element in the grid
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]")).Click();

            //Creating a new driver to the alert message and Clicking YES in the alert message, after we use a delay
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(3000);

            //////////////////////////Validating that the delete was successfull////////////////////////////

            //Asigning the Text of the last element in the last page to a string variable 
            string textvalue = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]")).Text;////*[@id="tmsGrid"]/div[3]/table/tbody/tr[1]/td[5]/a[1]

            //Comparing the Text to the time_code variable
            if (textvalue != "Dbot" + "Ed")
            {
                Console.WriteLine("Dbot" + "Ed" + " not found, Delete Test passed!");
                Assert.Pass();
            }
            else
            {
                Console.WriteLine("Dbot" + "Ed" + " found, Delete Test failed...");
                Assert.Fail();
            }
        }
    }
}
