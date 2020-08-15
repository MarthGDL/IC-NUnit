using System;
using IC_TimeMaterialPage.Helpers;
using IC_TimeMaterialPage.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace IC_TimeMaterialPage.Test
{
    [TestFixture][Parallelizable]
    class EmployeeTest:SetupHelper
    {

        [Test]
        public static void CreateEmployeeTest()
        {
            //Checking if we are in the Employee page
            EmployeePage.checkIfEmployee(driver);
            //Create TM
            EmployeePage.CreateEmployee(driver);
        }
    }
}
