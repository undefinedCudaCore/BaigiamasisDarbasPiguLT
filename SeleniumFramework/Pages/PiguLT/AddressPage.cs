namespace SeleniumFramework.Pages.PiguLTPage
{
    public class AddressPage
    {
        public static void ClickOnMyAccount()
        {
            Common.ClickElement(Locators.AddressPage.MyAccount);
        }

        public static void ClickOnDeliveryAddress()
        {
            Common.ClickElement(Locators.AddressPage.DeliveryAddress);
        }

        public static void ClickAddNewAddressButton()
        {
            Common.ClickElement(Locators.AddressPage.AddNewAddressButton);
        }

        public static void ClickAddressTrashIcon()
        {
            Common.ClickElement(Locators.AddressPage.AddressTrashIcon);
        }

        public static void ClickDeleteAddress()
        {
            Common.WaitForElementToBeVisible(Locators.AddressPage.RemoveAddressButton);
            Common.ClickElement(Locators.AddressPage.RemoveAddressButton);
        }

        public static void EnterCustomerName(string name)
        {
            Common.SendKeysToElement(Locators.AddressPage.InputName, name);
        }

        public static void EnterCustomerLastName(string lastName)
        {
            Common.SendKeysToElement(Locators.AddressPage.InputLastname, lastName);
        }

        public static void EnterCustomerPhoneNumber(string phoneNumber)
        {
            Common.SendKeysToElement(Locators.AddressPage.InputPhone, phoneNumber);
        }

        public static void EnterCustomerAddress(string address)
        {
            Common.SendKeysToElement(Locators.AddressPage.InputAddress, address);
        }

        public static void EnterCustomerPostCode(string postCode)
        {
            Common.SendKeysToElement(Locators.AddressPage.InputPostCode, postCode);
        }

        public static void ClickCityDropdown()
        {
            Common.ClickElement(Locators.AddressPage.SelectCityDropdown);
        }

        public static void SelectFromCityDropdown()
        {
            Common.ClickElement(Locators.AddressPage.SelectCityDropdownValue);
        }

        public static void ClickSaveChangesButton()
        {
            Common.ClickElement(Locators.AddressPage.SaveChangesButton);
        }

        public static string GetDefaultAddress()
        {
            Common.WaitForElementToBeVisible(Locators.AddressPage.DefaultSavedAddress);
            return Common.GetElementText(Locators.AddressPage.DefaultSavedAddress);
        }
        public static string GetNewAddress()
        {
            string locator = "(//*[contains(@class,'custom-address-col')])[2]//p[1]";
            Common.WaitForElementToBeVisible(locator);
            return Common.GetElementText(locator);
        }

        public static int GetAddressCount()
        {
            return Common.GetElementCount("//*[contains(@class,'custom-address-col')]");
        }
    }
}
