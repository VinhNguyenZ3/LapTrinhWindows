using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi06_02
{
    internal class LoaiSP
    {
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public string ChiTiet { get; set; }
       
        public LoaiSP() { }
        public LoaiSP(string maloai, string tenloai, string chitiet)
        {
            MaLoai = maloai;
            TenLoai = tenloai;
            ChiTiet = chitiet;
        }
    }
}
