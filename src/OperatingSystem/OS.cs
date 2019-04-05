using System;
using System.Runtime.InteropServices;

namespace OperatingSystem {
    public static class OS {
        public static bool IsWindows() =>
            RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

        public static bool IsMacOS() =>
            RuntimeInformation.IsOSPlatform(OSPlatform.OSX);

        public static bool IsLinux() =>
            RuntimeInformation.IsOSPlatform(OSPlatform.Linux);

         public static string UserProfile() =>
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
    }
}
