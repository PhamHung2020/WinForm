using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn
{
    public enum TypeUser
    {
        NHANVIEN,
        KHACH,
    }
    public class User
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string pass;
        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        private TypeUser loaiUser;
        public TypeUser LoaiUser
        {
            get { return loaiUser; }
            set { loaiUser = value; }
        }

        public User(string name = "Guest", string pass = "", TypeUser loaiUser = TypeUser.KHACH)
        {
            Name = name;
            Pass = pass;
            LoaiUser = loaiUser;
        }
    }
}
