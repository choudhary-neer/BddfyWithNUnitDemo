using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using TestStack.BDDfy;

namespace NUnitTestProject1
{
    //http://pascallaurin42.blogspot.com/2014/07/exploring-bddfy.html

    [Story(
    Title = "Using story attribute and setting the Title!",
    AsA = "As someone learning BDDfy",
    IWant = "I want to try splitting scenario in separated classes",
    SoThat = "My code is cleaner")]
    public class TestWithStoryAndScenarioInSeparatedClasses
    {
        [TestCase]
        public void FirstScenario()
        {
            new S1().BDDfy("Custom scenario title");
        }

        [TestCase]
        public void SecondScenario()
        {
            new S2().BDDfy();
        }

        private class S1
        {
            void GivenWhatever()
            {
                // ... 
            }
            void WhenSomethingHappens()
            {
                // ... 
            }
            void ThenProfit()
            {
                // ... 
            }
        }
        
        private class S2
        {
            void GivenWhatever()
            { // ... 
            }
            void WhenSomethingElseHappens()
            { // ... 
            }
            void ThenProfit()
            { // ... 
            }
        }
    }
}
