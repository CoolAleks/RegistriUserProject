using OpenQA.Selenium;
using registerUser.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registerUser.PageObject
{
    internal class DeleteAccountPage
    {
        private IWebDriver driver;
        private IWebElement textAccountDeleted;
        private IWebElement buttonContinueFinal;

        public DeleteAccountPage(IWebDriver driver)
        {
            this.driver = driver;
             textAccountDeleted = driver.FindElement(By.XPath("//h2[@data-qa='account-deleted']"));
            textAccountDeleted.Click();
            string textAccount = textAccountDeleted.Text;
            StringAssert.AreEqualIgnoringCase(textAccount, "Account Deleted!", "step 18 failed");
        }

        public MainMenuPage ToMainPage(IWebDriver driver)
        {

             buttonContinueFinal = driver.FindElement(By.XPath("//a[@data-qa='continue-button']"));
            buttonContinueFinal.Click();

            return new MainMenuPage(driver);
        }

    }
}
