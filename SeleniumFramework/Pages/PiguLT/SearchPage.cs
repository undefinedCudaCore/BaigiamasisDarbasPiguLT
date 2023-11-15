﻿namespace SeleniumFramework.Pages.PiguLTPage
{
    public class SearchPage
    {
        public static void ClickAllowAllCookies()
        {
            string locator = Locators.SearchItemPage.AllowCookiesButton;
            Common.ClickElement(locator);
        }

        public static void EnterSearchPhrase(string searchPhrase)
        {
            string locator = Locators.SearchItemPage.InputSearch;
            Common.WaitForSearchInput(locator);
            Common.SendKeysToElement(locator, searchPhrase);
        }

        public static void ClickSearchButton()
        {
            string locator = Locators.SearchItemPage.InputSearchButton;
            Common.ClickElement(locator);
        }

        public static void ClickFoundItemImageButton()
        {
            string locator = Locators.SearchItemPage.FoundItemImgButton;
            Common.ClickElement(locator);
        }

        //public static void ScrollIntoView()
        //{
        //    string locator = Locators.SearchItemPage.MoreInformationButton;
        //    ((IJavaScriptExecutor)Driver.GetDriver()).ExecuteScript("arguments[0].scrollIntoView(true);", Common.GetElementForJavascriptExecutor(locator));
        //}

        public static void ClickMoreInformationButton()
        {
            string locator = Locators.SearchItemPage.MoreInformationButton;
            Common.ClickElement(locator);
        }

        public static string GetProductName()
        {
            return Common.GetElementText(Locators.SearchItemPage.ProductName);
        }

        public static string ProductManufacturerCode()
        {
            return Common.GetElementText(Locators.SearchItemPage.ProductManufactureCode);
        }

        public static void GetTestFailScreenshot()
        {
            Common.TakeScreenshot();
        }
    }
}
