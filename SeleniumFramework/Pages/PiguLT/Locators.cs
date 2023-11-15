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
        internal class SearchItemPage
        {
            internal static string AllowCookiesButton = "//*[@id='cookie_block']//*/button[3]";
            internal static string InputSearch = "//*[@id='searchInput']";
            internal static string InputSearchButton = "//*[@id='main-search-form']/button[2]";
            internal static string FoundItemImgButton = "//*[@id='productBlock95591527']/div/div/div[3]/a";
            internal static string MoreInformationButton = "//*[@id='field-info-target']/i";
            internal static string ProductName = "//*[@id='product-info']/h1";
            internal static string ProductManufactureCode = "//*[@id='field-info']/div/div/table/tbody/tr[3]/td[2]";
        }

        internal class WishlistPage
        {
            internal static string AddToWishlistButton = "//*[@id='productBlock98465129']//*/button";
        }
    }
}
