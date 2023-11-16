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
            AddressPage.ClickOnMyOrders();
            AddressPage.ClickOnMyAddress();
            AddressPage.ClickAddAddressButton();
            AddressPage.EnterCustomerName(Strings.AddressString.Name);
            AddressPage.EnterCustomerLastName(Strings.AddressString.LastName);
            AddressPage.EnterCustomerPhoneNumber(Strings.AddressString.Phone);
            AddressPage.InitializeCityDropdown();
            AddressPage.SelectFromCityDropdown();
            AddressPage.EnterCustomerAddressr(Strings.AddressString.Address);
            AddressPage.EnterCustomerPostCode(Strings.AddressString.PostCode);
            AddressPage.ClickSaveChangesButton();

            Assert.That(AddressPage.GetAddress(), Is.EqualTo(Strings.AddressString.AccountAddress));
        }
    }
}
