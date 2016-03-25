using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace WebBankSP.Test
{
    [Binding]
    public class MyHashSteps
    {
        private static MyHash target;

        [BeforeScenario("MyHash")]
        public static void BeforeScenarioMyHash()
        {
            target = new MyHash();
            ScenarioContext.Current.Clear();
        }

        [AfterScenario("MyHash")]
        public static void AfterScenarioMyHash()
        {
            ScenarioContext.Current.Clear();
        }

        [Given(@"""(.*)"" as a input password")]
        public void GivenAsAInputPassword(string input)
        {
            ScenarioContext.Current.Add("input", input);
        }
        
        [When(@"call the GetHash method")]
        public void WhenCallTheGetHashMethod()
        {
            var input = ScenarioContext.Current["input"].ToString();
            var result = target.GetHash(input);
            ScenarioContext.Current.Add("result", result);
        }
        
        [Then(@"the hashed result should be ""(.*)""")]
        public void ThenTheHashedResultShouldBe(string expected)
        {
            var actual = ScenarioContext.Current["result"].ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}