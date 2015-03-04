namespace Endjin.SpecFlow.SharedSteps
{
    using System;
    using Should;
    using TechTalk.SpecFlow;

    [Binding]
    public class ExceptionSteps
    {
        [Then(@"an ""(.*)"" should be thrown")]
        [Then(@"a ""(.*)"" should be thrown")]
        public void ThenAnShouldBeThrown(string exceptionType)
        {
            var ex = ScenarioContext.Current.Get<Exception>("Exception");
            ex.GetType().Name.ShouldEqual(exceptionType);
        }
    }
}