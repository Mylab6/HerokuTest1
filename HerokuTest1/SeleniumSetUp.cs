using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HerokuTest1
{
    class SeleniumSetUp
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            string currentDirectory = Directory.GetCurrentDirectory(); 
            driver = new ChromeDriver(Path.Combine(currentDirectory,"chromedriver_win32\\chromedriver.exe")); 
        }

        [Test]
        public void test3()
        {
            int n = 3;
            AddAndCount(n);
        }
        [Test]
        public void test5()
        {
            int n = 5;
            AddAndCount(n);
        }

        private void AddAndCount(int n)
        {
            HerokuPageObject herokuPageObject = new HerokuPageObject(driver);
            for (int i = 0; i < n; i++)
            {
                herokuPageObject.AddElementButton().Click();
            }
            int numberOfDeleteButtons = herokuPageObject.ListOfDeleteButtons().Count;
            Assert.AreEqual(n, numberOfDeleteButtons);
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }
}
