using NUnit.Framework;
using SeleniumFramework.Pages.PiguLT;
using SeleniumFramework.Pages.PiguLTPage;
using SeleniumTests.BaseTests;

namespace SeleniumTests.PiguLT
{
    internal class AddAddress : BaseTest
    {
        internal class AddressTestData
        {
            public static string Name = "Demis";
            public static string LastName = "Karibidis";
            public static string Phone = "+37066105589";
            public static string Address = "Testo g. 12";
            public static string PostCode = "03642";
            public static string AccountAddress = "Testo g. 12, 03642, Vilnius";
        }

        [Test]
        public void CheckAddressInformation()
        {
            LoginPage.ClickOnProfileIcon();
            AddressPage.ClickOnMyOrders();
            AddressPage.ClickOnMyAddress();
            AddressPage.ClickAddAddressButton();
            AddressPage.EnterCustomerName(AddressTestData.Name);
            AddressPage.EnterCustomerLastName(AddressTestData.LastName);
            AddressPage.EnterCustomerPhoneNumber(AddressTestData.Phone);
            AddressPage.InitializeCityDropdown();
            AddressPage.SelectFromCityDropdown();
            AddressPage.EnterCustomerAddressr(AddressTestData.Address);
            AddressPage.EnterCustomerPostCode(AddressTestData.PostCode);
            AddressPage.ClickSaveChangesButton();

            Assert.That(AddressPage.GetAddress(), Is.EqualTo(AddressTestData.AccountAddress));
        }
    }
}
