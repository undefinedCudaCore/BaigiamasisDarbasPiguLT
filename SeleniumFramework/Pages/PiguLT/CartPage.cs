namespace SeleniumFramework.Pages.PiguLTPage
{
    public class CartPage
    {
        public static void ClickSortDropdown()
        {
            Common.ClickElement(Locators.CartPage.SelectSortDropdown);
        }

        public static void SelectSortPriceDescending()
        {
            Common.ClickElement(Locators.CartPage.SelectProductSortDropdownValue);
            Common.WaitForElementToNotExist("//*[@class='loader-overlay']");
        }

        public static void ClickOnCartItemImageOne()
        {
            Common.ClickElement(Locators.CartPage.FoundItemImage1);
        }

        public static void ClickOnCartItemImageTwo()
        {
            Common.ClickElement(Locators.CartPage.FoundItemImage2);
        }

        public static void ClickAddToCart()
        {
            string locator = Locators.CartPage.ProductSidebarButton;
            Common.ClickElement(locator);
        }

        public static void ClickRemoveFromProductFromCart()
        {
            Common.ClickElement(Locators.CartPage.RemoveItem);
        }

        public static void ClickContinueShoppingButton()
        {
            string locator = Locators.CartPage.ContinueShoppingButton;
            Common.WaitForElementToBeVisible(locator);
            Common.ClickElement(locator);
        }

        public static void ClickCartButton()
        {
            Common.ClickElement(Locators.CartPage.CartButton);
        }

        public static string GetFirstItemName()
        {
            return Common.GetElementText(Locators.CartPage.CartItemOne);
        }
        
        public static string GetSecondItemName()
        {
            return Common.GetElementText(Locators.CartPage.CartItemTwo);
        }
    }
}
