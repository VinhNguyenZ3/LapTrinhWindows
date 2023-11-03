using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_03
{
    internal class Person
    {
        public string CNMD { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }

        public Person() { }

        public Person(string cmmd, string hoten, string diachi)
        {
            this.CNMD = cmmd; this.HoTen = hoten; this.DiaChi = diachi;
        }

        public Person(Person per)
        {
            this.CNMD = per.CNMD;
            this.HoTen = per.HoTen;
            this.DiaChi = per.DiaChi;
        }

        //public void Nhapp()
        //{
        //    Console.Write("Nhap Map: ");
        //    Map = Console.ReadLine();
        //    Console.Write("Nhap HoTen: ");
        //    HoTen = Console.ReadLine();
        //    Console.Write("Nhap DiemTB: ");
        //    DiemTB = Convert.ToDouble(Console.ReadLine());
        //    Console.Write("Nhap Khoa: ");
        //    Khoa = Console.ReadLine();
        //}
        //public void Xuatp()
        //{
        //    Console.WriteLine("Map: {0} \t HoTen: {1} \t DiemTB: {2} \t Khoa: {3} \t", Map, HoTen, DiemTB, Khoa);
        //}
    }
}
