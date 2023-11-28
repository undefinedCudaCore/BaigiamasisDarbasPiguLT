using NUnit.Framework;
using SeleniumFramework.Pages.PiguLT;
using SeleniumFramework.Pages.PiguLTPage;

namespace SeleniumTests.BaseTests
{
    internal class BaseTestWithLogin : BaseTest
    {
        [SetUp]
        public void Login()
        {
            // Login to page
            // If you get the error "Too many logins, please try later." when trying to login, change the "EnterLoginEmail" variable. Select one from four:
            // InputEmail1; InputEmail2; InputEmail3; InputEmail4;
            HomePage.ClickAllowAllCookies();
            HomePage.HoverOnProfileIcon();
            HomePage.ClickOnBlueLoginButton();
            LoginPage.EnterLoginEmail(TestData.Login.InputEmail1);
            LoginPage.EnterLoginPassword(TestData.Login.InputPassword);
            LoginPage.ClickOnGreenLoginButton();
        }
    }
}
