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
                    _allImages = new Image[LinuxImages.Length + WindowsImages.Length];
                    for (int i = 0; i < LinuxImages.Length; i++)
                    {
                        _allImages[i] = LinuxImages[i];
                    }
                    for (int i = 0; i < WindowsImages.Length; i++)
                    {
                        _allImages[LinuxImages.Length + i] = WindowsImages[i];
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
    }
}
