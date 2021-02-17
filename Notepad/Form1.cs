using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class FormNotepad : Form
    {
        private string fileName = "Noname";
        public FormNotepad()
        {
            InitializeComponent();
        }

        private void SaveSetting()
        {
            Properties.Settings.Default.Location = this.Location;
            Properties.Settings.Default.Height = this.Height;
            Properties.Settings.Default.Width = this.Width;
            Properties.Settings.Default.Font = textBoxWrite.Font;
            Properties.Settings.Default.WordWrap = textBoxWrite.WordWrap;
            Properties.Settings.Default.Save();
        }

        private void LoadSetting()
        {
            this.Location = Properties.Settings.Default.Location;
            this.Height = Properties.Settings.Default.Height;
            this.Width = Properties.Settings.Default.Width;
            textBoxWrite.Font = Properties.Settings.Default.Font;
            textBoxWrite.WordWrap = Properties.Settings.Default.WordWrap;
            wordWrapToolStripMenuItem.Checked = textBoxWrite.WordWrap;
        }

        private void FormNotepad_Load(object sender, EventArgs e)
        {
            LoadSetting();
            this.Text = "Notepad - " + fileName;
        }

        private void FormNotepad_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveSetting();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fontsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = textBoxWrite.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxWrite.Font = fontDialog1.Font;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog1.FileName;
                System.IO.File.WriteAllText(fileName, textBoxWrite.Text);
                this.Text = "Notepad - " + fileName;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName == "Noname")
            {
                saveAsToolStripMenuItem_Click(null, null);
            }
            else
            {
                System.IO.File.WriteAllText(fileName, textBoxWrite.Text);
                this.Text = "Notepad - " + fileName;
            }
        }

        private void textBoxWrite_TextChanged(object sender, EventArgs e)
        {
            if (textBoxWrite.Modified)
            {
                this.Text = "Notepad - " + fileName + "*";
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxWrite.Modified)
            {
                if (MessageBox.Show("Bạn có muốn lưu tập văn bản đang soạn thảo hay không?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(null, null);
                }
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                textBoxWrite.Text = System.IO.File.ReadAllText(fileName);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxWrite.Modified)
            {
                if (MessageBox.Show("Bạn có muốn lưu tập văn bản đang soạn thảo hay không?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(null, null);
                }
            }
            textBoxWrite.Text = "";
            fileName = "Noname";
            this.Text = "Notepad - " + fileName;
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordWrapToolStripMenuItem.Checked == true)
            {
                textBoxWrite.WordWrap = true;
            }
            else
            {
                textBoxWrite.WordWrap = false;
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxWrite.Cut();
            
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxWrite.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxWrite.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxWrite.SelectAll();
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cutToolStripMenuItem_Click(null, null);
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            copyToolStripMenuItem_Click(null, null);
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pasteToolStripMenuItem_Click(null, null);
        }

        private void selectAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            selectAllToolStripMenuItem_Click(null, null);
        }

        private void FormNotepad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBoxWrite.Modified)
            {
                DialogResult res = MessageBox.Show("Bạn có muốn lưu tệp văn bản?", "Xác nhận",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(null, null);
                }
                else if (res == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }    
            }
        }
    }
}
