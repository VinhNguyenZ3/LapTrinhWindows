using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Write("Nhap tong so sinh vien n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            SinhVien[] arrSV = new SinhVien[n];
            Console.WriteLine("-===Nhap tong so sinh vien===-");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap sinh vien thu {0}: ", i + 1);
                arrSV[i] = new SinhVien();
                arrSV[i].NhapSV();
            }
            Console.Write("\n-===Xuat danh sach sinh vien===-\n");
            foreach (SinhVien sv in arrSV)
            {
                sv.XuatSV();
            }
            Console.ReadKey();
        }
    }
}
