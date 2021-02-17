using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public partial class FormDangNhap : Form
    {
        User NhanVien = new User() { Name = "pmh", Pass = "123456", LoaiUser = TypeUser.NHANVIEN};

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private bool DangNhapDung(string id, string password)
        {
            if (id == NhanVien.Name && password == NhanVien.Pass)
                return true;
            else
                return false;
        }

        private void DangNhap(User user)
        {
            ThucDon thucDon = new ThucDon(user);
            thucDon.Show();
            thucDon.DangXuat += ThucDon_DangXuat;

            ClearTextBox();
            this.Hide();
        }

        private void ClearTextBox()
        {
            foreach (var item in this.Controls)
            {
                TextBox textBox = item as TextBox;
                if (textBox != null)
                {
                    textBox.Clear();
                }
            }
            textBoxID.Focus();
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            if (DangNhapDung(textBoxID.Text, textBoxPasword.Text))
            {
                DangNhap(NhanVien);
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "FAILED!", MessageBoxButtons.OK);
            }
        }

        private void ThucDon_DangXuat(object sender, EventArgs e)
        {
            (sender as ThucDon).isShowing = false;
            (sender as ThucDon).Close();
            this.Show();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonKhach_Click(object sender, EventArgs e)
        {
            DangNhap(null);
        }
    }
}
