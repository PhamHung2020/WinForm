namespace QuanLyQuanAn
{
    partial class ChangeFood
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
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên món ăn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số lượng";
            // 
            // textBoxTenMonAn
            // 
            this.textBoxTenMonAn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenMonAn.Location = new System.Drawing.Point(245, 72);
            this.textBoxTenMonAn.Name = "textBoxTenMonAn";
            this.textBoxTenMonAn.Size = new System.Drawing.Size(357, 34);
            this.textBoxTenMonAn.TabIndex = 4;
            // 
            // textBoxDonGia
            // 
            this.textBoxDonGia.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDonGia.Location = new System.Drawing.Point(245, 179);
            this.textBoxDonGia.Name = "textBoxDonGia";
            this.textBoxDonGia.Size = new System.Drawing.Size(357, 34);
            this.textBoxDonGia.TabIndex = 5;
            // 
            // textBoxSoLuong
            // 
            this.textBoxSoLuong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoLuong.Location = new System.Drawing.Point(245, 283);
            this.textBoxSoLuong.Name = "textBoxSoLuong";
            this.textBoxSoLuong.Size = new System.Drawing.Size(357, 34);
            this.textBoxSoLuong.TabIndex = 6;
            // 
            // buttonSua
            // 
            this.buttonSua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.Location = new System.Drawing.Point(245, 364);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(102, 46);
            this.buttonSua.TabIndex = 7;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(500, 364);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(102, 46);
            this.buttonThoat.TabIndex = 8;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // ChangeFood
            // 
            this.AcceptButton = this.buttonSua;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonThoat;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.textBoxSoLuong);
            this.Controls.Add(this.textBoxDonGia);
            this.Controls.Add(this.textBoxTenMonAn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangeFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeFood";
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
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonThoat;
    }
}