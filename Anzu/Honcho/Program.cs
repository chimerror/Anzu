using Microsoft.Win32.TaskScheduler;
using System;
using System.Linq;
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

            using (var taskService = new TaskService())
            {
                TaskFolder anzuFolder = taskService.RootFolder.SubFolders.FirstOrDefault(f => f.Name.Equals("Anzu"));
                if (anzuFolder == null)
                {
                    anzuFolder = taskService.RootFolder.CreateFolder("Anzu");
                }

                string currentUser = Environment.UserName;
                TaskFolder userFolder = anzuFolder.SubFolders.FirstOrDefault(f => f.Name.Equals(currentUser));
                if (userFolder == null)
                {
                    userFolder = anzuFolder.CreateFolder(currentUser);
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                var applicationContext = new HonchoApplicationContext(taskService, userFolder);
                Application.Run(applicationContext);
            }
        }
    }
}
