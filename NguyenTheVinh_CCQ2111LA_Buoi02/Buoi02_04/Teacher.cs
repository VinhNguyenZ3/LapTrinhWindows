using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_03
{
    internal class Teacher: Person
    {
        public string MaGV { get; set; }
        public string Khoa { get; set; }
        public string ChucVu { get; set; }

        public Teacher() { }

        public Teacher(string magv, string chucvu, string khoa)
        {
            this.MaGV = magv; this.ChucVu = chucvu; this.Khoa = khoa;
        }

        public Teacher(Teacher gv)
        {
            this.MaGV = gv.MaGV;
            this.HoTen = gv.HoTen;
            this.CNMD = gv.CNMD;
            this.DiaChi = gv.DiaChi;
            this.ChucVu = gv.ChucVu;
            this.Khoa = gv.Khoa;
        }

        public void NhapGV()
        {
            Console.Write("Nhap Magv: ");
            MaGV = Console.ReadLine();
            Console.Write("Nhap Ho Ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap CNMD: ");
            CNMD = Console.ReadLine();
            Console.Write("Nhap Dia Chi: ");
            DiaChi = Console.ReadLine();
            Console.Write("Nhap Chuc Vu: ");
            ChucVu = Console.ReadLine();
            Console.Write("Nhap Khoa: ");
            Khoa = Console.ReadLine();
        }
        public void XuatGV()
        {
            Console.WriteLine("MaGV: {0} \t HoTen: {1} \t CNMD: {2} \t DiaChi: {3} \t ChucVu: {4} \t Khoa: {5} \t", MaGV, HoTen, CNMD, DiaChi, ChucVu, Khoa);
        }
    }
}
