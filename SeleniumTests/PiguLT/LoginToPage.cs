using NUnit.Framework;
using SeleniumFramework.Pages.PiguLT;
using SeleniumFramework.Pages.PiguLTPage;
using SeleniumTests.BaseTests;

namespace SeleniumTests.PiguLT
{
    internal class LoginToPage : BaseTest
    {
        //[Test]

        // If you want to test only the login functionality of a page functionality,
        //          you must comment on the login methods in the BaseTest class and uncomment the test annotation.
        // LoginToPage test passes only with "InputEmail1" variable indicated in the "EnterLoginEmail" method.
        public void LoginToWebShopAccount()
        {
            HomePage.ClickAllowAllCookies();
            HomePage.ClickOnProfileIcon();
            HomePage.ClickOnBlueLoginButton();
            LoginPage.EnterLoginEmail(TestData.Login.InputEmail1);
            LoginPage.EnterLoginPassword(TestData.Login.InputPassword);
            LoginPage.ClickOnGreenLoginButton();
            HomePage.ClickOnProfileIcon();
            LoginPage.ClickOnMyAccount();
            LoginPage.ClickOnEditProfile();
            LoginPage.GetMyAccountName();

            Assert.That(LoginPage.GetMyAccountName(), Is.EqualTo(TestData.Login.DisplayMyAccountName));
        }
    }
}
