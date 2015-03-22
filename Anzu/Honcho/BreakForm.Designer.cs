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
            this._flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
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
            this._badgererOptionsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this._lockScreenCheckBox = new System.Windows.Forms.CheckBox();
            this._badgererDisplayLabel = new System.Windows.Forms.Label();
            this._badgererDisplayDropDown = new System.Windows.Forms.ComboBox();
            this._buttonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._cancelButton = new System.Windows.Forms.Button();
            this._okButton = new System.Windows.Forms.Button();
            this._flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._startingTimeAfterHourPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._repeatSpecificNumberOfTimesPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._everyNumberOfDaysPicker)).BeginInit();
            this._badgererOptionsGroupBox.SuspendLayout();
            this._badgererOptionsFlowLayoutPanel.SuspendLayout();
            this._buttonsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _flowLayoutPanel
            // 
            resources.ApplyResources(this._flowLayoutPanel, "_flowLayoutPanel");
            this._flowLayoutPanel.Controls.Add(this._friendlyNameLabel);
            this._flowLayoutPanel.Controls.Add(this._friendlyNameTextBox);
            this._flowLayoutPanel.Controls.Add(this._breakDurationLabel);
            this._flowLayoutPanel.Controls.Add(this._breakDurationPicker);
            this._flowLayoutPanel.Controls.Add(this._breakIntervalLabel);
            this._flowLayoutPanel.Controls.Add(this._breakIntervalPicker);
            this._flowLayoutPanel.Controls.Add(this._startingTimeLabel);
            this._flowLayoutPanel.Controls.Add(this._startingTypeDropDown);
            this._flowLayoutPanel.Controls.Add(this._startingTimeAfterHourPicker);
            this._flowLayoutPanel.Controls.Add(this._startingSpecificTimePicker);
            this._flowLayoutPanel.Controls.Add(this._breakRepeatLabel);
            this._flowLayoutPanel.Controls.Add(this._repeatDurationDropDown);
            this._flowLayoutPanel.Controls.Add(this._repeatSpecificTimePicker);
            this._flowLayoutPanel.Controls.Add(this._repeatCertainDurationPicker);
            this._flowLayoutPanel.Controls.Add(this._repeatSpecificNumberOfTimesPicker);
            this._flowLayoutPanel.Controls.Add(this._breakScheduleLabel);
            this._flowLayoutPanel.Controls.Add(this._breakScheduleDropDown);
            this._flowLayoutPanel.Controls.Add(this._everyNumberOfDaysPicker);
            this._flowLayoutPanel.Controls.Add(this._checkBoxSunday);
            this._flowLayoutPanel.Controls.Add(this._checkBoxMonday);
            this._flowLayoutPanel.Controls.Add(this._checkBoxTuesday);
            this._flowLayoutPanel.Controls.Add(this._checkBoxWednesday);
            this._flowLayoutPanel.Controls.Add(this._checkBoxThursday);
            this._flowLayoutPanel.Controls.Add(this._checkBoxFriday);
            this._flowLayoutPanel.Controls.Add(this._checkBoxSaturday);
            this._flowLayoutPanel.Controls.Add(this._breakScheduleUntilLabel);
            this._flowLayoutPanel.Controls.Add(this._breakUntilDropDown);
            this._flowLayoutPanel.Controls.Add(this._breakUntilSpecificTimePicker);
            this._flowLayoutPanel.Controls.Add(this._breakUntilSpecificDurationPicker);
            this._flowLayoutPanel.Name = "_flowLayoutPanel";
            // 
            // _friendlyNameLabel
            // 
            resources.ApplyResources(this._friendlyNameLabel, "_friendlyNameLabel");
            this._friendlyNameLabel.Name = "_friendlyNameLabel";
            // 
            // _friendlyNameTextBox
            // 
            this._flowLayoutPanel.SetFlowBreak(this._friendlyNameTextBox, true);
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
            this._flowLayoutPanel.SetFlowBreak(this._breakDurationPicker, true);
            this._breakDurationPicker.Items.AddRange(new System.TimeSpan2[] {
            new System.TimeSpan2(0, 0, 5, 0),
            new System.TimeSpan2(0, 0, 10, 0),
            new System.TimeSpan2(0, 0, 15, 0),
            new System.TimeSpan2(0, 0, 30, 0),
            new System.TimeSpan2(0, 1, 0, 0)});
            resources.ApplyResources(this._breakDurationPicker, "_breakDurationPicker");
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
            this._flowLayoutPanel.SetFlowBreak(this._breakIntervalPicker, true);
            this._breakIntervalPicker.Items.AddRange(new System.TimeSpan2[] {
            new System.TimeSpan2(0, 1, 0, 0),
            new System.TimeSpan2(0, 0, 30, 0),
            new System.TimeSpan2(0, 2, 0, 0),
            new System.TimeSpan2(0, 3, 0, 0),
            new System.TimeSpan2(0, 4, 0, 0)});
            resources.ApplyResources(this._breakIntervalPicker, "_breakIntervalPicker");
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
            this._startingTypeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._startingTypeDropDown.FormattingEnabled = true;
            resources.ApplyResources(this._startingTypeDropDown, "_startingTypeDropDown");
            this._startingTypeDropDown.Name = "_startingTypeDropDown";
            // 
            // _startingTimeAfterHourPicker
            // 
            resources.ApplyResources(this._startingTimeAfterHourPicker, "_startingTimeAfterHourPicker");
            this._flowLayoutPanel.SetFlowBreak(this._startingTimeAfterHourPicker, true);
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
            this._flowLayoutPanel.SetFlowBreak(this._startingSpecificTimePicker, true);
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
            this._repeatDurationDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._repeatDurationDropDown.FormattingEnabled = true;
            resources.ApplyResources(this._repeatDurationDropDown, "_repeatDurationDropDown");
            this._repeatDurationDropDown.Name = "_repeatDurationDropDown";
            // 
            // _repeatSpecificTimePicker
            // 
            resources.ApplyResources(this._repeatSpecificTimePicker, "_repeatSpecificTimePicker");
            this._flowLayoutPanel.SetFlowBreak(this._repeatSpecificTimePicker, true);
            this._repeatSpecificTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._repeatSpecificTimePicker.Name = "_repeatSpecificTimePicker";
            this._repeatSpecificTimePicker.ShowUpDown = true;
            // 
            // _repeatCertainDurationPicker
            // 
            resources.ApplyResources(this._repeatCertainDurationPicker, "_repeatCertainDurationPicker");
            this._flowLayoutPanel.SetFlowBreak(this._repeatCertainDurationPicker, true);
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
            this._flowLayoutPanel.SetFlowBreak(this._repeatSpecificNumberOfTimesPicker, true);
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
            this._breakScheduleDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._breakScheduleDropDown.FormattingEnabled = true;
            resources.ApplyResources(this._breakScheduleDropDown, "_breakScheduleDropDown");
            this._breakScheduleDropDown.Name = "_breakScheduleDropDown";
            // 
            // _everyNumberOfDaysPicker
            // 
            resources.ApplyResources(this._everyNumberOfDaysPicker, "_everyNumberOfDaysPicker");
            this._flowLayoutPanel.SetFlowBreak(this._everyNumberOfDaysPicker, true);
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
            this._flowLayoutPanel.SetFlowBreak(this._checkBoxSaturday, true);
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
            this._breakUntilDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this._breakUntilDropDown, "_breakUntilDropDown");
            this._breakUntilDropDown.FormattingEnabled = true;
            this._breakUntilDropDown.Name = "_breakUntilDropDown";
            // 
            // _breakUntilSpecificTimePicker
            // 
            resources.ApplyResources(this._breakUntilSpecificTimePicker, "_breakUntilSpecificTimePicker");
            this._flowLayoutPanel.SetFlowBreak(this._breakUntilSpecificTimePicker, true);
            this._breakUntilSpecificTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._breakUntilSpecificTimePicker.Name = "_breakUntilSpecificTimePicker";
            this._breakUntilSpecificTimePicker.ShowUpDown = true;
            // 
            // _breakUntilSpecificDurationPicker
            // 
            resources.ApplyResources(this._breakUntilSpecificDurationPicker, "_breakUntilSpecificDurationPicker");
            this._flowLayoutPanel.SetFlowBreak(this._breakUntilSpecificDurationPicker, true);
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
            this._badgererOptionsGroupBox.Controls.Add(this._badgererOptionsFlowLayoutPanel);
            this._badgererOptionsGroupBox.Name = "_badgererOptionsGroupBox";
            this._badgererOptionsGroupBox.TabStop = false;
            // 
            // _badgererOptionsFlowLayoutPanel
            // 
            resources.ApplyResources(this._badgererOptionsFlowLayoutPanel, "_badgererOptionsFlowLayoutPanel");
            this._badgererOptionsFlowLayoutPanel.Controls.Add(this._lockScreenCheckBox);
            this._badgererOptionsFlowLayoutPanel.Controls.Add(this._badgererDisplayLabel);
            this._badgererOptionsFlowLayoutPanel.Controls.Add(this._badgererDisplayDropDown);
            this._badgererOptionsFlowLayoutPanel.Name = "_badgererOptionsFlowLayoutPanel";
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
            this._badgererDisplayDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._badgererDisplayDropDown.FormattingEnabled = true;
            resources.ApplyResources(this._badgererDisplayDropDown, "_badgererDisplayDropDown");
            this._badgererDisplayDropDown.Name = "_badgererDisplayDropDown";
            // 
            // _buttonsTableLayoutPanel
            // 
            resources.ApplyResources(this._buttonsTableLayoutPanel, "_buttonsTableLayoutPanel");
            this._buttonsTableLayoutPanel.Controls.Add(this._cancelButton, 1, 0);
            this._buttonsTableLayoutPanel.Controls.Add(this._okButton, 0, 0);
            this._buttonsTableLayoutPanel.Name = "_buttonsTableLayoutPanel";
            // 
            // _cancelButton
            // 
            resources.ApplyResources(this._cancelButton, "_cancelButton");
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // _okButton
            // 
            resources.ApplyResources(this._okButton, "_okButton");
            this._okButton.Name = "_okButton";
            this._okButton.UseVisualStyleBackColor = true;
            // 
            // BreakForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._flowLayoutPanel);
            this.Controls.Add(this._badgererOptionsGroupBox);
            this.Controls.Add(this._buttonsTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BreakForm";
            this._flowLayoutPanel.ResumeLayout(false);
            this._flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._startingTimeAfterHourPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._repeatSpecificNumberOfTimesPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._everyNumberOfDaysPicker)).EndInit();
            this._badgererOptionsGroupBox.ResumeLayout(false);
            this._badgererOptionsGroupBox.PerformLayout();
            this._badgererOptionsFlowLayoutPanel.ResumeLayout(false);
            this._badgererOptionsFlowLayoutPanel.PerformLayout();
            this._buttonsTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel _flowLayoutPanel;
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
        private System.Windows.Forms.FlowLayoutPanel _badgererOptionsFlowLayoutPanel;
        private System.Windows.Forms.CheckBox _lockScreenCheckBox;
        private System.Windows.Forms.Label _badgererDisplayLabel;
        private System.Windows.Forms.ComboBox _badgererDisplayDropDown;
        private System.Windows.Forms.TableLayoutPanel _buttonsTableLayoutPanel;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Label _friendlyNameLabel;
        private System.Windows.Forms.TextBox _friendlyNameTextBox;
    }
}