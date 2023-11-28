using NUnit.Framework;
using SeleniumFramework.Pages.PiguLTPage;
using SeleniumTests.BaseTests;

namespace SeleniumTests.PiguLT
{
    internal class SearchForItem : BaseTestWithLogin
    {
        [Test]
        public void SearchItemInWebShop()
        {
            SearchPage.EnterSearchPhrase(TestData.SearchItem.ItemSearchPhrase1);
            SearchPage.ClickSearchButton();
            SearchPage.ClickFoundItemImageButton();
            SearchPage.ClickMoreInformationButton();

            Assert.That(SearchPage.GetProductName(), Is.EqualTo(TestData.SearchItem.FoundProductName));
            Assert.That(SearchPage.ProductManufacturerCode(), Is.EqualTo(TestData.SearchItem.ManufacturerCode));
        }
    }
}
