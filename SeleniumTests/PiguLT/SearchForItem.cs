using NUnit.Framework;
using SeleniumFramework.Pages.PiguLTPage;
using SeleniumTests.BaseTests;

namespace SeleniumTests.PiguLT
{
    internal class SearchForItem : BaseTest
    {
        [Test]
        public void SearchItemInWebShop()
        {
            SearchPage.EnterSearchPhrase(Strings.SearchItemString.ItemSearchPhrase1);
            SearchPage.ClickSearchButton();
            SearchPage.ClickFoundItemImageButton();
            SearchPage.ClickMoreInformationButton();

            Assert.That(SearchPage.GetProductName(), Is.EqualTo(Strings.SearchItemString.FoundProductName));
            Assert.That(SearchPage.ProductManufacturerCode(), Is.EqualTo(Strings.SearchItemString.ManufacturerCode));
        }
    }
}
