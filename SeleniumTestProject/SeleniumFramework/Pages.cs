using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumFramework
{
    public static class Pages
    {
        public static StartMobilePage StartMobilePage
        {
            get
            {
                var startMobilePage = new StartMobilePage();
                PageFactory.InitElements(Browser.Driver, startMobilePage);
                return startMobilePage;
            }
        }

        public static StartWinPage StartWinPage
        {
            get
            {
                var startWinPage = new StartWinPage();
                PageFactory.InitElements(Browser.Driver, startWinPage);
                return startWinPage;
            }
        }
    }
}
