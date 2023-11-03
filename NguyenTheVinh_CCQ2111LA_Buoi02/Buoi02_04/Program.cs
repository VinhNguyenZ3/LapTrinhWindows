using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_03
{
    internal class Program
    {
        private static List<Student> NhapDSSinhVien()
        {
            List<Student> listSV = new List<Student>();
            Console.Write("Nhap tong so sinh vien n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-===Nhap tong so sinh vien===-");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap sinh vien thu {0}: ", i + 1);
                Student sv = new Student();
                sv.NhapSV();
                listSV.Add(sv);
            }
            return listSV;
        }
        private static List<Teacher> NhapDSGiaoVien()
        {
            List<Teacher> listGV = new List<Teacher>();
            Console.Write("Nhap tong so giao vien n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-===Nhap tong so giao vien===-");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap giao vien thu {0}: ", i + 1);
                Teacher gv = new Teacher();
                gv.NhapGV();
                listGV.Add(gv);
            }
            return listGV;
        }

        private static void XuatDDSV(List<Student> listSV)
        {
            foreach (Student sv in listSV)
                sv.XuatSV();
        }
        private static void XuatDDGV(List<Teacher> listSV)
        {
            foreach (Teacher sv in listSV)
                sv.XuatGV();
        }


        private static void TimSvCNTT(List<Student> listSinhVien)
        {
            List<Student> listSV = listSinhVien.Where(p => p.Khoa == "CNTT").ToList();
            if (listSV.Count() == 0)
                Console.WriteLine("Khong co sinh vien thuoc khoa “CNTT” ");
            else
            {
                Console.WriteLine("-===Danh sach sinh vien thuoc khoa “CNTT”===-");
                XuatDDSV(listSV);
            }
        }
        private static void SVDiemTBNho5CNTT(List<Student> listSinhVien)
        {
            List<Student> listSV = listSinhVien.Where(p => p.DiemTB < 5).Where(p => p.Khoa == "CNTT").ToList();
            Console.WriteLine("-===Danh sach sinh vien CNTT va diem < 5 ===-");
            XuatDDSV(listSV);
        }
        private static void GVDiaChiQuan9(List<Teacher> listGV)
        {
            List<Teacher> listGVQuan9 = listGV.Where(gv => (gv.DiaChi).Contains("Quận 9")).ToList();
            Console.WriteLine("-=== Danh sách giáo viên ở Quận 9 ===-");
            XuatDDGV(listGVQuan9);
        }
        private static void TimMaGV(List<Teacher> listGV)
        {
            List<Teacher> timGV = listGV.Where(gv => (gv.MaGV) == "CHN060286").ToList();
            Console.WriteLine("-=== Giáo viên có mã CHN060286 ===-");
            XuatDDGV(timGV);
        }
        private static void SvDTBMaxCNTT(List<Student> listSinhVien)
        {
            double diemMax = listSinhVien.Where(p => p.Khoa == "CNTT").Max(p => p.DiemTB);
            List<Student> listSV = listSinhVien.Where(p => p.Khoa == "CNTT" && p.DiemTB >= diemMax).ToList();
            Console.WriteLine("-===Danh sach sinh vien CNTT va diem trung binh cao nhat ===-");
            XuatDDSV(listSV);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            // 1.Xây dựng hàm nhập danh sách sinh viên(Student), nhập danh sách giáo viên(Teacher):
            List<Student> listSV = NhapDSSinhVien();
            List<Teacher> listGV = NhapDSGiaoVien();
            XuatDDSV(listSV);
            XuatDDGV(listGV);
            // 2.Tìm kiếm danh sách các sinh viên thuộc khoa “CNTT” nếu có.
            TimSvCNTT(listSV);
            // 3.Xuất ra danh sách tất cả sinh viên có điểm trung bình < 5 và thuộc khoa “CNTT”
            SVDiemTBNho5CNTT(listSV);

            // 4.Xuất ra danh sách giáo viên có địa chỉ chứa thông tin "Quận 9" nếu có
            GVDiaChiQuan9(listGV);

            // 5.Tìm kiếm giáo viên có mã giảng viên là CHN060286.Xuất ra thông tin giáo viên tìm được nếu có.
            TimMaGV(listGV);

            // 6.Tìm danh sách sinh viên có điểm trung bình cao nhất và thuộc khoa "CNTT"
            SvDTBMaxCNTT(listSV);

            Console.ReadKey();
        }

       
    }
}

