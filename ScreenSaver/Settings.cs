using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace ScreenSaver
{
    class Settings
    {
        #region Settings data
        public bool rotationEffect = true;
        public int moveSpeedX = 5; // range 0-10?
        public int moveSpeedY = 5; // range 0-10?
        #endregion

        #region Loading and storing data
        private const string REGISTRY_SUBKEY = "Software\\Floaticons Screensaver";
        private const string NAME_ROTATION = "RotationEffect";

        private Settings()
        { }

        public static Settings Load()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(REGISTRY_SUBKEY);
            try
            {
                var instance = new Settings();
                if (key == null)
                {
                    // default settings
                }
                else
                {
                    // read settings
                    instance.rotationEffect = (int)key.GetValue(NAME_ROTATION, 1) == 1;
                }
                return instance;
            }
            catch (InvalidCastException e)
            {
                MessageBox.Show("Please close regedit.");
                throw e;
            }
            finally
            {
                if (key != null)
                    key.Close();
            }
        }

        public void Save()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(REGISTRY_SUBKEY);
            key.SetValue(NAME_ROTATION, rotationEffect ? 1 : 0);
            key.Close();
        }
        #endregion
    }
}
