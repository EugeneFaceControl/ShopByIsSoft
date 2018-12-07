using System;
using NUnit.Framework;
using ShopByProject.Pages.HomePage;
using ShopByProject.Pages.ResultsPage;
using ShopByProject.Utils;

namespace ShopByTests
{
    public class SortingTests : BaseTest
    {
        [Test]
        public void CheckSorting()
        {
            Browser.GoTo(TestSettings.BaseURL);
            var section = new Section();
            var resultsPage = section.
                ChooseCategory("Компьютеры")
                .ChooseSubCategory("Ноутбуки");
            resultsPage.ChangePrice()
                .SetPriceFrom("700")
                .SetPriceTo("1500");
            resultsPage.ChangeProducer()
                .CheckOptions("Lenovo", "Dell", "HP");

            resultsPage.ChangeScreenResolution()
                .ShowAll<ScreenResolutionComponent>()
                .CheckOptions("12", "12.1", "12.5", "13", "13.1", "13.3", "13.4");
            resultsPage = resultsPage.ShowResults();
            resultsPage = resultsPage.ChangeSorting().SortByAscending();
            var allResults = resultsPage.GetResults();
            Console.WriteLine($"Quantity of notebooks: {allResults.Count}");
            var firstElementFromAscending = allResults[0].Text;
            resultsPage = resultsPage.ChangeSorting().SortByDescending();
            resultsPage.ChangePage().GoToLastPage();
            allResults = resultsPage.GetResults();
            var lastElementFromDescending = allResults[allResults.Count - 1].Text;
            Assert.AreEqual(firstElementFromAscending, lastElementFromDescending);
        }
    }
}
