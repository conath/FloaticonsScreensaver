using System;
using System.Windows.Forms;

namespace ScreenSaver
{
	public class DotNETScreenSaver
	{
		[STAThread]
		static void Main(string[] args) 
		{
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			if (args.Length > 0)
			{
                string arg1 = args[0].ToLower().Trim();
                string firstFlag = arg1.Substring(0, 2);
                
                string secondFlag = null;
                // Handle cases where arguments are separated by colon.
                // Examples: /c:1234567 or /P:1234567
                if (arg1.Length > 2)
                    secondFlag = arg1.Substring(3).Trim();
                else if (args.Length > 1)
                    secondFlag = args[1].ToLower().Trim();

                //MessageBox.Show("firstFlag " + firstFlag + " secondFlag " + secondFlag, "Floaticons Screensaver", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // determine which mode to run in
                switch (firstFlag)
                {
                    case "/c": // configure
                        RunOptions(firstFlag, secondFlag);
                        break;
                    case "/p": // mini preview
                        RunPreview(firstFlag, secondFlag);
                        break;
                    case "/s": // normal screensaver
                        Application.Run(new SCApplicationContext());
                        break;
                }
			}
			else
            {
                // right-clicked in Explorer and chosen configure, which we don't support
                MessageBox.Show("Please configure Floaticons from the screensaver control panel.", "Floaticons Screensaver", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
		}

        private static void RunNormally()
        {
            Application.Run(new SCApplicationContext());
        }

        private static void RunOptions(string firstArgument, string secondArgument)
        {
            Application.Run(new OptionsForm());
        }

        private static void RunPreview(string firstArgument, string secondArgument)
        {
            IntPtr previewWndHandle = new IntPtr(long.Parse(secondArgument));
            Application.Run(new ScreenSaverForm(previewWndHandle));
        }
	}
}
