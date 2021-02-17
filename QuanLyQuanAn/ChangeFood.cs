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
    public partial class ChangeFood : Form
    {
        private MonAn changeMonAn = null;
        public MonAn ChangeMonAn
        {
            set { changeMonAn = value; }
            get { return changeMonAn; }
        }
        public ChangeFood(MonAn changeMonAn)
        {
            InitializeComponent();
            ChangeMonAn = changeMonAn;
            textBoxTenMonAn.Text = changeMonAn.Ten;
            textBoxDonGia.Text = (changeMonAn.DonGia).ToString();
            textBoxSoLuong.Text = (changeMonAn.SoLuong).ToString();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            int donGia = -1;
            int soLuong = -1;
            if (!Int32.TryParse(textBoxDonGia.Text, out donGia) || donGia < 0
              || !Int32.TryParse(textBoxSoLuong.Text, out soLuong) || soLuong < 0)
            {
                MessageBox.Show("Bạn hãy nhập đơn giá và số lượng đúng");
            }
            else
            {
                DialogResult res = MessageBox.Show("Bạn đã chắc chắn chưa?", "Change Food", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    changeMonAn = new MonAn(textBoxTenMonAn.Text, donGia, soLuong);
                    this.Close();
                }
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
