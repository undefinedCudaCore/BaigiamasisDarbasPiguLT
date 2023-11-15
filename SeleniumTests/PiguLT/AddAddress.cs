using NUnit.Framework;
using SeleniumFramework.Pages.PiguLT;
using SeleniumFramework.Pages.PiguLTPage;
using SeleniumTests.BaseTests;
using System;

namespace SeleniumTests.PiguLT
{
    internal class AddAddress : BaseTest
    {
        [Test]
        public void CheckAddressInformation()
        {
            try
            {
                AddressPage.ClickOnProfileIcon();
                AddressPage.ClickOnBlueLoginButton();
                AddressPage.EnterLoginEmail(Strings.LoginString.InputEmail2);
                AddressPage.EnterLoginPassword(Strings.LoginString.InputPassword);
                AddressPage.ClickOnGreenLoginButton();
                AddressPage.ClickOnProfileIcon();
                AddressPage.ClickOnMyOrders();
                AddressPage.ClickOnMyAddress();
                AddressPage.ClickAddAddressButton();
                AddressPage.EnterCustomerName(
                    Strings.AddressString.Name);
                AddressPage.EnterCustomerLastName(
                    Strings.AddressString.LastName);
                AddressPage.EnterCustomerPhoneNumber(
                    Strings.AddressString.Phone);
                AddressPage.InitializeCityDropdown();
                AddressPage.SelectFromCityDropdown();
                AddressPage.EnterCustomerAddressr(
                    Strings.AddressString.Address);
                AddressPage.EnterCustomerPostCode(
                    Strings.AddressString.PostCode);
                AddressPage.ClickSaveChangesButton();
            }
            catch (Exception)
            {
                AddressPage.GetTestFailScreenshot();
            }
        }

    }
}
