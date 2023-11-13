using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing.Imaging;
using System;
using System.Runtime;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFramework
{
    public class Driver
    {
        internal static IWebDriver driver;

        public static void InitializeDriver()
        {
            driver = new ChromeDriver();
        }

        internal static IWebDriver GetDriver()
        {
            return driver;
        }

        internal static void OpenPage(string url)
        {
            driver.Url = url;
        }

        public static void MaximizeWindow()
        {
            GetDriver().Manage().Window.Maximize();
        }


        public static void QuitDriver()
        {
            driver.Quit();
        }
    }
}
