namespace Endjin.SpecFlow.Azure.Storage.Hooks
{
    #region Using Directives

    using Endjin.SpecFlow.Azure.Storage.Helpers;

    using TechTalk.SpecFlow;

    #endregion

    [Binding]
    public class StorageEmulatorHooks
    {
        [BeforeScenario("storage_emulator")]
        public static void StorageEmulatorSetup()
        {
            AzureEmulatorHelper.Start();
        }
    }
}