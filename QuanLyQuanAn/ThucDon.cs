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
    public partial class ThucDon : Form
    {
        bool goiMon = false;
        private User loginUser;
        public event EventHandler DangXuat;
        public bool isShowing = true;
        public ThucDon(User user)
        {
            InitializeComponent();
            if (user != null)
            {
                loginUser = user;
            }
            else
            {
                loginUser = new User();
            }
            LoadLoginUser();
            LoadThucDon();
            LoadCacMonDaChon();
        }

        private void LoadLoginUser()
        {
            Binding databinding = new Binding("Text", loginUser, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxLoginUser.DataBindings.Add(databinding);
            if (loginUser.LoaiUser == TypeUser.NHANVIEN)
            {
                PhanQuyen(true);
            }
            else
            {
                PhanQuyen(false);
            }
        }

        private void LoadThucDon()
        {
            listViewThucDon.Columns.Add(new ColumnHeader() { Text = "Tên món ăn", Width = 200});
            listViewThucDon.Columns.Add(new ColumnHeader() { Text = "Đơn giá" });
            listViewThucDon.Columns.Add(new ColumnHeader() { Text = "Số lượng" });
            //listViewThucDon.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            foreach (MonAn monAn in DanhSachMonAn.Instance.DsMonAn)
            {
                ListViewItem newItem = new ListViewItem(monAn.Ten);
                newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = monAn.DonGia.ToString()});
                newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = monAn.SoLuong.ToString() });
                listViewThucDon.Items.Add(newItem);
            }
        }

        private void LoadCacMonDaChon()
        {
            listViewMonDaChon.Columns.Add(new ColumnHeader() { Text = "Tên món ăn", Width = 200});
            listViewMonDaChon.Columns.Add(new ColumnHeader() { Text = "Đơn giá" });
            listViewMonDaChon.Columns.Add(new ColumnHeader() { Text = "Số lượng" });
            listViewMonDaChon.Columns.Add(new ColumnHeader() { Text = "Thành tiền", Width = 100 });
        }

        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            DangXuat?.Invoke(this, new EventArgs());
        }

        private void ThoatChuongTrinh()
        {
            if (isShowing)
                Application.Exit();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            ThoatChuongTrinh();
        }

        private void ThucDon_Closed(object sender, FormClosedEventArgs e)
        {
            ThoatChuongTrinh();
        }

        private void PhanQuyen(bool isEnable)
        {
            buttonThem.Enabled = buttonXoa.Enabled = buttonSua.Enabled = buttonThoat.Enabled = isEnable;
            buttonGoiMon.Enabled = buttonTinhTien.Enabled = !isEnable;
        }

        private void DoubleClickItem(ListView fromList, ListView toList, int amount)
        {
            if (loginUser.LoaiUser == TypeUser.NHANVIEN)
                return;
            ListViewItem selectedItem = fromList.SelectedItems[0];
            if (selectedItem == null)
                return;
            ListViewItem newItem = selectedItem.Clone() as ListViewItem;

            bool isContain = false;
            int index = 0;
            foreach (ListViewItem item in toList.Items)
            {
                if (newItem.Text == item.Text)
                {
                    isContain = true;
                    index = toList.Items.IndexOf(item);
                    newItem = item;
                    break;
                }
            }

            int currentAmount;
            if (!isContain)
            {
                currentAmount = Int32.Parse(selectedItem.SubItems[(int)COLUMNHEADER.SoLuong].Text);
                if (currentAmount - amount >= 0)
                {
                    currentAmount -= amount;
                    newItem.SubItems[(int)COLUMNHEADER.SoLuong].Text = amount.ToString();
                }
                else
                {
                    newItem.SubItems[(int)COLUMNHEADER.SoLuong].Text = currentAmount.ToString();
                    currentAmount = 0;
                }
                selectedItem.SubItems[(int)COLUMNHEADER.SoLuong].Text = currentAmount.ToString();
                //DanhSachMonAn.Instance.DsMonAn[listViewThucDon.SelectedIndices[0]].SoLuong = currentAmount;
                if (toList.Name == listViewMonDaChon.Name)
                {
                    newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "0" });
                }
                toList.Items.Add(newItem);
            }
            else
            {
                currentAmount = Int32.Parse(selectedItem.SubItems[(int)COLUMNHEADER.SoLuong].Text);
                int chosenAmount = Int32.Parse(newItem.SubItems[(int)COLUMNHEADER.SoLuong].Text);
                if (currentAmount - amount >= 0)
                {
                    currentAmount -= amount;
                    newItem.SubItems[(int)COLUMNHEADER.SoLuong].Text = (chosenAmount + amount).ToString();
                }
                else
                {
                    newItem.SubItems[(int)COLUMNHEADER.SoLuong].Text = (chosenAmount + currentAmount).ToString();
                    currentAmount = 0;
                }
                selectedItem.SubItems[(int)COLUMNHEADER.SoLuong].Text = currentAmount.ToString();
                //DanhSachMonAn.Instance.DsMonAn[listViewThucDon.SelectedIndices[0]].SoLuong = currentAmount;
            }

            if (fromList.Name == listViewThucDon.Name)
            {
                DanhSachMonAn.Instance.DsMonAn[listViewThucDon.SelectedIndices[0]].SoLuong = currentAmount;
            }
            else
            {
                int indexOfItem = 0;
                foreach (ListViewItem item in listViewThucDon.Items)
                {
                    if (item.Text == listViewMonDaChon.SelectedItems[0].Text)
                    {
                        indexOfItem = listViewThucDon.Items.IndexOf(item);
                        break;
                    }
                }
                DanhSachMonAn.Instance.DsMonAn[indexOfItem].SoLuong = Int32.Parse(listViewThucDon.Items[indexOfItem].SubItems[(int)COLUMNHEADER.SoLuong].Text);
            }

            foreach (ListViewItem item in listViewMonDaChon.Items)
            {
                int donGia = Int32.Parse(item.SubItems[(int)COLUMNHEADER.DonGia].Text);
                int soLuong = Int32.Parse(item.SubItems[(int)COLUMNHEADER.SoLuong].Text);
                item.SubItems[(int)COLUMNHEADER.ThanhTien].Text = (soLuong * donGia).ToString();
            }

            int tong = 0;
            foreach (ListViewItem item in listViewMonDaChon.Items)
            {
                tong += Int32.Parse(item.SubItems[(int)COLUMNHEADER.ThanhTien].Text);
            }
            textBoxTongTien.Text = tong.ToString() + " VND";
        }

        private void listViewThucDon_DoubleClick(object sender, EventArgs e)
        {
            DoubleClickItem(sender as ListView, listViewMonDaChon, 10);
        }

        private void listViewMonDaChon_DoubleClick(object sender, EventArgs e)
        {
            DoubleClickItem(sender as ListView, listViewThucDon, 10);
        }

        private void buttonGoiMon_Click(object sender, EventArgs e)
        {
            if (listViewMonDaChon.Items.Count == 0)
            {
                MessageBox.Show("Xin mời bạn chọn món ăn");
            }
            else
            {
                DialogResult res = MessageBox.Show("Bạn đã chắc chắn chưa?", "Gọi món", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    MessageBox.Show("Bạn đã gọi món thành công!!");
                    goiMon = true;
                }
            }    
        }

        private void buttonTinhTien_Click(object sender, EventArgs e)
        {
            if (goiMon)
            {
                MessageBox.Show("Tổng hóa đơn: " + textBoxTongTien.Text + " VND");
                buttonDangXuat.PerformClick();
            }
            else
            {
                MessageBox.Show("Bạn chưa gọi món ăn");
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            ListViewItem item = listViewThucDon.SelectedItems[0];
            if (item == null)
                return;
            DanhSachMonAn.Instance.DsMonAn.RemoveAt(listViewThucDon.SelectedIndices[0]);
            listViewThucDon.Items.Remove(item);
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            AddFood addFood = new AddFood();
            addFood.FormClosed += AddNewFood;
            addFood.ShowDialog();
        }

        private void AddNewFood(object sender, EventArgs e)
        {
            MonAn newFood = (sender as AddFood).NewMonAn;
            if (newFood == null)
                return;
            DanhSachMonAn.Instance.DsMonAn.Add(newFood);
            ListViewItem newItem = new ListViewItem(newFood.Ten);
            newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = newFood.DonGia.ToString() });
            newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = newFood.SoLuong.ToString() });
            listViewThucDon.Items.Add(newItem);
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (listViewThucDon.SelectedItems.Count == 0)
                return;
            ListViewItem selectedItem = listViewThucDon.SelectedItems[0];
            MonAn changeMonAn = DanhSachMonAn.Instance.DsMonAn[listViewThucDon.Items.IndexOf(selectedItem)];
            ChangeFood changeFood = new ChangeFood(changeMonAn);
            changeFood.FormClosed += ChangeFood_FormClosed;
            changeFood.ShowDialog();

        }

        private void ChangeFood_FormClosed(object sender, FormClosedEventArgs e)
        {
            MonAn changedMonAn = (sender as ChangeFood).ChangeMonAn;

            
            ListViewItem selectedItem = listViewThucDon.SelectedItems[0];
            MonAn changeMonAn = DanhSachMonAn.Instance.DsMonAn[listViewThucDon.Items.IndexOf(selectedItem)];

            changeMonAn.Ten = changedMonAn.Ten;
            changeMonAn.DonGia = changedMonAn.DonGia;
            changeMonAn.SoLuong = changedMonAn.SoLuong;

            selectedItem.Text = changedMonAn.Ten;
            selectedItem.SubItems[(int)COLUMNHEADER.DonGia].Text = changedMonAn.DonGia.ToString();
            selectedItem.SubItems[(int)COLUMNHEADER.SoLuong].Text = changedMonAn.SoLuong.ToString();
        }
    }

    public enum COLUMNHEADER
    {
        TenMonAn,
        DonGia,
        SoLuong,
        ThanhTien,
    }
}
