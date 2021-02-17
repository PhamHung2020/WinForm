namespace QuanLyQuanAn
{
    partial class AddFood
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTenMonAn = new System.Windows.Forms.TextBox();
            this.textBoxDonGia = new System.Windows.Forms.TextBox();
            this.textBoxSoLuong = new System.Windows.Forms.TextBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên món ăn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng";
            // 
            // textBoxTenMonAn
            // 
            this.textBoxTenMonAn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenMonAn.Location = new System.Drawing.Point(249, 55);
            this.textBoxTenMonAn.Name = "textBoxTenMonAn";
            this.textBoxTenMonAn.Size = new System.Drawing.Size(357, 34);
            this.textBoxTenMonAn.TabIndex = 3;
            // 
            // textBoxDonGia
            // 
            this.textBoxDonGia.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDonGia.Location = new System.Drawing.Point(249, 146);
            this.textBoxDonGia.Name = "textBoxDonGia";
            this.textBoxDonGia.Size = new System.Drawing.Size(357, 34);
            this.textBoxDonGia.TabIndex = 4;
            // 
            // textBoxSoLuong
            // 
            this.textBoxSoLuong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoLuong.Location = new System.Drawing.Point(249, 232);
            this.textBoxSoLuong.Name = "textBoxSoLuong";
            this.textBoxSoLuong.Size = new System.Drawing.Size(357, 34);
            this.textBoxSoLuong.TabIndex = 5;
            // 
            // buttonThem
            // 
            this.buttonThem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Location = new System.Drawing.Point(249, 332);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(102, 46);
            this.buttonThem.TabIndex = 6;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonThoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(504, 332);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(102, 46);
            this.buttonThoat.TabIndex = 7;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // AddFood
            // 
            this.AcceptButton = this.buttonThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonThoat;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.textBoxSoLuong);
            this.Controls.Add(this.textBoxDonGia);
            this.Controls.Add(this.textBoxTenMonAn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddFood";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTenMonAn;
        private System.Windows.Forms.TextBox textBoxDonGia;
        private System.Windows.Forms.TextBox textBoxSoLuong;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonThoat;
    }
}