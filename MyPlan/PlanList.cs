using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPlan
{
    [Serializable]
    public class PlanList
    {
        private List<PlanItem> planItemList;
        public List<PlanItem> PlanItemList { get => planItemList; set => planItemList = value; }
        public PlanList()
        {
            planItemList = new List<PlanItem>();
        }
    }
}
