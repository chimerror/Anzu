﻿using Microsoft.Win32.TaskScheduler;
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

        private readonly TaskService _taskService;
        private readonly TaskFolder _taskFolder;

        public BreakForm(TaskService taskService, TaskFolder taskFolder)
        {
            _taskService = taskService;
            _taskFolder = taskFolder;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _friendlyNameLabel.Text = Properties.Resources.FriendlyNameLabelText;
            _breakDurationLabel.Text = Properties.Resources.BreakDurationLabelText;
            _breakIntervalLabel.Text = Properties.Resources.BreakIntervalLabelText;

            _startingTimeLabel.Text = Properties.Resources.BreakStartLabelText;
            _startingTypeDropDown.SetComboBoxToEnum<StartingType>(
                st => st.GetFriendlyName(),
                StartingTypeDropDown_SelectedValueChanged);

            _startingSpecificTimePicker.CustomFormat = _dateTimePickerFormat;
            _startingSpecificTimePicker.Value = DateTime.Now;

            _breakRepeatLabel.Text = Properties.Resources.BreakRepeatLabelText;
            _repeatDurationDropDown.SetComboBoxToEnum<RepeatType>(
                rt => rt.GetFriendlyName(),
                RepeatTypeDropDown_SelectedValueChanged);

            _repeatSpecificTimePicker.CustomFormat = _dateTimePickerFormat;
            _repeatSpecificTimePicker.Value =
                _startingSpecificTimePicker.Value + _breakIntervalPicker.Value;

            _breakScheduleLabel.Text = Properties.Resources.BreakScheduleLabelText;
            _breakScheduleDropDown.SetComboBoxToEnum<ScheduleType>(
                st => st.GetFriendlyName(),
                ScheduleTypeDropDown_SelectedValueChanged);

            _checkBoxSunday.Text =
                CultureInfo.CurrentUICulture.DateTimeFormat.GetDayName(DayOfWeek.Sunday);
            _checkBoxMonday.Text =
                CultureInfo.CurrentUICulture.DateTimeFormat.GetDayName(DayOfWeek.Monday);
            _checkBoxTuesday.Text =
                CultureInfo.CurrentUICulture.DateTimeFormat.GetDayName(DayOfWeek.Tuesday);
            _checkBoxWednesday.Text =
                CultureInfo.CurrentUICulture.DateTimeFormat.GetDayName(DayOfWeek.Wednesday);
            _checkBoxThursday.Text =
                CultureInfo.CurrentUICulture.DateTimeFormat.GetDayName(DayOfWeek.Thursday);
            _checkBoxFriday.Text =
                CultureInfo.CurrentUICulture.DateTimeFormat.GetDayName(DayOfWeek.Friday);
            _checkBoxSaturday.Text =
                CultureInfo.CurrentUICulture.DateTimeFormat.GetDayName(DayOfWeek.Saturday);

            _breakScheduleUntilLabel.Text = Properties.Resources.BreakUntilLabelText;
            _breakUntilDropDown.SetComboBoxToEnum<UntilType>(
                ut => ut.GetFriendlyName(),
                UntilDropDown_SelectedValueChanged);

            _breakUntilSpecificTimePicker.CustomFormat = _dateTimePickerFormat;
            _breakUntilSpecificTimePicker.Value =
                _startingSpecificTimePicker.Value + _breakIntervalPicker.Value;

            _badgererOptionsGroupBox.Text = Properties.Resources.BadgererDisplayOptionsGroupBoxText;

            _lockScreenCheckBox.Text = Properties.Resources.LockScreenCheckboxText;

            _badgererDisplayLabel.Text = Properties.Resources.BadgererWindowDisplayLabel;
            _badgererDisplayDropDown.SetComboBoxToEnum<BadgererWindowType>(
                bwt => bwt.GetFriendlyName(),
                null);

            _okButton.Text = Properties.Resources.OkButtonText;
            _okButton.Click += OkButton_Click;
            _cancelButton.Text = Properties.Resources.CancelButtonText;
            _cancelButton.Click += CancelButton_Click;
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

        private void OkButton_Click(object sender, EventArgs e)
        {
            // Daily/Every number of days -> Daily
            // Weekly -> Weekly
            // Otherwise -> Time
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
