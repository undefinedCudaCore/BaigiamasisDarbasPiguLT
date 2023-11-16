using NUnit.Framework;
using SeleniumFramework.Pages.PiguLTPage;
using SeleniumTests.BaseTests;

namespace SeleniumTests.PiguLT
{
    internal class LoginToPage : BaseTest
    {
        //[Test]
        
        //If you want to test only the login functionality of a page functionality,
        //          you must comment on the login methods in the BaseTest class and uncomment the test annotation.
        public void LoginToWebShopAccount()
        {
            LoginPage.ClickAllowAllCookies();
            LoginPage.ClickOnProfileIcon();
            LoginPage.ClickOnBlueLoginButton();
            LoginPage.EnterLoginEmail(Strings.LoginString.InputEmail1);
            LoginPage.EnterLoginPassword(Strings.LoginString.InputPassword);
            LoginPage.ClickOnGreenLoginButton();
            LoginPage.ClickOnProfileIcon();
            LoginPage.ClickOnMyAccount();
            LoginPage.ClickOnEditProfile();
            LoginPage.GetMyAccountName();

            Assert.That(LoginPage.GetMyAccountName(), 
                    Is.EqualTo(Strings.LoginString.DisplayMyAccountName));
        }
    }
}
