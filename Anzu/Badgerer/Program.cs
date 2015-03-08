using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Badgerer
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static int Main(string[] args)
        {
            var options = new Options();
            CommandLine.Parser.Default.ParseArgumentsStrict(args, options);

            if (options.DisplayTimeInMs < 0)
            {
                Environment.Exit(1);
            }

            //System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("qps-ploc");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var form = new Form1(options.DisplayTimeInMs);

            if (options.ShowAsNormalWindow || options.DontMaximize)
            {
                form.TopMost = false;
                form.FormBorderStyle = FormBorderStyle.Sizable;
                form.Opacity = 1.0;
            }
            else
            {
                form.TopMost = true;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Opacity = Properties.Settings.Default.Opacity;
            }

            if (options.DontMaximize)
            {
                form.WindowState = FormWindowState.Normal;
                form.AutoSize = true;
            }
            else
            {
                form.WindowState = FormWindowState.Maximized;
            }

            form.BackColor = Properties.Settings.Default.Background;
            form.Text = Properties.Resources.WindowTitle;

            if (!options.DontLock)
            {
                LockWorkStation();
            }

            Application.Run(form);
            return 0;
        }

        [DllImport("user32.dll")]
        public static extern bool LockWorkStation();
    }
}
