using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPlan
{
    public partial class Job : UserControl
    {
        private DateTime date;
        public DateTime Date { get => date; set => date = value; }

        private PlanItem item;
        public PlanItem Item { get => item; set => item = value; }
        public Job(PlanItem item)
        {
            InitializeComponent();
            Item = item;
            Date = item.Date;
            JobInformation();
        }

        private void JobInformation()
        {
            textBoxContentJob.Text = item.Job;
            numericUpDownFromHour.Value = item.FromTime.X;
            numericUpDownFromMinute.Value = item.FromTime.Y;
            numericUpDownToHour.Value = item.ToTime.X;
            numericUpDownToMinute.Value = item.ToTime.Y;
            comboBoxStatus.DataSource = PlanItem.jobStatus;
            comboBoxStatus.SelectedIndex = PlanItem.jobStatus.IndexOf(item.Status.ToStringExten());
            checkBoxIsDone.Checked = (item.Status == JOBSTATUS.DONE) ? true : false;
        }

        public event EventHandler Delete;
        public event EventHandler Edit;
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Delete?.Invoke(this, new EventArgs());
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            item.Job = textBoxContentJob.Text;
            item.FromTime = new Point((int)numericUpDownFromHour.Value, (int)numericUpDownFromMinute.Value);
            item.ToTime = new Point((int)numericUpDownToHour.Value, (int)numericUpDownToMinute.Value);
            item.Status = (JOBSTATUS)comboBoxStatus.SelectedIndex;
            Edit?.Invoke(this, new EventArgs());
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStatus.SelectedItem.ToString() == JOBSTATUS.DONE.ToStringExten())
            {
                checkBoxIsDone.Checked = true;
            }
            else
            {
                checkBoxIsDone.Checked = false;
            }
        }
    }
}
