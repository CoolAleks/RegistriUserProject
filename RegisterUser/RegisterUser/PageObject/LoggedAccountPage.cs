using OpenQA.Selenium;
using registerUser.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registerUser.PageObject
{
    internal class LoggedAccountPage
    {
        private IWebDriver driver;
        private IWebElement buttonLoggedInAs;
        private IWebElement buttonDeleteAccount;

        public LoggedAccountPage(IWebDriver driver)
        {
            this.driver = driver;
             buttonLoggedInAs = driver.FindElement(By.XPath("//a[text()=' Logged in as ']"));
            string buttonLogged = buttonLoggedInAs.Text;
            StringAssert.Contains("Logged in as",buttonLogged, "step loggedAccount failed");

        }

        public DeleteAccountPage DeleteAccount(IWebDriver driver)
        {
             buttonDeleteAccount = driver.FindElement(By.XPath("//a[text()=' Delete Account']"));
            buttonDeleteAccount.Click();

            return new DeleteAccountPage(driver);
        }
    }
}
