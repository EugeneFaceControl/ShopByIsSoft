using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using ShopByProject.Utils;

namespace ShopByProject.Pages
{
    public class BasePage
    {
        protected IWebDriver Driver;

        protected WebDriverWait wait;

        public BasePage()
        {
            Driver = Browser.WebDriver;
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(TestSettings.ExplicitTimeout));
        }
    }
}
