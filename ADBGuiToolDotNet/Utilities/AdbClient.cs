using ADBGuiTool.Data;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADBGuiTool.Utilities
{
    public class AdbClient
    {
        #region Variables
        private static int adbTimeout;
        public static int ADBTimeout
        {
            get => adbTimeout > 0 ? adbTimeout : 5000;
            set => adbTimeout = value;
        }

        public string Output;

        readonly BackgroundWorker cmd = new BackgroundWorker();
        #endregion

        #region Process
        private void RunCommand(string adbCommand)
        {
            var info = new ProcessStartInfo()
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow  = true,
                RedirectStandardError = true,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                FileName = Utility.ADBTool,
                Arguments = adbCommand,
            };

            var process = new Process()
            {
                StartInfo = info,
                EnableRaisingEvents = true
            };
            process.Start();
            do
            {
                Output = process.StandardOutput.ReadToEnd();
            } while (!process.HasExited);
            process.Dispose();
        }
        #endregion

        #region ADB Commands
        public async void GetDevicesList(Action<string> OnStart, Action<List<Device>> OnDeviceScanned, Action<string> OnFinished)
        {
            OnStart("Scanning for device");
            List<Device> devices = new List<Device>();

            var command = "devices";
            await Task.Run(() => RunCommand(command));

            Debug.WriteLine(Output);

            var outLines = Output.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            var IDs = outLines.Skip(1).ToList();

            for (int i = 0; i < IDs.Count; i++)
            {
                var device = new Device();
                var temp = IDs[i];
                IDs[i] = temp.Substring(0, 11);

                device.ID = IDs[i];

                device.Name = await GetDeviceName(IDs[i]);
                device.Model = await GetDeviceModel(IDs[i]);

                devices.Add(device);
                OnFinished($"ID Found: {device.ID}"); 
            }
            if (devices.Count > 0)
            Debug.WriteLine($"{devices[0].ID}, {devices[0].Name}, {devices[0].Model}");
            OnDeviceScanned(devices);
        }

        public async Task<string> GetDeviceName(string ID)
        {
            var command = $" -s {ID} shell getprop ro.product.device";
            await Task.Run (() => RunCommand(command));
            string[] outLines = Output.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            return outLines.First();
        }

        public async Task<string> GetDeviceModel(string ID)
        {
            var command = $"-s {ID} shell getprop ro.product.model";
            await Task.Run(() => RunCommand(command));
            string[] outLines = Output.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            return outLines.First();
        }

        public async Task Push(string ID, string file, Action<string> OnStart, Action<string> OnFinished, string path = "/storage/emulated/0/Download/")
        {
            var filename = Path.GetFileName(file);
            OnStart($"Pushing {filename} to {path}");
            var command = $@"-s {ID} push ""{file}"" ""{path}""";
            await Task.Run(() => RunCommand(command));

            OnFinished($"All Files Successfully Pushed to Download");
        }

        public async Task Install(string ID, string file, Action<string> OnStart, Action<string> OnFinished)
        {
            var filename = Path.GetFileName(file);
            OnStart($"Installing: {filename}");
            var command = $@"-s {ID} install ""{file}""";
            await Task.Run(() => RunCommand(command));
            if (Output.Contains("Successfully".ToLowerInvariant()))
                OnFinished($"{file} Installed Successfully ");
        }
        #endregion
    }
}