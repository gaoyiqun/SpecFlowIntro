using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace WebBankSP.Test
{
    [Binding]
    public class AuthenticationSteps
    {
        private static Authentication target;

        [BeforeScenario("Authentication")]
        public static void BeforeFeatureAuthentication()
        {
            target = new Authentication(new MyHash(), new Doc());
            ScenarioContext.Current.Clear();
        }

        [AfterScenario("Authentication")]
        public static void AfterFeatureAuthentication()
        {
            ScenarioContext.Current.Clear();
        }

        [Given(@"user account number is ""(.*)""")]
        public void GivenUserAccountNumberIs(string id)
        {
            ScenarioContext.Current.Add("id", id);
        }
        
        [Given(@"password is ""(.*)""")]
        public void GivenPasswordIs(string password)
        {
            ScenarioContext.Current.Add("password", password);
        }
        
        [When(@"I call Verify method")]
        public void WhenICallVerifyMethod()
        {
            var id = ScenarioContext.Current["id"].ToString();
            var password = ScenarioContext.Current["password"].ToString();

            var result = target.Verify(id, password);
            ScenarioContext.Current.Add("result", result);
          
        }

        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(string result)
        {
            var isValid = Convert.ToBoolean(result);
            var actual = Convert.ToBoolean(ScenarioContext.Current["result"]);
            Assert.AreEqual(isValid, actual);
        }
    }
}
