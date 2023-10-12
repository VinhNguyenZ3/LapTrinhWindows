using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi01_02
{
    internal class Program
    {
        public static bool checkNamNhuan(int yy)
        {
            if ((yy % 4 == 0 && yy % 100 != 0) || (yy % 400 != 0))
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            int mm, yy;
            Console.Write("Nhap thang: ");
            mm = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap nam: ");
            yy = Int32.Parse(Console.ReadLine());
            checkNamNhuan(yy);
            switch (mm)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Nam {0}, Thang {1} co 31 ngay.", yy, mm);
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Nam {0}, Thang {1} co 30 ngay.", yy, mm);
                    break;
                case 2:
                    if (checkNamNhuan(yy) == true)
                    {
                        Console.WriteLine("Nam {0}, Thang {1} co 29 ngay.", yy, mm);
                    }
                    else
                    {
                        Console.WriteLine("Nam {0}, Thang {1} co 28 ngay.", yy, mm);
                    }
                    break;
                default:
                    Console.WriteLine("Thang khong hop le!");
                    Console.WriteLine("Nhap thang 1 den 12.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
