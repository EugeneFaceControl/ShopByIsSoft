using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;
using ShopByProject.Enums;

namespace ShopByProject.Utils
{
    public class Browser
    {
        public static IWebDriver WebDriver { get; private set; }

        public static void Init(BrowserEnum browserName)
        {
            switch (browserName)
            {
                case BrowserEnum.Chrome:
                    WebDriver = new ChromeDriver();
                    break;
                default:
                    throw new Exception("Unknown browser!");
            }

            WebDriver.Manage().Window.Maximize();
        }

        public static void GoTo(string url)
        {
            WebDriver.Url = url;
        }

        public static void Close()
        {
            WebDriver.Close();
            WebDriver.Quit();
        }

        public static IWebDriver SwitchToFrame(IWebElement element) => WebDriver.SwitchTo().Frame(element);

        public static void SetImplicitWait(double seconds)
        {
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
        }

        public static void TakeScreenShot(string testName)
        {
            WebDriver.TakeScreenshot().SaveAsFile($@"{AppDomain.CurrentDomain.BaseDirectory}Images\{testName}.jpg");
        }
    }
}
