
using OpenQA.Selenium;
using registerUser.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registerUser.PageObject
{
    internal class SignupPage
    {
        private IWebDriver driver;
        private IWebElement signupPage;
        private IWebElement fildTitleGenderMrSignup;
        private IWebElement fildPasswordSignup;
        private IWebElement fildDateOfBirthDays;
        private IWebElement day;
        private IWebElement fildDateOfBirthMonths;
        private IWebElement months;
        private IWebElement fildDateOfBirthYears;
        private IWebElement years;
        private IWebElement checkboxNewsletter;
        private IWebElement checkboxSpecialOffers;
        private IWebElement firstName;
        private IWebElement lastName;
        private IWebElement company;
        private IWebElement address;
        private IWebElement address2;
        private IWebElement country;
        private IWebElement countryCanada;
        private IWebElement state;
        private IWebElement city;
        private IWebElement zipcode;
        private IWebElement mobileNumber;
        private IWebElement buttonCreateAccount;
        


        public SignupPage(IWebDriver driver)
        {
            this.driver = driver;
             signupPage = driver.FindElement(By.XPath("//b[text()='Enter Account Information']"));
            string res = signupPage.Text;
            StringAssert.AreEqualIgnoringCase(res, "Enter Account Information", "step 8 SignupPage failed");
        }

        public AccountCreatedPage FillingFields(IWebDriver driver) { 

             fildTitleGenderMrSignup = driver.FindElement(By.XPath("//div[@id='uniform-id_gender1']"));
            fildTitleGenderMrSignup.Click();

             fildPasswordSignup = driver.FindElement(By.XPath("//input[@id='password']"));
            fildPasswordSignup.SendKeys("qwert12345");

             fildDateOfBirthDays = driver.FindElement(By.XPath("//select[@id='days']"));
            fildDateOfBirthDays.Click();
             day = driver.FindElement(By.XPath("//option[@value='1']"));
            day.Click();

             fildDateOfBirthMonths = driver.FindElement(By.XPath("//select[@id='months']"));
            fildDateOfBirthMonths.Click();
             months = driver.FindElement(By.XPath("//option[@value='6']"));
            months.Click();

             fildDateOfBirthYears = driver.FindElement(By.XPath("//select[@id='years']"));
            fildDateOfBirthYears.Click();
             years = driver.FindElement(By.XPath("//option[@value='1982']"));
            years.Click();

             checkboxNewsletter = driver.FindElement(By.XPath("//*[@id='newsletter']"));
            if (!checkboxNewsletter.Selected) checkboxNewsletter.Click();

             checkboxSpecialOffers = driver.FindElement(By.XPath("//*[@id='optin']"));
            checkboxSpecialOffers.Click();

             firstName = driver.FindElement(By.XPath("//input[@id='first_name']"));
            firstName.SendKeys(Faker.Name.First());

             lastName = driver.FindElement(By.XPath("//input[@id='last_name']"));
            lastName.SendKeys(Faker.Name.Last());

             company = driver.FindElement(By.XPath("//input[@id='company']"));
            company.SendKeys(Faker.Company.Name());

             address = driver.FindElement(By.XPath("//input[@id='address1']"));
            address.SendKeys(Faker.Address.StreetAddress());

             address2 = driver.FindElement(By.XPath("//input[@id='address2']"));
            address2.SendKeys(Faker.Address.StreetAddress());

             country = driver.FindElement(By.XPath("//select[@id='country']"));
            country.Click();
             countryCanada = driver.FindElement(By.XPath("//option[@value='Canada']"));
            countryCanada.Click();

             state = driver.FindElement(By.XPath("//input[@id='state']"));
            state.SendKeys(Faker.Address.Country());

             city = driver.FindElement(By.XPath("//input[@id='city']"));
            city.SendKeys(Faker.Address.City());

             zipcode = driver.FindElement(By.XPath("//input[@id='zipcode']"));
            zipcode.SendKeys(Faker.Address.ZipCode());

             mobileNumber = driver.FindElement(By.XPath("//input[@id='mobile_number']"));
            mobileNumber.SendKeys(Faker.Phone.Number());

             buttonCreateAccount = driver.FindElement(By.XPath("//button[text()='Create Account']"));
            buttonCreateAccount.Click();

            return new AccountCreatedPage(driver);
         }
    }
}
