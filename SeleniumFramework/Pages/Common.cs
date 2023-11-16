using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SeleniumFramework.Pages
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        public static IWebElement GetElementToScroll(string locator)
        {
            return GetElement(locator);
        }

        internal static void ClickElement(string locator)
        {
            GetElement(locator).Click();
        }

        internal static void SendKeysToElement(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static void WaitForElementToBeVisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(2));
            wait.Until(d => d.FindElement(By.XPath(locator)));
        }

        internal static void WaitForElement()
        {
            Thread.Sleep(3000);
        }
    }
}
