using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V113.Page;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace TestFramework.BaseTest
{
    public class BaseClass
    {
        public static IWebDriver driver;


        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver
            {
                Url = "https://automationexercise.com/"
            };
            driver.Manage().Window.Maximize();
        }

/*        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }*/

        protected static void SelectOptionByText(IWebElement element, string text)
        {
            var dropdown = new SelectElement(element);
            dropdown.SelectByText(text);
        }

        protected static ReadOnlyCollection<IWebElement> GetElementsList(By locator)
        {
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(10));
            IReadOnlyCollection<IWebElement> cards = wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(locator));
            return new ReadOnlyCollection<IWebElement>(cards.ToList());
        }

        protected static void WaitForElement(IWebElement element)
        {
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        protected static void SelectTitle(IList<IWebElement> TitleOptions, string title)
        {
            foreach (var radioButton in TitleOptions)
            {
                if (radioButton.GetAttribute("value") == title)
                {
                    if (!radioButton.Selected)
                    {
                        radioButton.Click();
                    }
                    break;
                }
            }
        }

        protected static void ScrollIntoViewAndClick(IWebElement element, IWebDriver driver)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            element.Click();
        }

        protected static void DismissIframeIfExists()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            By iframe = By.Id("aswift_1"); // id for outer iframe for this webpage sometimes = "aswift_2" or "aswift_3"
            By nestedIFrame = By.Id("ad_iframe");

            try
            {
                wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(iframe));
                wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(nestedIFrame));
                driver.FindElement(By.CssSelector("#dismiss-button")).Click();
                driver.SwitchTo().DefaultContent();
            }
            catch (WebDriverTimeoutException)
            {
                driver.SwitchTo().DefaultContent();
            }
        }
    }
}


