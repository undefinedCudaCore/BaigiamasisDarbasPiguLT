namespace SeleniumFramework.Pages.PiguLTPage
{
    internal class Locators
    {
        internal class LoginPage
        {
            internal static string IconProfile = "//*[@id='headeMenu']/li[1]/a/i";
            internal static string BlueLoginButton = "//*[@id='headeMenu']/li[1]/div/div/div[2]/a[1]";
            internal static string InputEmail = "//*[@id='loginModal']/div[1]/div[1]/form/div[3]/input";
            internal static string InputPassword = "//*[@id='passwordCont']/input";
            internal static string GreenLoginButton = "//*[@id='loginModal']/div[1]/div[1]/form/div[6]/input";
            internal static string MyAccount = "//*[@id='headeMenu']/li[1]/div/ul[1]/li/a";
            internal static string EditProfile = "//a[contains(@href, 'u/info')]";
            internal static string MyAccountName = "//*[@id='editMyInfo']/div[2]/div/div[1]";
        }
    }
}
