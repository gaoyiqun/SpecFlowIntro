using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace WebBankSP.Test
{
    [Binding]
    public class DocSteps
    {
        private static Doc target;

        [BeforeScenario("Doc")]
        public static void BeforeScenarioDoc()
        {
            target = new Doc();
            ScenarioContext.Current.Clear();
        }

        [AfterScenario("Doc")]
        public static void AfterScenarioDoc()
        {
            ScenarioContext.Current.Clear();
        }


        [Given(@"account id ""(.*)""")]
        public void GivenAccountId(string id)
        {
            ScenarioContext.Current.Add("id", id);
        }
        
        [When(@"call GetPassword method")]
        public void WhenCallGetPasswordMethod()
        {
            var id = ScenarioContext.Current["id"].ToString();
            var result = target.GetPassword(id);

            ScenarioContext.Current.Add("result", result);
        }
        
        [Then(@"the result back from doc should be ""(.*)""")]
        public void ThenTheResultBackFromDocShouldBe(string expected)
        {
            var actual = ScenarioContext.Current["result"].ToString() ;
            Assert.AreEqual(expected, actual);
        }
    }
}
