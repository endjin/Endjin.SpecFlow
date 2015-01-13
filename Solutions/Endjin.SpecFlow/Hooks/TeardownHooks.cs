namespace Endjin.SpecFlow.Hooks
{
    #region Using Directives

    using Endjin.Core.Composition;

    using TechTalk.SpecFlow;

    #endregion

    [Binding]
    public class TeardownHooks
    {
        [AfterFeature("container_feature_teardown")]
        public static void ContainerFeatureTeardown()
        {
            ShutdownContainer();
        }

        [AfterScenario("container_scenario_teardown")]
        public static void ContainerScenarioTeardown()
        {
            ShutdownContainer();
        }

        private static void ShutdownContainer()
        {
            if (ApplicationServiceLocator.Container != null)
            {
                ApplicationServiceLocator.Shutdown();
            }
        }
    }
}