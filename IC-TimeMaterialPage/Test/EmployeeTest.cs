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
        public static void CreateTMTest()
        {
            //Create TM
            TMPage.CreateTM(driver);
        }
        [Test]
        public static void EditTMTest()
        {
            //Edit TM
            TMPage.EditTM(driver);
        }
        [Test]
        public static void DeleteTMTest()
        {
            //Delete TM
            TMPage.DeleteTM(driver);
        }
    }
}
