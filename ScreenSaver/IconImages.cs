using System.Drawing;

namespace ScreenSaver
{
    static class IconImages
    {
        private static Image[] _allImages;

        public static Image[] AllImages {
            get {
                if (_allImages == null)
                {
                    int offset = 0;
                    int length = LinuxImages.Length + WindowsImages.Length
                        + MjdImages.Length + MjdSoftwareServicesImages.Length + MjdTechBrandsImages.Length;
                    _allImages = new Image[length];
                    for (int i = 0; i < LinuxImages.Length; i++)
                    {
                        _allImages[offset] = LinuxImages[i];
                        offset++;
                    }
                    for (int i = 0; i < WindowsImages.Length; i++)
                    {
                        _allImages[offset] = WindowsImages[i];
                        offset++;
                    }
                    for (int i = 0; i < MjdImages.Length; i++)
                    {
                        _allImages[offset] = MjdImages[i];
                        offset++;
                    }
                    for (int i = 0; i < MjdSoftwareServicesImages.Length; i++)
                    {
                        _allImages[offset] = MjdSoftwareServicesImages[i];
                        offset++;
                    }
                    for (int i = 0; i < MjdTechBrandsImages.Length; i++)
                    {
                        _allImages[offset] = MjdTechBrandsImages[i];
                        offset++;
                    }
                }
                return _allImages;
            }
        }

        public static Image[] LinuxImages = new Image[] {
            Properties.Resources.linux,
            Properties.Resources.mint,
            Properties.Resources.ubuntu
        };
        public static Image[] WindowsImages = new Image[] {
            Properties.WindowsIcons._3_0,
            Properties.WindowsIcons._3_1_etc,
            Properties.WindowsIcons._95_98,
            Properties.WindowsIcons._2000,
            Properties.WindowsIcons.ME,
            Properties.WindowsIcons.XP,
            Properties.WindowsIcons.Vista,
            Properties.WindowsIcons._7,
            Properties.WindowsIcons._8,
            Properties.WindowsIcons._10,
            Properties.WindowsIcons._11
        };

        public static Image[] MjdImages = new Image[]
        {
            Properties.MjdResources.MJD_Icon
        };

        public static Image[] MjdSoftwareServicesImages = new Image[]
        {
            Properties.MjdSoftwareServicesIcons.Cydia,
            Properties.MjdSoftwareServicesIcons.FaceTime,
            Properties.MjdSoftwareServicesIcons.Firefox,
            Properties.MjdSoftwareServicesIcons.Google_Chrome,
            Properties.MjdSoftwareServicesIcons.Hulu,
            Properties.MjdSoftwareServicesIcons.MS_Office_97,
            Properties.MjdSoftwareServicesIcons.MS_DOS,
            Properties.MjdSoftwareServicesIcons.MSN_Messenger,
            Properties.MjdSoftwareServicesIcons.Mac_OS,
            Properties.MjdSoftwareServicesIcons.Microsoft_Edge,
            Properties.MjdSoftwareServicesIcons.Netscape,
            Properties.MjdSoftwareServicesIcons.Twitter,
            Properties.MjdSoftwareServicesIcons.Windows_Longhorn,
            Properties.MjdSoftwareServicesIcons.Windows_Whistler,
            Properties.MjdSoftwareServicesIcons.eBay,
            Properties.MjdSoftwareServicesIcons.iTunes
        };

        public static Image[] MjdTechBrandsImages = new Image[]
        {
            Properties.MjdTechBrandsIcons.Alienware,
            Properties.MjdTechBrandsIcons.Amazon,
            Properties.MjdTechBrandsIcons.Apple_Aqua,
            Properties.MjdTechBrandsIcons.Apple_Grey,
            Properties.MjdTechBrandsIcons.Apple_Rainbow,
            Properties.MjdTechBrandsIcons.Dell,
            Properties.MjdTechBrandsIcons.Google,
            Properties.MjdTechBrandsIcons.HP_white,
            Properties.MjdTechBrandsIcons.IBM,
            Properties.MjdTechBrandsIcons.Microsoft_old,
            Properties.MjdTechBrandsIcons.Microsoft,
            Properties.MjdTechBrandsIcons.Nintendo,
            Properties.MjdTechBrandsIcons.Packard_Bell
        };
    }
}
