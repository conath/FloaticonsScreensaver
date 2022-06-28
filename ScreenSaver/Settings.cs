using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace ScreenSaver
{
    class Settings
    {
        #region Settings data
        public bool rotationEffect = true;
        public int moveSpeedX = 9; // range 0-10
        public bool moveY = true;
        #endregion

        #region Loading and storing data
        private const string REGISTRY_SUBKEY = "Software\\Floaticons Screensaver";
        private const string NAME_ROTATION = "RotationEffect";
        private const string NAME_XSPEED = "XMovementSpeed";
        private const string NAME_YMOVE = "YMovement";

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
                    instance.moveSpeedX = (int)key.GetValue(NAME_XSPEED, 1);
                    instance.moveY = (int)key.GetValue(NAME_YMOVE, 1) == 1;
                }
                return instance;
            }
            catch (InvalidCastException e)
            {
                MessageBox.Show("Can't load registry keys.");
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
            key.SetValue(NAME_XSPEED, moveSpeedX);
            key.SetValue(NAME_YMOVE, moveY ? 1 : 0);
            key.Close();
        }
        #endregion
    }
}
