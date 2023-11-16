using NUnit.Framework;
using SeleniumFramework.Pages.PiguLTPage;
using SeleniumTests.BaseTests;

namespace SeleniumTests.PiguLT
{
    internal class LoginToPage : BaseTest
    {
        public class LoginTestData
        {
            public static string InputEmail1 = "testforgraduationthesis@gmail.com";
            public static string InputEmail2 = "duationthetestforgraduat@gmail.com";
            public static string InputPassword = "seleniumtestforgraduationthesis";
            public static string DisplayMyAccountName = "Graduation Thesis";
        }

        //[Test]

        //If you want to test only the login functionality of a page functionality,
        //          you must comment on the login methods in the BaseTest class and uncomment the test annotation.
        public void LoginToWebShopAccount()
        {
            LoginPage.ClickAllowAllCookies();
            LoginPage.ClickOnProfileIcon();
            LoginPage.ClickOnBlueLoginButton();
            LoginPage.EnterLoginEmail(LoginTestData.InputEmail1);
            LoginPage.EnterLoginPassword(LoginTestData.InputPassword);
            LoginPage.ClickOnGreenLoginButton();
            LoginPage.ClickOnProfileIcon();
            LoginPage.ClickOnMyAccount();
            LoginPage.ClickOnEditProfile();
            LoginPage.GetMyAccountName();

            Assert.That(LoginPage.GetMyAccountName(), 
                    Is.EqualTo(LoginTestData.DisplayMyAccountName));
        }
    }
}
