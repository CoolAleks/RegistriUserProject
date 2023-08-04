
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registerUser.PageObject
{
    internal class LoginPage
    {
        private IWebDriver driver;
        private IWebElement loginPage;
        private IWebElement fieldlogin;
        private IWebElement fieldEmail;
        private IWebElement buttonSignup;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
           
             loginPage = driver.FindElement(By.XPath("//div[@class='signup-form']/h2"));
            Assert.True(loginPage.Displayed, "Step loginPage fail");

        }

        public SignupPage SignupButtonClick(IWebDriver driver) {

             fieldlogin = driver.FindElement(By.XPath("//input[@data-qa='signup-name']"));
            fieldlogin.SendKeys(Faker.Name.First());

             fieldEmail = driver.FindElement(By.XPath("//input[@data-qa='signup-email']"));
            fieldEmail.SendKeys(Faker.Internet.Email());

             buttonSignup = driver.FindElement(By.XPath("//button[@data-qa='signup-button']"));
            buttonSignup.Click();

            return new SignupPage(driver);
        }
    }
}
