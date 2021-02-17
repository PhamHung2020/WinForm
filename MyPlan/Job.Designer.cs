namespace MyPlan
{
    partial class Job
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxIsDone = new System.Windows.Forms.CheckBox();
            this.textBoxContentJob = new System.Windows.Forms.TextBox();
            this.numericUpDownFromHour = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFromMinute = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownToHour = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownToMinute = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFromHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFromMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownToHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownToMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxIsDone
            // 
            this.checkBoxIsDone.AutoSize = true;
            this.checkBoxIsDone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIsDone.Location = new System.Drawing.Point(4, 4);
            this.checkBoxIsDone.Name = "checkBoxIsDone";
            this.checkBoxIsDone.Size = new System.Drawing.Size(18, 17);
            this.checkBoxIsDone.TabIndex = 0;
            this.checkBoxIsDone.UseVisualStyleBackColor = true;
            // 
            // textBoxContentJob
            // 
            this.textBoxContentJob.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContentJob.Location = new System.Drawing.Point(28, 4);
            this.textBoxContentJob.Name = "textBoxContentJob";
            this.textBoxContentJob.Size = new System.Drawing.Size(491, 30);
            this.textBoxContentJob.TabIndex = 1;
            // 
            // numericUpDownFromHour
            // 
            this.numericUpDownFromHour.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownFromHour.Location = new System.Drawing.Point(525, 4);
            this.numericUpDownFromHour.Name = "numericUpDownFromHour";
            this.numericUpDownFromHour.Size = new System.Drawing.Size(55, 30);
            this.numericUpDownFromHour.TabIndex = 2;
            // 
            // numericUpDownFromMinute
            // 
            this.numericUpDownFromMinute.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownFromMinute.Location = new System.Drawing.Point(586, 4);
            this.numericUpDownFromMinute.Name = "numericUpDownFromMinute";
            this.numericUpDownFromMinute.Size = new System.Drawing.Size(55, 30);
            this.numericUpDownFromMinute.TabIndex = 3;
            // 
            // numericUpDownToHour
            // 
            this.numericUpDownToHour.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownToHour.Location = new System.Drawing.Point(695, 6);
            this.numericUpDownToHour.Name = "numericUpDownToHour";
            this.numericUpDownToHour.Size = new System.Drawing.Size(55, 30);
            this.numericUpDownToHour.TabIndex = 4;
            // 
            // numericUpDownToMinute
            // 
            this.numericUpDownToMinute.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownToMinute.Location = new System.Drawing.Point(765, 6);
            this.numericUpDownToMinute.Name = "numericUpDownToMinute";
            this.numericUpDownToMinute.Size = new System.Drawing.Size(55, 30);
            this.numericUpDownToMinute.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(647, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Đến";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(826, 7);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(130, 30);
            this.comboBoxStatus.TabIndex = 7;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // buttonModify
            // 
            this.buttonModify.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModify.Location = new System.Drawing.Point(962, 7);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(75, 37);
            this.buttonModify.TabIndex = 8;
            this.buttonModify.Text = "Sửa";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(1043, 7);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 37);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownToMinute);
            this.Controls.Add(this.numericUpDownToHour);
            this.Controls.Add(this.numericUpDownFromMinute);
            this.Controls.Add(this.numericUpDownFromHour);
            this.Controls.Add(this.textBoxContentJob);
            this.Controls.Add(this.checkBoxIsDone);
            this.Name = "Job";
            this.Size = new System.Drawing.Size(1126, 48);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFromHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFromMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownToHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownToMinute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxIsDone;
        private System.Windows.Forms.TextBox textBoxContentJob;
        private System.Windows.Forms.NumericUpDown numericUpDownFromHour;
        private System.Windows.Forms.NumericUpDown numericUpDownFromMinute;
        private System.Windows.Forms.NumericUpDown numericUpDownToHour;
        private System.Windows.Forms.NumericUpDown numericUpDownToMinute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonDelete;
    }
}
