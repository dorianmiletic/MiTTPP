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
    public class ChangeLanguage
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
        public void TheChangeLanguageTest()
        {
            driver.Navigate().GoToUrl("https://bakeronline.be/be-en/");
            driver.FindElement(By.XPath("//footer[@id='footer']/div/div/button")).Click();
            driver.FindElement(By.XPath("//div[@id='app']/main/div[4]/div/div/div/div/button[17]")).Click();
            driver.FindElement(By.XPath("//div[@id='app']/main/div[4]/div/div/div[2]/div[17]/button[3]")).Click();
            driver.Navigate().GoToUrl("https://bakeronline.es/es-en/");
            driver.FindElement(By.XPath("//footer[@id='footer']/div/div/button")).Click();
            driver.FindElement(By.XPath("//div[@id='app']/main/div[4]/div/div/div/div/button[2]")).Click();
            driver.FindElement(By.XPath("//div[@id='app']/main/div[4]/div/div/div[2]/div[2]/button[3]")).Click();
            driver.Navigate().GoToUrl("https://bakeronline.be/be-en/");
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
