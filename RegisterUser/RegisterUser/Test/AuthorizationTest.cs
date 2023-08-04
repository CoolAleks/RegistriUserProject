using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using registerUser.PageObject;
using OpenQA.Selenium.Chrome;

namespace registerUser.Test
{
    internal class AuthorizationTest
    {

        
        private IWebDriver driver;
        private ChromeOptions chromeOptions = new ChromeOptions();
       

        [SetUp]
        public void Setup()
        {
            chromeOptions.PageLoadStrategy = PageLoadStrategy.None;
            driver = new ChromeDriver(@"C:\webdriver\chromedriver", chromeOptions);

            try
            {
                driver.Navigate().GoToUrl("http://automationexercise.com");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection to url: Failed " + ex.StackTrace);
            }

        }


        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver = null;
        }


        [Test]
        public void MainMenuPage()
        {
            MainMenuPage mainMenuPage = new MainMenuPage(driver);
            LoginPage loginPage = mainMenuPage.LoginButtonClick(driver);
            SignupPage signupPage = loginPage.SignupButtonClick(driver);
            AccountCreatedPage accountCreatedPage = signupPage.FillingFields(driver);
            LoggedAccountPage loggedAccountPage = accountCreatedPage.ButtonNextClick(driver);
            DeleteAccountPage deleteAccountPage = loggedAccountPage.DeleteAccount(driver);
            deleteAccountPage.ToMainPage(driver);


        }
    }
}
