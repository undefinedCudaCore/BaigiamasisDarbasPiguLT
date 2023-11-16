using NUnit.Framework;
using SeleniumFramework.Pages.PiguLTPage;
using SeleniumTests.BaseTests;

namespace SeleniumTests.PiguLT
{
    internal class SearchForItem : BaseTest
    {
        internal class SearchItemTestData
        {
            public static string ItemSearchPhrase1 = "X515EA-BQ1735W";
            public static string FoundProductName = "Nešiojamas kompiuteris Asus X515EA-BQ1735W";
            public static string ManufacturerCode = "X515EA-BQ1735W";
        }

        [Test]
        public void SearchItemInWebShop()
        {
            SearchPage.EnterSearchPhrase(SearchItemTestData.ItemSearchPhrase1);
            SearchPage.ClickSearchButton();
            SearchPage.ClickFoundItemImageButton();
            SearchPage.ClickMoreInformationButton();

            Assert.That(SearchPage.GetProductName(), Is.EqualTo(SearchItemTestData.FoundProductName));
            Assert.That(SearchPage.ProductManufacturerCode(), Is.EqualTo(SearchItemTestData.ManufacturerCode));
        }
    }
}
