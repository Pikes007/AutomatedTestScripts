using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestFramework.PageObjects;
using TestFramework.TestData;

namespace TestFramework.Tests
{
    public class Tests : BaseTest.BaseClass
    {
        [TestCaseSource(typeof(FormSubmissionData), "testFormData")]
        public void TestCase1(Dictionary<string, string> formData)
        {
            var home = new HomePage();
            var login = home.GoToLogin();
            login.NewUserSignup(formData);
            login.FillSignUpForm(formData);
            login.ClickContinueButton();
            DismissIframeIfExists();
            home.ClickDeleteAccount();
            login.ClickContinueButton();
        }

        [TestCaseSource(typeof(FormSubmissionData), "testCase2Data")]

        public void TestCase2(Dictionary<string, string> testCase2Data)
        {
            var home = new HomePage();
            var login = home.GoToLogin();
            login.NewUserSignup(testCase2Data);
            login.FillSignUpForm(testCase2Data);
            login.ClickContinueButton();
            DismissIframeIfExists();
            login.LoggingOut();
            login.ValidUserLogin(testCase2Data);
            home.ClickDeleteAccount();
        }
    }
}