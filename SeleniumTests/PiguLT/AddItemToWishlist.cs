using NUnit.Framework;
using SeleniumFramework.Pages.PiguLTPage;
using SeleniumTests.BaseTests;
using System;

namespace SeleniumTests.PiguLT
{
    internal class AddItemToWishlist : BaseTest
    {
        [Test]
        public void AddItemToWishList()
        {
            LoginPage.ClickOnProfileIcon();
            LoginPage.ClickOnBlueLoginButton();
            LoginPage.EnterLoginEmail(Strings.LoginString.InputEmail1);
            LoginPage.EnterLoginPassword(Strings.LoginString.InputPassword);
            LoginPage.ClickOnGreenLoginButton();
            WishlistPage.EnterSearchPhrase(Strings.WishlistString.ItemSearchPhrase2);
            WishlistPage.ClickSearchButton();
            WishlistPage.ClickAddToWishlistButton();
            WishlistPage.OpenWishlistButton();

            try
            {
                Assert.That(WishlistPage.GetWishlistProductName(),
                    Is.EqualTo(Strings.WishlistString.WishlistItem1));
            }
            catch (Exception ex)
            {
                SearchPage.GetTestFailScreenshot();

                throw;
            }
        }
    }
}
