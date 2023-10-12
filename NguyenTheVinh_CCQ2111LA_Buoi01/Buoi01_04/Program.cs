using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi01_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, p = 0, s = 0;
            Console.WriteLine("Nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap c: ");
            c = Convert.ToInt32(Console.ReadLine());
            if ((a + b > c) && (a + c > b) && (b + c < a))
            {
                p = a + b + c;
                s = (int)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine($"Ket qua: P = {p}, S = {s}");
            }
            else
            {
                Console.WriteLine("3 canh a,b,c khong phai la 1 tam giac!");
            }
            Console.ReadKey();
        }
    }
}
