using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Diagnostics;
using Path = System.IO.Path;

namespace PlatformToolsLib
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:PlatformToolsDotNetFrameworkLibrary"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:PlatformToolsDotNetFrameworkLibrary;assembly=PlatformToolsDotNetFrameworkLibrary"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:CustomControl1/>
    ///
    /// </summary>
    public class ADBClient : Control
    {
        static ADBClient()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ADBClient), new FrameworkPropertyMetadata(typeof(ADBClient)));
        }

        public ADBClient(string adbPath)
        {
            ADBPath = adbPath;
        }

        #region Variables
        private static int adbTimeout;
        public static int ADBTimeout
        {
            get => adbTimeout > 0 ? adbTimeout : 5000;
            set => adbTimeout = value;
        }
        bool scanningDevice =false;
        public string ADBPath { get; private set; }

        public string Output;
        #endregion

        #region Process
        private void RunCommand(string adbCommand)
        {
            var info = new ProcessStartInfo()
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true,
                RedirectStandardError = true,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                FileName = ADBPath,
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
            if (!scanningDevice)
            {
                scanningDevice = true;
                await Task.Run(() => RunCommand(command));
                scanningDevice = false;
            }

            var outLines = Output.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            var IDs = outLines.Skip(1).ToList();

            for (int i = 0; i < IDs.Count; i++)
            {
                var device = new Device();
                //var temp = IDs[i];
                IDs[i] = IDs[i].Substring(0, IDs[i].Length - 7);

                device.ID = IDs[i];

                device.Name = await GetDeviceName(IDs[i]);
                device.Model = await GetDeviceModel(IDs[i]);

                devices.Add(device);
                OnFinished($"ID Found: {device.ID}");
            }
            if (devices.Count > 0)
            OnDeviceScanned(devices);
        }

        public async Task<string> GetDeviceName(string ID)
        {
            var command = $" -s {ID} shell getprop ro.product.device";
            await Task.Run(() => RunCommand(command));
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
            if (Output.Contains("Success"))
                OnFinished($"{filename} Installed Successfully ");
        }
        #endregion
    }
}