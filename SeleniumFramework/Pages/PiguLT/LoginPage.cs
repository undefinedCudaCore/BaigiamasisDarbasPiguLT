namespace SeleniumFramework.Pages.PiguLTPage
{
    public class LoginPage
    {
        public static void Open()
        {
            Driver.OpenPage("https://pigu.lt/lt/");
        }

        public static void ClickOnProfileIcon()
        {
            string locator = Locators.LoginPage.IconProfile;
            Common.ClickElement(locator);
        }

        public static void ClickOnBlueLoginButton()
        {
            string locator = Locators.LoginPage.BlueLoginButton;
            Common.ClickElement(locator);
        }

        public static void EnterLoginEmail(string loginEmail)
        {
            string locator = Locators.LoginPage.InputEmail;
            Common.SendKeysToElement(locator, loginEmail);
        }

        public static void EnterLoginPassword(string loginPassword)
        {
            string locator = Locators.LoginPage.InputPassword;
            Common.SendKeysToElement(locator, loginPassword);
        }

        public static void ClickOnGreenLoginButton()
        {
            string locator = Locators.LoginPage.GreenLoginButton;
            Common.ClickElement(locator);
        }

        public static void ClickOnMyAccount()
        {
            string locator = Locators.LoginPage.MyAccount;
            Common.ClickElement(locator);
        }

        public static void ClickOnEditProfile()
        {
            string locator = Locators.LoginPage.EditProfile;
            Common.ClickElement(locator);
        }

        public static string GetMyAccountName()
        {
            return Common.GetElementText(Locators.LoginPage.MyAccountName);
        }

        public static void GetFailScreenshot()
        {
            Common.TakeScreenshot();
        }
    }
}
