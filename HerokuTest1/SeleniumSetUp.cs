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
        public void test()
        {
            driver.Url = "http://www.google.com";
            Console.WriteLine(driver.CurrentWindowHandle); 
        }
        [Test]
        public void test2()
        {
            driver.Url = "http://www.google.co.in";
            Console.WriteLine(driver.CurrentWindowHandle);
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }
}
