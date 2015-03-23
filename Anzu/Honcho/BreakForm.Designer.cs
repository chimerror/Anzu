namespace Honcho
{
    partial class BreakForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BreakForm));
            this._friendlyNameLabel = new System.Windows.Forms.Label();
            this._friendlyNameTextBox = new System.Windows.Forms.TextBox();
            this._breakDurationLabel = new System.Windows.Forms.Label();
            this._breakDurationPicker = new System.Windows.Forms.TimeSpanPicker();
            this._breakIntervalLabel = new System.Windows.Forms.Label();
            this._breakIntervalPicker = new System.Windows.Forms.TimeSpanPicker();
            this._startingTimeLabel = new System.Windows.Forms.Label();
            this._startingTypeDropDown = new System.Windows.Forms.ComboBox();
            this._startingTimeAfterHourPicker = new System.Windows.Forms.NumericUpDown();
            this._startingSpecificTimePicker = new System.Windows.Forms.DateTimePicker();
            this._breakRepeatLabel = new System.Windows.Forms.Label();
            this._repeatDurationDropDown = new System.Windows.Forms.ComboBox();
            this._repeatSpecificTimePicker = new System.Windows.Forms.DateTimePicker();
            this._repeatCertainDurationPicker = new System.Windows.Forms.TimeSpanPicker();
            this._repeatSpecificNumberOfTimesPicker = new System.Windows.Forms.NumericUpDown();
            this._breakScheduleLabel = new System.Windows.Forms.Label();
            this._breakScheduleDropDown = new System.Windows.Forms.ComboBox();
            this._everyNumberOfDaysPicker = new System.Windows.Forms.NumericUpDown();
            this._checkBoxSunday = new System.Windows.Forms.CheckBox();
            this._checkBoxMonday = new System.Windows.Forms.CheckBox();
            this._checkBoxTuesday = new System.Windows.Forms.CheckBox();
            this._checkBoxWednesday = new System.Windows.Forms.CheckBox();
            this._checkBoxThursday = new System.Windows.Forms.CheckBox();
            this._checkBoxFriday = new System.Windows.Forms.CheckBox();
            this._checkBoxSaturday = new System.Windows.Forms.CheckBox();
            this._breakScheduleUntilLabel = new System.Windows.Forms.Label();
            this._breakUntilDropDown = new System.Windows.Forms.ComboBox();
            this._breakUntilSpecificTimePicker = new System.Windows.Forms.DateTimePicker();
            this._breakUntilSpecificDurationPicker = new System.Windows.Forms.TimeSpanPicker();
            this._badgererOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this._lockScreenCheckBox = new System.Windows.Forms.CheckBox();
            this._badgererDisplayLabel = new System.Windows.Forms.Label();
            this._badgererDisplayDropDown = new System.Windows.Forms.ComboBox();
            this._cancelButton = new System.Windows.Forms.Button();
            this._okButton = new System.Windows.Forms.Button();
            this._overarchingTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this._breakOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this._breakOptionsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._badgererOptionsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._scheduleOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this._scheduleOptionsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._startingTimePanel = new System.Windows.Forms.Panel();
            this._breakRepeatPanel = new System.Windows.Forms.Panel();
            this._breakSchedulePanel = new System.Windows.Forms.Panel();
            this._weekdaysFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this._untilPanel = new System.Windows.Forms.Panel();
            this._buttonsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this._startingTimeAfterHourPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._repeatSpecificNumberOfTimesPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._everyNumberOfDaysPicker)).BeginInit();
            this._badgererOptionsGroupBox.SuspendLayout();
            this._overarchingTableLayout.SuspendLayout();
            this._breakOptionsGroupBox.SuspendLayout();
            this._breakOptionsTableLayoutPanel.SuspendLayout();
            this._badgererOptionsTableLayoutPanel.SuspendLayout();
            this._scheduleOptionsGroupBox.SuspendLayout();
            this._scheduleOptionsTableLayoutPanel.SuspendLayout();
            this._startingTimePanel.SuspendLayout();
            this._breakRepeatPanel.SuspendLayout();
            this._breakSchedulePanel.SuspendLayout();
            this._weekdaysFlowLayoutPanel.SuspendLayout();
            this._untilPanel.SuspendLayout();
            this._buttonsFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _friendlyNameLabel
            // 
            resources.ApplyResources(this._friendlyNameLabel, "_friendlyNameLabel");
            this._friendlyNameLabel.Name = "_friendlyNameLabel";
            // 
            // _friendlyNameTextBox
            // 
            resources.ApplyResources(this._friendlyNameTextBox, "_friendlyNameTextBox");
            this._friendlyNameTextBox.Name = "_friendlyNameTextBox";
            // 
            // _breakDurationLabel
            // 
            resources.ApplyResources(this._breakDurationLabel, "_breakDurationLabel");
            this._breakDurationLabel.Name = "_breakDurationLabel";
            // 
            // _breakDurationPicker
            // 
            resources.ApplyResources(this._breakDurationPicker, "_breakDurationPicker");
            this._breakDurationPicker.Items.AddRange(new System.TimeSpan2[] {
            new System.TimeSpan2(0, 0, 5, 0),
            new System.TimeSpan2(0, 0, 10, 0),
            new System.TimeSpan2(0, 0, 15, 0),
            new System.TimeSpan2(0, 0, 30, 0),
            new System.TimeSpan2(0, 1, 0, 0)});
            this._breakDurationPicker.Name = "_breakDurationPicker";
            this._breakDurationPicker.Value = new System.TimeSpan2(0, 0, 5, 0);
            // 
            // _breakIntervalLabel
            // 
            resources.ApplyResources(this._breakIntervalLabel, "_breakIntervalLabel");
            this._breakIntervalLabel.Name = "_breakIntervalLabel";
            // 
            // _breakIntervalPicker
            // 
            resources.ApplyResources(this._breakIntervalPicker, "_breakIntervalPicker");
            this._breakIntervalPicker.Items.AddRange(new System.TimeSpan2[] {
            new System.TimeSpan2(0, 1, 0, 0),
            new System.TimeSpan2(0, 0, 30, 0),
            new System.TimeSpan2(0, 2, 0, 0),
            new System.TimeSpan2(0, 3, 0, 0),
            new System.TimeSpan2(0, 4, 0, 0)});
            this._breakIntervalPicker.Name = "_breakIntervalPicker";
            this._breakIntervalPicker.Value = new System.TimeSpan2(0, 1, 0, 0);
            // 
            // _startingTimeLabel
            // 
            resources.ApplyResources(this._startingTimeLabel, "_startingTimeLabel");
            this._startingTimeLabel.Name = "_startingTimeLabel";
            // 
            // _startingTypeDropDown
            // 
            resources.ApplyResources(this._startingTypeDropDown, "_startingTypeDropDown");
            this._startingTypeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._startingTypeDropDown.FormattingEnabled = true;
            this._startingTypeDropDown.Name = "_startingTypeDropDown";
            // 
            // _startingTimeAfterHourPicker
            // 
            resources.ApplyResources(this._startingTimeAfterHourPicker, "_startingTimeAfterHourPicker");
            this._startingTimeAfterHourPicker.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this._startingTimeAfterHourPicker.Name = "_startingTimeAfterHourPicker";
            this._startingTimeAfterHourPicker.Value = new decimal(new int[] {
            55,
            0,
            0,
            0});
            // 
            // _startingSpecificTimePicker
            // 
            resources.ApplyResources(this._startingSpecificTimePicker, "_startingSpecificTimePicker");
            this._startingSpecificTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._startingSpecificTimePicker.Name = "_startingSpecificTimePicker";
            this._startingSpecificTimePicker.ShowUpDown = true;
            // 
            // _breakRepeatLabel
            // 
            resources.ApplyResources(this._breakRepeatLabel, "_breakRepeatLabel");
            this._breakRepeatLabel.Name = "_breakRepeatLabel";
            // 
            // _repeatDurationDropDown
            // 
            resources.ApplyResources(this._repeatDurationDropDown, "_repeatDurationDropDown");
            this._repeatDurationDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._repeatDurationDropDown.FormattingEnabled = true;
            this._repeatDurationDropDown.Name = "_repeatDurationDropDown";
            // 
            // _repeatSpecificTimePicker
            // 
            resources.ApplyResources(this._repeatSpecificTimePicker, "_repeatSpecificTimePicker");
            this._repeatSpecificTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._repeatSpecificTimePicker.Name = "_repeatSpecificTimePicker";
            this._repeatSpecificTimePicker.ShowUpDown = true;
            // 
            // _repeatCertainDurationPicker
            // 
            resources.ApplyResources(this._repeatCertainDurationPicker, "_repeatCertainDurationPicker");
            this._repeatCertainDurationPicker.Items.AddRange(new System.TimeSpan2[] {
            new System.TimeSpan2(2, 0, 0, 0),
            new System.TimeSpan2(3, 0, 0, 0),
            new System.TimeSpan2(7, 0, 0, 0),
            new System.TimeSpan2(0, 4, 0, 0),
            new System.TimeSpan2(0, 6, 0, 0),
            new System.TimeSpan2(0, 8, 0, 0),
            new System.TimeSpan2(0, 12, 0, 0)});
            this._repeatCertainDurationPicker.Name = "_repeatCertainDurationPicker";
            this._repeatCertainDurationPicker.Value = new System.TimeSpan2(1, 0, 0, 0);
            // 
            // _repeatSpecificNumberOfTimesPicker
            // 
            resources.ApplyResources(this._repeatSpecificNumberOfTimesPicker, "_repeatSpecificNumberOfTimesPicker");
            this._repeatSpecificNumberOfTimesPicker.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._repeatSpecificNumberOfTimesPicker.Name = "_repeatSpecificNumberOfTimesPicker";
            this._repeatSpecificNumberOfTimesPicker.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // _breakScheduleLabel
            // 
            resources.ApplyResources(this._breakScheduleLabel, "_breakScheduleLabel");
            this._breakScheduleLabel.Name = "_breakScheduleLabel";
            // 
            // _breakScheduleDropDown
            // 
            resources.ApplyResources(this._breakScheduleDropDown, "_breakScheduleDropDown");
            this._breakScheduleDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._breakScheduleDropDown.FormattingEnabled = true;
            this._breakScheduleDropDown.Name = "_breakScheduleDropDown";
            // 
            // _everyNumberOfDaysPicker
            // 
            resources.ApplyResources(this._everyNumberOfDaysPicker, "_everyNumberOfDaysPicker");
            this._everyNumberOfDaysPicker.Maximum = new decimal(new int[] {
            366,
            0,
            0,
            0});
            this._everyNumberOfDaysPicker.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._everyNumberOfDaysPicker.Name = "_everyNumberOfDaysPicker";
            this._everyNumberOfDaysPicker.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // _checkBoxSunday
            // 
            resources.ApplyResources(this._checkBoxSunday, "_checkBoxSunday");
            this._checkBoxSunday.Name = "_checkBoxSunday";
            this._checkBoxSunday.UseVisualStyleBackColor = true;
            // 
            // _checkBoxMonday
            // 
            resources.ApplyResources(this._checkBoxMonday, "_checkBoxMonday");
            this._checkBoxMonday.Name = "_checkBoxMonday";
            this._checkBoxMonday.UseVisualStyleBackColor = true;
            // 
            // _checkBoxTuesday
            // 
            resources.ApplyResources(this._checkBoxTuesday, "_checkBoxTuesday");
            this._checkBoxTuesday.Name = "_checkBoxTuesday";
            this._checkBoxTuesday.UseVisualStyleBackColor = true;
            // 
            // _checkBoxWednesday
            // 
            resources.ApplyResources(this._checkBoxWednesday, "_checkBoxWednesday");
            this._checkBoxWednesday.Name = "_checkBoxWednesday";
            this._checkBoxWednesday.UseVisualStyleBackColor = true;
            // 
            // _checkBoxThursday
            // 
            resources.ApplyResources(this._checkBoxThursday, "_checkBoxThursday");
            this._checkBoxThursday.Name = "_checkBoxThursday";
            this._checkBoxThursday.UseVisualStyleBackColor = true;
            // 
            // _checkBoxFriday
            // 
            resources.ApplyResources(this._checkBoxFriday, "_checkBoxFriday");
            this._checkBoxFriday.Name = "_checkBoxFriday";
            this._checkBoxFriday.UseVisualStyleBackColor = true;
            // 
            // _checkBoxSaturday
            // 
            resources.ApplyResources(this._checkBoxSaturday, "_checkBoxSaturday");
            this._checkBoxSaturday.Name = "_checkBoxSaturday";
            this._checkBoxSaturday.UseVisualStyleBackColor = true;
            // 
            // _breakScheduleUntilLabel
            // 
            resources.ApplyResources(this._breakScheduleUntilLabel, "_breakScheduleUntilLabel");
            this._breakScheduleUntilLabel.Name = "_breakScheduleUntilLabel";
            // 
            // _breakUntilDropDown
            // 
            resources.ApplyResources(this._breakUntilDropDown, "_breakUntilDropDown");
            this._breakUntilDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._breakUntilDropDown.FormattingEnabled = true;
            this._breakUntilDropDown.Name = "_breakUntilDropDown";
            // 
            // _breakUntilSpecificTimePicker
            // 
            resources.ApplyResources(this._breakUntilSpecificTimePicker, "_breakUntilSpecificTimePicker");
            this._breakUntilSpecificTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._breakUntilSpecificTimePicker.Name = "_breakUntilSpecificTimePicker";
            this._breakUntilSpecificTimePicker.ShowUpDown = true;
            // 
            // _breakUntilSpecificDurationPicker
            // 
            resources.ApplyResources(this._breakUntilSpecificDurationPicker, "_breakUntilSpecificDurationPicker");
            this._breakUntilSpecificDurationPicker.Items.AddRange(new System.TimeSpan2[] {
            new System.TimeSpan2(7, 0, 0, 0),
            new System.TimeSpan2(14, 0, 0, 0),
            new System.TimeSpan2(30, 0, 0, 0)});
            this._breakUntilSpecificDurationPicker.Name = "_breakUntilSpecificDurationPicker";
            this._breakUntilSpecificDurationPicker.Value = new System.TimeSpan2(7, 0, 0, 0);
            // 
            // _badgererOptionsGroupBox
            // 
            resources.ApplyResources(this._badgererOptionsGroupBox, "_badgererOptionsGroupBox");
            this._overarchingTableLayout.SetColumnSpan(this._badgererOptionsGroupBox, 2);
            this._badgererOptionsGroupBox.Controls.Add(this._badgererOptionsTableLayoutPanel);
            this._badgererOptionsGroupBox.Name = "_badgererOptionsGroupBox";
            this._badgererOptionsGroupBox.TabStop = false;
            // 
            // _lockScreenCheckBox
            // 
            resources.ApplyResources(this._lockScreenCheckBox, "_lockScreenCheckBox");
            this._lockScreenCheckBox.Checked = true;
            this._lockScreenCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this._lockScreenCheckBox.Name = "_lockScreenCheckBox";
            this._lockScreenCheckBox.UseVisualStyleBackColor = true;
            // 
            // _badgererDisplayLabel
            // 
            resources.ApplyResources(this._badgererDisplayLabel, "_badgererDisplayLabel");
            this._badgererDisplayLabel.Name = "_badgererDisplayLabel";
            // 
            // _badgererDisplayDropDown
            // 
            resources.ApplyResources(this._badgererDisplayDropDown, "_badgererDisplayDropDown");
            this._badgererDisplayDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._badgererDisplayDropDown.FormattingEnabled = true;
            this._badgererDisplayDropDown.Name = "_badgererDisplayDropDown";
            // 
            // _cancelButton
            // 
            resources.ApplyResources(this._cancelButton, "_cancelButton");
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // _okButton
            // 
            resources.ApplyResources(this._okButton, "_okButton");
            this._okButton.Name = "_okButton";
            this._okButton.UseVisualStyleBackColor = true;
            // 
            // _overarchingTableLayout
            // 
            resources.ApplyResources(this._overarchingTableLayout, "_overarchingTableLayout");
            this._overarchingTableLayout.Controls.Add(this._badgererOptionsGroupBox, 0, 2);
            this._overarchingTableLayout.Controls.Add(this._friendlyNameLabel, 0, 0);
            this._overarchingTableLayout.Controls.Add(this._friendlyNameTextBox, 1, 0);
            this._overarchingTableLayout.Controls.Add(this._breakOptionsGroupBox, 0, 1);
            this._overarchingTableLayout.Controls.Add(this._scheduleOptionsGroupBox, 0, 3);
            this._overarchingTableLayout.Controls.Add(this._buttonsFlowLayoutPanel, 0, 4);
            this._overarchingTableLayout.Name = "_overarchingTableLayout";
            // 
            // _breakOptionsGroupBox
            // 
            resources.ApplyResources(this._breakOptionsGroupBox, "_breakOptionsGroupBox");
            this._overarchingTableLayout.SetColumnSpan(this._breakOptionsGroupBox, 2);
            this._breakOptionsGroupBox.Controls.Add(this._breakOptionsTableLayoutPanel);
            this._breakOptionsGroupBox.Name = "_breakOptionsGroupBox";
            this._breakOptionsGroupBox.TabStop = false;
            // 
            // _breakOptionsTableLayoutPanel
            // 
            resources.ApplyResources(this._breakOptionsTableLayoutPanel, "_breakOptionsTableLayoutPanel");
            this._breakOptionsTableLayoutPanel.Controls.Add(this._breakIntervalLabel, 0, 1);
            this._breakOptionsTableLayoutPanel.Controls.Add(this._breakDurationLabel, 0, 0);
            this._breakOptionsTableLayoutPanel.Controls.Add(this._breakDurationPicker, 1, 0);
            this._breakOptionsTableLayoutPanel.Controls.Add(this._breakIntervalPicker, 1, 1);
            this._breakOptionsTableLayoutPanel.Name = "_breakOptionsTableLayoutPanel";
            // 
            // _badgererOptionsTableLayoutPanel
            // 
            resources.ApplyResources(this._badgererOptionsTableLayoutPanel, "_badgererOptionsTableLayoutPanel");
            this._badgererOptionsTableLayoutPanel.Controls.Add(this._badgererDisplayDropDown, 0, 0);
            this._badgererOptionsTableLayoutPanel.Controls.Add(this._badgererDisplayLabel, 0, 0);
            this._badgererOptionsTableLayoutPanel.Controls.Add(this._lockScreenCheckBox, 0, 0);
            this._badgererOptionsTableLayoutPanel.Name = "_badgererOptionsTableLayoutPanel";
            // 
            // _scheduleOptionsGroupBox
            // 
            resources.ApplyResources(this._scheduleOptionsGroupBox, "_scheduleOptionsGroupBox");
            this._overarchingTableLayout.SetColumnSpan(this._scheduleOptionsGroupBox, 2);
            this._scheduleOptionsGroupBox.Controls.Add(this._scheduleOptionsTableLayoutPanel);
            this._scheduleOptionsGroupBox.Name = "_scheduleOptionsGroupBox";
            this._scheduleOptionsGroupBox.TabStop = false;
            // 
            // _scheduleOptionsTableLayoutPanel
            // 
            resources.ApplyResources(this._scheduleOptionsTableLayoutPanel, "_scheduleOptionsTableLayoutPanel");
            this._scheduleOptionsTableLayoutPanel.Controls.Add(this._breakUntilDropDown, 1, 4);
            this._scheduleOptionsTableLayoutPanel.Controls.Add(this._breakScheduleUntilLabel, 0, 4);
            this._scheduleOptionsTableLayoutPanel.Controls.Add(this._breakScheduleDropDown, 1, 2);
            this._scheduleOptionsTableLayoutPanel.Controls.Add(this._breakScheduleLabel, 0, 2);
            this._scheduleOptionsTableLayoutPanel.Controls.Add(this._repeatDurationDropDown, 1, 1);
            this._scheduleOptionsTableLayoutPanel.Controls.Add(this._breakRepeatLabel, 0, 1);
            this._scheduleOptionsTableLayoutPanel.Controls.Add(this._startingTimeLabel, 0, 0);
            this._scheduleOptionsTableLayoutPanel.Controls.Add(this._startingTypeDropDown, 1, 0);
            this._scheduleOptionsTableLayoutPanel.Controls.Add(this._startingTimePanel, 2, 0);
            this._scheduleOptionsTableLayoutPanel.Controls.Add(this._breakRepeatPanel, 2, 1);
            this._scheduleOptionsTableLayoutPanel.Controls.Add(this._breakSchedulePanel, 2, 2);
            this._scheduleOptionsTableLayoutPanel.Controls.Add(this._weekdaysFlowLayoutPanel, 0, 3);
            this._scheduleOptionsTableLayoutPanel.Controls.Add(this._untilPanel, 2, 4);
            this._scheduleOptionsTableLayoutPanel.Name = "_scheduleOptionsTableLayoutPanel";
            // 
            // _startingTimePanel
            // 
            resources.ApplyResources(this._startingTimePanel, "_startingTimePanel");
            this._startingTimePanel.Controls.Add(this._startingSpecificTimePicker);
            this._startingTimePanel.Controls.Add(this._startingTimeAfterHourPicker);
            this._startingTimePanel.Name = "_startingTimePanel";
            // 
            // _breakRepeatPanel
            // 
            resources.ApplyResources(this._breakRepeatPanel, "_breakRepeatPanel");
            this._breakRepeatPanel.Controls.Add(this._repeatSpecificNumberOfTimesPicker);
            this._breakRepeatPanel.Controls.Add(this._repeatCertainDurationPicker);
            this._breakRepeatPanel.Controls.Add(this._repeatSpecificTimePicker);
            this._breakRepeatPanel.Name = "_breakRepeatPanel";
            // 
            // _breakSchedulePanel
            // 
            resources.ApplyResources(this._breakSchedulePanel, "_breakSchedulePanel");
            this._breakSchedulePanel.Controls.Add(this._everyNumberOfDaysPicker);
            this._breakSchedulePanel.Name = "_breakSchedulePanel";
            // 
            // _weekdaysFlowLayoutPanel
            // 
            resources.ApplyResources(this._weekdaysFlowLayoutPanel, "_weekdaysFlowLayoutPanel");
            this._scheduleOptionsTableLayoutPanel.SetColumnSpan(this._weekdaysFlowLayoutPanel, 3);
            this._weekdaysFlowLayoutPanel.Controls.Add(this._checkBoxSunday);
            this._weekdaysFlowLayoutPanel.Controls.Add(this._checkBoxMonday);
            this._weekdaysFlowLayoutPanel.Controls.Add(this._checkBoxTuesday);
            this._weekdaysFlowLayoutPanel.Controls.Add(this._checkBoxWednesday);
            this._weekdaysFlowLayoutPanel.Controls.Add(this._checkBoxThursday);
            this._weekdaysFlowLayoutPanel.Controls.Add(this._checkBoxFriday);
            this._weekdaysFlowLayoutPanel.Controls.Add(this._checkBoxSaturday);
            this._weekdaysFlowLayoutPanel.Name = "_weekdaysFlowLayoutPanel";
            // 
            // _untilPanel
            // 
            resources.ApplyResources(this._untilPanel, "_untilPanel");
            this._untilPanel.Controls.Add(this._breakUntilSpecificDurationPicker);
            this._untilPanel.Controls.Add(this._breakUntilSpecificTimePicker);
            this._untilPanel.Name = "_untilPanel";
            // 
            // _buttonsFlowLayoutPanel
            // 
            resources.ApplyResources(this._buttonsFlowLayoutPanel, "_buttonsFlowLayoutPanel");
            this._overarchingTableLayout.SetColumnSpan(this._buttonsFlowLayoutPanel, 2);
            this._buttonsFlowLayoutPanel.Controls.Add(this._cancelButton);
            this._buttonsFlowLayoutPanel.Controls.Add(this._okButton);
            this._buttonsFlowLayoutPanel.Name = "_buttonsFlowLayoutPanel";
            // 
            // BreakForm
            // 
            this.AcceptButton = this._okButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._cancelButton;
            this.Controls.Add(this._overarchingTableLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BreakForm";
            ((System.ComponentModel.ISupportInitialize)(this._startingTimeAfterHourPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._repeatSpecificNumberOfTimesPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._everyNumberOfDaysPicker)).EndInit();
            this._badgererOptionsGroupBox.ResumeLayout(false);
            this._badgererOptionsGroupBox.PerformLayout();
            this._overarchingTableLayout.ResumeLayout(false);
            this._overarchingTableLayout.PerformLayout();
            this._breakOptionsGroupBox.ResumeLayout(false);
            this._breakOptionsGroupBox.PerformLayout();
            this._breakOptionsTableLayoutPanel.ResumeLayout(false);
            this._breakOptionsTableLayoutPanel.PerformLayout();
            this._badgererOptionsTableLayoutPanel.ResumeLayout(false);
            this._badgererOptionsTableLayoutPanel.PerformLayout();
            this._scheduleOptionsGroupBox.ResumeLayout(false);
            this._scheduleOptionsGroupBox.PerformLayout();
            this._scheduleOptionsTableLayoutPanel.ResumeLayout(false);
            this._scheduleOptionsTableLayoutPanel.PerformLayout();
            this._startingTimePanel.ResumeLayout(false);
            this._breakRepeatPanel.ResumeLayout(false);
            this._breakSchedulePanel.ResumeLayout(false);
            this._weekdaysFlowLayoutPanel.ResumeLayout(false);
            this._weekdaysFlowLayoutPanel.PerformLayout();
            this._untilPanel.ResumeLayout(false);
            this._buttonsFlowLayoutPanel.ResumeLayout(false);
            this._buttonsFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _breakDurationLabel;
        private System.Windows.Forms.TimeSpanPicker _breakDurationPicker;
        private System.Windows.Forms.Label _breakIntervalLabel;
        private System.Windows.Forms.TimeSpanPicker _breakIntervalPicker;
        private System.Windows.Forms.Label _startingTimeLabel;
        private System.Windows.Forms.ComboBox _startingTypeDropDown;
        private System.Windows.Forms.DateTimePicker _startingSpecificTimePicker;
        private System.Windows.Forms.NumericUpDown _startingTimeAfterHourPicker;
        private System.Windows.Forms.Label _breakRepeatLabel;
        private System.Windows.Forms.ComboBox _repeatDurationDropDown;
        private System.Windows.Forms.DateTimePicker _repeatSpecificTimePicker;
        private System.Windows.Forms.TimeSpanPicker _repeatCertainDurationPicker;
        private System.Windows.Forms.NumericUpDown _repeatSpecificNumberOfTimesPicker;
        private System.Windows.Forms.Label _breakScheduleLabel;
        private System.Windows.Forms.ComboBox _breakScheduleDropDown;
        private System.Windows.Forms.NumericUpDown _everyNumberOfDaysPicker;
        private System.Windows.Forms.CheckBox _checkBoxSunday;
        private System.Windows.Forms.CheckBox _checkBoxMonday;
        private System.Windows.Forms.CheckBox _checkBoxTuesday;
        private System.Windows.Forms.CheckBox _checkBoxWednesday;
        private System.Windows.Forms.CheckBox _checkBoxThursday;
        private System.Windows.Forms.CheckBox _checkBoxFriday;
        private System.Windows.Forms.CheckBox _checkBoxSaturday;
        private System.Windows.Forms.Label _breakScheduleUntilLabel;
        private System.Windows.Forms.ComboBox _breakUntilDropDown;
        private System.Windows.Forms.DateTimePicker _breakUntilSpecificTimePicker;
        private System.Windows.Forms.TimeSpanPicker _breakUntilSpecificDurationPicker;
        private System.Windows.Forms.GroupBox _badgererOptionsGroupBox;
        private System.Windows.Forms.CheckBox _lockScreenCheckBox;
        private System.Windows.Forms.Label _badgererDisplayLabel;
        private System.Windows.Forms.ComboBox _badgererDisplayDropDown;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Label _friendlyNameLabel;
        private System.Windows.Forms.TextBox _friendlyNameTextBox;
        private System.Windows.Forms.TableLayoutPanel _overarchingTableLayout;
        private System.Windows.Forms.GroupBox _breakOptionsGroupBox;
        private System.Windows.Forms.TableLayoutPanel _breakOptionsTableLayoutPanel;
        private System.Windows.Forms.GroupBox _scheduleOptionsGroupBox;
        private System.Windows.Forms.TableLayoutPanel _scheduleOptionsTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel _badgererOptionsTableLayoutPanel;
        private System.Windows.Forms.Panel _startingTimePanel;
        private System.Windows.Forms.Panel _breakRepeatPanel;
        private System.Windows.Forms.Panel _breakSchedulePanel;
        private System.Windows.Forms.FlowLayoutPanel _weekdaysFlowLayoutPanel;
        private System.Windows.Forms.Panel _untilPanel;
        private System.Windows.Forms.FlowLayoutPanel _buttonsFlowLayoutPanel;
    }
}