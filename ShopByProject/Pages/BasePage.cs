using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ShopByProject.Utils;

namespace ShopByProject.Pages
{
    public class BasePage
    {
        protected IWebDriver Driver;

        protected const string ShowResultsStr = "#ModelFilter__NumModelWindow > div:nth-child(1)";

        protected WebDriverWait wait;

        public BasePage()
        {
            Driver = Browser.WebDriver;
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(TestSettings.ExplicitTimeout));
        }

//        public void Check
    }
}
