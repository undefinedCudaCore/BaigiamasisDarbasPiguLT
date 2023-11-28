namespace SeleniumFramework.Pages.PiguLTPage
{
    public class CartPage
    {

        public static void ClickSortDropdown()
        {
            Common.ClickElement(Locators.CartPage.SelectSortDropdown);
        }

        public static void SelectSortDropdownValue()
        {
            Common.ClickElement(Locators.CartPage.SelectProductSortDropdownValue);
            Common.WaitForElementToNotExist("//*[@class='loader-overlay']");
        }

        public static void ClickOnCartItemImegaOne()
        {
            Common.ClickElement(Locators.CartPage.FoundItemImage1);
        }

        public static void ClickOnCartItemImageTwo()
        {
            Common.ClickElement(Locators.CartPage.FoundItemImage2);
        }

        public static void AddToCartFirstProduct()
        {
            string locator = Locators.CartPage.ProductSidebarButton;
            Common.ClickElement(locator);
        }

        public static void AddToCartSecondProduct()
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

        public static void ClickCartButtonFirstTime()
        {
            Common.ClickElement(Locators.CartPage.CartButton);
        }

        public static void ClickCartButtonSecondTime()
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
