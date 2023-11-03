using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_02
{
    internal class Program
    {
        private static List<SinhVien> NhapDSSinhVien()
        {
            List<SinhVien> listSV = new List<SinhVien>();
            Console.Write("Nhap tong so sinh vien n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-===Nhap tong so sinh vien===-");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap sinh vien thu {0}: ", i + 1);
                SinhVien sv = new SinhVien();
                sv.NhapSV();
                listSV.Add(sv);
            }
            return listSV;
        }
        private static void XuatDDSV(List<SinhVien> listSV)
        {
            foreach (SinhVien sv in listSV)
                sv.XuatSV();
        }
        private static void DSSVCNTT(List<SinhVien> listSV)
        {
            List<SinhVien> listCNTT1 = listSV.Where(p => p.Khoa == "CNTT").ToList();
            if (listCNTT1.Count() == 0)
                Console.WriteLine("Khong co sinh vien khoa CNTT");
            else
            {
                Console.WriteLine("-===Danh sach sinh vien khoa CNTT===-");
                XuatDDSV(listCNTT1);
            }
        }
        private static void DSSVLonHon5(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listSV = listSinhVien.Where(p => p.DiemTB >= 5).ToList();
            if (listSV.Count() == 0)
                Console.WriteLine("Khong co sinh vien co diem >= 5 ");
            else
            {
                Console.WriteLine("-===Danh sach sinh vien co diem >= 5===-");
                XuatDDSV(listSV);
            }
        }
        private static void DSSVDTTangDan(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listSV = listSinhVien.Where(p => p.DiemTB >= 5).ToList();
            Console.WriteLine("-===Danh sach sinh vien sap xep diem tang dan===-");
            XuatDDSV(listSV);
        }
        private static void DSSVCNTTDiemTBLonHonBang5(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listSV = listSinhVien.Where(p => p.DiemTB >= 5).Where(p => p.Khoa == "CNTT").ToList();
            Console.WriteLine("-===Danh sach sinh vien CNTT va diem >= 5 ===-");
            XuatDDSV(listSV);
        }
        private static void DSSVDTBMaxCNTT(List<SinhVien> listSinhVien)
        {
            double diemMax = listSinhVien.Where(p => p.Khoa == "CNTT").Max(p => p.DiemTB);
            List<SinhVien> listSV = listSinhVien.Where(p => p.Khoa == "CNTT" && p.DiemTB >= diemMax).ToList();
            Console.WriteLine("-===Danh sach sinh vien CNTT va diem lon nhat ===-");
            XuatDDSV(listSV);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            List<SinhVien> listSV = NhapDSSinhVien();
            XuatDDSV(listSV);



            //1.1Xuất ra thông tin của các sinh viên thuộc khoa "CNTT"(nếu có).
            DSSVCNTT(listSV);

            //1.2 Xuất ra thông tin sinh viên có điểm TB lớn hơn bằng 5(nếu có).
            DSSVLonHon5(listSV);

            //1.3 Xuất ra danh sách sinh viên được sắp xếp theo điểm trung bình tăng dần.
            DSSVDTTangDan(listSV);

            //1.4 Xuất ra danh sách sinh viên có điểm TB lớn hơn bằng 5 và thuộc khoa "CNTT"(nếu có).
            DSSVCNTTDiemTBLonHonBang5(listSV);

            //1.5 Xuất ra danh sách sinh viên có điểm trung bình cao nhất và thuộc khoa "CNTT"(nếu có).
            DSSVDTBMaxCNTT(listSV);
            Console.ReadKey();
        }
    }
}
