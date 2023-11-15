using NUnit.Framework;
using SeleniumFramework.Pages.PiguLTPage;
using SeleniumTests.BaseTests;
using System;

namespace SeleniumTests.PiguLT
{
    internal class AddItemTo : BaseTest
    {
        [Test]
        public void AddItemToWishList()
        {
            LoginPage.ClickOnProfileIcon();
            LoginPage.ClickOnBlueLoginButton();
            LoginPage.EnterLoginEmail(Strings.LoginString.InputEmail1);
            LoginPage.EnterLoginPassword(Strings.LoginString.InputPassword);
            LoginPage.ClickOnGreenLoginButton();
            WishlistPage.EnterSearchPhrase(Strings.WishlistString.ItemSearchPhrase2);
            WishlistPage.ClickSearchButton();
            WishlistPage.ClickAddToWishlistButton();
            WishlistPage.OpenWishlistButton();

            try
            {
                Assert.That(WishlistPage.GetWishlistProductName(),
                    Is.EqualTo(Strings.WishlistString.WishlistItem1));

                WishlistPage.ClickAddToWishlistButton();

            }
            catch (Exception ex)
            {
                SearchPage.GetTestFailScreenshot();

                WishlistPage.ClickAddToWishlistButton();
            }
        }

        [Test]
        public void AddItemToCart()
        {
            CartPage.ClickAllowAllCookies();
            CartPage.EnterSearchPhrase(Strings.CartString.ItemSearchPhrase3);
            CartPage.ClickSearchButton();
            CartPage.SelectSortDropdown();
            CartPage.SelectSortDropdownValue();
            CartPage.ClickOnCartItemOne();
            CartPage.AddToCartFirstProduct();
            CartPage.ClickContinueShoppingButton();
            CartPage.EnterSearchPhrase(Strings.CartString.ItemSearchPhrase4);
            CartPage.ClickSearchButton();
            CartPage.ScrollIntoView();
            CartPage.ClickOnCartItemTwo();
            CartPage.AddToCartSecondProduct();
            CartPage.ClickContinueShoppingButton();
            CartPage.ClickCartButton();

        }
    }
}
