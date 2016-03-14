using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowIntro
{
    [Binding]
    public class CalculatorSteps
    {
        Calculator _calculator = new Calculator();

        [Given(@"I have entered 50 into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator()
        {
            _calculator.FirstNumber = 50;
        }
        
        [Given(@"I have also entered 70 into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator()
        {
            _calculator.SecondNumber = 70;
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _calculator.Add();
        }
        
        [Then(@"the result should be 120 on the screen")]
        public void ThenTheResultShouldBeOnTheScreen()
        {
            Assert.AreEqual(120, _calculator.Result);
        }
    }
}
