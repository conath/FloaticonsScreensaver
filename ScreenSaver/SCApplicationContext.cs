using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScreenSaver
{
    /// <summary>
    /// Wraps the forms (basically, window) for each display so they are shown at the same time.
    /// </summary>
    public class SCApplicationContext : ApplicationContext
    {
        private void onFormClosed(object sender, EventArgs e)
        {
            // the following check would ensure we only
            // exit the application after the last form has closed
            /*
            if (Application.OpenForms.Count == 0)
            {
                ExitThread();
            }
            */
            // instead, we want to exit after the first one closes.
            // This way the screensavers exit on all displays even with a single keystroke
            ExitThread();
        }

        public SCApplicationContext()
        {
            int numDisplays = Screen.AllScreens.GetUpperBound(0) + 1;

            //If WinForms exposed a global event that fires whenever a new Form is created,
            //we could use that event to register for the form's `FormClosed` event.
            //Without such a global event, we have to register each Form when it is created
            //This means that any forms created outside of the ApplicationContext will not prevent the 
            //application close.

            var forms = new List<Form>();
            for (int i = 0; i < numDisplays; i++)
            {
                forms.Add(new ScreenSaverForm(i));
            }
            foreach (var form in forms)
            {
                form.FormClosed += onFormClosed;
                form.Show();
            }
        }
    }
}
