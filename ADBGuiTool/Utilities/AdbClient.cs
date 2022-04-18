using ADBGuiTool.Data;
using System;
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

        BackgroundWorker cmd = new BackgroundWorker();
        //private Process shell;
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
        public async void GetDevicesList(Action<List<Device>> OnFinished)
        {
            List<Device> devices = new List<Device>();

            var command = "devices";
            await Task.Run(() => RunCommand(command));

            Debug.WriteLine(Output);

            var outLines = Output.Split(new[] { Environment.NewLine }, StringSplitOptions.TrimEntries);
            var IDs = outLines.Skip(1).SkipLast(2).ToList();

            for (int i = 0; i < IDs.Count; i++)
            {
                var device = new Device();
                var temp = IDs[i];
                IDs[i] = temp.Substring(0, 11);

                device.DeviceID = IDs[i];

                device.DeviceName = await GetDeviceName(IDs[i]);
                device.DeviceModel = await GetDeviceModel(IDs[i]);

                devices.Add(device);
            }
            if (devices.Count > 0)
            Debug.WriteLine($"{devices[0].DeviceID}, {devices[0].DeviceName}, {devices[0].DeviceModel}");
            OnFinished(devices);
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
        #endregion
    }
}