using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ScreenSaver
{
    public partial class OptionsForm : Form
    {
        private Settings settings;

        public OptionsForm()
        {
            InitializeComponent();
            settings = Settings.Load();
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            rotationEffectCheckBox.Checked = settings.rotationEffect;
            verticalMovementCheckBox.Checked = settings.moveY;
            animationSpeedSlider.Value = settings.moveSpeedX;
            LinuxIconsCheckList.Items.AddRange(Strings.LinuxIconNames);
            WindowsIconsCheckList.Items.AddRange(Strings.WindowsIconNames);
            for (int i = 0; i < Strings.LinuxIconNames.Length; i++)
            {
                LinuxIconsCheckList.SetItemChecked(i, settings.IsIconEnabled(Strings.LinuxIconNames[i]));
            }
            for (int i = 0; i < Strings.WindowsIconNames.Length; i++)
            {
                WindowsIconsCheckList.SetItemChecked(i,
                    settings.IsIconEnabled(Strings.WindowsIconNames[i]));
            }
            LinuxIconsCheckList.ItemCheck += LinuxIconsCheckedListBox_ItemCheck;
            WindowsIconsCheckList.ItemCheck += WindowsIconsCheckedListBox_ItemCheck;
            // hide mjd button by default, unless MJD mode is enabled
            if (!settings.mjdMode) tabControl1.TabPages.Remove(mjdTabPage);
        }
        
        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            linkLabel1.LinkVisited = true;
            // Call the Process.Start method to open the default browser
            // with a URL:
            Process.Start("https://github.com/conath/FloaticonsScreensaver/");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link.\rn" + ex.Message);
            }
        }

        private void rotationEffect_CheckedChanged(object sender, EventArgs e)
        {
            settings.rotationEffect = rotationEffectCheckBox.Checked;
        }

        private void OptionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // ask to save?
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            settings.Save();
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // "Apply and Preview"
        private void previewButton_Click(object sender, EventArgs e)
        {
            settings.Save();
            // start another copy of the program, in screensaver mode
            var process = Process.GetCurrentProcess();
            string fullPath = process.MainModule.FileName;
            previewProcess.StartInfo.FileName = fullPath;
            // No need to quit a previously running one, since the screensaver quits on user interaction.
            // Therefore it's practically impossible to click the preview button while the screensaver runs.
            previewProcess.Start();
        }

        private void animationSpeedSlider_Scroll(object sender, EventArgs e)
        {
            settings.moveSpeedX = animationSpeedSlider.Value;
        }

        private void verticalMovementCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            settings.moveY = verticalMovementCheckBox.Checked;
        }

        /// <summary>
        /// Invoked when an icon row is highlighted (selected)
        /// </summary>
        private void LinuxIconsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            linuxPreviewImage.Image = IconImages.LinuxImages[LinuxIconsCheckList.SelectedIndex];
        }

        /// <summary>
        /// Invoked when an icon is checked or unchecked.
        /// </summary>
        private void LinuxIconsCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int index = e.Index;
            settings.SetIconEnabled(Strings.LinuxIconNames[index], e.NewValue == CheckState.Checked);
        }

        /// <summary>
        /// Invoked when an icon row is highlighted (selected)
        /// </summary>
        private void WindowsIconsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            windowsPreviewImage.Image = IconImages.WindowsImages[WindowsIconsCheckList.SelectedIndex];
        }

        /// <summary>
        /// Invoked when an icon is checked or unchecked.
        /// </summary>
        private void WindowsIconsCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int index = e.Index;
            settings.SetIconEnabled(Strings.WindowsIconNames[index], e.NewValue == CheckState.Checked);
        }

        private void mjdLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (settings.mjdMode)
            {
                // show YouTube channel
                Process.Start("http://mjd.yt");
                e.Link.Visited = true;
            }
            else
            {
                // reveal MJD tab
                tabControl1.TabPages.Add(mjdTabPage);
                settings.mjdMode = true;
            }
        }

        private void mjdModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            settings.mjdMode = mjdModeCheckBox.Checked;
        }

        private void showMjdIconsFirstCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            settings.showMjdIconFirst = showMjdIconFirstCheckbox.Checked;
        }
    }
}
