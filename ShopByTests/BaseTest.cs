using System;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using ShopByProject.Enums;
using ShopByProject.Utils;

namespace ShopByTests
{
    [TestFixture]
    public class BaseTest
    {
        private TestSettings settings;

        public string Id { get; set; }

        [SetUp]
        public void SetUp()
        {
            Id = DateTime.Now.ToString("MMddHHmmss");
            settings = new TestSettings();
            BrowserInit(settings.BrowserName);
        }

        [TearDown]
        public void CleanUp()
        {
            try
            {
                if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Passed)
                {
                    Browser.TakeScreenShot($"{TestContext.CurrentContext.Test.Name} {Id}");
                }
            }
            finally
            {
                Browser.Close();
            }
        }

        public void BrowserInit(BrowserEnum browserName)
        {
            Browser.Init(browserName);
            Browser.SetImplicitWait(settings.ImplicitTimeout);
        }

        [Test]
        public void DoSmth()
        {
        }

    }
}
