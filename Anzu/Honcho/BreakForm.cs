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
        private static readonly string _dateTimePickerFormat =
            CultureInfo.CurrentUICulture.DateTimeFormat.ShortDatePattern +
            " " +
            CultureInfo.CurrentUICulture.DateTimeFormat.ShortTimePattern;
        private DateTime _lastSpecificStartDateTime = DateTime.MinValue;
        private DateTime _lastSpecificEndDateTime = DateTime.MinValue;

        public BreakForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _breakDurationLabel.Text = Properties.Resources.BreakDurationLabelText;
            _breakIntervalLabel.Text = Properties.Resources.BreakIntervalLabelText;
            _startingTimeLabel.Text = Properties.Resources.BreakStartLabelText;
            _breakRepeatLabel.Text = Properties.Resources.BreakRepeatLabelText;
            _breakScheduleLabel.Text = Properties.Resources.BreakScheduleLabelText;

            _startingTimeLabel.Text = Properties.Resources.BreakStartLabelText;
            _startingTypeDropDown.SetComboBoxToEnum<StartingType>(st => st.GetFriendlyName(), StartingTypeDropDown_SelectedValueChanged);

            _startingSpecificTimePicker.CustomFormat = _dateTimePickerFormat;
            _startingSpecificTimePicker.ValueChanged += StartingSpecificTimePicker_ValueChanged;

            _repeatDurationDropDown.SetComboBoxToEnum<RepeatType>(rt => rt.GetFriendlyName(), RepeatTypeDropDown_SelectedValueChanged);

            _repeatSpecificTimePicker.CustomFormat = _dateTimePickerFormat;
            _repeatSpecificTimePicker.ValueChanged += RepeatSpecificTimePicker_ValueChanged;

            _breakScheduleDropDown.SetComboBoxToEnum<ScheduleType>(st => st.GetFriendlyName(), ScheduleTypeDropDown_SelectedValueChanged);

            _checkBoxSunday.Text = CultureInfo.CurrentUICulture.DateTimeFormat.GetDayName(DayOfWeek.Sunday);
            _checkBoxMonday.Text = CultureInfo.CurrentUICulture.DateTimeFormat.GetDayName(DayOfWeek.Monday);
            _checkBoxTuesday.Text = CultureInfo.CurrentUICulture.DateTimeFormat.GetDayName(DayOfWeek.Tuesday);
            _checkBoxWednesday.Text = CultureInfo.CurrentUICulture.DateTimeFormat.GetDayName(DayOfWeek.Wednesday);
            _checkBoxThursday.Text = CultureInfo.CurrentUICulture.DateTimeFormat.GetDayName(DayOfWeek.Thursday);
            _checkBoxFriday.Text = CultureInfo.CurrentUICulture.DateTimeFormat.GetDayName(DayOfWeek.Friday);
            _checkBoxSaturday.Text = CultureInfo.CurrentUICulture.DateTimeFormat.GetDayName(DayOfWeek.Saturday);
        }

        private void StartingTypeDropDown_SelectedValueChanged(object sender, EventArgs e)
        {
            var currentValue = (StartingType)_startingTypeDropDown.SelectedValue;
            switch (currentValue)
            {
                case StartingType.SpecificTime:
                    _startingTimeAfterHourPicker.Enabled = false;
                    _startingTimeAfterHourPicker.Visible = false;
                    _startingSpecificTimePicker.Enabled = true;
                    _startingSpecificTimePicker.Visible = true;
                    _flowLayoutPanel.SetFlowBreak(_startingTypeDropDown, false);

                    _startingSpecificTimePicker.Value = 
                        _lastSpecificStartDateTime.Equals(DateTime.MinValue) ?
                        DateTime.Now :
                        _lastSpecificStartDateTime;
                    break;

                case StartingType.AfterTheHour:
                    _startingSpecificTimePicker.Enabled = false;
                    _startingSpecificTimePicker.Visible = false;
                    _startingTimeAfterHourPicker.Enabled = true;
                    _startingTimeAfterHourPicker.Visible = true;
                    _flowLayoutPanel.SetFlowBreak(_startingTypeDropDown, false);
                    break;

                default:
                    _startingTimeAfterHourPicker.Enabled = false;
                    _startingTimeAfterHourPicker.Visible = false;
                    _startingSpecificTimePicker.Enabled = false;
                    _startingSpecificTimePicker.Visible = false;
                    _flowLayoutPanel.SetFlowBreak(_startingTypeDropDown, true);
                    break;
            }
        }

        private void RepeatTypeDropDown_SelectedValueChanged(object sender, EventArgs e)
        {
            var currentValue = (RepeatType)_repeatDurationDropDown.SelectedValue;
            switch (currentValue)
            {
                case RepeatType.UntilSpecificTime:
                    _repeatSpecificTimePicker.Enabled = true;
                    _repeatSpecificTimePicker.Visible = true;
                    _repeatCertainDurationPicker.Enabled = false;
                    _repeatCertainDurationPicker.Visible = false;
                    _repeatSpecificNumberOfTimesPicker.Enabled = false;
                    _repeatSpecificNumberOfTimesPicker.Visible = false;
                    _flowLayoutPanel.SetFlowBreak(_repeatDurationDropDown, false);

                    _repeatSpecificTimePicker.Value =
                        _lastSpecificEndDateTime.Equals(DateTime.MinValue) ?
                        DateTime.Now :
                        _lastSpecificEndDateTime;
                    break;

                case RepeatType.UntilCertainDuration:
                    _repeatSpecificTimePicker.Enabled = false;
                    _repeatSpecificTimePicker.Visible = false;
                    _repeatCertainDurationPicker.Enabled = true;
                    _repeatCertainDurationPicker.Visible = true;
                    _repeatSpecificNumberOfTimesPicker.Enabled = false;
                    _repeatSpecificNumberOfTimesPicker.Visible = false;
                    _flowLayoutPanel.SetFlowBreak(_repeatDurationDropDown, false);
                    break;

                case RepeatType.CertainNumberOfTimes:
                    _repeatSpecificTimePicker.Enabled = false;
                    _repeatSpecificTimePicker.Visible = false;
                    _repeatCertainDurationPicker.Enabled = false;
                    _repeatCertainDurationPicker.Visible = false;
                    _repeatSpecificNumberOfTimesPicker.Enabled = true;
                    _repeatSpecificNumberOfTimesPicker.Visible = true;
                    _flowLayoutPanel.SetFlowBreak(_repeatDurationDropDown, false);
                    break;

                default:
                    _repeatSpecificTimePicker.Enabled = false;
                    _repeatSpecificTimePicker.Visible = false;
                    _repeatCertainDurationPicker.Enabled = false;
                    _repeatCertainDurationPicker.Visible = false;
                    _repeatSpecificNumberOfTimesPicker.Enabled = false;
                    _repeatSpecificNumberOfTimesPicker.Visible = false;
                    _flowLayoutPanel.SetFlowBreak(_repeatDurationDropDown, true);
                    break;
            }
        }

        private void ScheduleTypeDropDown_SelectedValueChanged(object sender, EventArgs e)
        {
            var currentType = (ScheduleType)_breakScheduleDropDown.SelectedValue;
            switch (currentType)
            {
                case ScheduleType.EveryNumberOfDays:
                    _everyNumberOfDaysPicker.Enabled = true;
                    _everyNumberOfDaysPicker.Visible = true;
                    _checkBoxSunday.Enabled = false;
                    _checkBoxMonday.Enabled = false;
                    _checkBoxTuesday.Enabled = false;
                    _checkBoxWednesday.Enabled = false;
                    _checkBoxThursday.Enabled = false;
                    _checkBoxFriday.Enabled = false;
                    _checkBoxSaturday.Enabled = false;
                    _checkBoxSunday.Visible = false;
                    _checkBoxMonday.Visible = false;
                    _checkBoxTuesday.Visible = false;
                    _checkBoxWednesday.Visible = false;
                    _checkBoxThursday.Visible = false;
                    _checkBoxFriday.Visible = false;
                    _checkBoxSaturday.Visible = false;
                    _flowLayoutPanel.SetFlowBreak(_breakScheduleDropDown, false);
                    break;
                
                case ScheduleType.OnCertainDaysOfTheWeek:
                    _everyNumberOfDaysPicker.Enabled = false;
                    _everyNumberOfDaysPicker.Visible = false;
                    _checkBoxSunday.Enabled = true;
                    _checkBoxMonday.Enabled = true;
                    _checkBoxTuesday.Enabled = true;
                    _checkBoxWednesday.Enabled = true;
                    _checkBoxThursday.Enabled = true;
                    _checkBoxFriday.Enabled = true;
                    _checkBoxSaturday.Enabled = true;
                    _checkBoxSunday.Visible = true;
                    _checkBoxMonday.Visible = true;
                    _checkBoxTuesday.Visible = true;
                    _checkBoxWednesday.Visible = true;
                    _checkBoxThursday.Visible = true;
                    _checkBoxFriday.Visible = true;
                    _checkBoxSaturday.Visible = true;
                    _flowLayoutPanel.SetFlowBreak(_breakScheduleDropDown, true);
                    break;

                default:
                    _everyNumberOfDaysPicker.Enabled = false;
                    _everyNumberOfDaysPicker.Visible = false;
                    _checkBoxSunday.Enabled = false;
                    _checkBoxMonday.Enabled = false;
                    _checkBoxTuesday.Enabled = false;
                    _checkBoxWednesday.Enabled = false;
                    _checkBoxThursday.Enabled = false;
                    _checkBoxFriday.Enabled = false;
                    _checkBoxSaturday.Enabled = false;
                    _checkBoxSunday.Visible = false;
                    _checkBoxMonday.Visible = false;
                    _checkBoxTuesday.Visible = false;
                    _checkBoxWednesday.Visible = false;
                    _checkBoxThursday.Visible = false;
                    _checkBoxFriday.Visible = false;
                    _checkBoxSaturday.Visible = false;
                    _flowLayoutPanel.SetFlowBreak(_breakScheduleDropDown, true);
                    break;
            }
        }
        
        private void StartingSpecificTimePicker_ValueChanged(object sender, EventArgs e)
        {
            _lastSpecificStartDateTime = _startingSpecificTimePicker.Value;
        }

        private void RepeatSpecificTimePicker_ValueChanged(object sender, EventArgs e)
        {
            _lastSpecificEndDateTime = _repeatSpecificTimePicker.Value;
        }
    }
}
