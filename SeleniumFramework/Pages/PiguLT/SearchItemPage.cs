using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumFramework.Pages.PiguLTPage
{
    public class SearchItemPage
    {
        public static void Open()
        {
            Driver.OpenPage("https://pigu.lt/lt/");
        }

        public static void ClickAllowAllCookies()
        {
            string locator = Locators.SearchItemPage.AllowCoociesButton;
            Common.ClickElement(locator);
        }

        public static void Waiting()
        {
            Common.Wait();
        }

        public static void EnterSearchPhrase(string searchPhrase)
        {
            string locator = Locators.SearchItemPage.InputSearch;
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

        public static void ScrollIntoView()
        {
            string locator = Locators.SearchItemPage.MoreInformationButton;
            ((IJavaScriptExecutor)Driver.GetDriver()).ExecuteScript("arguments[0].scrollIntoView(true);", Common.GetElementForJavascriptExecutor(locator));
        }

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
