using System.IO;
using System.Windows.Forms;

namespace ADBGuiTool.Utilities
{
    public class Utility
    {
        const string PlatformToolsFolder = "PlatformTools";

        public static string ADBTool
        { get => Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), PlatformToolsFolder, "adb.exe"); }

        public static string Fastboot
        { get => Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), PlatformToolsFolder, "fastboot.exe"); }
    }
}
