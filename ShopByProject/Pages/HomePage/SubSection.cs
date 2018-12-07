using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ShopByProject.Pages.HomePage
{
    public class SubSection : BasePage
    {
        private readonly By subSectionsBy = By.CssSelector("div.Catalog__Table > div > span");

        public SubSection()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(subSectionsBy));
            SubSections =  Driver.FindElements(subSectionsBy).ToList();
        }

        private List<IWebElement> SubSections { get; set; }

        public ResultsPage.ResultsPage ChooseSubCategory(string catalogElementName)
        {
            var element = SubSections.First(x => x.Text == catalogElementName);
            element.FindElement(By.XPath(".//ancestor::a")).Click();
            return new ResultsPage.ResultsPage();
        }
    }
}
