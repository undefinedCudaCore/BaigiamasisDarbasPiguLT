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
            internal static string OpenWishlist = "//*[@id='headeMenu']/li[3]/a";
            internal static string WishlistProductName = "//*[@id='productBlock98465129']//*/p/a";
        }

        internal class CartPage
        {
            internal static string SelectProductSortDropdown = "//*[@id='sort_select']";
            internal static string SelectProductSortDropdownValue = "//*[@id='sort_selectpd']";
            internal static string FoundItemImage1 = "//*[@id='productBlock60011144']//*/div[3]/a";
            internal static string FoundItemImage2 = "//*[@id='productBlock95458347']//*/div[3]/a";
            internal static string ProductSidebarButton = "//*[@data-cy='product-page-add-to-cart']";
            internal static string ContinueShoppingButton = "//*[@id='continue']";
            internal static string CartButton = "//*[@id='cartWidget']";
            internal static string CartItemOne = "//*[@id='productSliceBlock434950543']/td[2]/div/a";
            internal static string CartItemTwo = "//*[@id='productSliceBlock434966868']/td[2]/div/a";
            internal static string RemoveItem = "//*[@widget-attachpoint='removeFromCart']";
        }

        internal class AddressPage
        {
            internal static string MyOrders = "//*[@id='headeMenu']/li[1]/div/ul[2]/li/a";
            internal static string MyAddress = "//*[@href='u/addresses/customers']";
            internal static string AddAddressButton = "//*[@href='https://pigu.lt/lt/u/customer/add']";
            internal static string InputName = "//*[@autocomplete='given-name']";
            internal static string InputLastname = "//*[@autocomplete='family-name']";
            internal static string InputPhone = "//*[@Name='phone']|//*[@placeholder='Pvz.: +37066105555']";
            internal static string SelectCityDropdown = "//*[@id='city_idFilter']";
            internal static string SelectCityDropdownValue = "//*[@id='city_id1']";
            internal static string InputAddress = "//*[@id='address']";
            internal static string InputPostCode = "//*[@name='post_code']";
            internal static string SaveChangesButton = "//*[@id='addressEdit']/form/div[2]/div[6]/a[2]";
        }
    }
}
