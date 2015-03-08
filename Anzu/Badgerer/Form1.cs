using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Badgerer
{
    public partial class Form1 : Form
    {
        private readonly TimeSpan _countdownInterval;
        private readonly Timer _closeTimer = new Timer();
        private readonly Timer _updateTimer = new Timer();
        private readonly DateTime _startTime; 

        public Form1(int countdownIntervalInMs)
        {
            if (countdownIntervalInMs < 0)
            {
                throw new ArgumentException("countdownIntervalInMs must be non-negative.");
            }

            _countdownInterval = TimeSpan.FromMilliseconds(countdownIntervalInMs);

            InitializeComponent();

            _countdownLabel.Font = Properties.Settings.Default.CountdownFont;

            _closeTimer.Tick += CloseTimer_Tick;
            _closeTimer.Interval = (int)_countdownInterval.TotalMilliseconds;

            _updateTimer.Tick += UpdateTimer_Tick;
            _updateTimer.Interval = Properties.Settings.Default.UpdateInterval;

            _startTime = DateTime.Now;
            _closeTimer.Start();
            _updateTimer.Start();
        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            Close();
        }
        
        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            var timeLeft = _countdownInterval - (DateTime.Now - _startTime); 
            _countdownLabel.Text = 
                String.Format("{0} {1}",
                Properties.Resources.CountdownString,
                timeLeft.TrimMilliseconds().ToString("g"));
        }
    }
}
