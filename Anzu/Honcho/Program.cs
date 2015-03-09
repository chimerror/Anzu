using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Honcho
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("qps-ploc");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var applicationContext = new HonchoApplicationContext();
            Application.Run(applicationContext);
        }
    }
}
