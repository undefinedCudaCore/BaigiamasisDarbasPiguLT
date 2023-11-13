using NUnit.Framework;
using SeleniumFramework.Pages.PiguLTPage;
using SeleniumTests.BaseTests;
using System;

namespace SeleniumTests.PiguLT
{
    internal class LoginToPage : BaseTest
    {
        [Test]
        public void LoginToWebShopAccount()
        {
            string loginEmail = "testforgraduationthesis@gmail.com";
            string loginPassword = "seleniumtestforgraduationthesis";
            //string loginEmail = "duationthetestforgraduat@gmail.com";
            //string loginPassword = "seleniumtestforgraduationthesis";
            string displayMyAccountName = "Graduation Thesis";

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

            try
            {
                Assert.That(LoginPage.GetMyAccountName(), Is.EqualTo(displayMyAccountName));
            }
            catch (Exception ex)
            {
                LoginPage.GetTestFailScreenshot();

                throw;
            }
        }
    }
}
