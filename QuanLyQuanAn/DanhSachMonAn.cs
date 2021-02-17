using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn
{
    class DanhSachMonAn
    {
        private static volatile DanhSachMonAn instance;
        internal static DanhSachMonAn Instance
        {
            get
            {
                if (instance == null)
                    instance = new DanhSachMonAn();
                return instance;
            }
            set { instance = value; }
        }
        private List<MonAn> dsMonAn;
        public List<MonAn> DsMonAn
        {
            get { return dsMonAn; }
            set { dsMonAn = value; }
        }

        private DanhSachMonAn()
        {
            dsMonAn = new List<MonAn>();
            dsMonAn.Add(new MonAn("Bánh mì truyền thống", 20000, 50));
            dsMonAn.Add(new MonAn("Bánh mì xíu mại", 25000, 40));
            dsMonAn.Add(new MonAn("Bánh mì chả cua", 25000, 40));
            dsMonAn.Add(new MonAn("Bánh mì gà nướng", 30000, 30));
        }
    }
}
