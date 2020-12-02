using System;
using TechTalk.SpecFlow;
using Xunit;

namespace BDD_REQ
{
    [Binding]
    public class ArithmeticFunctionsSteps
    {

        int a;

        int b;

        int x;

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            a = p0;
        }
        
        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            b = p0;
        }
        
        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            x = a+b;
        }
        
        [When(@"the second number is substracted from the first")]
        public void WhenTheSecondNumberIsSubstractedFromTheFirst()
        {
            x = a - b;
        }
        
        [When(@"the numbers are multiplied")]
        public void WhenTheNumbersAreMultiplied()
        {
            x = a * b;
        }
        
        [When(@"the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            x = a / b;
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.Equal(x,p0);
        }
    }
}
