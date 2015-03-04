namespace Endjin.SpecFlow.SharedSteps
{
    #region Using Directives

    using System;
    using System.Collections;
    using System.Linq;

    using Should;

    using TechTalk.SpecFlow;

    #endregion

    [Binding]
    public class ResultSteps
    {
        [Then(@"the result count should be (.*)")]
        public void ThenTheResultCountShouldBe(int count)
        {
            var result = ScenarioContext.Current.Get<IList>("Result");
            result.Count.ShouldEqual(count);
        }

        [Then(@"the result should equal the datetime (.*)")]
        public void ThenTheResultShouldBeEqualDateTime(DateTime result)
        {
            ScenarioContext.Current.Get<DateTime>("Result").ShouldEqual(result);
        }

        [Then(@"the result should equal the datetimeoffset (.*)")]
        public void ThenTheResultShouldBeEqualDateTimeOffset(string result)
        {
            ScenarioContext.Current.Get<DateTimeOffset>("Result").ShouldEqual(DateTimeOffset.Parse(result));
        }

        [Then(@"the result should equal the integer (.*)")]
        public void ThenTheResultShouldBeEqualInt(int result)
        {
            ScenarioContext.Current.Get<int>("Result").ShouldEqual(result);
        }

        [Then(@"the result should equal the string ""(.*)""")]
        public void ThenTheResultShouldBeEqualString(string result)
        {
            ScenarioContext.Current.Get<string>("Result").ShouldEqual(result);
        }

        [Then(@"the result should be false")]
        public void ThenTheResultShouldBeFalse()
        {
            ScenarioContext.Current.Get<bool>("Result").ShouldBeFalse();
        }

        [Then(@"the result should be greater than the datetime (.*)")]
        public void ThenTheResultShouldBeGreaterThanDateTime(DateTime result)
        {
            ScenarioContext.Current.Get<DateTime>("Result").ShouldBeGreaterThan(result);
        }

        [Then(@"the result should be greater than the datetimeoffset (.*)")]
        public void ThenTheResultShouldBeGreaterThanDateTimeOffset(string result)
        {
            ScenarioContext.Current.Get<DateTimeOffset>("Result").ShouldBeGreaterThan(DateTimeOffset.Parse(result));
        }

        [Then(@"the result should be greater than the integer (.*)")]
        public void ThenTheResultShouldBeGreaterThanInt(int result)
        {
            ScenarioContext.Current.Get<int>("Result").ShouldBeGreaterThan(result);
        }

        [Then(@"the result should be greater than or equal to the datetime (.*)")]
        public void ThenTheResultShouldBeGreaterThanOrEqualToDateTime(DateTime result)
        {
            ScenarioContext.Current.Get<DateTime>("Result").ShouldBeGreaterThanOrEqualTo(result);
        }

        [Then(@"the result should be greater than or equal to the datetimeoffset (.*)")]
        public void ThenTheResultShouldBeGreaterThanOrEqualToDateTimeOffset(string result)
        {
            ScenarioContext.Current.Get<DateTimeOffset>("Result").ShouldBeGreaterThanOrEqualTo(DateTimeOffset.Parse(result));
        }

        [Then(@"the result should be greater than or equal to the integer (.*)")]
        public void ThenTheResultShouldBeGreaterThanOrEqualToInt(int result)
        {
            ScenarioContext.Current.Get<int>("Result").ShouldBeGreaterThanOrEqualTo(result);
        }

        [Then(@"the result should be less than the datetime (.*)")]
        public void ThenTheResultShouldBeLessThanDateTime(DateTime result)
        {
            ScenarioContext.Current.Get<DateTime>("Result").ShouldBeLessThan(result);
        }

        [Then(@"the result should be less than the datetimeoffset (.*)")]
        public void ThenTheResultShouldBeLessThanDateTimeOffset(string result)
        {
            ScenarioContext.Current.Get<DateTimeOffset>("Result").ShouldBeLessThan(DateTimeOffset.Parse(result));
        }

        [Then(@"the result should be less than the integer (.*)")]
        public void ThenTheResultShouldBeLessThanInt(int result)
        {
            ScenarioContext.Current.Get<int>("Result").ShouldBeLessThan(result);
        }

        [Then(@"the result should be less than or equal to the datetime (.*)")]
        public void ThenTheResultShouldBeLessThanOrEqualToDateTime(DateTime result)
        {
            ScenarioContext.Current.Get<DateTime>("Result").ShouldBeLessThanOrEqualTo(result);
        }

        [Then(@"the result should be less than or equal to the datetimeoffset (.*)")]
        public void ThenTheResultShouldBeLessThanOrEqualToDateTimeOffset(string result)
        {
            ScenarioContext.Current.Get<DateTimeOffset>("Result").ShouldBeLessThanOrEqualTo(DateTimeOffset.Parse(result));
        }

        [Then(@"the result should be less than or equal to the integer (.*)")]
        public void ThenTheResultShouldBeLessThanOrEqualToInt(int result)
        {
            ScenarioContext.Current.Get<int>("Result").ShouldBeLessThanOrEqualTo(result);
        }

        [Then(@"the result should be null")]
        public void ThenTheResultShouldBeNull()
        {
            ScenarioContext.Current.ContainsKey("NullResult").ShouldBeTrue();
        }

        [Then(@"the result should be of type (.*)")]
        public void ThenTheResultShouldBeOfType(string typeName)
        {
            ScenarioContext.Current.Get<object>("Result").GetType().Name.ShouldEqual(typeName);
        }

        [Then(@"the result should be true")]
        public void ThenTheResultShouldBeTrue()
        {
            ScenarioContext.Current.Get<bool>("Result").ShouldBeTrue();
        }

        [Then(@"the result should contain")]
        public void ThenTheResultShouldContain(Table table)
        {
            var result = ScenarioContext.Current.Get<IEnumerable>("Result").Cast<object>().ToList();

            foreach (var row in table.Rows)
            {
                result.Any(actual => this.MatchRow(row, actual)).ShouldBeTrue();
            }
        }

        [Then(@"the result should equal the context value (.*)")]
        public void ThenTheResultShouldEqualTheContextValue(string contextValueKey)
        {
            var firstHash = ScenarioContext.Current.GetValueOrNull<object>(contextValueKey);
            var result = ScenarioContext.Current.GetValueOrNull<object>("Result");
            
            result.ShouldEqual(firstHash);
        }

        [Then(@"the result should not be null")]
        public void ThenTheResultShouldNotBeNull()
        {
            ScenarioContext.Current.ContainsKey("NullResult").ShouldBeFalse();
        }

        [Then(@"the result should not equal the string ""(.*)""")]
        public void ThenTheResultShouldNotEqualString(string result)
        {
            ScenarioContext.Current.Get<string>("Result").ShouldNotEqual(result);
        }

        private bool Compare(string expected, object actual)
        {
            if (actual == null && expected == null)
            {
                return true;
            }

            if (actual == null || expected == null)
            {
                return false;
            }

            if (actual.GetType() == typeof(string))
            {
                return expected == (string)actual;
            }

            if (actual.GetType() == typeof(DateTime))
            {
                return (DateTime)actual == DateTime.Parse(expected);
            }
            if (actual.GetType() == typeof(DateTime?))
            {
                return ((DateTime?)actual).Value == DateTime.Parse(expected);
            }

            if (actual.GetType() == typeof(DateTimeOffset))
            {
                return (DateTimeOffset)actual == DateTimeOffset.Parse(expected);
            }
            if (actual.GetType() == typeof(DateTimeOffset?))
            {
                return ((DateTimeOffset?)actual).Value == DateTimeOffset.Parse(expected);
            }

            if (actual.GetType() == typeof(TimeSpan))
            {
                return (TimeSpan)actual == TimeSpan.Parse(expected);
            }
            if (actual.GetType() == typeof(TimeSpan?))
            {
                return ((TimeSpan?)actual).Value == TimeSpan.Parse(expected);
            }

            if (actual.GetType() == typeof(int))
            {
                return (int)actual == int.Parse(expected);
            }
            if (actual.GetType() == typeof(int?))
            {
                return ((int?)actual).Value == int.Parse(expected);
            }

            if (actual.GetType() == typeof(double))
            {
                return (double)actual == double.Parse(expected);
            }
            if (actual.GetType() == typeof(double?))
            {
                return ((double?)actual).Value == double.Parse(expected);
            }

            if (actual.GetType() == typeof(long))
            {
                return (long)actual == long.Parse(expected);
            }
            if (actual.GetType() == typeof(long?))
            {
                return ((long?)actual).Value == long.Parse(expected);
            }

            if (actual.GetType() == typeof(char))
            {
                return (char)actual == char.Parse(expected);
            }
            if (actual.GetType() == typeof(char?))
            {
                return ((char?)actual).Value == char.Parse(expected);
            }

            if (actual.GetType() == typeof(bool))
            {
                return (bool)actual == bool.Parse(expected);
            }
            if (actual.GetType() == typeof(bool?))
            {
                return ((bool?)actual).Value == bool.Parse(expected);
            }

            if (actual.GetType().IsEnum)
            {
                return Enum.Parse(actual.GetType(), expected) == actual;
            }

            return false;
        }

        private object GetPropertyValue(string k, object actual)
        {
            if (k == "This")
            {
                return actual;
            }

            var propInfo = actual.GetType().GetProperty(k);
            return propInfo.GetValue(actual);
        }

        private bool MatchRow(TableRow row, object actual)
        {
            foreach (var k in row.Keys)
            {
                if (!this.Compare(row[k], this.GetPropertyValue(k, actual)))
                {
                    return false;
                }
            }

            return true;
        }
    }
}