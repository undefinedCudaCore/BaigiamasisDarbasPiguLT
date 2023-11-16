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
            SearchPage.EnterSearchPhrase(Strings.WishlistString.ItemSearchPhrase2);
            SearchPage.ClickSearchButton();
            WishlistPage.ClickAddToWishlistButton();
            WishlistPage.OpenWishlistButton();
            WishlistPage.ClickAddToWishlistButton();

            Assert.That(WishlistPage.GetWishlistProductName(), Is.EqualTo(Strings.WishlistString.WishlistItem1));
        }

        [Test]
        public void AddItemToCart()
        {
            SearchPage.EnterSearchPhrase(Strings.CartString.ItemSearchPhrase3);
            SearchPage.ClickSearchButton();
            CartPage.SelectSortDropdown();
            CartPage.SelectSortDropdownValue();
            CartPage.ClickOnCartItemOne();
            CartPage.AddToCartFirstProduct();
            CartPage.ClickContinueShoppingButton();
            SearchPage.EnterSearchPhrase(Strings.CartString.ItemSearchPhrase4);
            SearchPage.ClickSearchButton();
            CartPage.ScrollIntoView();
            CartPage.ClickOnCartItemTwo();
            CartPage.AddToCartSecondProduct();
            CartPage.ClickContinueShoppingButton();
            CartPage.ClickCartButton();
            CartPage.ItemOneNameForAssert();
            CartPage.ClickRemoveFromProductFromCart();
            CartPage.ClickRemoveFromProductFromCart();

            Assert.That(CartPage.itemOne, Is.EqualTo(Strings.CartString.CartItemNameOne));
        }
    }
}
