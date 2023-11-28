namespace SeleniumFramework.Pages.PiguLTPage
{
    public class SearchPage
    {
        public static void EnterSearchPhrase(string searchPhrase)
        {
            Common.SendKeysToElement(Locators.SearchItemPage.InputSearch, searchPhrase);
        }

        public static void ClickSearchButton()
        {
            Common.ClickElement(Locators.SearchItemPage.InputSearchButton);
        }

        public static void ClickFoundItemImageButton()
        {
            Common.ClickElement(Locators.SearchItemPage.FoundItemImgButton);
        }

        public static void ClickMoreInformationButton()
        {
            Common.ClickElement(Locators.SearchItemPage.MoreInformationButton);
        }

        public static string GetProductName()
        {
            return Common.GetElementText(Locators.SearchItemPage.ProductName);
        }

        public static string ProductManufacturerCode()
        {
            return Common.GetElementText(Locators.SearchItemPage.ProductManufactureCode);
        }
    }
}
