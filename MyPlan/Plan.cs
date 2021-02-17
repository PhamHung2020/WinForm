using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPlan
{
    public partial class Plan : Form
    {
        private PlanList dataList;
        public PlanList DataList { get => dataList; set => dataList = value; }
        public Plan(DateTime date, PlanList dataList)
        {
            InitializeComponent();
            
            this.dataList = new PlanList();
            this.dataList = dataList;
            dateTimePickerDate.Value = date;
        }


        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {
            ClearFlowLayoutPanel();
            ShowJobByDate(dateTimePickerDate.Value);
        }

        private void ClearFlowLayoutPanel()
        {
            flowLayoutJob.Controls.Clear();
        }

        private void ShowJobByDate(DateTime date)
        {
            foreach (PlanItem item in dataList.PlanItemList)
            {
                if (item.Date.IsEqualDate(date))
                {
                    AddJob(item);
                }
            }
        }

        private void AddJob(PlanItem item)
        {
            Job job = new Job(item);
            job.Delete += Job_Delete;
            job.Edit += Job_Edit;
            //job.MouseClick += Job_Click;
            flowLayoutJob.Controls.Add(job);
        }

        //private void Job_Click(object sender, EventArgs e)
        //{
        //    (sender as Job).BackColor = Color.Violet;
        //}

        private void Job_Edit(object sender, EventArgs e)
        {
            
        }

        private void Job_Delete(object sender, EventArgs e)
        {
            Job jobDelete = sender as Job;
            PlanItem itemDelete = jobDelete.Item;
            flowLayoutJob.Controls.Remove(jobDelete);
            dataList.PlanItemList.Remove(itemDelete);
           
        }

        private void buttonYesterday_Click(object sender, EventArgs e)
        {
            dateTimePickerDate.Value = dateTimePickerDate.Value.AddDays(-1);
        }

        private void buttonTomorrow_Click(object sender, EventArgs e)
        {
            dateTimePickerDate.Value = dateTimePickerDate.Value.AddDays(1);
        }

        private void menuStripItemToday_Click(object sender, EventArgs e)
        {
            dateTimePickerDate.Value = DateTime.Now;
        }

        private void menuStripItemAddJob_Click(object sender, EventArgs e)
        {
            PlanItem item = new PlanItem() { Date = dateTimePickerDate.Value };
            dataList.PlanItemList.Add(item);
            AddJob(item);
        }
    }
}
