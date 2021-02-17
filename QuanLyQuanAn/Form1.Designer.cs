namespace QuanLyQuanAn
{
    partial class FormDangNhap
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
            this.labelID = new System.Windows.Forms.Label();
            this.labelPasword = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxPasword = new System.Windows.Forms.TextBox();
            this.buttonDangNhap = new System.Windows.Forms.Button();
            this.buttonKhach = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(61, 78);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(123, 26);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "Tài khoản:";
            // 
            // labelPasword
            // 
            this.labelPasword.AutoSize = true;
            this.labelPasword.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasword.Location = new System.Drawing.Point(61, 195);
            this.labelPasword.Name = "labelPasword";
            this.labelPasword.Size = new System.Drawing.Size(120, 26);
            this.labelPasword.TabIndex = 1;
            this.labelPasword.Text = "Mật khẩu:";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(212, 70);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(443, 34);
            this.textBoxID.TabIndex = 2;
            // 
            // textBoxPasword
            // 
            this.textBoxPasword.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasword.Location = new System.Drawing.Point(212, 187);
            this.textBoxPasword.Name = "textBoxPasword";
            this.textBoxPasword.Size = new System.Drawing.Size(443, 34);
            this.textBoxPasword.TabIndex = 3;
            this.textBoxPasword.UseSystemPasswordChar = true;
            // 
            // buttonDangNhap
            // 
            this.buttonDangNhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDangNhap.Location = new System.Drawing.Point(66, 283);
            this.buttonDangNhap.Name = "buttonDangNhap";
            this.buttonDangNhap.Size = new System.Drawing.Size(173, 43);
            this.buttonDangNhap.TabIndex = 4;
            this.buttonDangNhap.Text = "Đăng nhập";
            this.buttonDangNhap.UseVisualStyleBackColor = true;
            this.buttonDangNhap.Click += new System.EventHandler(this.buttonDangNhap_Click);
            // 
            // buttonKhach
            // 
            this.buttonKhach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKhach.Location = new System.Drawing.Point(281, 283);
            this.buttonKhach.Name = "buttonKhach";
            this.buttonKhach.Size = new System.Drawing.Size(173, 43);
            this.buttonKhach.TabIndex = 5;
            this.buttonKhach.Text = "Khách";
            this.buttonKhach.UseVisualStyleBackColor = true;
            this.buttonKhach.Click += new System.EventHandler(this.buttonKhach_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonThoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(482, 283);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(173, 43);
            this.buttonThoat.TabIndex = 6;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // FormDangNhap
            // 
            this.AcceptButton = this.buttonDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonThoat;
            this.ClientSize = new System.Drawing.Size(708, 374);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonKhach);
            this.Controls.Add(this.buttonDangNhap);
            this.Controls.Add(this.textBoxPasword);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelPasword);
            this.Controls.Add(this.labelID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelPasword;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxPasword;
        private System.Windows.Forms.Button buttonDangNhap;
        private System.Windows.Forms.Button buttonKhach;
        private System.Windows.Forms.Button buttonThoat;
    }
}

