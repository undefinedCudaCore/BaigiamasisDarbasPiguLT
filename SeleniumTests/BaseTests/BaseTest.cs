using NUnit.Framework;
using NUnit.Framework.Interfaces;
using SeleniumFramework;
using SeleniumFramework.Pages.PiguLT;
using SeleniumFramework.Pages.PiguLTPage;

namespace SeleniumTests.BaseTests
{
    internal class BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            Driver.OpenPage("https://pigu.lt/lt/");
            Driver.MaximizeWindow();

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

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                Driver.TakeScreenshot();
            }
            Driver.QuitDriver();
        }
    }
}
