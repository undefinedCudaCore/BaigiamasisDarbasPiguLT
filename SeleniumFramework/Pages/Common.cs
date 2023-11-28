using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SeleniumFramework.Pages
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        private static List<IWebElement> GetElements(string locator)
        {
            return Driver.GetDriver().FindElements(By.XPath(locator)).ToList();
        }

        internal static int GetElementCount(string locator)
        {
            return GetElements(locator).Count;
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
            System.Threading.Thread.Sleep(3000);
        }

        internal static void HoverOverElement(string locator)
        {
            IWebElement element = GetElement(locator);

            Actions actions = new Actions(Driver.GetDriver());
            actions.MoveToElement(element);
            actions.Perform();
        }

        // After closing cookies, the page reloads a lot
        // while scripts are added to <head> part of the page
        // This method reads the page source with 50ms delays
        // and waits until the page source has not changed for at least 500ms
        // before allowing tests to proceed further
        internal static void WaitForPageToLoad()
        {
            string sourcePrevious = Driver.GetDriver().PageSource;
            int timeout = 0;

            while (timeout < 500)
            {
                string sourceCurrent = Driver.GetDriver().PageSource;
                if (!sourceCurrent.Equals(sourcePrevious))
                {
                    sourcePrevious = sourceCurrent;
                    timeout = 0;
                    System.Threading.Thread.Sleep(50);
                } 
                else
                {
                    timeout += 50;
                }
            }
        }

        internal static void WaitForElementToNotExist(string locator)
        {
            while (true)
            {
                try
                {
                    GetElement(locator);
                    System.Threading.Thread.Sleep(50);
                }
                catch (NoSuchElementException)
                {
                    return;
                }
            }
        }
    }
}
