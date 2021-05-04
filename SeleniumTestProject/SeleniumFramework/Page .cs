using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumFramework.Configuration.Environments;

namespace SeleniumFramework
{
    public abstract class Page : PageObject
    {
        public static string Url { get; set; }

        protected Page()
        {
            var env = EnvironmentsSection.Settings.Environments[GetType().Name];
            Url = env.Url;
            PageTitle = env.PageTitle;
        }

        /// <summary>
        /// Navigates to the page URL.
        /// </summary>
        public void Goto()
        {
            try
            {
                Browser.Goto(Url);
                WaitForLoad();
            }
            catch (Exception e)
            {
                throw new Exception(GetType().Name + " could not be loaded. Check page url is correct in app.config." +
                                    " " + e.Message);
            }
        }
    }
}
