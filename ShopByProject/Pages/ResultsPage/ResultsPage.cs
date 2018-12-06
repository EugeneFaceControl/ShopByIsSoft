using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;

namespace ShopByProject.Pages.ResultsPage
{
    public class ResultsPage : BasePage
    {
        private IWebElement ChangeParam(string paramName)
        {
            var element = Driver.FindElement(By.XPath(
                $"//*[@class='ModelFilter__ParamList']/div[.//span[@class='ModelFilter__ParamName'][. = '{paramName}']]"));
            if (!element.GetAttribute("class").Contains("ModelFilter__TipAttrWapperOpen"))
            {
                element.FindElement(By.CssSelector("ModelFilter__ParamName")).Click();
            }

            return element;
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

        public ScreenResolution ChangeScreenResolution()
        {
            // TODO Think about it
            var resolutionElement = ChangeParam("Диагональ экрана, \"");
            return new ScreenResolution(resolutionElement);
        }
    }
}