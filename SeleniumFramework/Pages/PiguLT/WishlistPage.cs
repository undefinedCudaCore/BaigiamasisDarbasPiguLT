namespace SeleniumFramework.Pages.PiguLTPage
{
    public class WishlistPage : SearchPage
    {
        public static void ClickAddToWishlistButton()
        {
            string locator = Locators.WishlistPage.AddToWishlistButton;
            Common.ClickElement(locator);
        }

        public static void OpenWishlistButton()
        {
            string locator = Locators.WishlistPage.OpenWishlist;
            Common.ClickElement(locator);
        }

        public static string GetWishlistProductName()
        {
            return Common.GetElementText(Locators.WishlistPage.WishlistProductName);
        }

    }
}
