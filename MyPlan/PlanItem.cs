using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPlan
{
    public class PlanItem
    {
        private DateTime date;
        public DateTime Date { get => date; set => date = value; }
        private string job;
        public string Job { get => job; set => job = value; }

        private Point fromTime;
        public Point FromTime { get => fromTime; set => fromTime = value; }

        private Point toTime;
        public Point ToTime { get => toTime; set => toTime = value; }

        private JOBSTATUS status;
        public JOBSTATUS Status { get => status; set => status = value; }

        public static List<string> jobStatus = new List<string>() { "Đã xong", "Đang làm", "Sắp tới", "Đã trễ" };
    }

    public enum JOBSTATUS
    {
        DONE, 
        DOING, 
        COMING,
        MISSED,
    }

    public static class JobStatusExtension
    {
        public static string ToStringExten(this JOBSTATUS status)
        {
            switch (status)
            {
                case JOBSTATUS.DONE:
                    return "Đã xong";
                case JOBSTATUS.DOING:
                    return "Đang làm";
                case JOBSTATUS.COMING:
                    return "Sắp tới";
                case JOBSTATUS.MISSED:
                    return "Đã trễ";
                default:
                    return null;
            }
        }
    }
}
