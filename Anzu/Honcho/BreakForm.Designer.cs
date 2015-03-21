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
            this._flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
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
            this._friendlyNameLabel = new System.Windows.Forms.Label();
            this._friendlyNameTextBox = new System.Windows.Forms.TextBox();
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
            this._flowLayoutPanel.AutoSize = true;
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
            this._flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._flowLayoutPanel.Name = "_flowLayoutPanel";
            this._flowLayoutPanel.Size = new System.Drawing.Size(510, 317);
            this._flowLayoutPanel.TabIndex = 0;
            // 
            // _breakDurationLabel
            // 
            this._breakDurationLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._breakDurationLabel.AutoSize = true;
            this._breakDurationLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._breakDurationLabel.Location = new System.Drawing.Point(3, 33);
            this._breakDurationLabel.Name = "_breakDurationLabel";
            this._breakDurationLabel.Size = new System.Drawing.Size(86, 13);
            this._breakDurationLabel.TabIndex = 2;
            this._breakDurationLabel.Text = "Take a break for";
            this._breakDurationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this._breakDurationPicker.Location = new System.Drawing.Point(95, 29);
            this._breakDurationPicker.Name = "_breakDurationPicker";
            this._breakDurationPicker.Size = new System.Drawing.Size(121, 21);
            this._breakDurationPicker.TabIndex = 1;
            this._breakDurationPicker.Value = new System.TimeSpan2(0, 0, 5, 0);
            // 
            // _breakIntervalLabel
            // 
            this._breakIntervalLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._breakIntervalLabel.AutoSize = true;
            this._breakIntervalLabel.Location = new System.Drawing.Point(3, 60);
            this._breakIntervalLabel.Name = "_breakIntervalLabel";
            this._breakIntervalLabel.Size = new System.Drawing.Size(33, 13);
            this._breakIntervalLabel.TabIndex = 3;
            this._breakIntervalLabel.Text = "every";
            this._breakIntervalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this._breakIntervalPicker.Location = new System.Drawing.Point(42, 56);
            this._breakIntervalPicker.Name = "_breakIntervalPicker";
            this._breakIntervalPicker.Size = new System.Drawing.Size(121, 21);
            this._breakIntervalPicker.TabIndex = 4;
            this._breakIntervalPicker.Value = new System.TimeSpan2(0, 1, 0, 0);
            // 
            // _startingTimeLabel
            // 
            this._startingTimeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._startingTimeLabel.AutoSize = true;
            this._startingTimeLabel.Location = new System.Drawing.Point(3, 87);
            this._startingTimeLabel.Name = "_startingTimeLabel";
            this._startingTimeLabel.Size = new System.Drawing.Size(41, 13);
            this._startingTimeLabel.TabIndex = 5;
            this._startingTimeLabel.Text = "starting";
            this._startingTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _startingTypeDropDown
            // 
            this._startingTypeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._startingTypeDropDown.FormattingEnabled = true;
            this._startingTypeDropDown.Location = new System.Drawing.Point(50, 83);
            this._startingTypeDropDown.Name = "_startingTypeDropDown";
            this._startingTypeDropDown.Size = new System.Drawing.Size(121, 21);
            this._startingTypeDropDown.TabIndex = 6;
            // 
            // _startingTimeAfterHourPicker
            // 
            this._startingTimeAfterHourPicker.Enabled = false;
            this._flowLayoutPanel.SetFlowBreak(this._startingTimeAfterHourPicker, true);
            this._startingTimeAfterHourPicker.Location = new System.Drawing.Point(177, 83);
            this._startingTimeAfterHourPicker.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this._startingTimeAfterHourPicker.Name = "_startingTimeAfterHourPicker";
            this._startingTimeAfterHourPicker.Size = new System.Drawing.Size(120, 20);
            this._startingTimeAfterHourPicker.TabIndex = 8;
            this._startingTimeAfterHourPicker.Value = new decimal(new int[] {
            55,
            0,
            0,
            0});
            this._startingTimeAfterHourPicker.Visible = false;
            // 
            // _startingSpecificTimePicker
            // 
            this._startingSpecificTimePicker.Enabled = false;
            this._flowLayoutPanel.SetFlowBreak(this._startingSpecificTimePicker, true);
            this._startingSpecificTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._startingSpecificTimePicker.Location = new System.Drawing.Point(3, 110);
            this._startingSpecificTimePicker.Name = "_startingSpecificTimePicker";
            this._startingSpecificTimePicker.ShowUpDown = true;
            this._startingSpecificTimePicker.Size = new System.Drawing.Size(200, 20);
            this._startingSpecificTimePicker.TabIndex = 7;
            this._startingSpecificTimePicker.Visible = false;
            // 
            // _breakRepeatLabel
            // 
            this._breakRepeatLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._breakRepeatLabel.AutoSize = true;
            this._breakRepeatLabel.Location = new System.Drawing.Point(3, 140);
            this._breakRepeatLabel.Name = "_breakRepeatLabel";
            this._breakRepeatLabel.Size = new System.Drawing.Size(78, 13);
            this._breakRepeatLabel.TabIndex = 9;
            this._breakRepeatLabel.Text = "repeat break(s)";
            this._breakRepeatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _repeatDurationDropDown
            // 
            this._repeatDurationDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._repeatDurationDropDown.FormattingEnabled = true;
            this._repeatDurationDropDown.Location = new System.Drawing.Point(87, 136);
            this._repeatDurationDropDown.Name = "_repeatDurationDropDown";
            this._repeatDurationDropDown.Size = new System.Drawing.Size(121, 21);
            this._repeatDurationDropDown.TabIndex = 10;
            // 
            // _repeatSpecificTimePicker
            // 
            this._repeatSpecificTimePicker.Enabled = false;
            this._flowLayoutPanel.SetFlowBreak(this._repeatSpecificTimePicker, true);
            this._repeatSpecificTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._repeatSpecificTimePicker.Location = new System.Drawing.Point(214, 136);
            this._repeatSpecificTimePicker.Name = "_repeatSpecificTimePicker";
            this._repeatSpecificTimePicker.ShowUpDown = true;
            this._repeatSpecificTimePicker.Size = new System.Drawing.Size(200, 20);
            this._repeatSpecificTimePicker.TabIndex = 11;
            this._repeatSpecificTimePicker.Visible = false;
            // 
            // _repeatCertainDurationPicker
            // 
            this._repeatCertainDurationPicker.Enabled = false;
            this._flowLayoutPanel.SetFlowBreak(this._repeatCertainDurationPicker, true);
            this._repeatCertainDurationPicker.Items.AddRange(new System.TimeSpan2[] {
            new System.TimeSpan2(2, 0, 0, 0),
            new System.TimeSpan2(3, 0, 0, 0),
            new System.TimeSpan2(7, 0, 0, 0),
            new System.TimeSpan2(0, 4, 0, 0),
            new System.TimeSpan2(0, 6, 0, 0),
            new System.TimeSpan2(0, 8, 0, 0),
            new System.TimeSpan2(0, 12, 0, 0)});
            this._repeatCertainDurationPicker.Location = new System.Drawing.Point(3, 163);
            this._repeatCertainDurationPicker.Name = "_repeatCertainDurationPicker";
            this._repeatCertainDurationPicker.Size = new System.Drawing.Size(121, 21);
            this._repeatCertainDurationPicker.TabIndex = 12;
            this._repeatCertainDurationPicker.Value = new System.TimeSpan2(1, 0, 0, 0);
            this._repeatCertainDurationPicker.Visible = false;
            // 
            // _repeatSpecificNumberOfTimesPicker
            // 
            this._repeatSpecificNumberOfTimesPicker.Enabled = false;
            this._flowLayoutPanel.SetFlowBreak(this._repeatSpecificNumberOfTimesPicker, true);
            this._repeatSpecificNumberOfTimesPicker.Location = new System.Drawing.Point(3, 190);
            this._repeatSpecificNumberOfTimesPicker.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._repeatSpecificNumberOfTimesPicker.Name = "_repeatSpecificNumberOfTimesPicker";
            this._repeatSpecificNumberOfTimesPicker.Size = new System.Drawing.Size(120, 20);
            this._repeatSpecificNumberOfTimesPicker.TabIndex = 13;
            this._repeatSpecificNumberOfTimesPicker.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this._repeatSpecificNumberOfTimesPicker.Visible = false;
            // 
            // _breakScheduleLabel
            // 
            this._breakScheduleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._breakScheduleLabel.AutoSize = true;
            this._breakScheduleLabel.Location = new System.Drawing.Point(3, 220);
            this._breakScheduleLabel.Name = "_breakScheduleLabel";
            this._breakScheduleLabel.Size = new System.Drawing.Size(91, 13);
            this._breakScheduleLabel.TabIndex = 14;
            this._breakScheduleLabel.Text = "schedule break(s)";
            this._breakScheduleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _breakScheduleDropDown
            // 
            this._breakScheduleDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._breakScheduleDropDown.FormattingEnabled = true;
            this._breakScheduleDropDown.Location = new System.Drawing.Point(100, 216);
            this._breakScheduleDropDown.Name = "_breakScheduleDropDown";
            this._breakScheduleDropDown.Size = new System.Drawing.Size(121, 21);
            this._breakScheduleDropDown.TabIndex = 15;
            // 
            // _everyNumberOfDaysPicker
            // 
            this._everyNumberOfDaysPicker.Enabled = false;
            this._flowLayoutPanel.SetFlowBreak(this._everyNumberOfDaysPicker, true);
            this._everyNumberOfDaysPicker.Location = new System.Drawing.Point(227, 216);
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
            this._everyNumberOfDaysPicker.Size = new System.Drawing.Size(120, 20);
            this._everyNumberOfDaysPicker.TabIndex = 16;
            this._everyNumberOfDaysPicker.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this._everyNumberOfDaysPicker.Visible = false;
            // 
            // _checkBoxSunday
            // 
            this._checkBoxSunday.AutoSize = true;
            this._checkBoxSunday.Enabled = false;
            this._checkBoxSunday.Location = new System.Drawing.Point(3, 243);
            this._checkBoxSunday.Name = "_checkBoxSunday";
            this._checkBoxSunday.Size = new System.Drawing.Size(62, 17);
            this._checkBoxSunday.TabIndex = 17;
            this._checkBoxSunday.Text = "Sunday";
            this._checkBoxSunday.UseVisualStyleBackColor = true;
            this._checkBoxSunday.Visible = false;
            // 
            // _checkBoxMonday
            // 
            this._checkBoxMonday.AutoSize = true;
            this._checkBoxMonday.Enabled = false;
            this._checkBoxMonday.Location = new System.Drawing.Point(71, 243);
            this._checkBoxMonday.Name = "_checkBoxMonday";
            this._checkBoxMonday.Size = new System.Drawing.Size(64, 17);
            this._checkBoxMonday.TabIndex = 18;
            this._checkBoxMonday.Text = "Monday";
            this._checkBoxMonday.UseVisualStyleBackColor = true;
            this._checkBoxMonday.Visible = false;
            // 
            // _checkBoxTuesday
            // 
            this._checkBoxTuesday.AutoSize = true;
            this._checkBoxTuesday.Enabled = false;
            this._checkBoxTuesday.Location = new System.Drawing.Point(141, 243);
            this._checkBoxTuesday.Name = "_checkBoxTuesday";
            this._checkBoxTuesday.Size = new System.Drawing.Size(67, 17);
            this._checkBoxTuesday.TabIndex = 19;
            this._checkBoxTuesday.Text = "Tuesday";
            this._checkBoxTuesday.UseVisualStyleBackColor = true;
            this._checkBoxTuesday.Visible = false;
            // 
            // _checkBoxWednesday
            // 
            this._checkBoxWednesday.AutoSize = true;
            this._checkBoxWednesday.Enabled = false;
            this._checkBoxWednesday.Location = new System.Drawing.Point(214, 243);
            this._checkBoxWednesday.Name = "_checkBoxWednesday";
            this._checkBoxWednesday.Size = new System.Drawing.Size(83, 17);
            this._checkBoxWednesday.TabIndex = 20;
            this._checkBoxWednesday.Text = "Wednesday";
            this._checkBoxWednesday.UseVisualStyleBackColor = true;
            this._checkBoxWednesday.Visible = false;
            // 
            // _checkBoxThursday
            // 
            this._checkBoxThursday.AutoSize = true;
            this._checkBoxThursday.Enabled = false;
            this._checkBoxThursday.Location = new System.Drawing.Point(303, 243);
            this._checkBoxThursday.Name = "_checkBoxThursday";
            this._checkBoxThursday.Size = new System.Drawing.Size(70, 17);
            this._checkBoxThursday.TabIndex = 21;
            this._checkBoxThursday.Text = "Thursday";
            this._checkBoxThursday.UseVisualStyleBackColor = true;
            this._checkBoxThursday.Visible = false;
            // 
            // _checkBoxFriday
            // 
            this._checkBoxFriday.AutoSize = true;
            this._checkBoxFriday.Enabled = false;
            this._checkBoxFriday.Location = new System.Drawing.Point(379, 243);
            this._checkBoxFriday.Name = "_checkBoxFriday";
            this._checkBoxFriday.Size = new System.Drawing.Size(54, 17);
            this._checkBoxFriday.TabIndex = 22;
            this._checkBoxFriday.Text = "Friday";
            this._checkBoxFriday.UseVisualStyleBackColor = true;
            this._checkBoxFriday.Visible = false;
            // 
            // _checkBoxSaturday
            // 
            this._checkBoxSaturday.AutoSize = true;
            this._checkBoxSaturday.Enabled = false;
            this._flowLayoutPanel.SetFlowBreak(this._checkBoxSaturday, true);
            this._checkBoxSaturday.Location = new System.Drawing.Point(439, 243);
            this._checkBoxSaturday.Name = "_checkBoxSaturday";
            this._checkBoxSaturday.Size = new System.Drawing.Size(68, 17);
            this._checkBoxSaturday.TabIndex = 23;
            this._checkBoxSaturday.Text = "Saturday";
            this._checkBoxSaturday.UseVisualStyleBackColor = true;
            this._checkBoxSaturday.Visible = false;
            // 
            // _breakScheduleUntilLabel
            // 
            this._breakScheduleUntilLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._breakScheduleUntilLabel.AutoSize = true;
            this._breakScheduleUntilLabel.Enabled = false;
            this._breakScheduleUntilLabel.Location = new System.Drawing.Point(3, 270);
            this._breakScheduleUntilLabel.Name = "_breakScheduleUntilLabel";
            this._breakScheduleUntilLabel.Size = new System.Drawing.Size(26, 13);
            this._breakScheduleUntilLabel.TabIndex = 24;
            this._breakScheduleUntilLabel.Text = "until";
            this._breakScheduleUntilLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._breakScheduleUntilLabel.Visible = false;
            // 
            // _breakUntilDropDown
            // 
            this._breakUntilDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._breakUntilDropDown.Enabled = false;
            this._breakUntilDropDown.FormattingEnabled = true;
            this._breakUntilDropDown.Location = new System.Drawing.Point(35, 266);
            this._breakUntilDropDown.Name = "_breakUntilDropDown";
            this._breakUntilDropDown.Size = new System.Drawing.Size(121, 21);
            this._breakUntilDropDown.TabIndex = 25;
            this._breakUntilDropDown.Visible = false;
            // 
            // _breakUntilSpecificTimePicker
            // 
            this._breakUntilSpecificTimePicker.Enabled = false;
            this._flowLayoutPanel.SetFlowBreak(this._breakUntilSpecificTimePicker, true);
            this._breakUntilSpecificTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._breakUntilSpecificTimePicker.Location = new System.Drawing.Point(162, 266);
            this._breakUntilSpecificTimePicker.Name = "_breakUntilSpecificTimePicker";
            this._breakUntilSpecificTimePicker.ShowUpDown = true;
            this._breakUntilSpecificTimePicker.Size = new System.Drawing.Size(200, 20);
            this._breakUntilSpecificTimePicker.TabIndex = 26;
            this._breakUntilSpecificTimePicker.Visible = false;
            // 
            // _breakUntilSpecificDurationPicker
            // 
            this._breakUntilSpecificDurationPicker.Enabled = false;
            this._flowLayoutPanel.SetFlowBreak(this._breakUntilSpecificDurationPicker, true);
            this._breakUntilSpecificDurationPicker.Items.AddRange(new System.TimeSpan2[] {
            new System.TimeSpan2(7, 0, 0, 0),
            new System.TimeSpan2(14, 0, 0, 0),
            new System.TimeSpan2(30, 0, 0, 0)});
            this._breakUntilSpecificDurationPicker.Location = new System.Drawing.Point(3, 293);
            this._breakUntilSpecificDurationPicker.Name = "_breakUntilSpecificDurationPicker";
            this._breakUntilSpecificDurationPicker.Size = new System.Drawing.Size(121, 21);
            this._breakUntilSpecificDurationPicker.TabIndex = 27;
            this._breakUntilSpecificDurationPicker.Value = new System.TimeSpan2(7, 0, 0, 0);
            this._breakUntilSpecificDurationPicker.Visible = false;
            // 
            // _badgererOptionsGroupBox
            // 
            this._badgererOptionsGroupBox.AutoSize = true;
            this._badgererOptionsGroupBox.Controls.Add(this._badgererOptionsFlowLayoutPanel);
            this._badgererOptionsGroupBox.Location = new System.Drawing.Point(0, 297);
            this._badgererOptionsGroupBox.Name = "_badgererOptionsGroupBox";
            this._badgererOptionsGroupBox.Size = new System.Drawing.Size(516, 65);
            this._badgererOptionsGroupBox.TabIndex = 1;
            this._badgererOptionsGroupBox.TabStop = false;
            this._badgererOptionsGroupBox.Text = "When taking a break:";
            // 
            // _badgererOptionsFlowLayoutPanel
            // 
            this._badgererOptionsFlowLayoutPanel.AutoSize = true;
            this._badgererOptionsFlowLayoutPanel.Controls.Add(this._lockScreenCheckBox);
            this._badgererOptionsFlowLayoutPanel.Controls.Add(this._badgererDisplayLabel);
            this._badgererOptionsFlowLayoutPanel.Controls.Add(this._badgererDisplayDropDown);
            this._badgererOptionsFlowLayoutPanel.Location = new System.Drawing.Point(12, 19);
            this._badgererOptionsFlowLayoutPanel.Name = "_badgererOptionsFlowLayoutPanel";
            this._badgererOptionsFlowLayoutPanel.Size = new System.Drawing.Size(498, 27);
            this._badgererOptionsFlowLayoutPanel.TabIndex = 0;
            // 
            // _lockScreenCheckBox
            // 
            this._lockScreenCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._lockScreenCheckBox.AutoSize = true;
            this._lockScreenCheckBox.Checked = true;
            this._lockScreenCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this._lockScreenCheckBox.Location = new System.Drawing.Point(3, 5);
            this._lockScreenCheckBox.Name = "_lockScreenCheckBox";
            this._lockScreenCheckBox.Size = new System.Drawing.Size(103, 17);
            this._lockScreenCheckBox.TabIndex = 0;
            this._lockScreenCheckBox.Text = "Lock the screen";
            this._lockScreenCheckBox.UseVisualStyleBackColor = true;
            // 
            // _badgererDisplayLabel
            // 
            this._badgererDisplayLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._badgererDisplayLabel.AutoSize = true;
            this._badgererDisplayLabel.Location = new System.Drawing.Point(112, 7);
            this._badgererDisplayLabel.Name = "_badgererDisplayLabel";
            this._badgererDisplayLabel.Size = new System.Drawing.Size(146, 13);
            this._badgererDisplayLabel.TabIndex = 15;
            this._badgererDisplayLabel.Text = "Display Badgerer window as: ";
            this._badgererDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _badgererDisplayDropDown
            // 
            this._badgererDisplayDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._badgererDisplayDropDown.FormattingEnabled = true;
            this._badgererDisplayDropDown.Location = new System.Drawing.Point(264, 3);
            this._badgererDisplayDropDown.Name = "_badgererDisplayDropDown";
            this._badgererDisplayDropDown.Size = new System.Drawing.Size(121, 21);
            this._badgererDisplayDropDown.TabIndex = 16;
            // 
            // _buttonsTableLayoutPanel
            // 
            this._buttonsTableLayoutPanel.AutoSize = true;
            this._buttonsTableLayoutPanel.ColumnCount = 2;
            this._buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._buttonsTableLayoutPanel.Controls.Add(this._cancelButton, 1, 0);
            this._buttonsTableLayoutPanel.Controls.Add(this._okButton, 0, 0);
            this._buttonsTableLayoutPanel.Location = new System.Drawing.Point(0, 368);
            this._buttonsTableLayoutPanel.Name = "_buttonsTableLayoutPanel";
            this._buttonsTableLayoutPanel.RowCount = 1;
            this._buttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._buttonsTableLayoutPanel.Size = new System.Drawing.Size(510, 29);
            this._buttonsTableLayoutPanel.TabIndex = 3;
            // 
            // _cancelButton
            // 
            this._cancelButton.Location = new System.Drawing.Point(258, 3);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 1;
            this._cancelButton.Text = "Cancel";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // _okButton
            // 
            this._okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._okButton.Location = new System.Drawing.Point(177, 3);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(75, 23);
            this._okButton.TabIndex = 0;
            this._okButton.Text = "OK";
            this._okButton.UseVisualStyleBackColor = true;
            // 
            // _friendlyNameLabel
            // 
            this._friendlyNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._friendlyNameLabel.AutoSize = true;
            this._friendlyNameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._friendlyNameLabel.Location = new System.Drawing.Point(3, 6);
            this._friendlyNameLabel.Name = "_friendlyNameLabel";
            this._friendlyNameLabel.Size = new System.Drawing.Size(74, 13);
            this._friendlyNameLabel.TabIndex = 28;
            this._friendlyNameLabel.Text = "Friendly Name";
            this._friendlyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _friendlyNameTextBox
            // 
            this._flowLayoutPanel.SetFlowBreak(this._friendlyNameTextBox, true);
            this._friendlyNameTextBox.Location = new System.Drawing.Point(83, 3);
            this._friendlyNameTextBox.MaxLength = 256;
            this._friendlyNameTextBox.Name = "_friendlyNameTextBox";
            this._friendlyNameTextBox.Size = new System.Drawing.Size(424, 20);
            this._friendlyNameTextBox.TabIndex = 29;
            // 
            // BreakForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(520, 401);
            this.Controls.Add(this._flowLayoutPanel);
            this.Controls.Add(this._badgererOptionsGroupBox);
            this.Controls.Add(this._buttonsTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BreakForm";
            this.Text = "Schedule New Break";
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