using NUnit.Framework;
using SeleniumFramework.Pages.PiguLTPage;
using SeleniumTests.BaseTests;

namespace SeleniumTests.PiguLT
{
    internal class AddItemTo : BaseTest
    {
        internal class WishlistTestData
        {
            public static string ItemSearchPhrase2 = "pixel 8 pro";
            public static string WishlistItem1 = "Google Pixel 8 Pro 5G 12/128GB Obsidian GA04798-GB";
        }

        internal class CartTestData
        {
            public static string ItemSearchPhrase3 = "intel i-9";
            public static string ItemSearchPhrase4 = "AMD ryzen 9";
            public static string CartItemNameOne = "Katarata, UAB";
            public static string CartItemNameTwo = "PC GAMER";
        }

        [Test]
        public void AddItemToWishList()
        {
            SearchPage.EnterSearchPhrase(WishlistTestData.ItemSearchPhrase2);
            SearchPage.ClickSearchButton();
            WishlistPage.ClickAddToWishlistButton();
            WishlistPage.OpenWishlistButton();
            WishlistPage.ClickAddToWishlistButton();

            Assert.That(WishlistPage.GetWishlistProductName(), Is.EqualTo(WishlistTestData.WishlistItem1));
        }

        [Test]
        public void AddItemToCart()
        {
            SearchPage.EnterSearchPhrase(CartTestData.ItemSearchPhrase3);
            SearchPage.ClickSearchButton();
            CartPage.SelectSortDropdown();
            CartPage.SelectSortDropdownValue();
            CartPage.ClickOnCartItemOne();
            CartPage.AddToCartFirstProduct();
            CartPage.ClickContinueShoppingButton();
            SearchPage.EnterSearchPhrase(CartTestData.ItemSearchPhrase4);
            SearchPage.ClickSearchButton();
            CartPage.ScrollIntoView();
            CartPage.ClickOnCartItemTwo();
            CartPage.AddToCartSecondProduct();
            CartPage.ClickContinueShoppingButton();
            CartPage.ClickCartButton();
            CartPage.ItemOneNameForAssert();
            CartPage.ClickRemoveFromProductFromCart();
            CartPage.ClickRemoveFromProductFromCart();

            Assert.That(CartPage.itemOne, Is.EqualTo(CartTestData.CartItemNameOne));
        }
    }
}
