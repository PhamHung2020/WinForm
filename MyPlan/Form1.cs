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
    
    public partial class Form1 : Form
    {
        #region Properties
        private List<List<Button>> matrixButton;
        private List<string> daysOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        private PlanManager planManager;
        private string filePath = "data.xml";
        #endregion
        public Form1()
        {
            InitializeComponent();
            LoadMatrixButton();
            planManager = new PlanManager();
            
            try
            {
                planManager.DataList = planManager.DeserializeFormXML(filePath) as PlanList;
            }
            catch
            {
                SetDefaultJob();
            }
        }

        private void SetDefaultJob()
        {
            PlanItem item1 = new PlanItem()
            {
                Date = DateTime.Now,
                FromTime = new Point(5, 6),
                ToTime = new Point(6, 5),
                Job = "Thử nghiệm",
                Status = JOBSTATUS.DONE,
            };
            planManager.DataList.PlanItemList.Add(item1);

            PlanItem item2 = new PlanItem()
            {
                Date = DateTime.Now,
                FromTime = new Point(5, 6),
                ToTime = new Point(6, 5),
                Job = "Lập trình",
                Status = JOBSTATUS.DONE,
            };
            planManager.DataList.PlanItemList.Add(item2);

            PlanItem item3 = new PlanItem()
            {
                Date = DateTime.Now.AddDays(-1),
                FromTime = new Point(5, 6),
                ToTime = new Point(6, 5),
                Job = "Code",
                Status = JOBSTATUS.DONE,
            };
            planManager.DataList.PlanItemList.Add(item3);
            
        }

        private void LoadMatrixButton()
        {
            matrixButton = new List<List<Button>>();

            Button oldButton = new Button()
            {
                Height = 0,
                Width = 0,
                Location = new Point(-Constant.ButtonMargin, 0),
            };

            for (int i = 0; i < Constant.DaysOfColumn; ++i)
            {
                matrixButton.Add(new List<Button>());
                for (int j = 0; j < Constant.DaysOfWeek; ++j)
                {
                    Button button = new Button()
                    {
                        Height = Constant.DateButtonHeight,
                        Width = Constant.DateButtonWidth,
                        Location = new Point(oldButton.Location.X + oldButton.Width + Constant.ButtonMargin, oldButton.Location.Y),
                    };
                    button.Click += Button_Click;
                    panelDaysOfMonth.Controls.Add(button);
                    matrixButton[i].Add(button);

                    oldButton = button;
                }
                oldButton = new Button()
                {
                    Height = 0,
                    Width = 0,
                    Location = new Point(-Constant.ButtonMargin, oldButton.Height + oldButton.Location.Y)
                };
            }

            SetDayDefault();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (string.IsNullOrEmpty(button.Text))
                return;
            Plan planForm = new Plan(new DateTime(dateTimePickerDate.Value.Year, dateTimePickerDate.Value.Month, Convert.ToInt32(button.Text)), planManager.DataList);
            planForm.ShowDialog();
        }

        private void AddDayToMatrixButton(DateTime date)
        {
            DateTime useDay = new DateTime(date.Year, date.Month, 1);
            int column = daysOfWeek.IndexOf(useDay.DayOfWeek.ToString());

            int line = 0;
            for (int i = 1; i <= date.DaysOfMonth(); ++i)
            {
                matrixButton[line][column].Text = useDay.Day.ToString();

                if (useDay.IsEqualDate(DateTime.Now))
                    matrixButton[line][column].BackColor = Color.Red;

                if (useDay.IsEqualDate(dateTimePickerDate.Value))
                    matrixButton[line][column].BackColor = Color.Aqua;

                useDay = useDay.AddDays(1);
                ++column;
                if (column >= Constant.DaysOfWeek)
                {
                    ++line;
                    column = 0;
                }
            }
        }

        private void ClearMatrixButton()
        {
            for (int i = 0; i < Constant.DaysOfColumn; ++i)
            {
                for (int j = 0; j < Constant.DaysOfWeek; ++j)
                {
                    matrixButton[i][j].Text = "";
                    matrixButton[i][j].BackColor = DefaultBackColor;
                }
            }
        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {
            ClearMatrixButton();
            AddDayToMatrixButton((sender as DateTimePicker).Value);
        }

        private void SetDayDefault()
        {
            dateTimePickerDate.Value = DateTime.Now;
        }

        private void buttonNextMonth_Click(object sender, EventArgs e)
        {
            dateTimePickerDate.Value = dateTimePickerDate.Value.AddMonths(1);
        }

        private void buttonPreviousMonth_Click(object sender, EventArgs e)
        {
            dateTimePickerDate.Value = dateTimePickerDate.Value.AddMonths(-1);
        }

        private void buttonToday_Click(object sender, EventArgs e)
        {
            SetDayDefault();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            planManager.SerializeToXML(filePath);
        }
    }
}
