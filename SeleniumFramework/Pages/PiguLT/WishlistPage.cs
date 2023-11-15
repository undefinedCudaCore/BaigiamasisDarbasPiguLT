namespace SeleniumFramework.Pages.PiguLTPage
{
    public class WishlistPage : SearchPage
    {
        public static void ClickAddToWishlistButton()
        {
            string locator = Locators.WishlistPage.AddToWishlistButton;
            Common.ClickElement(locator);
        }
    }
}
