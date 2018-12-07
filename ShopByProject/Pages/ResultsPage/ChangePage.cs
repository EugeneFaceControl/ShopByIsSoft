using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ShopByProject.Pages.ResultsPage
{
    public class ChangePage : BasePage
    {
        private const string pagesStr = ".Paging__InnerPages > a";

        private List<IWebElement> pagesElements;

        public ChangePage()
        {
            pagesElements = Driver.FindElements(By.CssSelector(pagesStr)).ToList();
        }

        public void GoToLastPage()
        {
            pagesElements[pagesElements.Count - 2].Click();
        }
    }
}
