using NUnit.Framework;
using SeleniumFramework.Pages.PiguLTPage;
using SeleniumTests.BaseTests;


namespace SeleniumTests.PiguLT
{
    internal class LoginScenario : BaseTest
    {
        [Test]
        public void LoginToWebShopAccount()
        {
            string loginEmail = "testforgraduationthesis@gmail.com";
            string loginPassword = "seleniumtestforgraduationthesis";

            LoginPage.Open();
            LoginPage.ClickOnProfileIcon();
            LoginPage.ClickOnBlueLoginButton();
            LoginPage.EnterLoginEmail(loginEmail);
            LoginPage.EnterLoginPassword(loginPassword);
            LoginPage.ClickOnGreenLoginButton();
            LoginPage.ClickOnProfileIcon();
            LoginPage.ClickOnMyAccount();
            LoginPage.ClickOnEditProfile();
            LoginPage.GetMyAccountName();
        }
    }
}
