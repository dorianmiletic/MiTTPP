using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework.Legacy;

namespace SeleniumTests
{
    [TestFixture]
    public class Search
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            ClassicAssert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheSearchTest()
        {
            driver.Navigate().GoToUrl("https://bakeronline.be/be-en/");
            driver.FindElement(By.XPath("//header[@id='homepage-search']/div/form/input")).Click();
            driver.FindElement(By.XPath("//header[@id='homepage-search']/div/form/input")).Clear();
            driver.FindElement(By.XPath("//header[@id='homepage-search']/div/form/input")).SendKeys("belgium");
            driver.Navigate().GoToUrl("https://shop.paul-belgium.be/be-nl/paul-rive-gauche");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
