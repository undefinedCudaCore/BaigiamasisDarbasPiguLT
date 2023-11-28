using SeleniumFramework.Pages.PiguLTPage;

namespace SeleniumFramework.Pages.PiguLT
{
    public class HomePage
    {
        public static void ClickAllowAllCookies()
        {
            Common.ClickElement(Locators.LoginPage.AllowCookiesButton);
            Common.WaitForPageToLoad();
        }

        public static void HoverOnProfileIcon()
        {
            Common.HoverOverElement(Locators.LoginPage.IconProfile);
        }

        public static void ClickOnBlueLoginButton()
        {
            Common.ClickElement(Locators.LoginPage.BlueLoginButton);
        }
    }
}
