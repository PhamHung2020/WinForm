namespace MyPlan
{
    partial class Plan
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
            this.flowLayoutJob = new System.Windows.Forms.FlowLayoutPanel();
            this.panelDate = new System.Windows.Forms.Panel();
            this.buttonYesterday = new System.Windows.Forms.Button();
            this.buttonTomorrow = new System.Windows.Forms.Button();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.panelJob = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStripItemAddJob = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemToday = new System.Windows.Forms.ToolStripMenuItem();
            this.panelAll.SuspendLayout();
            this.panelDate.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAll
            // 
            this.panelAll.Controls.Add(this.flowLayoutJob);
            this.panelAll.Controls.Add(this.panelDate);
            this.panelAll.Controls.Add(this.panelJob);
            this.panelAll.Location = new System.Drawing.Point(12, 33);
            this.panelAll.Name = "panelAll";
            this.panelAll.Size = new System.Drawing.Size(1138, 716);
            this.panelAll.TabIndex = 0;
            // 
            // flowLayoutJob
            // 
            this.flowLayoutJob.Location = new System.Drawing.Point(4, 68);
            this.flowLayoutJob.Name = "flowLayoutJob";
            this.flowLayoutJob.Size = new System.Drawing.Size(1125, 645);
            this.flowLayoutJob.TabIndex = 2;
            // 
            // panelDate
            // 
            this.panelDate.Controls.Add(this.buttonYesterday);
            this.panelDate.Controls.Add(this.buttonTomorrow);
            this.panelDate.Controls.Add(this.dateTimePickerDate);
            this.panelDate.Location = new System.Drawing.Point(4, 6);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(1125, 55);
            this.panelDate.TabIndex = 1;
            // 
            // buttonYesterday
            // 
            this.buttonYesterday.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYesterday.Location = new System.Drawing.Point(91, 7);
            this.buttonYesterday.Name = "buttonYesterday";
            this.buttonYesterday.Size = new System.Drawing.Size(126, 38);
            this.buttonYesterday.TabIndex = 2;
            this.buttonYesterday.Text = "Hôm qua";
            this.buttonYesterday.UseVisualStyleBackColor = true;
            this.buttonYesterday.Click += new System.EventHandler(this.buttonYesterday_Click);
            // 
            // buttonTomorrow
            // 
            this.buttonTomorrow.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTomorrow.Location = new System.Drawing.Point(893, 7);
            this.buttonTomorrow.Name = "buttonTomorrow";
            this.buttonTomorrow.Size = new System.Drawing.Size(126, 38);
            this.buttonTomorrow.TabIndex = 1;
            this.buttonTomorrow.Text = "Ngày mai";
            this.buttonTomorrow.UseVisualStyleBackColor = true;
            this.buttonTomorrow.Click += new System.EventHandler(this.buttonTomorrow_Click);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDate.Location = new System.Drawing.Point(426, 15);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(255, 22);
            this.dateTimePickerDate.TabIndex = 0;
            this.dateTimePickerDate.ValueChanged += new System.EventHandler(this.dateTimePickerDate_ValueChanged);
            // 
            // panelJob
            // 
            this.panelJob.Location = new System.Drawing.Point(4, 64);
            this.panelJob.Name = "panelJob";
            this.panelJob.Size = new System.Drawing.Size(0, 0);
            this.panelJob.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripItemAddJob,
            this.menuStripItemToday});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1162, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStripItemAddJob
            // 
            this.menuStripItemAddJob.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripItemAddJob.Name = "menuStripItemAddJob";
            this.menuStripItemAddJob.Size = new System.Drawing.Size(107, 26);
            this.menuStripItemAddJob.Text = "Thêm việc";
            this.menuStripItemAddJob.Click += new System.EventHandler(this.menuStripItemAddJob_Click);
            // 
            // menuStripItemToday
            // 
            this.menuStripItemToday.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripItemToday.Name = "menuStripItemToday";
            this.menuStripItemToday.Size = new System.Drawing.Size(94, 26);
            this.menuStripItemToday.Text = "Hôm nay";
            this.menuStripItemToday.Click += new System.EventHandler(this.menuStripItemToday_Click);
            // 
            // Plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 761);
            this.Controls.Add(this.panelAll);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Plan";
            this.Text = "Plan";
            this.panelAll.ResumeLayout(false);
            this.panelDate.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAll;
        private System.Windows.Forms.Panel panelJob;
        private System.Windows.Forms.Panel panelDate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemAddJob;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemToday;
        private System.Windows.Forms.Button buttonYesterday;
        private System.Windows.Forms.Button buttonTomorrow;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutJob;
    }
}