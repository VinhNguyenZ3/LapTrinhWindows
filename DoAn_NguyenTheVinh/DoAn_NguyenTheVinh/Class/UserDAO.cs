using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DoAn_NguyenTheVinh.Class
{
    internal class UserDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        KetNoi kn = new KetNoi();
        public UserDAO()
        {
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
                sql = "SELECT Users.UserID, Users.Username, Users.Password, Users.FullName, Users.Status," +
                    " Users.PhoneNumber, Users.Address, Users.DateOfBirth, Users.Role FROM Users";
            }
            else
            {
                sql = "SELECT Users.UserID, Users.Username, Users.Password, Users.FullName, Users.Status, Users.PhoneNumber, Users.Address, Users.DateOfBirth, Users.Role FROM Users";
            }
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt;
        }
        public int getCount()
        {
            string sql = "SELECT COUNT(Users.UserID) FROM Users";
            cmd = new SqlCommand(sql, conn);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        public DataRow getRow(int userid)
        {
            string sql = "SELECT Users.UserID, Users.Username, Users.Password, Users.FullName, Users.Status, Users.PhoneNumber, Users.Address, Users.DateOfBirth," +
                " Users.Role FROM Users WHERE Users.UserID='" + userid + "'";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            DataRow row = dt.Rows[0];
            return row;
        }


        public string[] getInfoUser(string username)
        {
            string sql = "SELECT Users.UserID, Users.Username, Users.Password, Users.FullName, Users.Status, Users.PhoneNumber, Users.Address, Users.DateOfBirth," +
                    " Users.Role FROM Users WHERE Users.Username='" + username + "'";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                string[] resultArray = new string[]
                {
                row["UserID"].ToString(),
                row["Username"].ToString(),
                row["Password"].ToString(),
                row["FullName"].ToString(),
                row["Status"].ToString(),
                row["PhoneNumber"].ToString(),
                row["Address"].ToString(),
                row["DateOfBirth"].ToString(),
                row["Role"].ToString()
                };
                return resultArray;
            }
            else
                return new string[] { "Không tìm thấy dữ liệu" };
        }

        public String getUser(string username)
        {
            string sql = "SELECT Users.UserID, Users.Username, Users.Password, Users.FullName, Users.Status, Users.PhoneNumber, Users.Address, Users.DateOfBirth," +
                " Users.Role FROM Users WHERE Users.Username='" + username + "'";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                string result = "ID: " + row["UserID"].ToString() +
                                "  -  Họ và tên: " + row["FullName"].ToString() +
                                "  -  Chức: " + row["Role"].ToString();

                return result;
            }
            else
                return "No data found";
        }
        public String getUserName(string username)
        {
            string sql = "SELECT Users.Username FROM Users WHERE Users.Username='" + username + "'";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return row["Username"].ToString();
            }
            else
                return "No data found";
        }
        public String checkUserStatus(string username)
        {
            string sql = "SELECT Users.Username, Users.Password, Users.Status FROM Users WHERE Users.Username='" + username + "'";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                string result = row["Status"].ToString();
                return result;
            }
            else
                return null;
        }
        public String checkPassword(string password)
        {
            string sql = "SELECT Users.Username, Users.Password FROM Users WHERE Users.Password='" + password + "'";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                string result = row["Password"].ToString();
                return result;
            }
            else
                return null;
        }
        public String checkAccount(string username)
        {
            string sql = "SELECT Users.Username, Users.Password FROM Users WHERE Users.Username='" + username + "'";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                string result = row["Username"].ToString();
                return result;
            }
            else
                return null;
        }

        public void InsertTwo(User user)
        {
            string sql = "INSERT INTO Users(UserID,Username,Password,FullName,Status,PhoneNumber,Address,DateOfBirth,Role) " +
                "VALUES(@USERID,@USERNAME,@PASSWORD,@FULLNAME,@STATUS,@PHONENUMBER,@ADDRESS,@DATEOFBIRTH,@ROLE)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@USERID", user.UserID);
            cmd.Parameters.AddWithValue("@USERNAME", user.Username);
            cmd.Parameters.AddWithValue("@PASSWORD", user.Password);
            cmd.Parameters.AddWithValue("@FULLNAME", user.FullName);
            cmd.Parameters.AddWithValue("@STATUS", user.Status);
            cmd.Parameters.AddWithValue("@PHONENUMBER", user.PhoneNumber);
            cmd.Parameters.AddWithValue("@ADDRESS", user.Address);
            cmd.Parameters.AddWithValue("@DATEOFBIRTH", user.DateOfBirth);
            cmd.Parameters.AddWithValue("@ROLE", user.Role);
            cmd.ExecuteNonQuery();
        }
        public void UpdateTwo(User user)
        {
            string sql = "UPDATE Users SET Username=@USERNAME, Password=@PASSWORD, FullName=@FULLNAME, Status=@STATUS, " +
                "PhoneNumber=@PHONENUMBER,Address=@ADDRESS, DateOfBirth=@DATEOFBIRTH,Role=@ROLE WHERE UserID=@USERID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@USERID", user.UserID);
            cmd.Parameters.AddWithValue("@USERNAME", user.Username);
            cmd.Parameters.AddWithValue("@PASSWORD", user.Password);
            cmd.Parameters.AddWithValue("@FULLNAME", user.FullName);
            cmd.Parameters.AddWithValue("@STATUS", user.Status);
            cmd.Parameters.AddWithValue("@PHONENUMBER", user.PhoneNumber);
            cmd.Parameters.AddWithValue("@ADDRESS", user.Address);
            cmd.Parameters.AddWithValue("@DATEOFBIRTH", user.DateOfBirth);
            cmd.Parameters.AddWithValue("@ROLE", user.Role);
            cmd.ExecuteNonQuery();
        }
        public void UpdatePassword(User user)
        {
            string sql = "UPDATE Users SET Password=@PASSWORD";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@PASSWORD", user.Password);
            cmd.ExecuteNonQuery();
        }
        //public void UpdatePassword(User user)
        //{
        //    string sql = "UPDATE Users SET Password=@PASSWORD WHERE Users.Username=@USERNAME";
        //    cmd = new SqlCommand(sql, conn);
        //    cmd.Parameters.AddWithValue("@PASSWORD", user.Password);
        //    cmd.ExecuteNonQuery();
        //}
        public void DeleteTwo(int userid)
        {
            string sql = "DELETE FROM Users WHERE UserID=@USERID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@USERID", userid);
            cmd.ExecuteNonQuery();
        }
    }
}
