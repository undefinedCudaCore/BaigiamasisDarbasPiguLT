using SeleniumFramework.Pages.PiguLTPage;

namespace SeleniumFramework.Pages.PiguLT
{
    public class HomePage
    {
        public static void ClickAllowAllCookies()
        {
            Common.ClickElement(Locators.LoginPage.AllowCookiesButton);
        }

        public static void ClickOnProfileIcon()
        {
            Common.WaitForElement();

            Common.ClickElement(Locators.LoginPage.IconProfile);
        }

        public static void ClickOnBlueLoginButton()
        {
            Common.ClickElement(Locators.LoginPage.BlueLoginButton);
        }
    }
}
