using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ShopByProject.Pages.ResultsPage
{
    public class Producer : FormWithCheckboxes
    {
        public Producer(IWebElement filterElement) : base(filterElement)
        {
        }

        public Producer()
        {
            
        }
    }
}
