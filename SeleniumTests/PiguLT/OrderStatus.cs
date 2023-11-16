using NUnit.Framework;
using SeleniumFramework.Pages.PiguLT;
using SeleniumFramework.Pages.PiguLTPage;
using SeleniumTests.BaseTests;

namespace SeleniumTests.PiguLT
{
    internal class OrderStatus :BaseTest
    {
        [Test]
        public void OrderStatucCheck()
        {
            SearchPage.ClickAllowAllCookies();
            LoginPage.ClickOnProfileIcon();
            LoginPage.ClickOnBlueLoginButton();
            LoginPage.EnterLoginEmail(Strings.LoginString.InputEmail1);
            LoginPage.EnterLoginPassword(Strings.LoginString.InputPassword);
            LoginPage.ClickOnGreenLoginButton();

            OrderPage.ClickInformationButton();
            OrderPage.ClickTrackOrderButton();
            OrderPage.ClickSelectOrderDropdown();
            OrderPage.ClickSelectOrderDropdownValue();

            Assert.That(OrderPage.GetOrderStatus(), Is.EqualTo(Strings.OrderString.OrderStatus));
        }
    }
}
