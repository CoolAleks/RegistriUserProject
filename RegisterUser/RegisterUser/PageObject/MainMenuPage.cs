using OpenQA.Selenium;
using registerUser.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registerUser.PageObject
{
    internal class MainMenuPage
    {
        private IWebDriver driver;
        private IWebElement pageTitleDisplay;
        private IWebElement buttonLogin;



        public MainMenuPage(IWebDriver driver)
        {
            this.driver = driver;
           IWebElement pageTitleDisplay = driver.FindElement(By.XPath("//a[text()=' Home']"));
            Assert.That(pageTitleDisplay.Text, Is.EqualTo("Home"));
                    } 
        public LoginPage LoginButtonClick(IWebDriver driver) {
            IWebElement buttonLogin = driver.FindElement(By.XPath("//a[contains(text(),' Signup')]"));
            buttonLogin.Click();
            return new LoginPage(driver);
        }
    }
}
