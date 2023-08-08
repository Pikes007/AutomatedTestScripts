using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using TestFramework.BaseTest;
using OpenQA.Selenium.Support.Extensions;
using TestFramework.TestData;

namespace TestFramework.PageObjects
{
    internal class LoginPage : BaseClass
    {

        public LoginPage()
        {
            PageFactory.InitElements(driver , this);
        }

        [FindsBy(How = How.CssSelector, Using = "input[placeholder='Name']")]
        private IWebElement SignUpName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[data-qa='signup-email']")]
        private IWebElement SignUpEmail { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button[data-qa='signup-button']")]
        private IWebElement SignUpButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//b[normalize-space()='Enter Account Information']")]
        public IWebElement EnterAccountInformation { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#password")]
        private IWebElement Password { get; set; }
        
        [FindsBy(How = How.CssSelector, Using = "#days")]
        private IWebElement SelectDay { get; set; }
        
        [FindsBy(How = How.CssSelector, Using = "#months")]
        private IWebElement SelectMonth { get; set; }
        
        [FindsBy(How = How.CssSelector, Using = "#years")]
        private IWebElement SelectYear { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#country")]
        private IWebElement SelectCountry { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='radio']")]
        private IList<IWebElement> RadioButtons { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#newsletter")]
        private IWebElement NewsletterCheckbox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#optin")]
        private IWebElement SpecialOffersCheckbox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#first_name")]
        private IWebElement FirstName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#last_name")]
        private IWebElement LastName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#address1")]
        private IWebElement Address { get; set; }
        
        [FindsBy(How = How.CssSelector, Using = "#state")]
        private IWebElement State { get; set; }
        
        [FindsBy(How = How.CssSelector, Using = "#city")]
        private IWebElement City { get; set; }
        
        [FindsBy(How = How.CssSelector, Using = "#zipcode")]
        private IWebElement ZipCode { get; set; }
        
        [FindsBy(How = How.CssSelector, Using = "#mobile_number")]
        private IWebElement MobileNumber { get; set; }
        
        [FindsBy(How = How.CssSelector, Using = "button[data-qa='create-account']")]
        private IWebElement CreateAccountButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".btn.btn-primary")]
        private IWebElement ContinueButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[data-qa='login-email']")]
        private IWebElement LoginEmail { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[placeholder='Password']")]
        private IWebElement LoginPassword { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button[data-qa='login-button']")]
        private IWebElement LoginButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='/logout']")]
        private IWebElement LogOut { get; set; }

        public void NewUserSignup(Dictionary<string, string> formData)
        {
            SignUpName.SendKeys(formData["firstName"]);
            SignUpEmail.SendKeys(formData["email"]);
            SignUpButton.Click();
        }

        public void ValidUserLogin(Dictionary<string, string> formData)
        {
            LoginEmail.SendKeys(formData["email"]);
            LoginPassword.SendKeys(formData["password"]);
            LoginButton.Click();
        }

        public void ClickContinueButton()
        {
            ContinueButton.Click();
        }

        public void LoggingOut()
        {
            LogOut.Click();
        }

        public void FillSignUpForm(Dictionary<string, string> formData)
        {
            SelectTitle(RadioButtons, formData["title"]);
            Password.SendKeys(formData["password"]);
            WaitForElement(SelectDay);
            SelectOptionByText(SelectDay, formData["birthDay"]);
            SelectOptionByText(SelectMonth, formData["birthMonth"]);
            SelectOptionByText(SelectYear, formData["birthYear"]);
            ScrollIntoViewAndClick(NewsletterCheckbox, driver);
            ScrollIntoViewAndClick(SpecialOffersCheckbox, driver);
            FirstName.SendKeys(formData["firstName"]);
            LastName.SendKeys(formData["lastName"]);
            Address.SendKeys(formData["address"]);
            State.SendKeys(formData["state"]);
            City.SendKeys(formData["city"]);
            ZipCode.SendKeys(formData["zipcode"]);
            MobileNumber.SendKeys(formData["mobileNumber"]);
            SelectOptionByText(SelectCountry, formData["country"]);
            ScrollIntoViewAndClick(CreateAccountButton, driver);
        }
/*
        public static IEnumerable<Dictionary<string, string>> GetTestFormData()
        {
            return FormSubmissionData.testFormData;
        }*/
    }

}

