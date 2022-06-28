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
        }
        
        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            linkLabel1.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
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
    }
}
