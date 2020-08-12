using System;
using IC_TimeMaterialPage.Helpers;
using IC_TimeMaterialPage.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace IC_TimeMaterialPage
{
    [TestFixture][Parallelizable]
    class TMTest:SetupHelper
    {
        static void Main(string[] args)
        {

        }
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
