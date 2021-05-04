using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumFramework;

namespace SeleniumTestProject
{
    [TestClass]
    public class FrontEndTests
    {
        [TestInitialize]
        public void SetupTest()
        {
            Browser.Open();
        }

        [TestMethod]
        public void Test1Mobile()
        {
            Pages.StartMobilePage.Goto();
            Assert.IsTrue(Pages.StartMobilePage.IsMobileMenuDisplayed() && !Pages.StartMobilePage.IsWinMenuDisplayed());
        }

        [TestMethod]
        public void Test2Win()
        {
            Pages.StartWinPage.Goto();
            Assert.IsTrue(!Pages.StartWinPage.IsMobileMenuDisplayed() && Pages.StartWinPage.IsWinMenuDisplayed());
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Browser.Quit();
        }
    }
}
