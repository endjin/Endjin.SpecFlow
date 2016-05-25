namespace Endjin.SpecFlow.Azure.Storage.Helpers
{
    #region Using Directives

    using System;
    using System.Diagnostics;
    using System.IO;

    #endregion

    internal static class AzureEmulatorHelper
    {
        private const string AzureEmulatorFilePath = @"Microsoft SDKs\Azure\Storage Emulator\AzureStorageEmulator.exe";
        private const string WaStorageEmulatorFilePath = @"Microsoft SDKs\Azure\Storage Emulator\WAStorageEmulator.exe";
        private const string OldWaStorageEmulatorFilePath = @"Microsoft SDKs\Windows Azure\Storage Emulator\WAStorageEmulator.exe";

        public static void Start()
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), AzureEmulatorFilePath);
            var info = new FileInfo(path);

            if (!info.Exists)
            {
                path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), WaStorageEmulatorFilePath);
                info = new FileInfo(path);
            }

            if (!info.Exists)
            {
                path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), OldWaStorageEmulatorFilePath);
                info = new FileInfo(path);
            }

            if (Process.GetProcessesByName(Path.GetFileNameWithoutExtension(info.FullName)).Length > 0)
            {
                return;
            }

            Execute("start", path);
        }

        private static void Execute(string argument, string path)
        {
            var start = new ProcessStartInfo { Arguments = argument, FileName = path };

            using (var proc = new Process { StartInfo = start })
            {
                proc.Start();
                proc.WaitForExit();

                var exitCode = proc.ExitCode;

                if (exitCode != 0)
                {
                    throw new InvalidOperationException($"Error {exitCode} executing {start.FileName} {start.Arguments}");
                }
            }
        }
    }
}