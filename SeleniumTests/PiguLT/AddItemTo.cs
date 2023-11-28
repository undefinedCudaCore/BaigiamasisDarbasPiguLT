using NUnit.Framework;
using SeleniumFramework.Pages.PiguLTPage;
using SeleniumTests.BaseTests;

namespace SeleniumTests.PiguLT
{
    internal class AddItemTo : BaseTest
    {
        [Test]
        public void AddItemToWishList()
        {
            SearchPage.EnterSearchPhrase(TestData.Wishlist.ItemSearchPhrase2);
            SearchPage.ClickSearchButton();
            WishlistPage.ClickAddToWishlistButton();
            WishlistPage.OpenWishlistButton();
            WishlistPage.ClickAddToWishlistButton();

            Assert.That(WishlistPage.GetWishlistProductName(), Is.EqualTo(TestData.Wishlist.WishlistItem1));
        }

        [Test]
        public void AddFirstItemToCart()
        {
            SearchPage.EnterSearchPhrase(TestData.Cart.ItemSearchPhrase3);
            SearchPage.ClickSearchButton();
            CartPage.ClickSortDropdown();
            CartPage.SelectSortPriceDescending();
            CartPage.ClickOnCartItemImageOne();
            CartPage.ClickAddToCart();
            CartPage.ClickContinueShoppingButton();
            CartPage.ClickCartButton();
            string actualName = CartPage.GetFirstItemName();
            CartPage.ClickRemoveFromProductFromCart();

            Assert.That(actualName, Is.EqualTo(TestData.Cart.CartFirstItemName));
        }

        [Test]
        public void AddSecondItemToCart()
        {
            SearchPage.EnterSearchPhrase(TestData.Cart.ItemSearchPhrase4);
            SearchPage.ClickSearchButton();
            CartPage.ClickOnCartItemImageTwo();
            CartPage.ClickAddToCart();
            CartPage.ClickContinueShoppingButton();
            CartPage.ClickCartButton();
            string actualTitle = CartPage.GetSecondItemName();
            CartPage.ClickRemoveFromProductFromCart();

            Assert.That(actualTitle, Is.EqualTo(TestData.Cart.CartSecondItemName));
        }
    }
}
