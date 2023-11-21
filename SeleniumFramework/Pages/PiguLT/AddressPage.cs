namespace SeleniumFramework.Pages.PiguLTPage
{
    public class AddressPage
    {
        public static string firstAddress;

        public static void ClickOnMyAccount()
        {
            Common.WaitForElement();

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
            FirstItemNameForAssert();

            Common.WaitForElement();
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

        public static string GetAddress()
        {
            Common.WaitForElementToBeVisible(Locators.AddressPage.SavedAddress);

            return Common.GetElementText(Locators.AddressPage.SavedAddress);
        }

        public static string FirstItemNameForAssert()
        {
            Common.WaitForElement();

            firstAddress = GetAddress();
            return firstAddress;
        }
    }
}
