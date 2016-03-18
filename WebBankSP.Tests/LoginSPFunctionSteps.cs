using System;
using TechTalk.SpecFlow;

namespace WebBankSP.Tests
{
    [Binding]
    public class LoginSPFunctionSteps
    {
        [Given(@"the LoginSP\.aspx page")]
        public void GivenTheLoginSP_AspxPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"Input Account No\. ""(.*)""")]
        public void GivenInputAccountNo_(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"Input Password ""(.*)""")]
        public void GivenInputPassword(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press ""(.*)"" button")]
        public void WhenIPressButton(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the page url will redirect to ""(.*)""")]
        public void ThenThePageUrlWillRedirectTo(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the Login page will give a message ""(.*)""")]
        public void ThenTheLoginPageWillGiveAMessage(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
