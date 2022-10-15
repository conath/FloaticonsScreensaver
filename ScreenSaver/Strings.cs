namespace ScreenSaver
{
    static class Strings
    {
        private static string[] _allStrings;

        public static string[] AllIconNames
        {
            get
            {
                if (_allStrings == null)
                {
                    _allStrings = new string[LinuxIconNames.Length + WindowsIconNames.Length];
                    for (int i = 0; i < LinuxIconNames.Length; i++)
                    {
                        _allStrings[i] = LinuxIconNames[i];
                    }
                    for (int i = 0; i < WindowsIconNames.Length; i++)
                    {
                        _allStrings[LinuxIconNames.Length + i] = WindowsIconNames[i];
                    }
                }
                return _allStrings;
            }
        }

        public static string[] LinuxIconNames = new string[] {
            "Generic Linux",
            "Linux Mint",
            "Ubuntu"
        };

        public static string[] WindowsIconNames = new string[]
        {
            "Windows 3.0",
            "Windows 3.1 etc.",
            "Windows 95-98",
            "Windows 2000",
            "Windows ME",
            "Windows XP",
            "Windows Vista",
            "Windows 7",
            "Windows 8 / 8.1",
            "Windows 10",
            "Windows 11"
        };
    }
}
