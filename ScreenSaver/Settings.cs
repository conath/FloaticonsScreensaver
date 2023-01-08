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
        public bool mjdMode = false;

        private Dictionary<string, bool> iconEnableState = new Dictionary<string, bool>();

        private const bool IconDefaultState = true;
        #endregion

        #region Loading and storing data
        private const string REGISTRY_SUBKEY = "Software\\Floaticons Screensaver";
        private const string ICONS_SUBKEY = "\\Icon State";
        private const string MJD_SUBKEY = "\\MJD";
        private const string NAME_ROTATION = "RotationEffect";
        private const string NAME_XSPEED = "XMovementSpeed";
        private const string NAME_YMOVE = "YMovement";
        private const string NAME_MJD_MODE = "EnableMjdMode";

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
                string[] allIconNames = Strings.GetAllIconNames();
                if (key == null)
                {
                    // default settings
                    foreach (var name in allIconNames)
                    {
                        instance.SetIconEnabled(name, IconDefaultState);
                    }
                }
                else
                {
                    // read settings
                    foreach (var name in allIconNames)
                    {
                        bool state = 1 == (int)key.GetValue(name, defaultValue: IconDefaultState);
                        instance.SetIconEnabled(name, state);
                    }
                }
            }
            void LoadMjdSettings()
            {
                if (key != null)
                    key.Close();
                key = Registry.CurrentUser.OpenSubKey(REGISTRY_SUBKEY + MJD_SUBKEY);
                if (key == null)
                {
                    // default settings
                }
                else
                {
                    instance.mjdMode = (int)key.GetValue(NAME_MJD_MODE, 0) == 1;
                }
            }

            try
            {
                LoadMainSettings();
                LoadIconSettings();
                LoadMjdSettings();
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Can't load registry keys.");
                // default settings
                string[] allIconNames = Strings.GetAllIconNames();
                foreach (var name in allIconNames)
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
            void SaveMainSettings()
            {
                RegistryKey mainKey = Registry.CurrentUser.CreateSubKey(REGISTRY_SUBKEY);
                mainKey.SetValue(NAME_ROTATION, rotationEffect ? 1 : 0);
                mainKey.SetValue(NAME_XSPEED, moveSpeedX);
                mainKey.SetValue(NAME_YMOVE, moveY ? 1 : 0);
                mainKey.Close();
            }
            void SaveIconSettings()
            {
                RegistryKey iconsKey = Registry.CurrentUser.CreateSubKey(REGISTRY_SUBKEY + ICONS_SUBKEY);
                foreach (var name in iconEnableState.Keys)
                {
                    iconsKey.SetValue(name, iconEnableState[name] ? 1 : 0);
                }
                iconsKey.Close();
            }
            void SaveMjdSettings()
            {
                RegistryKey mjdKey = Registry.CurrentUser.CreateSubKey(REGISTRY_SUBKEY + MJD_SUBKEY);
                mjdKey.SetValue(NAME_MJD_MODE, mjdMode ? 1 : 0);
                mjdKey.Close();
            }
            SaveMainSettings();
            SaveIconSettings();
            SaveMjdSettings();
        }
        #endregion
    }
}
