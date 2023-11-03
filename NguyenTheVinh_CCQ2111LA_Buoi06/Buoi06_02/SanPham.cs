using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi06_02
{
    internal class SanPham
    {
        public string MaSP { get; set; }
        public string MaLoai { get; set; }
        public string TenSP { get; set; }
        public string DVTinh { get; set; }
        public string GiaMua { get; set; }
        public string GiaBan { get; set; }
        public SanPham() { }
        public SanPham(string masp, string maloai, string tensp, string donvitinh, string giamua, string giaban)
        {
            MaSP = masp;
            MaLoai = maloai;
            TenSP = tensp;
            DVTinh = donvitinh;
            GiaMua = giamua;
            GiaBan = giaban;
        }
    }
}
