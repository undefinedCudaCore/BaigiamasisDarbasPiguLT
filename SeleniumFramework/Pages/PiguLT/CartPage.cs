using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SeleniumFramework.Pages.PiguLTPage
{
    public class CartPage : SearchPage
    {
        public static void SelectSortDropdown()
        {
            string locator = Locators.CartPage.SelectDropdown;
            Common.ClickElement(locator);
        }

        public static void SelectSortDropdownValue()
        {
            string locator = Locators.CartPage.SelectDropdownValue;
            Common.ClickElement(locator);
        }

        public static void ClickOnCartItemOne()
        {
            Common.WaitForElement();

            string locator = Locators.CartPage.FoundItemImage1;
            Common.ClickElement(locator);
        }

        public static void ClickOnCartItemTwo()
        {
            string locator = Locators.CartPage.FoundItemImage2;
            Common.ClickElement(locator);
        }

        public static void AddToCartFirstProduct()
        {
            string locator = Locators.CartPage.ProductSidebarButton;
            Common.ClickElement(locator);

            Common.WaitForElement();
        }

        public static void AddToCartSecondProduct()
        {
            string locator = Locators.CartPage.ProductSidebarButton;
            Common.ClickElement(locator);

            Common.WaitForElement();
        }

        public static void RemoveFromCartProduct()
        {
            Common.WaitForElement();

            string locator = Locators.CartPage.RemoveItem;
            Common.ClickElement(locator);
        }

        public static void ClickContinueShoppingButton()
        {
            string locator = Locators.CartPage.ContinueShoppingButton;
            Common.ClickElement(locator);
        }

        public static void ScrollIntoView()
        {
            IWebElement locator = Common.GetElementToScroll(Locators.CartPage.FoundItemImage2);
            Actions actions = new Actions(Driver.GetDriver());
            actions.MoveToElement(locator).Perform();
        }

        public static void ClickCartButton()
        {
            string locator = Locators.CartPage.CartButton;
            Common.ClickElement(locator);
        }

        public static string GetItemOneName()
        {
            return Common.GetElementText(Locators.CartPage.CartItemOne);
        }
        public static string GetItemTwoName()
        {
            return Common.GetElementText(Locators.CartPage.CartItemTwo);
        }
    }
}
