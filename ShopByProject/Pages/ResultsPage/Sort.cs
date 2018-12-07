using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ShopByProject.Pages.ResultsPage
{
    public class Sort : BasePage
    {
        private const string SortVariantsStr = ".PanelSetUp__SortBlock ul > li";
        private readonly List<IWebElement> allSorts;

        public Sort()
        {
            var sortVariantsBy = By.CssSelector(SortVariantsStr);
            wait.Until(ExpectedConditions.ElementIsVisible(sortVariantsBy));
            allSorts = Driver.FindElements(sortVariantsBy).ToList();
        }

        public ResultsPage SortByPopularity()
        {
            allSorts[0].Click();
            return new ResultsPage();
        }

        public ResultsPage SortByAscending()
        {
            allSorts[1].Click();
            return new ResultsPage();
        }

        public ResultsPage SortByDescending()
        {
            allSorts[2].Click();
            return new ResultsPage();
        }

        public ResultsPage SortBySales()
        {
            allSorts[3].Click();
            return new ResultsPage();
        }
    }
}
