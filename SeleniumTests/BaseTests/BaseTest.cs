using NUnit.Framework;
using NUnit.Framework.Interfaces;
using SeleniumFramework;
using SeleniumFramework.Pages.PiguLTPage;
using SeleniumTests.PiguLT;

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

            //Login to page
            LoginPage.ClickAllowAllCookies();
            LoginPage.ClickOnProfileIcon();
            LoginPage.ClickOnBlueLoginButton();
            LoginPage.EnterLoginEmail(LoginToPage.LoginTestData.InputEmail1);
            LoginPage.EnterLoginPassword(LoginToPage.LoginTestData.InputPassword);
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
