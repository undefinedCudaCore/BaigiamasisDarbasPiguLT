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
            Common.WaitForSearchInput();

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

            Common.WaitForSearchInput();
        }

        public static void AddToCartSecondProduct()
        {
            Common.WaitForSearchInput();

            string locator = Locators.CartPage.ProductSidebarButton;
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
    }
}
