using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ShopByProject.Pages.ResultsPage
{
    public class FormWithCheckboxes : BasePage
    {
        private readonly IWebElement filterName;

        public FormWithCheckboxes(IWebElement filterName)
        {
            this.filterName = filterName;
        }

        public void CheckProducers(params string[] producerNames)
        {
            producerNames = producerNames.Select(x => $".//a[label[text()='{x}']]/label").ToArray();
            var xpathString = string.Join("|", producerNames);
            var producers = filterName.FindElements(By.XPath(xpathString));
            foreach (var producer in producers)
            {
                if (!producer.Selected)
                {
                    producer.Click();
                }
            }
        }

    }
}
