using SeleniumFramework.Pages.PiguLTPage;
using System;

namespace SeleniumFramework.Pages.PiguLT
{
    public class AddressPage
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
        public static void EnterCustomerAddressr(string address)
        {
            string locator = Locators.AddressPage.InputAddress;
            Common.SendKeysToElement(locator, address);
        }

        public static void EnterCustomerPostCode(string postCode)
        {
            string locator = Locators.AddressPage.InputPostCode;
            Common.SendKeysToElement(locator, postCode);
        }

        public static void InitializeCityDropdown()
        {
            string locator = Locators.AddressPage.SelectCityDropdown;
            Common.ClickElement(locator);
        }

        public static void SelectFromCityDropdown()
        {
            string locator = Locators.AddressPage.SelectCityDropdownValue;
            Common.ClickElement(locator);
        }

        public static void ClickSaveChangesButton()
        {
            string locator = Locators.AddressPage.SaveChangesButton;
            Common.ClickElement(locator);
        }

        public static string GetAddress()
        {
            string locator = Locators.AddressPage.SavedAddress;
            Common.WaitForElementToBeVisible(locator);

            return Common.GetElementText(locator);
        }
    }
}
