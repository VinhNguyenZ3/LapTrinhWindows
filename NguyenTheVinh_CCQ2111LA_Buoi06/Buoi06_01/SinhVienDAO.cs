using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Buoi06_01
{
    
    internal class SinhVienDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        KetNoi kn = new KetNoi();
        public SinhVienDAO() {
            conn = kn.getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public DataTable getList(int? makhoa = null)
        {
            string sql = null;
            if (makhoa == null)
            {
                sql = "SELECT SinhVien.MaSV, SinhVien.HoTen, SinhVien.DiemTB, " +
                    "Khoa.TenKhoa FROM SinhVien INNER JOIN Khoa ON Khoa.MaKhoa=SinhVien.MaKhoa";
            }
            else
            {
                sql = "SELECT SinhVien.MaSV, SinhVien.HoTen, SinhVien.DiemTB, " +
                    "Khoa.TenKhoa FROM SinhVien INNER JOIN Khoa ON Khoa.MaKhoa=SinhVien.MaKhoa";
            }
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt;
        }
        public int getCount()
        {
            string sql = "SELECT COUNT(SinhVien.MaSV) FROM SinhVien INNER JOIN Khoa ON Khoa.MaKhoa=SinhVien.MaKhoa";
            cmd =new SqlCommand(sql, conn);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        public DataRow getRow(string masv) {
        string sql = "SELECT SinhVien.MaSV, SinhVien.HoTen, SinhVien.DiemTB, Khoa.TenKhoa";
        sql += "FROM SinhVien INNER JOIN Khoa ON Khoa.MaKhoa=SinhVien.MaKhoa WHERE SinhVien.MaSV='"+masv+"'";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            DataRow row = dt.Rows[0];
            return row;
        }
        public void InsertTwo(SinhVien sv)
        {
            string sql = "INSERT INTO SinhVien(MaSV,HoTen,MaKhoa,DiemTB) VALUES(@MASV,@HOTEN,@MAKHOA,@DIEMTB)";
            cmd = new SqlCommand (sql, conn);
            cmd.Parameters.AddWithValue("@MASV", sv.MaSV);
            cmd.Parameters.AddWithValue("@HOTEN", sv.HoTen);
            cmd.Parameters.AddWithValue("@DIEMTB", sv.DiemTB);
            cmd.Parameters.AddWithValue("@MAKHOA", sv.MaKhoa);
            cmd.ExecuteNonQuery();
        }
        public void UpdateTwo(SinhVien sv) {
            string sql = "UPDATE SinhVien SET HoTen=@HOTEN, MaKhoa=@MAKHOA,DiemTB=@DIEMTB WHERE MaSV=@MASV";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MASV", sv.MaSV);
            cmd.Parameters.AddWithValue("@HOTEN", sv.HoTen);
            cmd.Parameters.AddWithValue("@DIEMTB", sv.DiemTB);
            cmd.Parameters.AddWithValue("@MAKHOA", sv.MaKhoa);
            cmd.ExecuteNonQuery();
        }
        public void DeleteTwo(string masv)
        {
            string sql = "DELETE FROM SinhVien WHERE MaSV=@MASV";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MASV", masv);
            cmd.ExecuteNonQuery();
        }
    }





}
