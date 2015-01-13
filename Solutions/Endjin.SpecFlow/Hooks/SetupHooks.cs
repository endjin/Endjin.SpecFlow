namespace Endjin.SpecFlow.Hooks
{
    #region Using Directives

    using Endjin.Core.Composition;
    using Endjin.Core.Container;

    using TechTalk.SpecFlow;

    #endregion

    [Binding]
    public class SetupHooks
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

        private static void InitializeContainer()
        {
            if (ApplicationServiceLocator.Container == null)
            {
                ApplicationServiceLocator.InitializeAsync(new Container(), new DesktopBootstrapper()).Wait();
            }
        }
    }
}