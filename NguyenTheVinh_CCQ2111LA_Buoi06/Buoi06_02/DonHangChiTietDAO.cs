using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Buoi06_02
{
    internal class DonHangChiTietDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        KetNoi kn = new KetNoi();
        public DonHangChiTietDAO()
        {
            conn = kn.getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public DataTable getList(int? masp = null)
        {
            string sql = null;
            if (masp == null)
            {
                sql = "SELECT DonHangChiTiet.MaCTDH, DonHangChiTiet.MaDH, DonHangChiTiet.MaSP, DonHangChiTiet.TenSP," +
                    " DonHangChiTiet.DVTinh, DonHangChiTiet.DonGia,DonHangChiTiet.SoLuong, DonHangChiTiet.GhiChu" +
                    " FROM DonHangChiTiet";
            }
            else
            {
                sql = "SELECT DonHangChiTiet.MaCTDH, DonHangChiTiet.MaDH, DonHangChiTiet.MaSP, DonHangChiTiet.TenSP," +
                    " DonHangChiTiet.DVTinh, DonHangChiTiet.DonGia,DonHangChiTiet.SoLuong, DonHangChiTiet.GhiChu" +
                    " FROM DonHangChiTiet";
            }
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt;
        }
        public int getCount()
        {
            string sql = "SELECT COUNT(DonHangChiTiet.MaCTDH) FROM DonHangChiTiet";
            cmd = new SqlCommand(sql, conn);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        public DataRow getRow(string mactdh)
        {
            string sql = "SELECT DonHangChiTiet.MaCTDH, DonHangChiTiet.MaDH, DonHangChiTiet.MaSP, DonHangChiTiet.TenSP," +
                    " DonHangChiTiet.DVTinh, DonHangChiTiet.DonGia,DonHangChiTiet.SoLuong, DonHangChiTiet.GhiChu";
            sql += "FROM DonHangChiTiet INNER JOIN DonHang ON DonHang.MaHD=DonHangChiTiet.MaHD WHERE" +
                " DonHangChiTiet.MaCTDH='" + mactdh + "'";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            DataRow row = dt.Rows[0];
            return row;
        }
        public void InsertTwo(DonHangChiTiet mactdh)
        {
            string sql = "INSERT INTO DonHangChiTiet(MaCTDH,MaDH,MaSP,TenSP,DVTinh,DonGia,SoLuong,GhiChu) " +
                "VALUES(@MACTDH,@MAHD,@MASP,@TENSP,@DVTINH,@DONGIA,@SOLUONG,@GHICHU)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MACTDH", mactdh.MaCTDH);
            cmd.Parameters.AddWithValue("@MAHD", mactdh.MaDH);
            cmd.Parameters.AddWithValue("@MASP", mactdh.MaSP);
            cmd.Parameters.AddWithValue("@TENSP", mactdh.TenSP);
            cmd.Parameters.AddWithValue("@DVTINH", mactdh.DVTinh);
            cmd.Parameters.AddWithValue("@DONGIA", mactdh.DonGia);
            cmd.Parameters.AddWithValue("@SOLUONG", mactdh.SoLuong);
            cmd.Parameters.AddWithValue("@GHICHU", mactdh.GhiChu);
            cmd.ExecuteNonQuery();
        }
        public void UpdateTwo(DonHangChiTiet mactdh)
        {
            string sql = "UPDATE DonHangChiTiet SET MaCTDH=@MACTDH,MaDH=@MAHD, TenSP=@TENSP, DVTinh=@DVTINH, " +
                "DonGia=@DONGIA, SoLuong=@SOLUONG, GhiChu=@GHICHU WHERE MaCTDH=@MACTDH";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MACTDH", mactdh.MaCTDH);
            cmd.Parameters.AddWithValue("@MAHD", mactdh.MaDH);
            cmd.Parameters.AddWithValue("@MASP", mactdh.MaSP);
            cmd.Parameters.AddWithValue("@TENSP", mactdh.TenSP);
            cmd.Parameters.AddWithValue("@DVTINH", mactdh.DVTinh);
            cmd.Parameters.AddWithValue("@DONGIA", mactdh.DonGia);
            cmd.Parameters.AddWithValue("@SOLUONG", mactdh.SoLuong);
            cmd.Parameters.AddWithValue("@GHICHU", mactdh.GhiChu);
            cmd.ExecuteNonQuery();
        }
        public void DeleteTwo(string mactdh)
        {
            string sql = "DELETE FROM DonHangChiTiet WHERE MaCTDH=@MACTDH";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MACTDH", mactdh);
            cmd.ExecuteNonQuery();
        }
    }
}
