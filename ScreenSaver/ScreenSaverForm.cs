using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScreenSaver
{
	public class ScreenSaverForm : Form
	{
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
        private int ScreenNumber;

		public ScreenSaverForm(int scrn)
		{
			InitializeComponent();
			ScreenNumber = scrn;
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
			this.Bounds = Screen.AllScreens[ScreenNumber].Bounds;
			Cursor.Hide();
			TopMost = true;
            timer.Tick += Timer1_Tick;
            timer.Start();
            Randomize();
            delayTicks = 0;
        }

        private void OnMouseEvent(object sender, System.Windows.Forms.MouseEventArgs e)
        {
			if (!MouseXY.IsEmpty)
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
			Close();
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

        private const int XStartLeft = -256;
        private int XStartRight => Width + 128;
        private int MinYPos => -128;
        private int MaxYPos => Height + 128;

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
            float newRot = xPos / rotationDivident + angleOffset;
            e.Graphics.RotateTransform((int)Math.Round(newRot), System.Drawing.Drawing2D.MatrixOrder.Prepend);
            e.Graphics.DrawImage(images[imageIndex], 0, 0, 128, 128);
        }

        private void Randomize()
        {
            int config = random.Next(10);
            bool startLeft = config > 4;
            xPos = startLeft ? XStartLeft : XStartRight;
            if (startLeft)
                config -= 5;
            speed.X = startLeft ? 15 : -15;
            yPos = MinYPos + (config + 1) * Height / 5;
            speed.Y = random.Next(8);
            speed.Y *= config > 2 ? -1 : 1;
            // different random image
            int imageI = imageIndex;
            while (imageIndex == imageI)
                imageIndex = random.Next(images.Length);
            // Random delay
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
