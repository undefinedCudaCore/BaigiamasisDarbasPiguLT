using NUnit.Framework;
using SeleniumFramework.Pages.PiguLT;
using SeleniumFramework.Pages.PiguLTPage;
using SeleniumTests.BaseTests;

namespace SeleniumTests.PiguLT
{
    internal class AddAddress : BaseTest
    {
        [Test]
        public void CheckAddressInformation()
        {
            LoginPage.ClickOnProfileIcon();
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

            Assert.That(AddressPage.GetAddress(), Is.EqualTo(TestData.Address.AccountAddress));
        }
    }
}
