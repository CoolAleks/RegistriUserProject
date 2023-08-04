using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registerUser.PageObject
{
    internal class AccountCreatedPage
    {
        private IWebDriver driver;
        private IWebElement createAccount;
        private IWebElement buttonContinue;

        public AccountCreatedPage(IWebDriver driver)
        {
            this.driver = driver;
            createAccount = driver.FindElement(By.XPath("//b[text()='Account Created!']"));
            string res2 = createAccount.Text;
            StringAssert.AreEqualIgnoringCase(res2, "Account Created!", "step 13 failed");
           

        }

        public LoggedAccountPage ButtonNextClick(IWebDriver driver)
        {
             buttonContinue = driver.FindElement(By.XPath("//a[@data-qa='continue-button']"));
            buttonContinue.Click();

            return new LoggedAccountPage(driver);  
        }
    }
}
