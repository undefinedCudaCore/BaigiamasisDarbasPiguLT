using NUnit.Framework;
using SeleniumFramework.Pages.PiguLT;
using SeleniumFramework.Pages.PiguLTPage;
using SeleniumTests.BaseTests;

namespace SeleniumTests.PiguLT
{
    internal class AddAddress : BaseTest
    {
        [Test]
        public void CheckAddAddressInformation()
        {
            HomePage.HoverOnProfileIcon();
            AddressPage.ClickOnMyAccount();
            AddressPage.ClickOnDeliveryAddress();
            AddressPage.ClickAddNewAddressButton();
            AddressPage.EnterCustomerName(TestData.Address.NameText);
            AddressPage.EnterCustomerLastName(TestData.Address.LastNameText);
            AddressPage.EnterCustomerPhoneNumber(TestData.Address.PhoneText);
            AddressPage.ClickCityDropdown();
            AddressPage.SelectFromCityDropdown();
            AddressPage.EnterCustomerAddress(TestData.Address.AddressText);
            AddressPage.EnterCustomerPostCode(TestData.Address.PostCodeText);
            AddressPage.ClickSaveChangesButton();

            int addressCount = AddressPage.GetAddressCount();
            string addressDefault = AddressPage.GetDefaultAddress();
            string addressNew = AddressPage.GetNewAddress();

            Assert.That(addressCount, Is.EqualTo(2));
            Assert.That(addressNew, Is.EqualTo(TestData.Address.AccountAddress));
            Assert.That(addressDefault, Is.EqualTo(TestData.Address.AccountAddress));

            AddressPage.ClickAddressTrashIcon();
            AddressPage.ClickDeleteAddress();

            addressCount = AddressPage.GetAddressCount();
            Assert.That(addressCount, Is.EqualTo(1));
        }
    }
}
