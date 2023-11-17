using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_NguyenTheVinh.Class
{
    internal class CustomerDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        KetNoi kn = new KetNoi();
        public CustomerDAO()
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
                sql = "SELECT Customers.CustomerID, Customers.FirstName, Customers.LastName, " +
                    "Customers.Email, Customers.Phone, Customers.Address," +
                    " Customers.DateOfBirth, Customers.Nationality, Customers.IDCardNumber FROM Customers";
            }
            else
            {
                sql = "SELECT Customers.CustomerID, Customers.FirstName, Customers.LastName, " +
                   "Customers.Email, Customers.Phone, Customers.Address," +
                   " Customers.DateOfBirth, Customers.Nationality, Customers.IDCardNumber FROM Customers";
            }
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt;
        }
        public int getCount()
        {
            string sql = "SELECT COUNT(Customers.CustomerID) FROM Customers";
            cmd = new SqlCommand(sql, conn);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        public DataRow getRow(int customerid)
        {
            string sql = "SELECT Customers.CustomerID, Customers.FirstName, Customers.LastName, " +
                   "Customers.Email, Customers.Phone, Customers.Address," +
                   " Customers.DateOfBirth, Customers.Nationality, Customers.IDCardNumber" +
                   " FROM Customers WHERE Customers.CustomerID='" + customerid + "'";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            DataRow row = dt.Rows[0];
            return row;
        }
        public void InsertTwo(Customer customer)
        {
            string sql = "INSERT INTO Customers(CustomerID,FirstName,LastName,Email," +
                "Phone, Address, DateOfBirth, Nationality, IDCardNumber) " +
                "VALUES(@CUSTOMERID, @FIRSTNAME, @LASTNAME, " +
                "@EMAIL, @PHONE, @ADDRESS, @DATEOFBIRTH, @NATIONALITY, @IDCARDNUMBER)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@CUSTOMERID", customer.CustomerID);
            cmd.Parameters.AddWithValue("@FIRSTNAME", customer.FirstName);
            cmd.Parameters.AddWithValue("@LASTNAME", customer.LastName);

            cmd.Parameters.AddWithValue("@EMAIL", customer.Email);
            cmd.Parameters.AddWithValue("@PHONE", customer.Phone);
            cmd.Parameters.AddWithValue("@ADDRESS", customer.Address);

            cmd.Parameters.AddWithValue("@DATEOFBIRTH", customer.DateOfBirth);
            cmd.Parameters.AddWithValue("@NATIONALITY", customer.Nationality);
            cmd.Parameters.AddWithValue("@IDCARDNUMBER", customer.IDCardNumber);
            cmd.ExecuteNonQuery();
        }
        public void UpdateTwo(Customer customer)
        {
            string sql = "UPDATE Customers SET CustomerID=@CUSTOMERID, FirstName=@FIRSTNAME, " +
                "LastName=@LASTNAME, Email=@EMAIL, Phone=@PHONE, " +
                "Address=@ADDRESS,DateOfBirth=@DATEOFBIRTH, Nationality=@NATIONALITY, IDCardNumber=@IDCARDNUMBER" +
                " WHERE ReservationID=@RESERVATIONID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@CUSTOMERID", customer.CustomerID);
            cmd.Parameters.AddWithValue("@FIRSTNAME", customer.FirstName);
            cmd.Parameters.AddWithValue("@LASTNAME", customer.LastName);

            cmd.Parameters.AddWithValue("@EMAIL", customer.Email);
            cmd.Parameters.AddWithValue("@PHONE", customer.Phone);
            cmd.Parameters.AddWithValue("@ADDRESS", customer.Address);

            cmd.Parameters.AddWithValue("@DATEOFBIRTH", customer.DateOfBirth);
            cmd.Parameters.AddWithValue("@NATIONALITY", customer.Nationality);
            cmd.Parameters.AddWithValue("@IDCARDNUMBER", customer.IDCardNumber);
            cmd.ExecuteNonQuery();
        }
        public void DeleteTwo(int customerid)
        {
            string sql = "DELETE FROM Customers WHERE CustomerID=@CUSTOMERID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@CUSTOMERID", customerid);
            cmd.ExecuteNonQuery();
        }
    }
}
