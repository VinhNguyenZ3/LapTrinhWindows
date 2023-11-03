using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi06_01
{
    internal class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public string MaKhoa { get; set; }
        public string DiemTB { get; set; }
        public SinhVien() { }
        public SinhVien(string maSV, string hoTen, string maKhoa, string diemTB)
        {
            MaSV = maSV;
            HoTen = hoTen;
            MaKhoa = maKhoa;
            DiemTB = diemTB;
        }
    }
}
