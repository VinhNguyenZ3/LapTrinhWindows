using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi01_05
{
    internal class Program
    {
        static String[] NhapSV(int n)
        {
            String[] dssv = new String[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap sinh vien thu {i + 1}: ");
                dssv[i] = Console.ReadLine();
            }
            return dssv;
        }
        static void XuatSV(String[] dssv, int n)
        {
            for (int i = 0; i < n; i++)
                Console.WriteLine("Sinh vien thu {0}: {1}", i + 1, dssv[i]);
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap n sinh vien: ");
            n = Convert.ToInt32(Console.ReadLine());
            string[] dssv = NhapSV(n);
            Console.WriteLine("Danh sach sinh vien: ");
            XuatSV(dssv, n);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
