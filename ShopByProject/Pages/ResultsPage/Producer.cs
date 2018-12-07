using OpenQA.Selenium;

namespace ShopByProject.Pages.ResultsPage
{
    public class Producer : FormWithCheckboxes
    {
        public Producer(IWebElement filterElement) : base(filterElement)
        {
        }

        public Producer()
        {
            
        }
    }
}
