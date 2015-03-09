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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this._breakDurationLabel = new System.Windows.Forms.Label();
            this._breakDurationPicker = new System.Windows.Forms.TimeSpanPicker();
            this._breakIntervalLabel = new System.Windows.Forms.Label();
            this._breakIntervalPicker = new System.Windows.Forms.TimeSpanPicker();
            this._startingTimeLabel = new System.Windows.Forms.Label();
            this._startingTypeDropDown = new System.Windows.Forms.ComboBox();
            this._startingSpecificTimePicker = new System.Windows.Forms.DateTimePicker();
            this._startingTimeAfterHourPicker = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._startingTimeAfterHourPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this._breakDurationLabel);
            this.flowLayoutPanel1.Controls.Add(this._breakDurationPicker);
            this.flowLayoutPanel1.Controls.Add(this._breakIntervalLabel);
            this.flowLayoutPanel1.Controls.Add(this._breakIntervalPicker);
            this.flowLayoutPanel1.Controls.Add(this._startingTimeLabel);
            this.flowLayoutPanel1.Controls.Add(this._startingTypeDropDown);
            this.flowLayoutPanel1.Controls.Add(this._startingTimeAfterHourPicker);
            this.flowLayoutPanel1.Controls.Add(this._startingSpecificTimePicker);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(506, 267);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // _breakDurationLabel
            // 
            this._breakDurationLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._breakDurationLabel.AutoSize = true;
            this._breakDurationLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._breakDurationLabel.Location = new System.Drawing.Point(3, 7);
            this._breakDurationLabel.Name = "_breakDurationLabel";
            this._breakDurationLabel.Size = new System.Drawing.Size(86, 13);
            this._breakDurationLabel.TabIndex = 2;
            this._breakDurationLabel.Text = "Take a break for";
            this._breakDurationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _breakDurationPicker
            // 
            this.flowLayoutPanel1.SetFlowBreak(this._breakDurationPicker, true);
            this._breakDurationPicker.Items.AddRange(new System.TimeSpan2[] {
            new System.TimeSpan2(0, 0, 5, 0),
            new System.TimeSpan2(0, 0, 10, 0),
            new System.TimeSpan2(0, 0, 15, 0),
            new System.TimeSpan2(0, 0, 30, 0),
            new System.TimeSpan2(0, 1, 0, 0)});
            this._breakDurationPicker.Location = new System.Drawing.Point(95, 3);
            this._breakDurationPicker.Name = "_breakDurationPicker";
            this._breakDurationPicker.Size = new System.Drawing.Size(121, 21);
            this._breakDurationPicker.TabIndex = 1;
            this._breakDurationPicker.Value = new System.TimeSpan2(0, 0, 5, 0);
            // 
            // _breakIntervalLabel
            // 
            this._breakIntervalLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._breakIntervalLabel.AutoSize = true;
            this._breakIntervalLabel.Location = new System.Drawing.Point(3, 34);
            this._breakIntervalLabel.Name = "_breakIntervalLabel";
            this._breakIntervalLabel.Size = new System.Drawing.Size(33, 13);
            this._breakIntervalLabel.TabIndex = 3;
            this._breakIntervalLabel.Text = "every";
            this._breakIntervalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _breakIntervalPicker
            // 
            this.flowLayoutPanel1.SetFlowBreak(this._breakIntervalPicker, true);
            this._breakIntervalPicker.Items.AddRange(new System.TimeSpan2[] {
            new System.TimeSpan2(0, 1, 0, 0),
            new System.TimeSpan2(0, 0, 30, 0),
            new System.TimeSpan2(0, 2, 0, 0),
            new System.TimeSpan2(0, 3, 0, 0),
            new System.TimeSpan2(0, 4, 0, 0)});
            this._breakIntervalPicker.Location = new System.Drawing.Point(42, 30);
            this._breakIntervalPicker.Name = "_breakIntervalPicker";
            this._breakIntervalPicker.Size = new System.Drawing.Size(121, 21);
            this._breakIntervalPicker.TabIndex = 4;
            this._breakIntervalPicker.Value = new System.TimeSpan2(0, 1, 0, 0);
            // 
            // _startingTimeLabel
            // 
            this._startingTimeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._startingTimeLabel.AutoSize = true;
            this._startingTimeLabel.Location = new System.Drawing.Point(3, 61);
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
            this._startingTypeDropDown.Location = new System.Drawing.Point(50, 57);
            this._startingTypeDropDown.Name = "_startingTypeDropDown";
            this._startingTypeDropDown.Size = new System.Drawing.Size(121, 21);
            this._startingTypeDropDown.TabIndex = 6;
            // 
            // _startingSpecificTimePicker
            // 
            this._startingSpecificTimePicker.Enabled = false;
            this.flowLayoutPanel1.SetFlowBreak(this._startingSpecificTimePicker, true);
            this._startingSpecificTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._startingSpecificTimePicker.Location = new System.Drawing.Point(3, 84);
            this._startingSpecificTimePicker.Name = "_startingSpecificTimePicker";
            this._startingSpecificTimePicker.ShowUpDown = true;
            this._startingSpecificTimePicker.Size = new System.Drawing.Size(200, 20);
            this._startingSpecificTimePicker.TabIndex = 7;
            this._startingSpecificTimePicker.Visible = false;
            // 
            // _startingTimeAfterHourPicker
            // 
            this._startingTimeAfterHourPicker.Enabled = false;
            this.flowLayoutPanel1.SetFlowBreak(this._startingTimeAfterHourPicker, true);
            this._startingTimeAfterHourPicker.Location = new System.Drawing.Point(177, 57);
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
            // BreakForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(412, 291);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "BreakForm";
            this.Text = "BreakForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._startingTimeAfterHourPicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label _breakDurationLabel;
        private System.Windows.Forms.TimeSpanPicker _breakDurationPicker;
        private System.Windows.Forms.Label _breakIntervalLabel;
        private System.Windows.Forms.TimeSpanPicker _breakIntervalPicker;
        private System.Windows.Forms.Label _startingTimeLabel;
        private System.Windows.Forms.ComboBox _startingTypeDropDown;
        private System.Windows.Forms.DateTimePicker _startingSpecificTimePicker;
        private System.Windows.Forms.NumericUpDown _startingTimeAfterHourPicker;
    }
}