using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumFramework
{
    public class StartPage : Page
    {
        //[FindsBy(How = How.XPath, Using = "nav[contains(@id, 'navigation')]//span[text()='MENU']")]
        //private IWebElement menu;

        //[FindsBy(How = How.XPath, Using = "nav[contains(@id, 'navigation')]//span[text()='HOME']")]
        //private IWebElement home;

        //[FindsBy(How = How.XPath, Using = "nav[contains(@id, 'navigation')]//span[text()='TUTORIALS']")]
        //private IWebElement tutorials;

        //[FindsBy(How = How.XPath, Using = "nav[contains(@id, 'navigation')]//span[text()='PRACTICE']")]
        //private IWebElement practice;

        private readonly string _mobileMenu = "MENU";

        private readonly string[] _winMenu = new string[]
        {"HOME", "TUTORIALS", "PRACTICE", "SELENIUM", "CUCUMBER", "FORUMS", "ABOUT", "CONTACT"};

        public bool IsWinMenuDisplayed()
        {
            return _winMenu.Aggregate(true, (current, name) => current & Browser.Driver.FindElement(By.XPath(string.Format("//nav[contains(@id, 'navigation')]//span[text()='{0}']", name))).Displayed);
        }

        public bool IsMobileMenuDisplayed()
        {
            var mobileMenu =
                Browser.Driver.FindElements(
                    By.XPath(string.Format("//nav[contains(@id, 'navigation')]//span[text()='{0}']", _mobileMenu)));
            //Verify that page contains single MENU button
            return mobileMenu.Count == 1 && mobileMenu[0].Displayed;
        }
    }
}
