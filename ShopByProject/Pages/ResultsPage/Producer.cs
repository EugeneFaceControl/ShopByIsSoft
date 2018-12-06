using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ShopByProject.Pages.ResultsPage
{
    public class Producer : BasePage
    {
        private readonly By computerTypesBy = By.XPath(".//label[text()='Acer']|.//label[text()='Asus']");
        private List<IWebElement> ComputerTypes => Driver.FindElements(computerTypesBy).ToList();
        private IWebElement filterName;

        public Producer(IWebElement filterName)
        {
            this.filterName = filterName;
        }

        public void CheckProducers(params string[] producerNames)
        {
            producerNames = producerNames.Select(x => $".//label[text()='{x}']").ToArray();
            var xpathString = string.Join("|", producerNames);
            var producers = Driver.FindElements(By.XPath(xpathString));
            // TODO Click on checkboxes
        }
    }
}
