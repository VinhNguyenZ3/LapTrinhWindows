using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_02
{
    internal class SinhVien
    {
        //private string MaSV;
        //private string HoTen;
        //private double DiemTB;
        //private string Khoa;

        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public double DiemTB { get; set; }
        public string Khoa { get; set; }
        public SinhVien() { }

        public SinhVien(string masv, string hoten, double diem, string khoa)
        {
            this.MaSV = masv; this.HoTen = hoten; this.DiemTB = diem; this.Khoa = khoa;
        }

        public SinhVien(SinhVien sv)
        {
            this.MaSV = sv.MaSV;
            this.HoTen = sv.HoTen;
            this.DiemTB = sv.DiemTB;
            this.Khoa = sv.Khoa;
        }

        public void NhapSV()
        {
            Console.Write("Nhap MaSV: ");
            MaSV = Console.ReadLine();
            Console.Write("Nhap HoTen: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap DiemTB: ");
            DiemTB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap Khoa: ");
            Khoa = Console.ReadLine();
        }
        public void XuatSV()
        {
            Console.WriteLine("MaSV: {0} \t HoTen: {1} \t DiemTB: {2} \t Khoa: {3} \t", MaSV, HoTen, DiemTB, Khoa);
        }

    }
}
