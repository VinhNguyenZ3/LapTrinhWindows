using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Buoi06_01
{
    internal class KhoaDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        KetNoi kn = new KetNoi();
        public KhoaDAO()
        {
            conn = kn.getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public DataTable getList()
        {
            string sql = "SELECT * FROM Khoa";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt;
        }

        public int getCount()
        {
            string sql = "SELECT COUNT(Khoa.MaKhoa) FROM Khoa INNER JOIN SinhVien ON Khoa.MaKhoa=SinhVien.MaKhoa";
            cmd = new SqlCommand(sql, conn);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        public DataRow getRow(string makhoa)
        {
            string sql = "SELECT Khoa.MaKhoa, Khoa.TenKhoa, Khoa.GhiChu";
            sql += "FROM Khoa INNER JOIN SinhVien ON SinhVien.TenKhoa=Khoa.TenKhoa WHERE SinhVien.MaKhoa='" + makhoa + "'";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            DataRow row = dt.Rows[0];
            return row;
        }
        public void InsertTwo(Khoa kh)
        {
            string sql = "INSERT INTO Khoa(MaKhoa,TenKhoa,GhiChu) VALUES(@MAKHOA,@TENKHOA,@GHICHU)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MAKHOA", kh.MaKhoa);
            cmd.Parameters.AddWithValue("@TENKHOA", kh.TenKhoa);
            cmd.Parameters.AddWithValue("@GHICHU", kh.GhiChu);
            cmd.ExecuteNonQuery();
        }
        public void UpdateTwo(Khoa kh)
        {
            string sql = "UPDATE Khoa SET TenKhoa=@TENKHOA, GhiChu=@GHICHU WHERE MaKhoa=@MAKHOA";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MAKHOA", kh.MaKhoa);
            cmd.Parameters.AddWithValue("@TENKHOA", kh.TenKhoa);
            cmd.Parameters.AddWithValue("@GHICHU", kh.GhiChu);
            cmd.ExecuteNonQuery();
        }
        public void DeleteTwo(string makhoa)
        {
            string sql = "DELETE FROM Khoa WHERE MaKhoa=@MAKHOA";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MAKHOA", makhoa);
            cmd.ExecuteNonQuery();
        }
    }
}
