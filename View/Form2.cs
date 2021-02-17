using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class Form2 : Form
    {
        StatusBar bar = new StatusBar();
        public Form2()
        {
            InitializeComponent();
            bar.Text = "Status Bar";
            this.Controls.Add(bar);
            LoadTree();
            
        }

        private void LoadTree()
        {
            string path = "C:\\Users\\ACER\\Desktop\\WinForm\\";
            TreeNode root = new TreeNode() { Text = path, Tag = path };
            treeView1.Nodes.Add(root);
            AddTreeNode(ref root, path);
        }

        private void AddTreeNode(ref TreeNode root, string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);

            foreach (var item in dir.GetDirectories())
            {
                TreeNode node = new TreeNode(item.Name) { Tag = item.FullName };
                AddTreeNode(ref node, item.FullName);
                root.Nodes.Add(node);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeView treeView = sender as TreeView;
            TreeNode treeNode = treeView.SelectedNode;
            if (treeNode == null)
                return;
            listView1.Clear();
            DirectoryInfo dir = new DirectoryInfo(treeNode.Tag.ToString());

            foreach (var item in dir.GetDirectories())
            {
                listView1.Items.Add(new ListViewItem() { Text = item.Name,
                                                         ImageIndex = 0});
            }

            foreach (var item in dir.GetFiles())
            {
                Icon icon = Icon.ExtractAssociatedIcon(item.FullName);
                imageList1.Images.Add(icon);
                listView1.Items.Add(new ListViewItem()
                {
                    Text = item.Name,
                    ImageIndex = imageList1.Images.Count - 1
                });
            }

            bar.Text = dir.FullName + " " + dir.CreationTime.ToString();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null || listView1.SelectedItems.Count <= 0)
            {
                return;
            }

            string path = treeView1.SelectedNode.Tag + "\\" + listView1.SelectedItems[0].Text;
            try
            {
                FileInfo file = new FileInfo(path);
                bar.Text = file.FullName + " " + file.Length + " " + file.CreationTime.ToString();
            }
            catch
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                bar.Text = dir.FullName;
            }
        }
    }
}
