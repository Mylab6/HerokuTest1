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
        public void test6()
        {
            int n = 6; 
            HerokuPageObject herokuPageObject = new HerokuPageObject(driver);
            for (int i = 0; i < n; i++)
            {
                herokuPageObject.AddElementButton().Click(); 
            }
        }
        [Test]
        public void test10()
        {
            int n = 10;
            HerokuPageObject herokuPageObject = new HerokuPageObject(driver);
            for (int i = 0; i < n; i++)
            {
                herokuPageObject.AddElementButton().Click();
            }
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }
}
