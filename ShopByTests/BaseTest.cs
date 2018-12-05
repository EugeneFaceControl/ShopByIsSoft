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

        [SetUp]
        public void SetUp()
        {
            settings = new TestSettings();
            BrowserInit(settings.BrowserName);
        }

        [TearDown]
        public void CleanUp()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Passed)
            {
                Browser.TakeScreenShot(TestContext.CurrentContext.Test.Name);
            }
            Browser.Close();
        }

        public void BrowserInit(BrowserEnum browserName)
        {
            Browser.Init(browserName);
            Browser.SetImplicitWait(settings.ImplicitTimeout);
        }
    }
}
