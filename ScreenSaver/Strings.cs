namespace ScreenSaver
{
    static class Strings
    {
        private static string[] _allStrings;
        private static string[] _allStringsMjd;

        public static string[] GetAllIconNames(bool includeMjd = true)
        {
            if (includeMjd && _allStringsMjd != null)
                return _allStringsMjd;
            if (!includeMjd && _allStrings != null)
                return _allStrings;
            // strings not yet cached
            int offset = 0;
            int length = LinuxIconNames.Length + WindowsIconNames.Length;
            if (includeMjd)
                length += MjdIconNames.Length + MjdSoftwareServicesIconNames.Length + MjdTechBrandsIconNames.Length;
            string[] strings = new string[length];
            for (int i = 0; i < LinuxIconNames.Length; i++)
            {
                strings[offset] = LinuxIconNames[i];
                offset++;
            }
            for (int i = 0; i < WindowsIconNames.Length; i++)
            {
                strings[offset] = WindowsIconNames[i];
                offset++;
            }
            if (includeMjd)
            {
                for (int i = 0; i < MjdIconNames.Length; i++)
                {
                    strings[offset] = MjdIconNames[i];
                    offset++;
                }
                for (int i = 0; i < MjdSoftwareServicesIconNames.Length; i++)
                {
                    strings[offset] = MjdSoftwareServicesIconNames[i];
                    offset++;
                }
                for (int i = 0; i < MjdTechBrandsIconNames.Length; i++)
                {
                    strings[offset] = MjdTechBrandsIconNames[i];
                    offset++;
                }
                _allStringsMjd = strings;
            }
            else
            {
                _allStrings = strings;
            }
            return strings;
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
