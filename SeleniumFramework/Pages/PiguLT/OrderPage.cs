using SeleniumFramework.Pages.PiguLTPage;

namespace SeleniumFramework.Pages.PiguLT
{
    public class OrderPage
    {
        public static void ClickInformationButton()
        {
            string locator = Locators.OrderPage.Information;
            Common.ClickElement(locator);
        }

        public static void ClickTrackOrderButton()
        {
            string locator = Locators.OrderPage.TrackOrder;
            Common.ClickElement(locator);
        }

        public static void ClickSelectOrderDropdown()
        {
            string locator = Locators.OrderPage.SelectOrderDropdown;
            Common.ClickElement(locator);
        }

        public static void ClickSelectOrderDropdownValue()
        {
            string locator = Locators.OrderPage.SelectOrderDropdownValue;
            Common.ClickElement(locator);
        }

        public static string GetOrderStatus()
        {
            return Common.GetElementText(Locators.OrderPage.OrderInformation);
        }
    }
}
