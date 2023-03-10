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
            System.Windows.Forms.FlowLayoutPanel mjdFlowPanel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            System.Windows.Forms.Label label6;
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.mjdModeCheckBox = new System.Windows.Forms.CheckBox();
            this.showMjdIconFirstCheckbox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.iconsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.WindowsIconsCheckList = new System.Windows.Forms.CheckedListBox();
            this.windowsPreviewImage = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.prefabGroupBox = new System.Windows.Forms.GroupBox();
            this.LinuxIconsCheckList = new System.Windows.Forms.CheckedListBox();
            this.linuxPreviewImage = new System.Windows.Forms.PictureBox();
            this.todoLabel = new System.Windows.Forms.Label();
            this.aboutTabPage = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.mjdLabel = new System.Windows.Forms.LinkLabel();
            this.mjdTabPage = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.previewButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.previewProcess = new System.Diagnostics.Process();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            speedSliderLabel = new System.Windows.Forms.Label();
            mjdFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            label6 = new System.Windows.Forms.Label();
            mjdFlowPanel.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.generalTabPage.SuspendLayout();
            this.generalFlowPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animationSpeedSlider)).BeginInit();
            this.iconsTabPage.SuspendLayout();
            this.iconsFlowLayoutPanel.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowsPreviewImage)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.prefabGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linuxPreviewImage)).BeginInit();
            this.aboutTabPage.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.mjdTabPage.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox5.SuspendLayout();
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
            // mjdFlowPanel
            // 
            mjdFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            mjdFlowPanel.AutoSize = true;
            mjdFlowPanel.Controls.Add(this.groupBox4);
            mjdFlowPanel.Controls.Add(this.groupBox5);
            mjdFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            mjdFlowPanel.Location = new System.Drawing.Point(0, 0);
            mjdFlowPanel.Margin = new System.Windows.Forms.Padding(0);
            mjdFlowPanel.Name = "mjdFlowPanel";
            mjdFlowPanel.Padding = new System.Windows.Forms.Padding(8, 6, 6, 6);
            mjdFlowPanel.Size = new System.Drawing.Size(348, 410);
            mjdFlowPanel.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.mjdModeCheckBox);
            this.groupBox4.Controls.Add(this.showMjdIconFirstCheckbox);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(11, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox4.Size = new System.Drawing.Size(322, 84);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Michael MJD Mode";
            // 
            // mjdModeCheckBox
            // 
            this.mjdModeCheckBox.AutoSize = true;
            this.mjdModeCheckBox.Checked = true;
            this.mjdModeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mjdModeCheckBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mjdModeCheckBox.Location = new System.Drawing.Point(6, 36);
            this.mjdModeCheckBox.Name = "mjdModeCheckBox";
            this.mjdModeCheckBox.Padding = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.mjdModeCheckBox.Size = new System.Drawing.Size(310, 21);
            this.mjdModeCheckBox.TabIndex = 3;
            this.mjdModeCheckBox.Text = "MJD Mode enabled";
            this.mjdModeCheckBox.UseVisualStyleBackColor = true;
            this.mjdModeCheckBox.CheckedChanged += new System.EventHandler(this.mjdModeCheckBox_CheckedChanged);
            // 
            // showMjdIconFirstCheckbox
            // 
            this.showMjdIconFirstCheckbox.AutoSize = true;
            this.showMjdIconFirstCheckbox.Checked = true;
            this.showMjdIconFirstCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showMjdIconFirstCheckbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.showMjdIconFirstCheckbox.Location = new System.Drawing.Point(6, 57);
            this.showMjdIconFirstCheckbox.Name = "showMjdIconFirstCheckbox";
            this.showMjdIconFirstCheckbox.Padding = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.showMjdIconFirstCheckbox.Size = new System.Drawing.Size(310, 21);
            this.showMjdIconFirstCheckbox.TabIndex = 2;
            this.showMjdIconFirstCheckbox.Text = "Show MJD icon first";
            this.showMjdIconFirstCheckbox.UseVisualStyleBackColor = true;
            this.showMjdIconFirstCheckbox.CheckedChanged += new System.EventHandler(this.showMjdIconsFirstCheckbox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label5.Size = new System.Drawing.Size(308, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Additional icons have been unlocked, as seen on Michael MJD!";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.generalTabPage);
            this.tabControl1.Controls.Add(this.iconsTabPage);
            this.tabControl1.Controls.Add(this.aboutTabPage);
            this.tabControl1.Controls.Add(this.mjdTabPage);
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
            this.generalFlowPanel.Padding = new System.Windows.Forms.Padding(8, 6, 6, 6);
            this.generalFlowPanel.Size = new System.Drawing.Size(348, 410);
            this.generalFlowPanel.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(11, 9);
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
            this.label3.Size = new System.Drawing.Size(270, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Go to the Icons tab to choose the icons that are shown.";
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
            this.groupBox2.Location = new System.Drawing.Point(11, 73);
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
            this.iconsTabPage.Controls.Add(this.iconsFlowLayoutPanel);
            this.iconsTabPage.Controls.Add(this.todoLabel);
            this.iconsTabPage.Location = new System.Drawing.Point(4, 22);
            this.iconsTabPage.Name = "iconsTabPage";
            this.iconsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.iconsTabPage.Size = new System.Drawing.Size(348, 410);
            this.iconsTabPage.TabIndex = 1;
            this.iconsTabPage.Text = "Icons";
            this.iconsTabPage.UseVisualStyleBackColor = true;
            // 
            // iconsFlowLayoutPanel
            // 
            this.iconsFlowLayoutPanel.AutoSize = true;
            this.iconsFlowLayoutPanel.Controls.Add(this.flowLayoutPanel5);
            this.iconsFlowLayoutPanel.Controls.Add(this.flowLayoutPanel3);
            this.iconsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.iconsFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.iconsFlowLayoutPanel.Name = "iconsFlowLayoutPanel";
            this.iconsFlowLayoutPanel.Size = new System.Drawing.Size(342, 404);
            this.iconsFlowLayoutPanel.TabIndex = 1;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.Controls.Add(this.groupBox3);
            this.flowLayoutPanel5.Controls.Add(this.windowsPreviewImage);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(330, 166);
            this.flowLayoutPanel5.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.WindowsIconsCheckList);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.MinimumSize = new System.Drawing.Size(160, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(160, 160);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Windows Operating Systems";
            // 
            // WindowsIconsCheckList
            // 
            this.WindowsIconsCheckList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WindowsIconsCheckList.CheckOnClick = true;
            this.WindowsIconsCheckList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WindowsIconsCheckList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.WindowsIconsCheckList.FormattingEnabled = true;
            this.WindowsIconsCheckList.Location = new System.Drawing.Point(3, 16);
            this.WindowsIconsCheckList.Name = "WindowsIconsCheckList";
            this.WindowsIconsCheckList.Size = new System.Drawing.Size(154, 141);
            this.WindowsIconsCheckList.TabIndex = 0;
            this.WindowsIconsCheckList.SelectedIndexChanged += new System.EventHandler(this.WindowsIconsCheckedListBox_SelectedIndexChanged);
            // 
            // windowsPreviewImage
            // 
            this.windowsPreviewImage.Image = ((System.Drawing.Image)(resources.GetObject("windowsPreviewImage.Image")));
            this.windowsPreviewImage.InitialImage = global::ScreenSaver.Properties.Resources.ubuntu;
            this.windowsPreviewImage.Location = new System.Drawing.Point(186, 20);
            this.windowsPreviewImage.Margin = new System.Windows.Forms.Padding(20, 20, 16, 16);
            this.windowsPreviewImage.MaximumSize = new System.Drawing.Size(128, 128);
            this.windowsPreviewImage.MinimumSize = new System.Drawing.Size(128, 128);
            this.windowsPreviewImage.Name = "windowsPreviewImage";
            this.windowsPreviewImage.Size = new System.Drawing.Size(128, 128);
            this.windowsPreviewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.windowsPreviewImage.TabIndex = 1;
            this.windowsPreviewImage.TabStop = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.prefabGroupBox);
            this.flowLayoutPanel3.Controls.Add(this.linuxPreviewImage);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 175);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(336, 168);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // prefabGroupBox
            // 
            this.prefabGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prefabGroupBox.Controls.Add(this.LinuxIconsCheckList);
            this.prefabGroupBox.Location = new System.Drawing.Point(3, 3);
            this.prefabGroupBox.MinimumSize = new System.Drawing.Size(160, 160);
            this.prefabGroupBox.Name = "prefabGroupBox";
            this.prefabGroupBox.Size = new System.Drawing.Size(160, 160);
            this.prefabGroupBox.TabIndex = 0;
            this.prefabGroupBox.TabStop = false;
            this.prefabGroupBox.Text = "Linux Operating Systems";
            // 
            // LinuxIconsCheckList
            // 
            this.LinuxIconsCheckList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LinuxIconsCheckList.CheckOnClick = true;
            this.LinuxIconsCheckList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LinuxIconsCheckList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LinuxIconsCheckList.FormattingEnabled = true;
            this.LinuxIconsCheckList.Location = new System.Drawing.Point(3, 16);
            this.LinuxIconsCheckList.Name = "LinuxIconsCheckList";
            this.LinuxIconsCheckList.Size = new System.Drawing.Size(154, 141);
            this.LinuxIconsCheckList.TabIndex = 0;
            this.LinuxIconsCheckList.SelectedIndexChanged += new System.EventHandler(this.LinuxIconsCheckedListBox_SelectedIndexChanged);
            // 
            // linuxPreviewImage
            // 
            this.linuxPreviewImage.Image = ((System.Drawing.Image)(resources.GetObject("linuxPreviewImage.Image")));
            this.linuxPreviewImage.InitialImage = global::ScreenSaver.Properties.Resources.ubuntu;
            this.linuxPreviewImage.Location = new System.Drawing.Point(186, 20);
            this.linuxPreviewImage.Margin = new System.Windows.Forms.Padding(20, 20, 16, 16);
            this.linuxPreviewImage.MaximumSize = new System.Drawing.Size(128, 128);
            this.linuxPreviewImage.MinimumSize = new System.Drawing.Size(128, 128);
            this.linuxPreviewImage.Name = "linuxPreviewImage";
            this.linuxPreviewImage.Size = new System.Drawing.Size(128, 128);
            this.linuxPreviewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.linuxPreviewImage.TabIndex = 1;
            this.linuxPreviewImage.TabStop = false;
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
            this.flowLayoutPanel2.Controls.Add(this.mjdLabel);
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
            this.label1.Size = new System.Drawing.Size(219, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Floaticons © 2022-2023 Christoph Parstorfer.";
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
            // mjdLabel
            // 
            this.mjdLabel.AutoSize = true;
            this.mjdLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mjdLabel.LinkArea = new System.Windows.Forms.LinkArea(12, 11);
            this.mjdLabel.Location = new System.Drawing.Point(9, 40);
            this.mjdLabel.Name = "mjdLabel";
            this.mjdLabel.Size = new System.Drawing.Size(131, 17);
            this.mjdLabel.TabIndex = 2;
            this.mjdLabel.TabStop = true;
            this.mjdLabel.Text = "Inspired by Michael MJD.";
            this.mjdLabel.UseCompatibleTextRendering = true;
            this.mjdLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.mjdLabel_LinkClicked);
            // 
            // mjdTabPage
            // 
            this.mjdTabPage.Controls.Add(mjdFlowPanel);
            this.mjdTabPage.Location = new System.Drawing.Point(4, 22);
            this.mjdTabPage.Name = "mjdTabPage";
            this.mjdTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mjdTabPage.Size = new System.Drawing.Size(348, 410);
            this.mjdTabPage.TabIndex = 3;
            this.mjdTabPage.Text = "MJD Mode";
            this.mjdTabPage.UseVisualStyleBackColor = true;
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
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
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
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkBox2.Location = new System.Drawing.Point(3, 91);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Padding = new System.Windows.Forms.Padding(4);
            this.checkBox2.Size = new System.Drawing.Size(316, 25);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Rotation (icons will rotate slightly as they fly across)";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkBox1.Location = new System.Drawing.Point(3, 70);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Padding = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.checkBox1.Size = new System.Drawing.Size(316, 21);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Move diagonally (icons will move on tilted/diagonal paths)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.BackColor = System.Drawing.SystemColors.Window;
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBar1.LargeChange = 2;
            this.trackBar1.Location = new System.Drawing.Point(3, 31);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(0);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(316, 39);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = System.Windows.Forms.DockStyle.Top;
            label6.Location = new System.Drawing.Point(3, 16);
            label6.Name = "label6";
            label6.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            label6.Size = new System.Drawing.Size(91, 15);
            label6.TabIndex = 3;
            label6.Text = "Movement Speed";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(label6);
            this.groupBox5.Controls.Add(this.trackBar1);
            this.groupBox5.Controls.Add(this.checkBox1);
            this.groupBox5.Controls.Add(this.checkBox2);
            this.groupBox5.Location = new System.Drawing.Point(11, 99);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(322, 119);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Animation";
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(368, 474);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(384, 512);
            this.MinimumSize = new System.Drawing.Size(384, 512);
            this.Name = "OptionsForm";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Text = "Floaticons Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OptionsForm_FormClosing);
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            mjdFlowPanel.ResumeLayout(false);
            mjdFlowPanel.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
            this.iconsFlowLayoutPanel.ResumeLayout(false);
            this.iconsFlowLayoutPanel.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.windowsPreviewImage)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.prefabGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.linuxPreviewImage)).EndInit();
            this.aboutTabPage.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.mjdTabPage.ResumeLayout(false);
            this.mjdTabPage.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.FlowLayoutPanel iconsFlowLayoutPanel;
        private System.Windows.Forms.GroupBox prefabGroupBox;
        private System.Windows.Forms.CheckedListBox LinuxIconsCheckList;
        private System.Windows.Forms.PictureBox linuxPreviewImage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox WindowsIconsCheckList;
        private System.Windows.Forms.PictureBox windowsPreviewImage;
        private System.Windows.Forms.TabPage mjdTabPage;
        private System.Windows.Forms.LinkLabel mjdLabel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox showMjdIconFirstCheckbox;
        private System.Windows.Forms.CheckBox mjdModeCheckBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}