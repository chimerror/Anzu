using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Honcho
{
    public partial class BreakForm : Form
    {
        private const int ComboBoxPadding = 25;
        private DateTime _lastSpecificStartDateTime = DateTime.MinValue;

        public BreakForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _startingTypeDropDown.DataSource = Enum.GetValues(typeof(StartingType))
                .Cast<StartingType>()
                .Select(st => new KeyValuePair<string, int>(st.GetFriendlyName(), (int)st))
                .ToList();
            _startingTypeDropDown.ValueMember = "Value";
            _startingTypeDropDown.DisplayMember = "Key";
            _startingTypeDropDown.Width = ComboBoxPadding + _startingTypeDropDown.Items
                .Cast<KeyValuePair<string, int>>()
                .Max(kvp => TextRenderer.MeasureText(kvp.Key, _startingTypeDropDown.Font).Width);
            _startingTypeDropDown.SelectedValueChanged += StartingTypeDropDown_SelectedValueChanged;
            StartingTypeDropDown_SelectedValueChanged(null, null); // Force an update.

            _startingSpecificTimePicker.CustomFormat =
                CultureInfo.CurrentUICulture.DateTimeFormat.ShortDatePattern +
                " " +
                CultureInfo.CurrentUICulture.DateTimeFormat.ShortTimePattern;
            _startingSpecificTimePicker.ValueChanged += StartingSpecificTimePicker_ValueChanged;
        }

        private void StartingTypeDropDown_SelectedValueChanged(object sender, EventArgs e)
        {
            StartingType currentValue = (StartingType)_startingTypeDropDown.SelectedValue;
            switch (currentValue)
            {
                case StartingType.SpecificTime:
                    _startingTimeAfterHourPicker.Enabled = false;
                    _startingTimeAfterHourPicker.Visible = false;
                    _startingSpecificTimePicker.Enabled = true;
                    _startingSpecificTimePicker.Visible = true;
                    _startingSpecificTimePicker.Value = 
                        _lastSpecificStartDateTime.Equals(DateTime.MinValue) ?
                        DateTime.Now :
                        _lastSpecificStartDateTime;
                    flowLayoutPanel1.SetFlowBreak(_startingTypeDropDown, false);
                    break;
                case StartingType.AfterTheHour:
                    _startingSpecificTimePicker.Enabled = false;
                    _startingSpecificTimePicker.Visible = false;
                    _startingTimeAfterHourPicker.Enabled = true;
                    _startingTimeAfterHourPicker.Visible = true;
                    flowLayoutPanel1.SetFlowBreak(_startingTypeDropDown, false);
                    break;
                default:
                    _startingTimeAfterHourPicker.Enabled = false;
                    _startingTimeAfterHourPicker.Visible = false;
                    _startingSpecificTimePicker.Enabled = false;
                    _startingSpecificTimePicker.Visible = false;
                    flowLayoutPanel1.SetFlowBreak(_startingTypeDropDown, true);
                    break;
            }
        }
        
        private void StartingSpecificTimePicker_ValueChanged(object sender, EventArgs e)
        {
            _lastSpecificStartDateTime = _startingSpecificTimePicker.Value;
        }
    }
}
