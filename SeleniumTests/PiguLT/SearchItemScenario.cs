using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.PiguLTPage;
using SeleniumTests.BaseTests;
using System;

namespace SeleniumTests.PiguLT
{
    internal class SearchItemScenario : BaseTest
    {
        [Test]
        public void SearchItemInWebShop()
        {
            string itemSearchPhrase = "X515EA-BQ1735W";
            string foundProductName = "Nešiojamas kompiuteris Asus X515EA-BQ1735W";
            string manufacturerCode = "X515EA-BQ1735W";

            SearchItemPage.Open();
            SearchItemPage.ClickAllowAllCookies();
            SearchItemPage.Waiting();
            SearchItemPage.EnterSearchPhrase(itemSearchPhrase);
            SearchItemPage.ClickSearchButton();
            SearchItemPage.ClickFoundItemImageButton();
            //SearchItemPage.ScrollIntoView();
            SearchItemPage.ClickMoreInformationButton();

            try
            {
                Assert.That(SearchItemPage.GetProductName(), Is.EqualTo(foundProductName));
                Assert.That(SearchItemPage.ProductManufacturerCode(), Is.EqualTo(manufacturerCode));
            }
            catch (Exception ex)
            {
                SearchItemPage.GetTestFailScreenshot();

                throw;
            }
        }
    }
}
