using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopByProject.Enums;

namespace ShopByProject.Utils
{
    public class TestSettings
    {
        public string BaseURL => GetSetting("baseURL");

        public BrowserEnum BrowserName
        {
            get
            {
                Enum.TryParse(GetSetting("browserName"), true, out BrowserEnum browser);
                return browser;
            }
        }

        public double ExplicitTimeout => double.Parse(GetSetting("explicitTimeout"));
        public double ImplicitTimeout => double.Parse(GetSetting("implicitTimeout"));

        private string GetSetting(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}