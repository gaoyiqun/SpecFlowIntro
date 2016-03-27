using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using System;
using TechTalk.SpecFlow;

namespace WebBankSP.UnitTest
{
    [Binding]
    public class AuthenticationUnitTestSteps
    {
        private static Authentication target;
        private static IHash hashStub;
        private static IDoc docStub;

        [BeforeScenario("Authentication")]
        public static void BeforeScenarioAuthentication()
        {
            hashStub = MockRepository.GenerateStub<IHash>();
            docStub = MockRepository.GenerateStub<IDoc>();

            target = new Authentication(hashStub, docStub);
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
        
        [Given(@"IDoc will return ""(.*)""")]
        public void GivenIDocWillReturn(string docPassword)
        {
            docStub.Stub(x=> x.GetPassword(Arg<string>.Is.Anything)).Return(docPassword);
        }
        
        [Given(@"IHash will return ""(.*)""")]
        public void GivenIHashWillReturn(string hashPassword)
        {
            hashStub.Stub(x => x.GetHash(Arg<string>.Is.Anything)).Return(hashPassword);

        }

        [When(@"I call Verify method")]
        public void WhenICallVerifyMethod()
        {
            var id = ScenarioContext.Current["id"].ToString();
            var password = ScenarioContext.Current["password"].ToString();
            var result = target.Verify(id,password);

            ScenarioContext.Current.Add("result", result);

        }
        
        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(string expected)
        {
            var isValid = Convert.ToBoolean(expected);
            var actual = Convert.ToBoolean(ScenarioContext.Current["result"]);

            Assert.AreEqual(isValid, actual);
        }
    }
}
