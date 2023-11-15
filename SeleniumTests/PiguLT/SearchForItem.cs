using NUnit.Framework;
using SeleniumFramework.Pages.PiguLTPage;
using SeleniumTests.BaseTests;
using System;

namespace SeleniumTests.PiguLT
{
    internal class SearchForItem : BaseTest
    {
        [Test]
        public void SearchItemInWebShop()
        {
            SearchPage.ClickAllowAllCookies();
            SearchPage.EnterSearchPhrase(Strings.SearchItemString.ItemSearchPhrase1);
            SearchPage.ClickSearchButton();
            SearchPage.ClickFoundItemImageButton();
            SearchPage.ClickMoreInformationButton();

            try
            {
                Assert.That(SearchPage.GetProductName(), 
                    Is.EqualTo(Strings.SearchItemString.FoundProductName));
                Assert.That(SearchPage.ProductManufacturerCode(), 
                    Is.EqualTo(Strings.SearchItemString.ManufacturerCode));
            }
            catch (Exception ex)
            {
                SearchPage.GetTestFailScreenshot();
            }
        }
    }
}
