using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private DateTime _lastSpecificUntilDateTime = DateTime.MinValue;

        public BreakForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Debug.Assert(Controls.Count == Controls.OfType<Control>().Count(), "Not everything is a control!");

            _breakDurationLabel.Text = Properties.Resources.BreakDurationLabelText;
            _breakIntervalLabel.Text = Properties.Resources.BreakIntervalLabelText;
            _startingTimeLabel.Text = Properties.Resources.BreakStartLabelText;
            _breakRepeatLabel.Text = Properties.Resources.BreakRepeatLabelText;
            _breakScheduleLabel.Text = Properties.Resources.BreakScheduleLabelText;
            _breakScheduleUntilLabel.Text = Properties.Resources.BreakUntilLabelText;

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

            _breakUntilDropDown.SetComboBoxToEnum<UntilType>(ut => ut.GetFriendlyName(), UntilDropDown_SelectedValueChanged);

            _breakUntilSpecificTimePicker.CustomFormat = _dateTimePickerFormat;
            _breakUntilSpecificTimePicker.ValueChanged += BreakUntilSpecificTimePicker_ValueChanged;
        }

        private void StartingTypeDropDown_SelectedValueChanged(object sender, EventArgs e)
        {
            _startingTimeAfterHourPicker.HideAndDisable();
            _startingSpecificTimePicker.HideAndDisable();
            _flowLayoutPanel.SetFlowBreak(_startingTypeDropDown, false);

            var currentValue = (StartingType)_startingTypeDropDown.SelectedValue;
            switch (currentValue)
            {
                case StartingType.SpecificTime:
                    _startingSpecificTimePicker.ShowAndEnable();
                    _startingSpecificTimePicker.Value = 
                        _lastSpecificStartDateTime.Equals(DateTime.MinValue) ?
                        DateTime.Now :
                        _lastSpecificStartDateTime;
                    break;

                case StartingType.AfterTheHour:
                    _startingTimeAfterHourPicker.ShowAndEnable();
                    break;

                default:
                    _flowLayoutPanel.SetFlowBreak(_startingTypeDropDown, true);
                    break;
            }
        }

        private void RepeatTypeDropDown_SelectedValueChanged(object sender, EventArgs e)
        {
            _repeatSpecificTimePicker.HideAndDisable();
            _repeatCertainDurationPicker.HideAndDisable();
            _repeatSpecificNumberOfTimesPicker.HideAndDisable();
            _flowLayoutPanel.SetFlowBreak(_repeatDurationDropDown, false);

            var currentValue = (RepeatType)_repeatDurationDropDown.SelectedValue;
            switch (currentValue)
            {
                case RepeatType.UntilSpecificTime:
                    _repeatSpecificTimePicker.ShowAndEnable();
                    _repeatSpecificTimePicker.Value =
                        _lastSpecificEndDateTime.Equals(DateTime.MinValue) ?
                        DateTime.Now :
                        _lastSpecificEndDateTime;
                    break;

                case RepeatType.UntilCertainDuration:
                    _repeatCertainDurationPicker.ShowAndEnable();
                    break;

                case RepeatType.CertainNumberOfTimes:
                    _repeatSpecificNumberOfTimesPicker.ShowAndEnable();
                    break;

                default:
                    _flowLayoutPanel.SetFlowBreak(_repeatDurationDropDown, true);
                    break;
            }
        }

        private void ScheduleTypeDropDown_SelectedValueChanged(object sender, EventArgs e)
        {
            HideUntilSection();
            _everyNumberOfDaysPicker.HideAndDisable();
            _checkBoxSunday.HideAndDisable();
            _checkBoxMonday.HideAndDisable();
            _checkBoxTuesday.HideAndDisable();
            _checkBoxWednesday.HideAndDisable();
            _checkBoxThursday.HideAndDisable();
            _checkBoxFriday.HideAndDisable();
            _checkBoxSaturday.HideAndDisable();
            _flowLayoutPanel.SetFlowBreak(_breakScheduleDropDown, true);

            var currentType = (ScheduleType)_breakScheduleDropDown.SelectedValue;
            switch (currentType)
            {
                case ScheduleType.EveryNumberOfDays:
                    _everyNumberOfDaysPicker.ShowAndEnable();
                    _flowLayoutPanel.SetFlowBreak(_breakScheduleDropDown, false);
                    break;
                
                case ScheduleType.OnCertainDaysOfTheWeek:
                    _checkBoxSunday.ShowAndEnable();
                    _checkBoxMonday.ShowAndEnable();
                    _checkBoxTuesday.ShowAndEnable();
                    _checkBoxWednesday.ShowAndEnable();
                    _checkBoxThursday.ShowAndEnable();
                    _checkBoxFriday.ShowAndEnable();
                    _checkBoxSaturday.ShowAndEnable();
                    break;
            }

            // Until section should be shown and enabled after other controls so it
            // appears at the end.
            if (currentType != ScheduleType.Indefinitely)
            {
                ShowUntilSection();
            }
        }

        private void UntilDropDown_SelectedValueChanged(object sender, EventArgs e)
        {
            // Only update the section if it's already visible.
            if (_breakUntilDropDown.Visible)
            {
                ShowUntilSection();
            }
        }

        private void ShowUntilSection()
        {
            _breakScheduleUntilLabel.ShowAndEnable();
            _breakUntilDropDown.ShowAndEnable();

            _breakUntilSpecificTimePicker.HideAndDisable();
            _breakUntilSpecificDurationPicker.HideAndDisable();
            _flowLayoutPanel.SetFlowBreak(_breakUntilDropDown, false);

            var currentType = (UntilType)_breakUntilDropDown.SelectedValue;
            switch (currentType)
            {
                case UntilType.SpecificTime:
                    _breakUntilSpecificTimePicker.ShowAndEnable();
                    _breakUntilSpecificTimePicker.Value = 
                        _lastSpecificUntilDateTime.Equals(DateTime.MinValue) ?
                        DateTime.Now :
                        _lastSpecificUntilDateTime;
                    break;

                case UntilType.SpecificDuration:
                    _breakUntilSpecificDurationPicker.ShowAndEnable();
                    break;

                default:
                    _flowLayoutPanel.SetFlowBreak(_breakUntilDropDown, true);
                    break;
            }
        }

        private void HideUntilSection()
        {
            _breakScheduleUntilLabel.HideAndDisable();
            _breakUntilDropDown.HideAndDisable();
            _breakUntilSpecificTimePicker.HideAndDisable();
            _breakUntilSpecificDurationPicker.HideAndDisable();
        }
        
        private void StartingSpecificTimePicker_ValueChanged(object sender, EventArgs e)
        {
            _lastSpecificStartDateTime = _startingSpecificTimePicker.Value;
        }

        private void RepeatSpecificTimePicker_ValueChanged(object sender, EventArgs e)
        {
            _lastSpecificEndDateTime = _repeatSpecificTimePicker.Value;
        }

        private void BreakUntilSpecificTimePicker_ValueChanged(object sender, EventArgs e)
        {
            _lastSpecificUntilDateTime = _breakUntilSpecificTimePicker.Value;
        }
    }
}
