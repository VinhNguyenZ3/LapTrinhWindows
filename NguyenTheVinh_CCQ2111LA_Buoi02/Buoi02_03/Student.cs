using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_03
{
    internal class Student:Person
    {
        public string MaSV { get; set; }
        public double DiemTB { get; set; }
        public string Khoa { get; set; }
        public Student() { }

        public Student(string masv,  double diem, string khoa)
        {
            this.MaSV = masv;  this.DiemTB = diem; this.Khoa = khoa;
        }

        public Student(Student sv)
        {
            this.MaSV = sv.MaSV;
            this.HoTen = sv.HoTen;
            this.CNMD = sv.CNMD;
            this.DiaChi = sv.DiaChi;
            this.DiemTB = sv.DiemTB;
            this.Khoa = sv.Khoa;
        }

        public void NhapSV()
        {
            Console.Write("Nhap MaSV: ");
            MaSV = Console.ReadLine();
            Console.Write("Nhap Ho Ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap CNMD: ");
            CNMD = Console.ReadLine();
            Console.Write("Nhap Dia Chi: ");
            DiaChi = Console.ReadLine();
            Console.Write("Nhap Diem TB: ");
            DiemTB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap Khoa: ");
            Khoa = Console.ReadLine();
        }
        public void XuatSV()
        {
            Console.WriteLine("MaSV: {0} \t HoTen: {1} \t CNMD: {2} \t DiaChi: {3} \t DiemTB: {4} \t Khoa: {5} \t", MaSV, HoTen, CNMD, DiaChi, DiemTB, Khoa);
        }
    }
}
