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
            string itemSearchPhrase = "X515EA-BQ1735W";
            string foundProductName = "Nešiojamas kompiuteris Asus X515EA-BQ1735W";
            string manufacturerCode = "X515EA-BQ1735W";

            SearchPage.ClickAllowAllCookies();
            SearchPage.EnterSearchPhrase(itemSearchPhrase);
            SearchPage.ClickSearchButton();
            SearchPage.ClickFoundItemImageButton();
            //SearchItemPage.ScrollIntoView();
            SearchPage.ClickMoreInformationButton();

            try
            {
                Assert.That(SearchPage.GetProductName(), Is.EqualTo(foundProductName));
                Assert.That(SearchPage.ProductManufacturerCode(), Is.EqualTo(manufacturerCode));
            }
            catch (Exception ex)
            {
                SearchPage.GetTestFailScreenshot();

                throw;
            }
        }
    }
}
