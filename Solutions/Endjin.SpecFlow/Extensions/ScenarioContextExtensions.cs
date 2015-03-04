namespace TechTalk.SpecFlow
{
    public static class ScenarioContextExtensions
    {
        public static void AddValueOrNull<T>(this ScenarioContext context, string propertyName, T value) where T : class
        {
            if (value == null)
            {
                context.Add(propertyName + "Null", true);
            }

            context.Add(propertyName, value);
        }

        public static T GetValueOrNull<T>(this ScenarioContext context, string propertyName) where T : class
        {
            if (context.ContainsKey("Null" + propertyName))
            {
                return null;
            }

            return context.Get<T>(propertyName);
        }
    }
}