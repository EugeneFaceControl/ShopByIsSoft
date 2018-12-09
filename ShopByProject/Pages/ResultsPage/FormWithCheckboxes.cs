using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ShopByProject.Pages.ResultsPage
{
    public class FormWithCheckboxes : BasePage
    {
        public FormWithCheckboxes()
        {
            
        }
        private readonly IWebElement filterElement;

        private const string CheckboxesNamesString = ".//a[label[text()='{0}']]/label";
        private const string ShowMoreStr = ".//span[text()='Еще']";

        public FormWithCheckboxes(IWebElement filterElement)
        {
            this.filterElement = filterElement;
        }

        public void CheckOptions(params string[] checkboxesNames)
        {
            if (checkboxesNames.Length == 0) return;
            checkboxesNames = checkboxesNames.Select(x => string.Format(CheckboxesNamesString, x)).ToArray();
            var xpathString = string.Join("|", checkboxesNames);
            var checkboxes = filterElement.FindElements(By.XPath(xpathString));
            foreach (var checkbox in checkboxes)
            {
                if (checkbox.Selected) continue;
                if (checkbox.Enabled)
                {
                    wait.Until(ExpectedConditions.ElementToBeClickable(checkbox));
                    checkbox.Click();
                }
            }
        }

        public T ShowAll<T>() where T : FormWithCheckboxes, new()
        {
            var instance = Activator.CreateInstance(typeof(T), filterElement) as T;
            filterElement.FindElement(By.XPath(ShowMoreStr)).Click();
            return instance;
        }

    }
}
