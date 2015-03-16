using Microsoft.Win32.TaskScheduler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Honcho
{

    internal class HonchoApplicationContext : ApplicationContext
    {
        private readonly TaskService _taskService;
        private readonly TaskFolder _taskFolder;
        private readonly IContainer _components;
        private readonly NotifyIcon _notifyIcon;
        private BreakForm _createForm;

        public HonchoApplicationContext(TaskService taskService, TaskFolder taskFolder)
        {
            if (taskService == null)
            {
                throw new ArgumentNullException("taskService");
            }
            
            if (taskFolder == null)
            {
                throw new ArgumentNullException("taskFolder");
            }

            _taskService = taskService;
            _taskFolder = taskFolder;

            _components = new Container();
            _notifyIcon = new NotifyIcon(_components)
            {
                ContextMenuStrip = new ContextMenuStrip(),
                Icon = Properties.Resources.HonchoIcon,
                Text = Properties.Resources.HonchoToolTip,
                Visible = true
            };

            _notifyIcon.MouseUp += NotifyIcon_OnMouseUp;
            _notifyIcon.ContextMenuStrip.Opening += ContextMenuStrip_OnOpening;
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (disposing && _components != null)
            {
                _components.Dispose();
            }
        }

        protected override void ExitThreadCore()
        {
            _notifyIcon.Visible = false;
            base.ExitThreadCore();
        }
        
        private void NotifyIcon_OnMouseUp(object sender, MouseEventArgs e)
        {
            // HACK: This will make the menu display on a left click as well as a right
            // click. Using reflection is grody, but it seems to be the easiest way.
            if (e.Button == MouseButtons.Left)
            {
                var showContextMenuMethodInfo = typeof(NotifyIcon).GetMethod("ShowContextMenu", BindingFlags.Instance | BindingFlags.NonPublic);
                showContextMenuMethodInfo.Invoke(_notifyIcon, null);
            }
        }

        private void ContextMenuStrip_OnOpening(object sender, CancelEventArgs e)
        {
            e.Cancel = false;

            _notifyIcon.ContextMenuStrip.Items.Clear();

            _notifyIcon.ContextMenuStrip.Items.Add(Properties.Resources.ScheduleNewBreakMenuName, null, CreateTask_OnClicked);
            _notifyIcon.ContextMenuStrip.Items.Add(new ToolStripSeparator());
            var exitMenuItem = new ToolStripMenuItem(Properties.Resources.ExitMenuName, null, Exit_OnClicked);
            _notifyIcon.ContextMenuStrip.Items.Add(exitMenuItem);
        }

        private void Exit_OnClicked(object sender, EventArgs e)
        {
            ExitThread();
        }

        private void CreateTask_OnClicked(object sender, EventArgs e)
        {
            //var task = _taskService.NewTask();
            //var trigger = new TimeTrigger(DateTime.Now);
            //trigger.Enabled = true;
            //trigger.Repetition.Interval = TimeSpan.FromHours(1);
            //trigger.Repetition.StopAtDurationEnd = false;
            //trigger.ExecutionTimeLimit = TimeSpan.FromMinutes(5);
            //task.Triggers.Add(trigger);

            //task.Actions.Add(new ExecAction("badgerer.exe"));

            //_taskFolder.RegisterTaskDefinition(Guid.NewGuid().ToString(), task);

            if (_createForm == null)
            {
                _createForm = new BreakForm();
                _createForm.FormClosed += CreateForm_OnClosed;
                _createForm.Show();
            }
            else
            {
                _createForm.Activate();
            }
        }

        private void CreateForm_OnClosed(object sender, EventArgs e)
        {
            _createForm = null;
        }
    }
}
