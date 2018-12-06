using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ShopByProject.Pages.ResultsPage
{
    public class ScreenResolution : FormWithCheckboxes
    {
        public ScreenResolution(IWebElement filterName) : base(filterName)
        {
            
        }
    }
}
