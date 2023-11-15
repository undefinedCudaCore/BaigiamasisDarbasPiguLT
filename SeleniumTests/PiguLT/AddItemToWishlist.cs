using NUnit.Framework;
using SeleniumFramework.Pages.PiguLTPage;
using SeleniumTests.BaseTests;

namespace SeleniumTests.PiguLT
{
    internal class AddItemToWishlist : BaseTest
    {
        [Test]
        public void AddItemToWishList()
        {
            string itemSearchPhrase = "pixel 8 pro";

            LoginPage.ClickOnProfileIcon();
            LoginPage.ClickOnBlueLoginButton();
            LoginPage.EnterLoginEmail(Strings.LoginString.InputEmail1);
            LoginPage.EnterLoginPassword(Strings.LoginString.InputPassword);
            LoginPage.ClickOnGreenLoginButton();
            //WishlistPage.ClickAllowAllCookies();
            WishlistPage.EnterSearchPhrase(itemSearchPhrase);
            WishlistPage.ClickSearchButton();
            WishlistPage.ClickAddToWishlistButton();
        }
    }
}
