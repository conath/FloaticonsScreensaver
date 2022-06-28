namespace ScreenSaver
{
    partial class OptionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label speedSliderLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.generalTabPage = new System.Windows.Forms.TabPage();
            this.generalFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.animationSpeedSlider = new System.Windows.Forms.TrackBar();
            this.verticalMovementCheckBox = new System.Windows.Forms.CheckBox();
            this.rotationEffectCheckBox = new System.Windows.Forms.CheckBox();
            this.iconsTabPage = new System.Windows.Forms.TabPage();
            this.todoLabel = new System.Windows.Forms.Label();
            this.aboutTabPage = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.previewButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.previewProcess = new System.Diagnostics.Process();
            speedSliderLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.generalTabPage.SuspendLayout();
            this.generalFlowPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animationSpeedSlider)).BeginInit();
            this.iconsTabPage.SuspendLayout();
            this.aboutTabPage.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // speedSliderLabel
            // 
            speedSliderLabel.AutoSize = true;
            speedSliderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            speedSliderLabel.Location = new System.Drawing.Point(3, 16);
            speedSliderLabel.Name = "speedSliderLabel";
            speedSliderLabel.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            speedSliderLabel.Size = new System.Drawing.Size(91, 15);
            speedSliderLabel.TabIndex = 3;
            speedSliderLabel.Text = "Movement Speed";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.generalTabPage);
            this.tabControl1.Controls.Add(this.iconsTabPage);
            this.tabControl1.Controls.Add(this.aboutTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(6, 6);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(356, 436);
            this.tabControl1.TabIndex = 0;
            // 
            // generalTabPage
            // 
            this.generalTabPage.Controls.Add(this.generalFlowPanel);
            this.generalTabPage.Location = new System.Drawing.Point(4, 22);
            this.generalTabPage.Name = "generalTabPage";
            this.generalTabPage.Padding = new System.Windows.Forms.Padding(10);
            this.generalTabPage.Size = new System.Drawing.Size(348, 410);
            this.generalTabPage.TabIndex = 0;
            this.generalTabPage.Text = "General";
            this.generalTabPage.UseVisualStyleBackColor = true;
            // 
            // generalFlowPanel
            // 
            this.generalFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generalFlowPanel.AutoSize = true;
            this.generalFlowPanel.Controls.Add(this.groupBox1);
            this.generalFlowPanel.Controls.Add(this.groupBox2);
            this.generalFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.generalFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.generalFlowPanel.Margin = new System.Windows.Forms.Padding(0);
            this.generalFlowPanel.Name = "generalFlowPanel";
            this.generalFlowPanel.Padding = new System.Windows.Forms.Padding(6);
            this.generalFlowPanel.Size = new System.Drawing.Size(348, 410);
            this.generalFlowPanel.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(322, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Welcome to Floaticons!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 2, 0, 5);
            this.label3.Size = new System.Drawing.Size(271, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Go to the Icons tab to change the icons that are shown.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Change the overall appearance and animations below.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(speedSliderLabel);
            this.groupBox2.Controls.Add(this.animationSpeedSlider);
            this.groupBox2.Controls.Add(this.verticalMovementCheckBox);
            this.groupBox2.Controls.Add(this.rotationEffectCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(9, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 119);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Animation";
            // 
            // animationSpeedSlider
            // 
            this.animationSpeedSlider.AutoSize = false;
            this.animationSpeedSlider.BackColor = System.Drawing.SystemColors.Window;
            this.animationSpeedSlider.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.animationSpeedSlider.LargeChange = 2;
            this.animationSpeedSlider.Location = new System.Drawing.Point(3, 31);
            this.animationSpeedSlider.Margin = new System.Windows.Forms.Padding(0);
            this.animationSpeedSlider.Name = "animationSpeedSlider";
            this.animationSpeedSlider.Size = new System.Drawing.Size(316, 39);
            this.animationSpeedSlider.TabIndex = 2;
            this.animationSpeedSlider.Value = 9;
            this.animationSpeedSlider.Scroll += new System.EventHandler(this.animationSpeedSlider_Scroll);
            // 
            // verticalMovementCheckBox
            // 
            this.verticalMovementCheckBox.AutoSize = true;
            this.verticalMovementCheckBox.Checked = true;
            this.verticalMovementCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.verticalMovementCheckBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.verticalMovementCheckBox.Location = new System.Drawing.Point(3, 70);
            this.verticalMovementCheckBox.Name = "verticalMovementCheckBox";
            this.verticalMovementCheckBox.Padding = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.verticalMovementCheckBox.Size = new System.Drawing.Size(316, 21);
            this.verticalMovementCheckBox.TabIndex = 1;
            this.verticalMovementCheckBox.Text = "Move diagonally (icons will move on tilted/diagonal paths)";
            this.verticalMovementCheckBox.UseVisualStyleBackColor = true;
            this.verticalMovementCheckBox.CheckedChanged += new System.EventHandler(this.verticalMovementCheckBox_CheckedChanged);
            // 
            // rotationEffectCheckBox
            // 
            this.rotationEffectCheckBox.AutoSize = true;
            this.rotationEffectCheckBox.Checked = true;
            this.rotationEffectCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rotationEffectCheckBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rotationEffectCheckBox.Location = new System.Drawing.Point(3, 91);
            this.rotationEffectCheckBox.Name = "rotationEffectCheckBox";
            this.rotationEffectCheckBox.Padding = new System.Windows.Forms.Padding(4);
            this.rotationEffectCheckBox.Size = new System.Drawing.Size(316, 25);
            this.rotationEffectCheckBox.TabIndex = 0;
            this.rotationEffectCheckBox.Text = "Rotation (icons will rotate slightly as they fly across)";
            this.rotationEffectCheckBox.UseVisualStyleBackColor = true;
            this.rotationEffectCheckBox.CheckedChanged += new System.EventHandler(this.rotationEffect_CheckedChanged);
            // 
            // iconsTabPage
            // 
            this.iconsTabPage.Controls.Add(this.todoLabel);
            this.iconsTabPage.Location = new System.Drawing.Point(4, 22);
            this.iconsTabPage.Name = "iconsTabPage";
            this.iconsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.iconsTabPage.Size = new System.Drawing.Size(348, 410);
            this.iconsTabPage.TabIndex = 1;
            this.iconsTabPage.Text = "Icons";
            this.iconsTabPage.UseVisualStyleBackColor = true;
            // 
            // todoLabel
            // 
            this.todoLabel.AutoSize = true;
            this.todoLabel.Location = new System.Drawing.Point(7, 7);
            this.todoLabel.Name = "todoLabel";
            this.todoLabel.Size = new System.Drawing.Size(40, 13);
            this.todoLabel.TabIndex = 0;
            this.todoLabel.Text = "To Do!";
            // 
            // aboutTabPage
            // 
            this.aboutTabPage.Controls.Add(this.flowLayoutPanel2);
            this.aboutTabPage.Location = new System.Drawing.Point(4, 22);
            this.aboutTabPage.Name = "aboutTabPage";
            this.aboutTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.aboutTabPage.Size = new System.Drawing.Size(348, 410);
            this.aboutTabPage.TabIndex = 2;
            this.aboutTabPage.Text = "About";
            this.aboutTabPage.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.linkLabel1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(342, 404);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Floaticons © 2022 Christoph Parstorfer.";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(21, 9);
            this.linkLabel1.Location = new System.Drawing.Point(9, 23);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(169, 17);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "View the source code on GitHub.";
            this.linkLabel1.UseCompatibleTextRendering = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.previewButton);
            this.flowLayoutPanel1.Controls.Add(this.cancelButton);
            this.flowLayoutPanel1.Controls.Add(this.okButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 441);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(356, 27);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // previewButton
            // 
            this.previewButton.Location = new System.Drawing.Point(252, 4);
            this.previewButton.Margin = new System.Windows.Forms.Padding(0);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(104, 23);
            this.previewButton.TabIndex = 2;
            this.previewButton.Text = "Apply & Preview";
            this.previewButton.UseMnemonic = false;
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(169, 4);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(86, 4);
            this.okButton.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // previewProcess
            // 
            this.previewProcess.StartInfo.Arguments = "/s";
            this.previewProcess.StartInfo.Domain = "";
            this.previewProcess.StartInfo.LoadUserProfile = false;
            this.previewProcess.StartInfo.Password = null;
            this.previewProcess.StartInfo.StandardErrorEncoding = null;
            this.previewProcess.StartInfo.StandardOutputEncoding = null;
            this.previewProcess.StartInfo.UserName = "";
            this.previewProcess.StartInfo.WorkingDirectory = ".\\";
            this.previewProcess.SynchronizingObject = this;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 474);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "OptionsForm";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Text = "Floaticons Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OptionsForm_FormClosing);
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.generalTabPage.ResumeLayout(false);
            this.generalTabPage.PerformLayout();
            this.generalFlowPanel.ResumeLayout(false);
            this.generalFlowPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animationSpeedSlider)).EndInit();
            this.iconsTabPage.ResumeLayout(false);
            this.iconsTabPage.PerformLayout();
            this.aboutTabPage.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage generalTabPage;
        private System.Windows.Forms.TabPage iconsTabPage;
        private System.Windows.Forms.TabPage aboutTabPage;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox rotationEffectCheckBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label todoLabel;
        private System.Windows.Forms.FlowLayoutPanel generalFlowPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TrackBar animationSpeedSlider;
        private System.Windows.Forms.CheckBox verticalMovementCheckBox;
        private System.Windows.Forms.Button okButton;
        private System.Diagnostics.Process previewProcess;
    }
}