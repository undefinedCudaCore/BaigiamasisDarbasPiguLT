namespace SeleniumFramework.Pages.PiguLTPage
{
    public class TestData
    {
        public class Login
        {
            public static string InputEmail1 = "testforgraduationthesis@gmail.com";
            public static string InputEmail2 = "duationthetestforgraduat@gmail.com";
            public static string InputPassword = "seleniumtestforgraduationthesis";
            public static string DisplayMyAccountName = "Graduation Thesis";
        }

        public class SearchItem
        {
            public static string ItemSearchPhrase1 = "X515EA-BQ1735W";
            public static string FoundProductName = "Nešiojamas kompiuteris Asus X515EA-BQ1735W";
            public static string ManufacturerCode = "X515EA-BQ1735W";
        }

        public class Wishlist
        {
            public static string ItemSearchPhrase2 = "pixel 8 pro";
            public static string WishlistItem1 = "Google Pixel 8 Pro 5G 12/128GB Obsidian GA04798-GB";
        }

        public class Cart
        {
            public static string ItemSearchPhrase3 = "intel i-9";
            public static string ItemSearchPhrase4 = "AMD ryzen 9";
            public static string CartFirstItemName = "Katarata, UAB";
            public static string CartSecondItemName = "PC GAMER";
        }

        public class Address
        {
            public static string NameText = "Demis";
            public static string LastNameText = "Karibidis";
            public static string PhoneText = "+37066105589";
            public static string AddressText = "Testo g. 12";
            public static string PostCodeText = "03642";
            public static string AccountAddress = "Testo g. 12, 03642, Vilnius";
        }

        public class Order
        {
            public static string OrderStatus = "Užsakymų nėra.";
        }
    }
}
