using SeleniumFramework.Pages.PiguLTPage;

namespace SeleniumFramework.Pages.PiguLT
{
    public class AddressPage : LoginPage
    {
        public static void ClickOnMyOrders()
        {
            string locator = Locators.AddressPage.MyOrders;
            Common.ClickElement(locator);
        }

        public static void ClickOnMyAddress()
        {
            string locator = Locators.AddressPage.MyAddress;
            Common.ClickElement(locator);
        }

        public static void ClickAddAddressButton()
        {
            string locator = Locators.AddressPage.AddAddressButton;
            Common.ClickElement(locator);
        }

        public static void EnterCustomerName(string name)
        {
            string locator = Locators.AddressPage.InputName;
            Common.SendKeysToElement(locator, name);
        }

        public static void EnterCustomerLastName(string lastName)
        {
            string locator = Locators.AddressPage.InputLastname;
            Common.SendKeysToElement(locator, lastName);
        }

        public static void EnterCustomerPhoneNumber(string phoneNumber)
        {
            string locator = Locators.AddressPage.InputPhone;
            Common.SendKeysToElement(locator, phoneNumber);
        }
    }
}
