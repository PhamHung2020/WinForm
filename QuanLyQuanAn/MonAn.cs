using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn
{
    public class MonAn
    {
        private string ten;
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        private int donGia;
        public int DonGia
        {
            get { return donGia; }
            set
            {
                if (value >= 0)
                    donGia = value;
                else
                    donGia = 0;
            }
        }

        private int soLuong;
        public int SoLuong
        {
            get { return soLuong; }
            set
            {
                if (value >= 0)
                    soLuong = value;
                else
                    soLuong = 0;
            }
        }

        public MonAn(string ten, int donGia, int soLuong)
        {
            Ten = ten;
            DonGia = donGia;
            SoLuong = soLuong;
        }
    }
}
