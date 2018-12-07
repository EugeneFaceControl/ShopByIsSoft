using System;
using System.Threading;
using OpenQA.Selenium;

namespace ShopByProject.Pages.ResultsPage
{
    public class Price : BasePage
    {
        private readonly By priceFromBy = By.Name("price_before");
        private readonly By priceToBy = By.Name("price_after");
        private IWebElement PriceFrom => Driver.FindElement(priceFromBy);
        private IWebElement PriceTo => Driver.FindElement(priceToBy);

        public Price SetPriceFrom(string price)
        {
            PriceFrom.SendKeys(price);
            return this;
        }

        public Price SetPriceTo(string price)
        {
            PriceTo.SendKeys(price);
            return this;
        }
    }
}
