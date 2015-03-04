namespace Endjin.SpecFlow.Composition.Hooks
{
    #region Using Directives

    using Endjin.Core.Composition;
    using Endjin.Core.Container;

    using TechTalk.SpecFlow;

    #endregion

    [Binding]
    public class ContainerHooks
    {
        [BeforeFeature("container_feature")]
        public static void ContainerFeatureSetup()
        {
            InitializeContainer();
        }

        [AfterFeature("container_feature")]
        public static void ContainerFeatureTeardown()
        {
            ShutdownContainer();
        }

        [AfterScenario("container_scenario")]
        public static void ContainerScenarioTeardown()
        {
            ShutdownContainer();
        }

        [BeforeScenario("container_scenario")]
        public static void ContainerScenarioSetup()
        {
            InitializeContainer();
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