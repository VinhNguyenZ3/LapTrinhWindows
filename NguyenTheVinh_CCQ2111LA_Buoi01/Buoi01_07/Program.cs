using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi01_07
{
    internal class Program
    {
        static bool checkNT(int a)
        {
            if (a < 2)
                return false;
            else
                for (int i = 2; i < (int)(Math.Sqrt(a) + 1); i++)
                    if (a % i == 0)
                        return false;
            return true;
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap so nguyen duong n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Danh sach cac so nguyen to:");
            for (int i = 0; i < n; i++)
                if (checkNT(i) == true)
                    Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
