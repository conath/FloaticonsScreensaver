using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScreenSaver
{
    class Settings
    {
        #region Settings data
        public bool rotationEffect = true;
        public int moveSpeedX = 9; // range 0-10
        public bool moveY = true;

        private Dictionary<string, bool> iconEnableState = new Dictionary<string, bool>();

        private const bool IconDefaultState = true;
        #endregion

        #region Loading and storing data
        private const string REGISTRY_SUBKEY = "Software\\Floaticons Screensaver";
        private const string ICONS_SUBKEY = "\\Icon State";
        private const string NAME_ROTATION = "RotationEffect";
        private const string NAME_XSPEED = "XMovementSpeed";
        private const string NAME_YMOVE = "YMovement";

        private Settings()
        { }

        public static Settings Load()
        {
            var instance = new Settings();
            RegistryKey key = null;
            void LoadMainSettings()
            {
                key = Registry.CurrentUser.OpenSubKey(REGISTRY_SUBKEY);
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
            }
            void LoadIconSettings()
            {
                if (key != null)
                    key.Close();
                key = Registry.CurrentUser.OpenSubKey(REGISTRY_SUBKEY + ICONS_SUBKEY);
                if (key == null)
                {
                    // default settings
                    foreach (var name in Strings.AllIconNames)
                    {
                        instance.SetIconEnabled(name, IconDefaultState);
                    }
                }
                else
                {
                    // read settings
                    foreach (var name in Strings.AllIconNames)
                    {
                        bool state = 1 == (int)key.GetValue(name, defaultValue: IconDefaultState);
                        instance.SetIconEnabled(name, state);
                    }
                }
            }

            try
            {
                LoadMainSettings();
                LoadIconSettings();
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Can't load registry keys.");
                // default settings
                foreach (var name in Strings.AllIconNames)
                {
                    instance.SetIconEnabled(name, IconDefaultState);
                }
            }
            finally
            {
                if (key != null)
                    key.Close();
            }
            return instance;
        }

        public bool IsIconEnabled(string name)
        {
            if (iconEnableState.TryGetValue(name, out bool result))
                return result;
            else
                return IconDefaultState;
        }

        public void SetIconEnabled(string name, bool state)
        {
            iconEnableState[name] = state;
        }

        public void Save()
        {
            RegistryKey mainKey = Registry.CurrentUser.CreateSubKey(REGISTRY_SUBKEY);
            mainKey.SetValue(NAME_ROTATION, rotationEffect ? 1 : 0);
            mainKey.SetValue(NAME_XSPEED, moveSpeedX);
            mainKey.SetValue(NAME_YMOVE, moveY ? 1 : 0);
            mainKey.Close();
            RegistryKey iconsKey = Registry.CurrentUser.CreateSubKey(REGISTRY_SUBKEY + ICONS_SUBKEY);
            foreach (var name in iconEnableState.Keys)
            {
                iconsKey.SetValue(name, iconEnableState[name] ? 1 : 0);
            }
            iconsKey.Close();
        }
        #endregion
    }
}
