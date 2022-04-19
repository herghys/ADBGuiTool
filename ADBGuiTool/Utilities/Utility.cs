using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADBGuiTool.Utilities
{
    public class Utility
    {
        const string PlatformToolsFolder = "adb";

        public static string ADBTool
        { get => Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), PlatformToolsFolder, "adb.exe"); }

        public static string Fastboot
        { get => Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), PlatformToolsFolder, "fastboot.exe"); }
    }
}
