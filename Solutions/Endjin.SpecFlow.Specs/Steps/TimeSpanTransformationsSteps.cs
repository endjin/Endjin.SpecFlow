namespace Endjin.SpecFlow.Specs.Steps
{
    #region Using directives

    using System;

    using Should;

    using TechTalk.SpecFlow;
    using TechTalk.SpecFlow.Assist;

    #endregion

    [Binding]
    public class TimeSpanTransformationsSteps
    {
        [Given(@"a step contains the TimeSpan argument (.*)")]
        public void GivenAStepContainsTheTimeSpanArgumentDayHourMinuteSecond(TimeSpan timeSpan)
        {
            ScenarioContext.Current.Set(timeSpan, "TimeSpan");
        }

        [Then(@"the transformed TimeSpan should have")]
        public void ThenTheTransformedTimeSpanShouldHave(Table table)
        {
            var timeSpanModel = table.CreateInstance<TimeSpanModel>();

            var timeSpan = ScenarioContext.Current.Get<TimeSpan>("TimeSpan");

            timeSpan.Days.ShouldEqual(timeSpanModel.Days);
            timeSpan.Hours.ShouldEqual(timeSpanModel.Hours);
            timeSpan.Minutes.ShouldEqual(timeSpanModel.Minutes);
            timeSpan.Seconds.ShouldEqual(timeSpanModel.Seconds);
        }

        private class TimeSpanModel
        {
            public int Days { get; set; }
            public int Hours { get; set; }
            public int Minutes { get; set; }
            public int Seconds { get; set; }
        }
    }
}