using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Buoi07_01
{
    internal class MaHoa
    {
        public static string ToMD5(string str)
        {
            MD5 mh = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(str);
            byte[] hash = mh.ComputeHash(inputBytes);
            StringBuilder chuoimahoa = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                chuoimahoa.Append(hash[i].ToString("X2"));
            }
            return chuoimahoa.ToString();
        }
    }
}
