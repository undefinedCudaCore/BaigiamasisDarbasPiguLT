using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing.Imaging;
using System;
using System.Runtime;
using OpenQA.Selenium.Support.UI;
using System.Drawing;

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

        public static void OpenPage(string url)
        {
            driver.Url = url;
        }

        public static void MaximizeWindow()
        {
            GetDriver().Manage().Window.Maximize();
        }

        public static void TakeScreenshot()
        {
            Bitmap memoryImage;
            memoryImage = new Bitmap(1920, 1440);
            Size size = new Size(memoryImage.Width, memoryImage.Height);

            Graphics memoryGraphics = Graphics.FromImage(memoryImage);

            memoryGraphics.CopyFromScreen(0, 0, 0, 0, size);

            string fileName = string.Format(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                                      @"\Screenshot" + "_" +
                                             DateTime.Now.ToString("dd_MMMM_hh_mm_ss_tt") + ".png");

            memoryImage.Save(fileName);
        }

        public static void QuitDriver()
        {
            driver.Quit();
        }
    }
}
