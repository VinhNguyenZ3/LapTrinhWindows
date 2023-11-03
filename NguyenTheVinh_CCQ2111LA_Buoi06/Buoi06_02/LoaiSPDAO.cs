using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi06_02
{
    internal class LoaiSPDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        KetNoi kn = new KetNoi();
        public LoaiSPDAO()
        {
            conn = kn.getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public DataTable getList(int? maloai = null)
        {
            string sql = null;
            if (maloai == null)
            {
                sql = "SELECT LoaiSP.MaLoai, LoaiSP.TenLoai, LoaiSP.ChiTiet FROM LoaiSP";
            }
            else
            {
                sql = "SELECT LoaiSP.MaLoai, LoaiSP.TenLoai, LoaiSP.ChiTiet FROM LoaiSP";
            }
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt;
        }
        public int getCount()
        {
            string sql = "SELECT COUNT(LoaiSP.MaLoai) FROM LoaiSP";
            cmd = new SqlCommand(sql, conn);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        public DataRow getRow(string maloai)
        {
            string sql = "SELECT LoaiSP.MaLoai, LoaiSP.TenLoai, LoaiSP.ChiTiet";
            sql += "FROM LoaiSP INNER JOIN SanPham ON LoaiSP.MaLoai=SanPham.MaLoai WHERE LoaiSP.MaLoai='" + maloai + "'";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            DataRow row = dt.Rows[0];
            return row;
        }
        public void InsertTwo(LoaiSP maloai)
        {
            string sql = "INSERT INTO LoaiSP(MaLoai,TenLoai,ChiTiet) VALUES(@MALOAI,@TENLOAI,@CHITIET)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MALOAI", maloai.MaLoai);
            cmd.Parameters.AddWithValue("@TENLOAI", maloai.TenLoai);
            cmd.Parameters.AddWithValue("@CHITIET", maloai.ChiTiet);
            cmd.ExecuteNonQuery();
        }
        public void UpdateTwo(LoaiSP maloai)
        {
            string sql = "UPDATE LoaiSP SET TenLoai=@TENLOAI, ChiTiet=@CHITIET WHERE MaLoai=@MALOAI";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MALOAI", maloai.MaLoai);
            cmd.Parameters.AddWithValue("@TENLOAI", maloai.TenLoai);
            cmd.Parameters.AddWithValue("@CHITIET", maloai.ChiTiet);
            cmd.ExecuteNonQuery();
        }
        public void DeleteTwo(string maloai)
        {
            string sql = "DELETE FROM LoaiSP WHERE MaLoai=@MALOAI";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MALOAI", maloai);
            cmd.ExecuteNonQuery();
        }
    }
}
