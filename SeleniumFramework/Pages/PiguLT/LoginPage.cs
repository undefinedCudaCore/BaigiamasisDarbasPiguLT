namespace SeleniumFramework.Pages.PiguLTPage
{
    public class LoginPage
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

        public static void EnterLoginEmail(string loginEmail)
        {
            Common.SendKeysToElement(Locators.LoginPage.InputEmail, loginEmail);
        }

        public static void EnterLoginPassword(string loginPassword)
        {
            Common.SendKeysToElement(Locators.LoginPage.InputPassword, loginPassword);
        }

        public static void ClickOnGreenLoginButton()
        {
            Common.ClickElement(Locators.LoginPage.GreenLoginButton);
        }

        public static void ClickOnMyAccount()
        {
            Common.ClickElement(Locators.LoginPage.MyAccount);
        }

        public static void ClickOnEditProfile()
        {
            Common.ClickElement(Locators.LoginPage.EditProfile);
        }

        public static string GetMyAccountName()
        {
            return Common.GetElementText(Locators.LoginPage.MyAccountName);
        }
    }
}
