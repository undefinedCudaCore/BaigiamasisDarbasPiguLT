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
            try
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
                WishlistPage.ClickAddToWishlistButton();

                Assert.That(WishlistPage.GetWishlistProductName(),
                    Is.EqualTo(Strings.WishlistString.WishlistItem1));
            }
            catch (Exception ex)
            {
                WishlistPage.GetTestFailScreenshot();
            }
        }

        [Test]
        public void AddItemToCart()
        {
            try
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
                CartPage.RemoveFromCartProduct();
                CartPage.RemoveFromCartProduct();

                Assert.That(CartPage.GetItemOneName(),
                    Is.EqualTo(Strings.CartString.CartItemNameOne));
                Assert.That(CartPage.GetItemTwoName(),
                    Is.EqualTo(Strings.CartString.CartItemNameTwo));
            }
            catch (Exception ex)
            {
                CartPage.GetTestFailScreenshot();
            }
        }
    }
}
