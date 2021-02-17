namespace MyPlan
{
    partial class Form1
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
            this.panelAll = new System.Windows.Forms.Panel();
            this.panelDateTimeControl = new System.Windows.Forms.Panel();
            this.panelNotify = new System.Windows.Forms.Panel();
            this.numericUpDownNotify = new System.Windows.Forms.NumericUpDown();
            this.checkBoxNotify = new System.Windows.Forms.CheckBox();
            this.buttonToday = new System.Windows.Forms.Button();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.panelCalendar = new System.Windows.Forms.Panel();
            this.panelDaysOfMonth = new System.Windows.Forms.Panel();
            this.panelDaysOfWeek = new System.Windows.Forms.Panel();
            this.buttonNextMonth = new System.Windows.Forms.Button();
            this.buttonPreviousMonth = new System.Windows.Forms.Button();
            this.labelSunday = new System.Windows.Forms.Label();
            this.labelSaturday = new System.Windows.Forms.Label();
            this.labelFriday = new System.Windows.Forms.Label();
            this.labelThursday = new System.Windows.Forms.Label();
            this.labelWednesday = new System.Windows.Forms.Label();
            this.labelTuesday = new System.Windows.Forms.Label();
            this.labelMonday = new System.Windows.Forms.Label();
            this.panelAll.SuspendLayout();
            this.panelDateTimeControl.SuspendLayout();
            this.panelNotify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNotify)).BeginInit();
            this.panelCalendar.SuspendLayout();
            this.panelDaysOfWeek.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAll
            // 
            this.panelAll.Controls.Add(this.panelDateTimeControl);
            this.panelAll.Controls.Add(this.panelCalendar);
            this.panelAll.Location = new System.Drawing.Point(12, 12);
            this.panelAll.Name = "panelAll";
            this.panelAll.Size = new System.Drawing.Size(1241, 730);
            this.panelAll.TabIndex = 0;
            // 
            // panelDateTimeControl
            // 
            this.panelDateTimeControl.Controls.Add(this.panelNotify);
            this.panelDateTimeControl.Controls.Add(this.buttonToday);
            this.panelDateTimeControl.Controls.Add(this.dateTimePickerDate);
            this.panelDateTimeControl.Location = new System.Drawing.Point(3, 3);
            this.panelDateTimeControl.Name = "panelDateTimeControl";
            this.panelDateTimeControl.Size = new System.Drawing.Size(1232, 61);
            this.panelDateTimeControl.TabIndex = 1;
            // 
            // panelNotify
            // 
            this.panelNotify.Controls.Add(this.numericUpDownNotify);
            this.panelNotify.Controls.Add(this.checkBoxNotify);
            this.panelNotify.Location = new System.Drawing.Point(7, 3);
            this.panelNotify.Name = "panelNotify";
            this.panelNotify.Size = new System.Drawing.Size(339, 55);
            this.panelNotify.TabIndex = 2;
            // 
            // numericUpDownNotify
            // 
            this.numericUpDownNotify.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownNotify.Location = new System.Drawing.Point(143, 9);
            this.numericUpDownNotify.Maximum = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.numericUpDownNotify.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNotify.Name = "numericUpDownNotify";
            this.numericUpDownNotify.Size = new System.Drawing.Size(180, 30);
            this.numericUpDownNotify.TabIndex = 1;
            this.numericUpDownNotify.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBoxNotify
            // 
            this.checkBoxNotify.AutoSize = true;
            this.checkBoxNotify.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNotify.Location = new System.Drawing.Point(3, 10);
            this.checkBoxNotify.Name = "checkBoxNotify";
            this.checkBoxNotify.Size = new System.Drawing.Size(115, 26);
            this.checkBoxNotify.TabIndex = 0;
            this.checkBoxNotify.Text = "Thông báo";
            this.checkBoxNotify.UseVisualStyleBackColor = true;
            // 
            // buttonToday
            // 
            this.buttonToday.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToday.Location = new System.Drawing.Point(728, 8);
            this.buttonToday.Name = "buttonToday";
            this.buttonToday.Size = new System.Drawing.Size(152, 34);
            this.buttonToday.TabIndex = 1;
            this.buttonToday.Text = "Hôm nay";
            this.buttonToday.UseVisualStyleBackColor = true;
            this.buttonToday.Click += new System.EventHandler(this.buttonToday_Click);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDate.Location = new System.Drawing.Point(464, 13);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(245, 22);
            this.dateTimePickerDate.TabIndex = 0;
            this.dateTimePickerDate.ValueChanged += new System.EventHandler(this.dateTimePickerDate_ValueChanged);
            // 
            // panelCalendar
            // 
            this.panelCalendar.Controls.Add(this.panelDaysOfMonth);
            this.panelCalendar.Controls.Add(this.panelDaysOfWeek);
            this.panelCalendar.Location = new System.Drawing.Point(3, 70);
            this.panelCalendar.Name = "panelCalendar";
            this.panelCalendar.Size = new System.Drawing.Size(1235, 657);
            this.panelCalendar.TabIndex = 0;
            // 
            // panelDaysOfMonth
            // 
            this.panelDaysOfMonth.Location = new System.Drawing.Point(161, 92);
            this.panelDaysOfMonth.Name = "panelDaysOfMonth";
            this.panelDaysOfMonth.Size = new System.Drawing.Size(954, 565);
            this.panelDaysOfMonth.TabIndex = 1;
            // 
            // panelDaysOfWeek
            // 
            this.panelDaysOfWeek.Controls.Add(this.buttonNextMonth);
            this.panelDaysOfWeek.Controls.Add(this.buttonPreviousMonth);
            this.panelDaysOfWeek.Controls.Add(this.labelSunday);
            this.panelDaysOfWeek.Controls.Add(this.labelSaturday);
            this.panelDaysOfWeek.Controls.Add(this.labelFriday);
            this.panelDaysOfWeek.Controls.Add(this.labelThursday);
            this.panelDaysOfWeek.Controls.Add(this.labelWednesday);
            this.panelDaysOfWeek.Controls.Add(this.labelTuesday);
            this.panelDaysOfWeek.Controls.Add(this.labelMonday);
            this.panelDaysOfWeek.Location = new System.Drawing.Point(4, 14);
            this.panelDaysOfWeek.Name = "panelDaysOfWeek";
            this.panelDaysOfWeek.Size = new System.Drawing.Size(1228, 69);
            this.panelDaysOfWeek.TabIndex = 0;
            // 
            // buttonNextMonth
            // 
            this.buttonNextMonth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNextMonth.Location = new System.Drawing.Point(1098, 16);
            this.buttonNextMonth.Name = "buttonNextMonth";
            this.buttonNextMonth.Size = new System.Drawing.Size(127, 35);
            this.buttonNextMonth.TabIndex = 7;
            this.buttonNextMonth.Text = "Tháng sau";
            this.buttonNextMonth.UseVisualStyleBackColor = true;
            this.buttonNextMonth.Click += new System.EventHandler(this.buttonNextMonth_Click);
            // 
            // buttonPreviousMonth
            // 
            this.buttonPreviousMonth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPreviousMonth.Location = new System.Drawing.Point(3, 16);
            this.buttonPreviousMonth.Name = "buttonPreviousMonth";
            this.buttonPreviousMonth.Size = new System.Drawing.Size(153, 35);
            this.buttonPreviousMonth.TabIndex = 2;
            this.buttonPreviousMonth.Text = "Tháng trước";
            this.buttonPreviousMonth.UseVisualStyleBackColor = true;
            this.buttonPreviousMonth.Click += new System.EventHandler(this.buttonPreviousMonth_Click);
            // 
            // labelSunday
            // 
            this.labelSunday.AutoSize = true;
            this.labelSunday.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunday.Location = new System.Drawing.Point(995, 22);
            this.labelSunday.Name = "labelSunday";
            this.labelSunday.Size = new System.Drawing.Size(86, 23);
            this.labelSunday.TabIndex = 6;
            this.labelSunday.Text = "Chủ nhật";
            // 
            // labelSaturday
            // 
            this.labelSaturday.AutoSize = true;
            this.labelSaturday.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaturday.Location = new System.Drawing.Point(869, 22);
            this.labelSaturday.Name = "labelSaturday";
            this.labelSaturday.Size = new System.Drawing.Size(60, 23);
            this.labelSaturday.TabIndex = 5;
            this.labelSaturday.Text = "Thứ 7";
            // 
            // labelFriday
            // 
            this.labelFriday.AutoSize = true;
            this.labelFriday.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriday.Location = new System.Drawing.Point(733, 22);
            this.labelFriday.Name = "labelFriday";
            this.labelFriday.Size = new System.Drawing.Size(60, 23);
            this.labelFriday.TabIndex = 4;
            this.labelFriday.Text = "Thứ 6";
            // 
            // labelThursday
            // 
            this.labelThursday.AutoSize = true;
            this.labelThursday.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThursday.Location = new System.Drawing.Point(600, 23);
            this.labelThursday.Name = "labelThursday";
            this.labelThursday.Size = new System.Drawing.Size(60, 23);
            this.labelThursday.TabIndex = 3;
            this.labelThursday.Text = "Thứ 5";
            // 
            // labelWednesday
            // 
            this.labelWednesday.AutoSize = true;
            this.labelWednesday.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWednesday.Location = new System.Drawing.Point(456, 22);
            this.labelWednesday.Name = "labelWednesday";
            this.labelWednesday.Size = new System.Drawing.Size(60, 23);
            this.labelWednesday.TabIndex = 2;
            this.labelWednesday.Text = "Thứ 4";
            // 
            // labelTuesday
            // 
            this.labelTuesday.AutoSize = true;
            this.labelTuesday.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTuesday.Location = new System.Drawing.Point(316, 23);
            this.labelTuesday.Name = "labelTuesday";
            this.labelTuesday.Size = new System.Drawing.Size(60, 23);
            this.labelTuesday.TabIndex = 1;
            this.labelTuesday.Text = "Thứ 3";
            // 
            // labelMonday
            // 
            this.labelMonday.AutoSize = true;
            this.labelMonday.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonday.Location = new System.Drawing.Point(175, 23);
            this.labelMonday.Name = "labelMonday";
            this.labelMonday.Size = new System.Drawing.Size(60, 23);
            this.labelMonday.TabIndex = 0;
            this.labelMonday.Text = "Thứ 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 787);
            this.Controls.Add(this.panelAll);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyPlan App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panelAll.ResumeLayout(false);
            this.panelDateTimeControl.ResumeLayout(false);
            this.panelNotify.ResumeLayout(false);
            this.panelNotify.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNotify)).EndInit();
            this.panelCalendar.ResumeLayout(false);
            this.panelDaysOfWeek.ResumeLayout(false);
            this.panelDaysOfWeek.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAll;
        private System.Windows.Forms.Panel panelDateTimeControl;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Panel panelCalendar;
        private System.Windows.Forms.Panel panelDaysOfMonth;
        private System.Windows.Forms.Panel panelDaysOfWeek;
        private System.Windows.Forms.Button buttonToday;
        private System.Windows.Forms.Button buttonNextMonth;
        private System.Windows.Forms.Button buttonPreviousMonth;
        private System.Windows.Forms.Label labelSunday;
        private System.Windows.Forms.Label labelSaturday;
        private System.Windows.Forms.Label labelFriday;
        private System.Windows.Forms.Label labelThursday;
        private System.Windows.Forms.Label labelWednesday;
        private System.Windows.Forms.Label labelTuesday;
        private System.Windows.Forms.Label labelMonday;
        private System.Windows.Forms.Panel panelNotify;
        private System.Windows.Forms.NumericUpDown numericUpDownNotify;
        private System.Windows.Forms.CheckBox checkBoxNotify;
    }
}

