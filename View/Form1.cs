using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class Form1 : Form
    {
        private List<Subject> subjects = new List<Subject>();
        public Form1()
        {
            InitializeComponent();
            LoadSubjects();
            LoadItem();
        }

        private void LoadSubjects()
        {
            subjects.Add(new Subject("Toán", 9.8));
            subjects.Add(new Subject("Lý", 9.5));
            subjects.Add(new Subject("Hóa", 8.3));
            subjects.Add(new Subject("Văn", 7.8));
        }

        private void LoadItem()
        {
            listView1.Columns.Add(new ColumnHeader() { Text = "Môn học" });
            listView1.Columns.Add(new ColumnHeader() { Text = "Điểm" });
            listView1.Columns.Add(new ColumnHeader() { Text = "Xếp hạng" });

            int i = 0;
            foreach (Subject item in subjects)
            {
                ListViewItem listViewItem = new ListViewItem(item.ToString());
                listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.Score.ToString() });
                listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.Rank() });
                listViewItem.ImageIndex = i;
                listView1.Items.Add(listViewItem);
                ++i;
            }
        }

        private void buttonLargeIcon_Click(object sender, EventArgs e)
        {
            listView1.View = System.Windows.Forms.View.LargeIcon;
        }

        private void buttonSmallIcon_Click(object sender, EventArgs e)
        {
            listView1.View = System.Windows.Forms.View.SmallIcon;
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            listView1.View = System.Windows.Forms.View.List;
        }

        private void buttonDetail_Click(object sender, EventArgs e)
        {
            listView1.View = System.Windows.Forms.View.Details;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void n(object sender, EventArgs e)
        {

        }
    }
}
