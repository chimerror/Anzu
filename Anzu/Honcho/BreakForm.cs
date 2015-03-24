using Microsoft.Win32.TaskScheduler;
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
            _friendlyNameLabel.SetMinimumWidth();

            _breakOptionsGroupBox.Text = Properties.Resources.BreakOptionsGroupBoxText;
            _breakDurationLabel.Text = Properties.Resources.BreakDurationLabelText;
            _breakDurationLabel.SetMinimumWidth();
            _breakIntervalLabel.Text = Properties.Resources.BreakIntervalLabelText;
            _breakIntervalLabel.SetMinimumWidth();

            _badgererOptionsGroupBox.Text = Properties.Resources.BadgererDisplayOptionsGroupBoxText;

            _lockScreenCheckBox.Text = Properties.Resources.LockScreenCheckboxText;

            _badgererDisplayLabel.Text = Properties.Resources.BadgererWindowDisplayLabel;
            _badgererDisplayDropDown.SetComboBoxToEnum<BadgererWindowType>(
                bwt => bwt.GetFriendlyName(),
                null);

            _scheduleOptionsGroupBox.Text = Properties.Resources.ScheduleOptionsGroupBoxText;
            _startingTimeLabel.Text = Properties.Resources.BreakStartLabelText;
            _startingTimeLabel.SetMinimumWidth();
            _startingTypeDropDown.SetComboBoxToEnum<StartingType>(
                st => st.GetFriendlyName(),
                StartingTypeDropDown_SelectedValueChanged);

            _startingSpecificTimePicker.CustomFormat = _dateTimePickerFormat;
            _startingSpecificTimePicker.Value = DateTime.Now;

            _breakRepeatLabel.Text = Properties.Resources.BreakRepeatLabelText;
            _breakRepeatLabel.SetMinimumWidth();
            _repeatDurationDropDown.SetComboBoxToEnum<RepeatType>(
                rt => rt.GetFriendlyName(),
                RepeatTypeDropDown_SelectedValueChanged);

            _repeatSpecificTimePicker.CustomFormat = _dateTimePickerFormat;
            _repeatSpecificTimePicker.Value =
                _startingSpecificTimePicker.Value + _breakIntervalPicker.Value;

            _breakScheduleLabel.Text = Properties.Resources.BreakScheduleLabelText;
            _breakScheduleLabel.SetMinimumWidth();
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
            _breakScheduleUntilLabel.SetMinimumWidth();
            _breakUntilDropDown.SetComboBoxToEnum<UntilType>(
                ut => ut.GetFriendlyName(),
                UntilDropDown_SelectedValueChanged);

            _breakUntilSpecificTimePicker.CustomFormat = _dateTimePickerFormat;
            _breakUntilSpecificTimePicker.Value =
                _startingSpecificTimePicker.Value + _breakIntervalPicker.Value;

            _okButton.Text = Properties.Resources.OkButtonText;
            _okButton.Click += OkButton_Click;
            _cancelButton.Text = Properties.Resources.CancelButtonText;
            _cancelButton.Click += CancelButton_Click;
        }

        private void StartingTypeDropDown_SelectedValueChanged(object sender, EventArgs e)
        {
            _startingTimeAfterHourPicker.HideAndDisable();
            _startingSpecificTimePicker.HideAndDisable();

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
                    break;
            }
        }

        private void RepeatTypeDropDown_SelectedValueChanged(object sender, EventArgs e)
        {
            _repeatSpecificTimePicker.HideAndDisable();
            _repeatCertainDurationPicker.HideAndDisable();
            _repeatSpecificNumberOfTimesPicker.HideAndDisable();
            HideScheduleSection();
            HideUntilSection();

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
                    break;
            }

            if (currentValue != RepeatType.Indefinitely)
            {
                ShowScheduleSection();
                ShowUntilSection();
            }
        }

        private void ScheduleTypeDropDown_SelectedValueChanged(object sender, EventArgs e)
        {
            // Only update the section if it's already visible.
            if (_breakScheduleDropDown.Visible)
            {
                ShowScheduleSection();
            }
        }

        private void ShowScheduleSection()
        {
            _breakScheduleLabel.ShowAndEnable();
            _breakScheduleDropDown.ShowAndEnable();

            _everyNumberOfDaysPicker.HideAndDisable();
            _checkBoxSunday.HideAndDisable();
            _checkBoxMonday.HideAndDisable();
            _checkBoxTuesday.HideAndDisable();
            _checkBoxWednesday.HideAndDisable();
            _checkBoxThursday.HideAndDisable();
            _checkBoxFriday.HideAndDisable();
            _checkBoxSaturday.HideAndDisable();

            var currentType = (ScheduleType)_breakScheduleDropDown.SelectedValue;
            switch (currentType)
            {
                case ScheduleType.EveryNumberOfDays:
                    _everyNumberOfDaysPicker.ShowAndEnable();
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
        }

        private void HideScheduleSection()
        {
            _breakScheduleLabel.HideAndDisable();
            _breakScheduleDropDown.HideAndDisable();
            _everyNumberOfDaysPicker.HideAndDisable();
            _checkBoxSunday.HideAndDisable();
            _checkBoxMonday.HideAndDisable();
            _checkBoxTuesday.HideAndDisable();
            _checkBoxWednesday.HideAndDisable();
            _checkBoxThursday.HideAndDisable();
            _checkBoxFriday.HideAndDisable();
            _checkBoxSaturday.HideAndDisable();
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
            Trigger taskTrigger;
            RepeatType repeatType = (RepeatType)_repeatDurationDropDown.SelectedValue;
            ScheduleType scheduleType = (ScheduleType)_breakScheduleDropDown.SelectedValue;
            if (repeatType == RepeatType.Indefinitely)
            {
                taskTrigger = new TimeTrigger();
            }
            else if (scheduleType == ScheduleType.Daily)
            {
                taskTrigger = new DailyTrigger(1);
            }
            else if (scheduleType == ScheduleType.EveryNumberOfDays)
            {
                short interval = Convert.ToInt16(_everyNumberOfDaysPicker.Value);
                taskTrigger = new DailyTrigger(interval);
            }
            else if (scheduleType == ScheduleType.OnCertainDaysOfTheWeek)
            {
                taskTrigger = new WeeklyTrigger(GetSelectedDaysOfTheWeek(), 1);
            }
            else
            {
                Debug.Fail("Somehow ended up in unknown repeat-schedule set up. Setting trigger to time trigger");
                taskTrigger = new TimeTrigger();
            }

            taskTrigger.Enabled = true;

            StartingType startingType = (StartingType)_startingTypeDropDown.SelectedValue;
            DateTime now = DateTime.Now;
            int desiredStartingMinute = Convert.ToInt32(_startingTimeAfterHourPicker.Value);
            switch (startingType)
            {
                case StartingType.SpecificTime:
                    taskTrigger.StartBoundary = _startingSpecificTimePicker.Value;
                    break;

                case StartingType.AfterTheHour:
                    int difference = desiredStartingMinute - now.Minute;
                    if (difference < 0)
                    {
                        difference = 60 + difference;
                    }
                    taskTrigger.StartBoundary = now.AddMinutes(difference);
                    break;

                case StartingType.Now:
                    taskTrigger.StartBoundary = now;
                    break;

                default:
                    Debug.Fail("Somehow ended up in unknown starting setup. Setting start to now.");
                    taskTrigger.StartBoundary = now;
                    break;
            }

            UntilType untilType = (UntilType)_breakUntilDropDown.SelectedValue;
            DateTime endTime = DateTime.MaxValue;
            if (repeatType != RepeatType.Indefinitely && untilType != UntilType.Idefinitely)
            {
                switch (untilType)
                {
                    case UntilType.SpecificTime:
                        endTime = _breakUntilSpecificTimePicker.Value;
                        break;

                    case UntilType.SpecificDuration:
                        endTime = taskTrigger.StartBoundary.Add(_breakUntilSpecificDurationPicker.Value);
                        break;

                    default:
                        Debug.Fail("Somehow ended up in unknown ending setup. Setting end to max value");
                        endTime = DateTime.MaxValue;
                        break;
                }
            }

            if (endTime < taskTrigger.StartBoundary)
            {
                MessageBox.Show(Properties.Resources.EndTimeErrorMessage, Properties.Resources.EndTimeErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (endTime != DateTime.MaxValue)
            {
                taskTrigger.EndBoundary = endTime;
            }

            TimeSpan breakDuration = _breakDurationPicker.Value;
            taskTrigger.ExecutionTimeLimit = breakDuration;

            TimeSpan breakInterval = _breakIntervalPicker.Value;
            if (breakInterval < breakDuration)
            {
                MessageBox.Show(Properties.Resources.BreakDurationErrorMessage, Properties.Resources.BreakDurationErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TimeSpan repeatDuration = TimeSpan.Zero;
            DateTime specificRepeatEndTime = _repeatSpecificTimePicker.Value;
            if (repeatType == RepeatType.UntilSpecificTime && taskTrigger.StartBoundary >= specificRepeatEndTime)
            {
                MessageBox.Show(Properties.Resources.RepeatEndTimeErrorMessage, Properties.Resources.RepeatEndTimeErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (repeatType)
            {
                case RepeatType.Indefinitely:
                    repeatDuration = TimeSpan.Zero;
                    break;

                case RepeatType.UntilSpecificTime:
                    repeatDuration = specificRepeatEndTime - taskTrigger.StartBoundary;
                    break;

                case RepeatType.UntilCertainDuration:
                    repeatDuration = _repeatCertainDurationPicker.Value;
                    break;

                case RepeatType.Once:
                    repeatDuration = breakInterval;
                    break;

                case RepeatType.CertainNumberOfTimes:
                    int numberOfTimes = Convert.ToInt32(_repeatSpecificNumberOfTimesPicker.Value);
                    repeatDuration = new TimeSpan(breakInterval.Ticks * numberOfTimes);
                    break;

                default:
                    Debug.Fail("Somehow ended up in unknown repeat type. Setting repetition to indefinitely.");
                    repeatDuration = TimeSpan.Zero;
                    break;
            }

            if (repeatDuration != TimeSpan.Zero && repeatDuration < breakInterval)
            {
                MessageBox.Show(Properties.Resources.RepeatDurationErrorMessage, Properties.Resources.RepeatDurationErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            taskTrigger.SetRepetition(breakInterval, repeatDuration, false);

            var task = _taskService.NewTask();
            task.Triggers.Add(taskTrigger);

            task.Actions.Add(new ExecAction("badgerer.exe"));

            string friendlyName = string.IsNullOrWhiteSpace(_friendlyNameTextBox.Text) ? null : _friendlyNameTextBox.Text;
            var anzuTaskData = new AnzuTaskData(friendlyName);
            task.Data = anzuTaskData.Serialize();

            task.Settings.Enabled = true;
            task.Settings.ExecutionTimeLimit = breakDuration;
            task.Settings.StopIfGoingOnBatteries = false;
            task.Settings.WakeToRun = false;
            task.Settings.MultipleInstances = TaskInstancesPolicy.IgnoreNew;
            task.Principal.LogonType = TaskLogonType.InteractiveToken;

            _taskFolder.RegisterTaskDefinition(Guid.NewGuid().ToString(), task, TaskCreation.Create, Environment.UserName);

            Close();
        }

        private DaysOfTheWeek GetSelectedDaysOfTheWeek()
        {
            DaysOfTheWeek result = (DaysOfTheWeek)0;

            if (_checkBoxSunday.Checked)
            {
                result |= DayOfWeek.Sunday.ToTaskSchedulerDay();
            }

            if (_checkBoxMonday.Checked)
            {
                result |= DayOfWeek.Monday.ToTaskSchedulerDay();
            }

            if (_checkBoxTuesday.Checked)
            {
                result |= DayOfWeek.Tuesday.ToTaskSchedulerDay();
            }

            if (_checkBoxWednesday.Checked)
            {
                result |= DayOfWeek.Wednesday.ToTaskSchedulerDay();
            }

            if (_checkBoxThursday.Checked)
            {
                result |= DayOfWeek.Thursday.ToTaskSchedulerDay();
            }

            if (_checkBoxFriday.Checked)
            {
                result |= DayOfWeek.Friday.ToTaskSchedulerDay();
            }

            if (_checkBoxSaturday.Checked)
            {
                result |= DayOfWeek.Saturday.ToTaskSchedulerDay();
            }

            return result;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
