using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ShopByProject.Utils;

namespace ShopByProject.Pages.ResultsPage
{
    public class ResultsPage : BasePage
    {
        private const string ParamStr =
            "//*[@class='ModelFilter__ParamList']/div[.//span[@class='ModelFilter__ParamName'][. = '{0}']]";
        private const string AllResults = ".ModelList > div";
        private const string SortStr = ".PanelSetUp__SortBlock .chzn-txt-sel";

        private IWebElement ChangeParam(string paramName)
        {
            var element = Driver.FindElement(By.XPath(string.Format(ParamStr, paramName)));
            if (!element.GetAttribute("class").Contains("ModelFilter__TipAttrWapperOpen"))
            {
                element.FindElement(By.CssSelector("ModelFilter__ParamName")).Click();
            }

            return element;
        }

        public ChangePage ChangePage()
        {
            return new ChangePage();
        }

        public SortComponent ChangeSorting()
        {
            Driver.FindElement(By.CssSelector(SortStr)).Click();
            return new SortComponent();
        }

        public Price ChangePrice()
        {
            ChangeParam("Цена, руб.");
            return new Price();
        }

        public Producer ChangeProducer()
        {
            var producerElement = ChangeParam("Производитель");
            return new Producer(producerElement);
        }

        public ScreenResolutionComponent ChangeScreenResolution()
        {
            // TODO Think about it
            var resolutionElement = ChangeParam("Диагональ экрана, \"");
            return new ScreenResolutionComponent(resolutionElement);
        }

        public ResultsPage ShowResults()
        {
            var showResults = By.CssSelector(ShowResultsStr);

            bool ShowResultsButtonIsClicked()
            {
                var showResultsButton = Driver.FindElement(showResults);
                showResultsButton.Click();
                return true;
            }

            new Wait().ExecuteUntilTrue(ShowResultsButtonIsClicked);

            return this;
        }

        public List<IWebElement> GetResults()
        {
            return Driver.FindElements(By.CssSelector(AllResults)).ToList();
        }
    }
}