using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.IO;

namespace SeleniumCsharp
{
    public class Tests
    {
        IWebDriver driver;
        [OneTimeSetUp]
        public void Setup_2()
        {
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
#pragma warning disable CS1009 // Unrecognized escape sequence
#pragma warning disable CS1009 // Unrecognized escape sequence
            driver = new ChromeDriver("D:\SeleniumCsharp\chromedriver_win32(1)" + @"\drivers\");
#pragma warning restore CS1009 // Unrecognized escape sequence
#pragma warning restore CS1009 // Unrecognized escape sequence
        }

        [Test]
        public void verifyLogo()
        {
            driver.Navigate().GoToUrl("https://www.browserstack.com/");
            Assert.IsTrue(driver.FindElement(By.Id("logo"))).Displayed;
        }
        [OneTimeTearDown]
        public void TearDown_2()
        {
            driver.Quit();
        }
    }
}