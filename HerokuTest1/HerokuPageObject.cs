using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HerokuTest1
{
    class HerokuPageObject
    {
        public String StartingUrl = "https://the-internet.herokuapp.com/add_remove_elements/";
        private IWebDriver driver;

        public HerokuPageObject(IWebDriver driver)
        {
            this.driver = driver; 
            this.driver.Url = StartingUrl; 


        }
        public IWebElement AddElementButton()
        {
            return this.driver.FindElement(By.CssSelector("[onclick=\"addElement()\"]"));


        }
        public System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> ListOfDeleteButtons()
        {

            return this.driver.FindElements(By.ClassName("added-manually"));
        }
    }
}
