using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework
{
    public class StartMobilePage : StartPage
    {
        public StartMobilePage()
        {
            Browser.SetSize(500, 850);
        }
    }
}
