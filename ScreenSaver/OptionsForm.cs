using System;
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
            rotationEffect.Checked = settings.rotationEffect;
            applyButton.Enabled = false;
        }
        
        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            linkLabel1.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("https://github.com/conath/FloaticonsScreensaver/");
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
            settings.rotationEffect = rotationEffect.Checked;
            applyButton.Enabled = true;
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

        private void applyButton_Click(object sender, EventArgs e)
        {
            settings.Save();
            applyButton.Enabled = false;
        }
    }
}
