using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using ShopByProject.Utils;

namespace ShopByProject.Pages.HomePage
{
    public class Section : BasePage
    {
        private readonly By catalogSectionsBy = By.CssSelector("#Catalog > div > div.Catalog__SectionMainBlock");
        private readonly By linkElementBy = By.CssSelector("span > a");


        private List<IWebElement> CatalogElements => Driver.FindElements(catalogSectionsBy).ToList();

        public Section()
        {
            
        }

        public SubSection ChooseCategory(string catalogElementName)
        {
            var element = CatalogElements.First(x => x.Text == catalogElementName);
            Browser.ExecuteJs("arguments[0].style.color='red'", element);
            Browser.FocusOnElement(element.FindElement(linkElementBy));
            return new SubSection();
        }
    }
}
