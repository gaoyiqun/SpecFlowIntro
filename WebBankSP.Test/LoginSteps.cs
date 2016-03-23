using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace TestWebBank
{
    [Binding]
    public class LoginSteps
    {
        #region Test Setting

        private static IWebDriver driver;
        private static StringBuilder verificationErrors;
        private static string baseURL;

        [BeforeFeature("WebBankSP")]
        public static void BeforeFeatureWebAtm()
        {
            driver = new FirefoxDriver();
        
            baseURL = "http://localhost/WebBankSP";
            verificationErrors = new StringBuilder();
        }

        [AfterFeature("WebBankSP")]
        public static void AfterFeatureWebAtm()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        #endregion Test Setting

        [Given(@"the LoginSP\.aspx page")]
        public void GivenTheLoginSP_AspxPage()
        { 
            driver.Navigate().GoToUrl(baseURL+"/LoginSP.aspx");
        }

        [Given(@"Input Account No\. ""(.*)""")]
        public void GivenInputAccountNo_(string accountNo)
        {
            driver.FindElement(By.Id("txtAccountNo")).Clear();
            driver.FindElement(By.Id("txtAccountNo")).SendKeys(accountNo);
        }

        [Given(@"Input Password ""(.*)""")]
        public void GivenInputPassword(string password)
        {
            driver.FindElement(By.Id("txtPassword")).Clear();
            driver.FindElement(By.Id("txtPassword")).SendKeys(password);
        }

        [When(@"I press ConfirmLogin button")]
        public void WhenIPressConfirmLoginButton()
        {
            driver.FindElement(By.Id("btnLogin")).Click();
        }

        [Then(@"the page url will redirect to ""(.*)""")]
        public void ThenThePageUrlWillRedirectTo(string url)
        {
            var expected = string.Format("{0}/{1}", baseURL, url);
            Assert.AreEqual(expected, driver.Url);
        }

        [Then(@"the Login page will give a message ""(.*)""")]
        public void ThenTheLoginPageWillGiveAMessage(string message)
        {
            Assert.AreEqual(message, driver.FindElement(By.Id("Message")).Text);
        }
    }
}