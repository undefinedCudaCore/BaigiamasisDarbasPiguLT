using SeleniumFramework.Pages.PiguLTPage;

namespace SeleniumFramework.Pages.PiguLT
{
    public class AddressPage
    {
        public static string firstAddress;

        public static void ClickOnMyAccount()
        {
            Common.WaitForElement();

            string locator = Locators.AddressPage.MyAccount;
            Common.ClickElement(locator);
        }

        public static void ClickOnDeliveryAddress()
        {
            string locator = Locators.AddressPage.DeliveryAddress;
            Common.ClickElement(locator);
        }

        public static void ClickAddNewAddressButton()
        {
            string locator = Locators.AddressPage.AddNewAddressButton;
            Common.ClickElement(locator);
        }

        public static void ClickAddressTrashIcon()
        {
            FirstItemNameForAssert();

            Common.WaitForElement();
            Common.ClickElement(Locators.AddressPage.AddressTrashIcon);
        }

        public static void ClickRemoveAddress()
        {
            Common.WaitForElementToBeVisible(Locators.AddressPage.RemoveAddressButton);
            Common.ClickElement(Locators.AddressPage.RemoveAddressButton);
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
        public static void EnterCustomerAddress(string address)
        {
            string locator = Locators.AddressPage.InputAddress;
            Common.SendKeysToElement(locator, address);
        }

        public static void EnterCustomerPostCode(string postCode)
        {
            string locator = Locators.AddressPage.InputPostCode;
            Common.SendKeysToElement(locator, postCode);
        }

        public static void ClickCityDropdown()
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

        public static string FirstItemNameForAssert()
        {
            Common.WaitForElement();

            firstAddress = GetAddress();
            return firstAddress;
        }
    }
}
