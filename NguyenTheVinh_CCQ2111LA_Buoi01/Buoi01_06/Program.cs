using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi01_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, delta;
            Console.WriteLine("Nhap a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap c:");
            c = Convert.ToInt32(Console.ReadLine());
            delta = b ^ 2 - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem.");
            }
            else if (delta == 0)
            {
                Console.WriteLine("Phuong trinh co 1 nghiem x.");
            }
            else
                Console.WriteLine("Phuong trinh co 2 nghiem.");
            Console.ReadKey();

        }
    }
}
