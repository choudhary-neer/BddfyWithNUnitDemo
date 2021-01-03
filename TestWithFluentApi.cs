using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using TestStack.BDDfy;

namespace NUnitTestProject1
{
    //http://pascallaurin42.blogspot.com/2014/07/exploring-bddfy.html
    public class TestWithFluentApi
    {
        [TestCase]
        public void ReusingStepForScenario1()
        {
            new TestWithFluentApi()
                .Given(s => s.GivenWhatever(), "Given some pre-condition")
                    .And(s => s.AndOtherGiven(54))
                .When(s => s.WhenSomethingElseHappens())
                .Then(s => s.ThenProfit())
                    .And(s => s.AndManyMore(45))
                .BDDfy();
        }

        [TestCase]
        public void ReusingStepForScenario2()
        {
            new TestWithFluentApi()
                .Given(s => s.GivenWhatever(), "Given some pre-condition")
                    .And(s => s.AndOtherGiven(123))
                .When(s => s.WhenSomethingElseHappens())
                .Then(s => s.ThenProfit())
                    .And(s => s.AndManyMore(321), "And {0} more things!")
                .BDDfy("Scenario 2 with steps re-use");
        }

        void GivenWhatever()
        { // ... 
        }
        void AndOtherGiven(int input)
        { // ...
        }
        void WhenSomethingElseHappens()
        { // ...
        }
        void ThenProfit()
        { // ... 
        }
        void AndManyMore(int expected)
        { // ... 
        }
    }
}
