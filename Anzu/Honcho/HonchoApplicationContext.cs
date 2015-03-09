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
        private readonly IContainer _components;
        private readonly NotifyIcon _notifyIcon;

        public HonchoApplicationContext()
        {
            _components = new Container();
            _notifyIcon = new NotifyIcon(_components)
            {
                ContextMenuStrip = new ContextMenuStrip(),
                Icon = Properties.Resources.HonchoIcon,
                Text = Properties.Resources.HonchoToolTip,
                Visible = true
            };

            _notifyIcon.MouseUp += NotifyIcon_MouseUp;
            _notifyIcon.ContextMenuStrip.Opening += ContextMenuStrip_Opening;
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
        
        private void NotifyIcon_MouseUp(object sender, MouseEventArgs e)
        {
            // HACK: This will make the menu display on a left click as well as a right
            // click. Using reflection is grody, but it seems to be the easiest way.
            if (e.Button == MouseButtons.Left)
            {
                var showContextMenuMethodInfo = typeof(NotifyIcon).GetMethod("ShowContextMenu", BindingFlags.Instance | BindingFlags.NonPublic);
                showContextMenuMethodInfo.Invoke(_notifyIcon, null);
            }
        }

        private void ContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = false;

            _notifyIcon.ContextMenuStrip.Items.Clear();
            var exitMenuItem = new ToolStripMenuItem(Properties.Resources.ExitMenuName, null, Exit_OnClicked);
            _notifyIcon.ContextMenuStrip.Items.Add(exitMenuItem);
        }

        private void Exit_OnClicked(object sender, EventArgs e)
        {
            ExitThread();
        }
    }
}
