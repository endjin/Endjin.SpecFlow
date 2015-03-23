namespace Endjin.SpecFlow.Transformations
{
    #region Using directives

    using System;

    using TechTalk.SpecFlow;

    #endregion

    [Binding]
    public class TimeSpanTransformations
    {
        [StepArgumentTransformation(@"(?:(\d*) day(?:s)?(?:, )?)?(?:(\d*) hour(?:s)?(?:, )?)?(?:(\d*) minute(?:s)?(?:, )?)?(?:(\d*) second(?:s)?(?:, )?)?")]
        public TimeSpan DaysHoursMinutesSeconds(string days, string hours, string minutes, string seconds)
        {
            int daysParsed;
            int hoursParsed;
            int minutesParsed;
            int secondsParsed;

            int.TryParse(days, out daysParsed);
            int.TryParse(hours, out hoursParsed);
            int.TryParse(minutes, out minutesParsed);
            int.TryParse(seconds, out secondsParsed);

            return new TimeSpan(daysParsed, hoursParsed, minutesParsed, secondsParsed);
        }
    }
}