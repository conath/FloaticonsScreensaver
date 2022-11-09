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
                    int offset = 0;
                    int length = LinuxIconNames.Length + WindowsIconNames.Length 
                        + MjdIconNames.Length + MjdSoftwareServicesIconNames.Length + MjdTechBrandsIconNames.Length;
                    _allStrings = new string[length];
                    for (int i = 0; i < LinuxIconNames.Length; i++)
                    {
                        _allStrings[offset] = LinuxIconNames[i];
                        offset++;
                    }
                    for (int i = 0; i < WindowsIconNames.Length; i++)
                    {
                        _allStrings[offset] = WindowsIconNames[i];
                        offset++;
                    }
                    for (int i = 0; i < MjdIconNames.Length; i++)
                    {
                        _allStrings[offset] = MjdIconNames[i];
                        offset++;
                    }
                    for (int i = 0; i < MjdSoftwareServicesIconNames.Length; i++)
                    {
                        _allStrings[offset] = MjdSoftwareServicesIconNames[i];
                        offset++;
                    }
                    for (int i = 0; i < MjdTechBrandsIconNames.Length; i++)
                    {
                        _allStrings[offset] = MjdTechBrandsIconNames[i];
                        offset++;
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

        public static string[] MjdIconNames = new string[]
        {
            "MJD"
        };

        public static string[] MjdSoftwareServicesIconNames = new string[]
        {
            "Cydia",
            "FaceTime",
            "Firefox",
            "Google Chrome",
            "Hulu",
            "MS Office 97",
            "MS-DOS",
            "MSN Messenger",
            "Mac OS",
            "Microsoft Edge",
            "Netscape",
            "Twitter",
            "Windows Longhorn",
            "Windows Whistler",
            "eBay",
            "iTunes"
        };

        public static string[] MjdTechBrandsIconNames = new string[]
        {
           "Alienware",
            "Amazon",
            "Apple Aqua",
            "Apple Grey",
            "Apple Rainbow",
            "Dell",
            "Google",
            "HP white",
            "IBM",
            "Microsoft old",
            "Microsoft",
            "Nintendo",
            "Packard Bell"
        };
    }
}
