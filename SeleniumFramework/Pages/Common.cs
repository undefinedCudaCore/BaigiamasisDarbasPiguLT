using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;

namespace SeleniumFramework.Pages
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
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

        public static void TakeScreenshot()
        {
            Bitmap memoryImage;
            memoryImage = new Bitmap(1000, 900);
            Size size = new Size(memoryImage.Width, memoryImage.Height);

            Graphics memoryGraphics = Graphics.FromImage(memoryImage);

            memoryGraphics.CopyFromScreen(0, 0, 0, 0, size);

            string fileName = string.Format(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                                      @"\Screenshot" + "_" +
                                             DateTime.Now.ToString("dd_MMMM_hh_mm_ss_tt") + ".png");

            memoryImage.Save(fileName);
        }

        internal static IWebElement GetElementForJavascriptExecutor(string locator)
        {
            return GetElement(locator);
        }

        internal static void WaitForSearchInput(string locator)
        {
            Thread.Sleep(3000);
        }
    }
}
