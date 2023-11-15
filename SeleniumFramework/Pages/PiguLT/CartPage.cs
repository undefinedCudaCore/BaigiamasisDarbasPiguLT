namespace SeleniumFramework.Pages.PiguLTPage
{
    public class CartPage : SearchPage
    {
        public static void SelectSortDropdown()
        {
            string locator = Locators.CartPage.SelectDropdown;
            Common.ClickElement(locator);
        }

    }
}
