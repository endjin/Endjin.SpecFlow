namespace Endjin.SpecFlow.Hooks
{
    #region Using Directives

    using Endjin.Core.Composition;
    using Endjin.Core.Container;

    using TechTalk.SpecFlow;

    #endregion

    [Binding]
    public class ContainerHooks
    {
        [BeforeFeature("container_feature_setup")]
        public static void ContainerFeatureSetup()
        {
            InitializeContainer();
        }

        [BeforeScenario("container_scenario_setup")]
        public static void ContainerScenarioSetup()
        {
            InitializeContainer();
        }

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

        private static void InitializeContainer()
        {
            if (ApplicationServiceLocator.Container == null)
            {
                ApplicationServiceLocator.InitializeAsync(new Container(), new DesktopBootstrapper()).Wait();
            }
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