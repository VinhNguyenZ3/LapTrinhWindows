using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi06_01
{
    internal class Khoa
    {
        public String MaKhoa { get; set; }
        public String TenKhoa { get; set; }
        public String GhiChu { get; set; }
        public Khoa() { }
        public Khoa(string maKhoa, string tenKhoa, string ghiChu)
        {
            MaKhoa = maKhoa;
            TenKhoa = tenKhoa;
            GhiChu = ghiChu;
        }
    }
}
