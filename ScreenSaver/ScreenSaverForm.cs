using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ScreenSaver
{
	public class ScreenSaverForm : Form
	{
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern bool GetClientRect(IntPtr hWnd, out Rectangle lpRect);

        private System.ComponentModel.IContainer components;
		private Point MouseXY;
        private Image[] images = new Image[] {
            Properties.Resources.linux,
            Properties.Resources.mint,
            Properties.Resources.ubuntu,
            Properties.Resources.windows_11,
            Properties.Resources.windows_2003_xp,
            Properties.Resources.windows_3,
            Properties.Resources.windows_7,
            Properties.Resources.windows_8_10
        };
        private Timer timer;
        private readonly int screenNumber;
        private readonly bool previewMode;

        public ScreenSaverForm(int scrn)
        {
            InitializeComponent();
            screenNumber = scrn;
            previewMode = false;
        }

        public ScreenSaverForm(IntPtr previewHandle)
        {
            InitializeComponent();
            screenNumber = -1;
            // running as small preview inside the screensaver control panel
            previewMode = true;

            // Set the preview window as the parent of this window
            SetParent(this.Handle, previewHandle);

            // Make this a child window so it will close when the parent dialog closes
            // GWL_STYLE = -16, WS_CHILD = 0x40000000
            SetWindowLong(this.Handle, -16, new IntPtr(GetWindowLong(this.Handle, -16) | 0x40000000));

            // Place our window inside the parent
            Rectangle ParentRect;
            GetClientRect(previewHandle, out ParentRect);
            Size = ParentRect.Size;
            Location = new Point(0, 0);

            // room for further behavior changes to allow useful preview
        }

        protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		private void ScreenSaverForm_Load(object sender, System.EventArgs e)
		{
            if (previewMode)
            {
                /// bounds configured in the constructor
            }
            else
            {
			    this.Bounds = Screen.AllScreens[screenNumber].Bounds;
			    Cursor.Hide();
			    TopMost = true;
            }

            timer.Tick += Timer1_Tick;
            timer.Start();
            Randomize();
            delayTicks = 0;
        }

        private void OnMouseEvent(object sender, System.Windows.Forms.MouseEventArgs e)
        {
			if (!previewMode && !MouseXY.IsEmpty)
			{
				if (MouseXY != new Point(e.X, e.Y))
					Close();
				if (e.Clicks > 0)
					Close();
			}
			MouseXY = new Point(e.X, e.Y);
		}
		
		private void ScreenSaverForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
            if (!previewMode)
            {
                Close();
            }
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer.Interval = 16;
            // 
            // ScreenSaverForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Snow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreenSaverForm";
            this.Text = "ScreenSaver";
            this.Load += new System.EventHandler(this.ScreenSaverForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ScreenSaverForm_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseEvent);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseEvent);
            this.ResumeLayout(false);

		}
        #endregion

        private Settings settings = Settings.Load();

        private int IconWidth => previewMode ? 32 : 128;
        private int IconHeight => previewMode ? 32 : 128;
        private int XSpeed => IconWidth / 9;
        private int XStartLeft => -2 * IconWidth;
        private int XStartRight => Width + IconWidth;
        private int MinYPos => -IconHeight;
        private int MaxYPos => Height + IconHeight;
        private int YSpeed => IconHeight / 16;

        private Random random = new Random();

        private Point speed = new Point(15, 8);
        private int delayTicks = 0; // there are 60 tiks per second
        private int DelaySeconds
        {
            get => delayTicks / 60;
            set => delayTicks = value * 60;
        }
        private int imageIndex = 0;
        private int tickFrame = 0;
        private int xPos = 0;
        private int yPos = 0;
        private float angleOffset = -15.0f;
        private float rotationDivident = 50.0f;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.Clear(Color.Black);
            e.Graphics.TranslateTransform(xPos, yPos);
            if (settings.rotationEffect)
            {
                float newRot = xPos / rotationDivident + angleOffset;
                e.Graphics.RotateTransform((int)Math.Round(newRot), System.Drawing.Drawing2D.MatrixOrder.Prepend);
            }
            if (previewMode)
                e.Graphics.DrawImage(images[imageIndex], 0, 0, IconWidth, IconHeight);
            else
                e.Graphics.DrawImage(images[imageIndex], 0, 0, IconWidth, IconHeight);
        }

        private void Randomize()
        {
            int config = random.Next(10);
            bool startLeft = config > 4;
            xPos = startLeft ? XStartLeft : XStartRight;
            if (startLeft)
                config -= 5;
            speed.X = startLeft ? XSpeed : -XSpeed;
            yPos = MinYPos + (config + 1) * Height / 5;
            speed.Y = random.Next(YSpeed);
            speed.Y *= config > 2 ? -1 : 1;
            // different random image
            int imageI = imageIndex;
            while (imageIndex == imageI)
                imageIndex = random.Next(images.Length);
            // Random delay
            if (previewMode)
                DelaySeconds = random.Next(2); // less delay in Preview mode
            else
                DelaySeconds = random.Next(6);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (delayTicks > 0)
            {
                delayTicks--;
                return;
            }
            tickFrame++;
            if (tickFrame == 61)
            {
                // extra frame due to 16ms timer interval, don't draw this one
                tickFrame = 0;
                return;
            }
            // move
            xPos+= speed.X;
            yPos+= speed.Y;
            // flew out of bounds?
            if (xPos > Width + 200 || xPos < XStartLeft)
            {
                Randomize();
            }
            //Console.WriteLine($"Box location {this.pictureBox1.Location.X},{this.pictureBox1.Location.Y}");
            // ensure gets called again
            Refresh();
        }
    }
}
