using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi01_03
{
    internal class Program
    {
        public static int tongSoLe(int n)
        {
            int tong = 0;
            for (int i = 0; i <= (2 * n - 1); i++)
                if (i % 2 != 0)
                    tong += i;
            return tong;
        }
        static void Main(string[] args)
        {
            int n, kq;
            Console.WriteLine("Nhap so nguyen duong n: ");
            n = Convert.ToInt32(Console.ReadLine());
            kq = tongSoLe(n);
            Console.WriteLine("Tong cac so le tu 1 den 2n-1: {0}", kq);
            Console.ReadKey();
        }
    }
}
