using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using TestFramework.BaseTest;

namespace TestFramework.PageObjects
{
    internal class HomePage 
    {
        
        public HomePage() 
        {
            PageFactory.InitElements(BaseClass.driver , this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@href = '/login']")]
        private IWebElement LogIn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a[href='/delete_account']")]
        private IWebElement DeleteAccount { get; set; }

        public LoginPage GoToLogin()
        {
            LogIn.Click();
            return new LoginPage();
        }

        public void ClickDeleteAccount()
        {
            WebDriverWait wait = new(BaseClass.driver, TimeSpan.FromSeconds(15));
            wait.Until(ExpectedConditions.ElementToBeClickable(DeleteAccount));
            DeleteAccount.Click();
        }

    }
}
