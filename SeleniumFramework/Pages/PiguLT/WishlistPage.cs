namespace SeleniumFramework.Pages.PiguLTPage
{
    public class WishlistPage
    {
        public static void ClickAddToWishlistButton()
        {
            Common.ClickElement(Locators.WishlistPage.AddToWishlistButton);
        }

        public static void OpenWishlistButton()
        {
            Common.ClickElement(Locators.WishlistPage.OpenWishlist);
        }

        public static string GetWishlistProductName()
        {
            return Common.GetElementText(Locators.WishlistPage.WishlistProductName);
        }
    }
}
