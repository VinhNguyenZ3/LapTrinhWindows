using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi06_02
{
    internal class DonHangChiTiet
    {
        public string MaCTDH { get; set; }
        public string MaDH { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string DVTinh { get; set; }
        public string DonGia { get; set; }
        public string SoLuong { get; set; }
        public string GhiChu { get; set; }
        public DonHangChiTiet() { }
        public DonHangChiTiet(string mactdh, string mahd, string masp, string tensp, string donvitinh,
            string dongia, string soluong, string chitiet)
        {
            MaCTDH = masp;
            MaDH = mahd;
            MaSP = masp;
            TenSP = tensp;
            DVTinh = donvitinh;
            DonGia = dongia;
            SoLuong = soluong;
            GhiChu = chitiet;
        }
    }
}
