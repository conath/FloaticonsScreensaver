using System;
using System.Windows.Forms;

namespace ScreenSaver
{
	public class DotNETScreenSaver
	{
		[STAThread]
		static void Main(string[] args) 
		{
			if (args.Length > 0)
			{
                string arg = args[0].ToLower().Trim();
                // configure
                if (arg.Substring(0,2) == "/c")
				{
                    // TODO: Allow choosing which icons should appear. Maybe even load custom icons
                    MessageBox.Show("There are no options to configure.", "Floaticons Screensaver", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else if (arg == "/s") // preview?
				{
					for (int i = Screen.AllScreens.GetLowerBound(0); i <= Screen.AllScreens.GetUpperBound(0); i++) 
						Application.Run(new ScreenSaverForm(i));				
				}
			}
			else // run normally
			{
				for (int i = Screen.AllScreens.GetLowerBound(0); i <= Screen.AllScreens.GetUpperBound(0); i++) 
					Application.Run(new ScreenSaverForm(i));				
			}
		}
	}
}
