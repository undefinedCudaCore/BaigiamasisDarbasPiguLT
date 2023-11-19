using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SeleniumFramework.Pages.PiguLTPage
{
    public class CartPage
    {
        public static string cartFirstItem;
        public static string cartSecondItem;

        public static void ClickSortDropdown()
        {
            Common.ClickElement(Locators.CartPage.SelectSortDropdown);
        }

        public static void SelectSortDropdownValue()
        {
            Common.ClickElement(Locators.CartPage.SelectProductSortDropdownValue);
        }

        public static void ClickOnCartItemImegaOne()
        {
            Common.WaitForElement();

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

            Common.WaitForElementToBeVisible(locator);
        }

        public static void AddToCartSecondProduct()
        {
            string locator = Locators.CartPage.ProductSidebarButton;
            Common.ClickElement(locator);

            Common.WaitForElementToBeVisible(locator);
        }

        public static void ClickRemoveFromProductFromCart()
        {
            Common.WaitForElement();

            Common.ClickElement(Locators.CartPage.RemoveItem);
        }

        public static void ClickContinueShoppingButton()
        {
            string locator = Locators.CartPage.ContinueShoppingButton;
            
            Common.WaitForElementToBeVisible(locator);
            Common.ClickElement(locator);
        }

        public static void ScrollIntoView()
        {
            IWebElement locator = Common.GetElementToScroll(Locators.CartPage.FoundItemImage2);
            Actions actions = new Actions(Driver.GetDriver());
            actions.MoveToElement(locator).Perform();
        }

        public static void ClickCartButtonFirstTime()
        {
            Common.ClickElement(Locators.CartPage.CartButton);

            FirstItemNameForAssert();
        }

        public static void ClickCartButtonSecondTime()
        {
            Common.ClickElement(Locators.CartPage.CartButton);

            SecondItemNameForAssert();
        }

        public static string GetFirstItemName()
        {
            return Common.GetElementText(Locators.CartPage.CartItemOne);
        }
        
        public static string GetSecondItemName()
        {
            return Common.GetElementText(Locators.CartPage.CartItemTwo);
        }

        public static string FirstItemNameForAssert()
        {
            Common.WaitForElement();

            cartFirstItem = GetFirstItemName();
            return cartFirstItem;
        }

        public static string SecondItemNameForAssert()
        {
            Common.WaitForElement();

            cartSecondItem = GetSecondItemName();
            return cartSecondItem;
        }
    }
}
