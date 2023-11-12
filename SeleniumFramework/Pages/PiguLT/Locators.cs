namespace SeleniumFramework.Pages.PiguLTPage
{
    internal class Locators
    {
        internal class LoginPage
        {
            internal static string IconProfile = "//*[@id='headeMenu']/li[1]/a/i";
            internal static string BlueLoginButton = "//a[contains(@href, 'https://pigu.lt/lt/u/login')]";
            internal static string InputEmail = "//input[@name='email']";
            internal static string InputPassword = "//input[@name='password']";
            internal static string GreenLoginButton = "//input[@name='login']";
            internal static string MyAccount = "//*[@id='headeMenu']/li[1]/div/ul[1]/li/a";
            internal static string EditProfile = "//a[contains(@href, 'u/info')]";
            internal static string MyAccountName = "//*[@id='editMyInfo']/div[2]/div/div[1]";
        }

    }
}
