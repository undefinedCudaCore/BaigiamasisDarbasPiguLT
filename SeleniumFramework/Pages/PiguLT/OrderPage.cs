using SeleniumFramework.Pages.PiguLTPage;

namespace SeleniumFramework.Pages.PiguLT
{
    public class OrderPage
    {
        public static void ClickInformationButton()
        {
            Common.ClickElement(Locators.OrderPage.Information);
        }

        public static void ClickTrackOrderButton()
        {
            Common.ClickElement(Locators.OrderPage.TrackOrder);
        }

        public static void ClickSelectOrderDropdown()
        {
            Common.ClickElement(Locators.OrderPage.SelectOrderDropdown);
        }

        public static void ClickSelectOrderDropdownValue()
        {
            Common.ClickElement(Locators.OrderPage.SelectOrderDropdownValue);
        }

        public static string GetOrderStatus()
        {
            return Common.GetElementText(Locators.OrderPage.OrderInformation);
        }
    }
}
