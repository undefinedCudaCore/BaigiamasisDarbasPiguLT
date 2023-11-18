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
            string locator = Locators.CartPage.SelectSortDropdown;
            Common.ClickElement(locator);
        }

        public static void SelectSortDropdownValue()
        {
            string locator = Locators.CartPage.SelectProductSortDropdownValue;
            Common.ClickElement(locator);
        }

        public static void ClickOnCartItemImegaOne()
        {
            Common.WaitForElement();

            string locator = Locators.CartPage.FoundItemImage1;
            Common.ClickElement(locator);
        }

        public static void ClickOnCartItemImageTwo()
        {
            string locator = Locators.CartPage.FoundItemImage2;
            Common.ClickElement(locator);
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

            string locator = Locators.CartPage.RemoveItem;
            Common.ClickElement(locator);
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
            string locator = Locators.CartPage.CartButton;
            Common.ClickElement(locator);

            FirstItemNameForAssert();
        }

        public static void ClickCartButtonSecondTime()
        {
            string locator = Locators.CartPage.CartButton;
            Common.ClickElement(locator);

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
