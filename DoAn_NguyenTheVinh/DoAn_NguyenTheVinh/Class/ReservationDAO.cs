using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_NguyenTheVinh.Class
{
    internal class ReservationDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        KetNoi kn = new KetNoi();
        public ReservationDAO()
        {
            conn = kn.getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public DataTable getList(int? id = null)
        {
            string sql = null;
            if (id == null)
            {
                sql = "SELECT Reservations.ReservationID, Reservations.CustomerID, Reservations.RoomID, " +
                    "Reservations.PaymentStatus, Reservations.SpecialRequests, Reservations.NumberOfAdults," +
                    " Reservations.NumberOfChildren, Reservations.CheckInDate, Reservations.CheckOutDate," +
                    " Reservations.TotalAmount,Reservations.CheckInStatus,Reservations.CheckOutStatus" +
                    " FROM Reservations" +
                    " INNER JOIN Customers ON Reservations.CustomerID = Customers.CustomerID" +
                    " INNER JOIN Rooms ON Reservations.RoomID = Rooms.RoomID";
            }
            else
            {
                sql = "SELECT Reservations.ReservationID, Reservations.CustomerID, Reservations.RoomID, " +
                    "Reservations.PaymentStatus, Reservations.SpecialRequests, Reservations.NumberOfAdults," +
                    " Reservations.NumberOfChildren, Reservations.CheckInDate, Reservations.CheckOutDate," +
                    " Reservations.TotalAmount,Reservations.CheckInStatus,Reservations.CheckOutStatus" +
                    " FROM Reservations" +
                    " INNER JOIN Customers ON Reservations.CustomerID = Customers.CustomerID" +
                    " INNER JOIN Rooms ON Reservations.RoomID = Rooms.RoomID WHERE Reservations.RomID='"+id+"'";
            }
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt;
        }
        public int getCount()
        {
            string sql = "SELECT COUNT(Reservations.ReservationID) FROM Reservations " +
                " INNER JOIN Customers ON Reservations.CustomerID = Customers.CustomerID" +
                " INNER JOIN Rooms ON Reservations.RoomID = Rooms.RoomID";
            cmd = new SqlCommand(sql, conn);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        public DataRow getRow(int reservationid)
        {
            string sql = "SELECT Reservations.ReservationID, Reservations.CustomerID, Reservations.RoomID, " +
                    "Reservations.PaymentStatus, Reservations.SpecialRequests, Reservations.NumberOfAdults" +
                    " Reservations.NumberOfChildren, Reservations.CheckInDate, Reservations.CheckOutDate," +
                    " Reservations.TotalAmount,Reservations.CheckInStatus,Reservations.CheckOutStatus" +
                    " FROM Reservations " +
                    " INNER JOIN Customers ON Reservations.CustomerID = Customers.CustomerID" +
                    " INNER JOIN Rooms ON Reservations.RoomID = Rooms.RoomID" +
                    " WHERE Reservations.ReservationID='" + reservationid + "'";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            DataRow row = dt.Rows[0];
            return row;
        }
        public void InsertTwo(Reservation reservation)
        {
            string sql = "INSERT INTO Reservations(ReservationID,CustomerID,RoomID,PaymentStatus," +
                "SpecialRequests, NumberOfAdults,NumberOfChildren,CheckInDate,CheckOutDate,TotalAmount," +
                "CheckInStatus, CheckOutStatus) " +
                "VALUES(@RESERVATIONID, @CUSTOMERID, @ROOMID, @PAYMENTSTATUS, @SPECIALREQUESTS, " +
                "@NUMBEROFADULTS, @NUMBEROFCHILDREN, @CHECKINDATE,@CHECKOUTDATE, @TOTALAMOUNT, " +
                "@CHECKINSTATUS, @CHECKOUTSTATUS)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@RESERVATIONID", reservation.ReservationID);
            cmd.Parameters.AddWithValue("@CUSTOMERID", reservation.CustomerID);
            cmd.Parameters.AddWithValue("@ROOMID", reservation.RoomID);
            cmd.Parameters.AddWithValue("@PAYMENTSTATUS", reservation.PaymentStatus);
            cmd.Parameters.AddWithValue("@SPECIALREQUESTS", reservation.SpecialRequests);
            cmd.Parameters.AddWithValue("@NUMBEROFADULTS", reservation.NumberOfAdults);

            cmd.Parameters.AddWithValue("@NUMBEROFCHILDREN", reservation.NumberOfChildren);
            cmd.Parameters.AddWithValue("@CHECKINDATE", reservation.CheckInDate);
            cmd.Parameters.AddWithValue("@CHECKOUTDATE", reservation.CheckOutDate);
            cmd.Parameters.AddWithValue("@TOTALAMOUNT", reservation.TotalAmount);
            cmd.Parameters.AddWithValue("@CHECKINSTATUS", reservation.CheckInStatus);
            cmd.Parameters.AddWithValue("@CHECKOUTSTATUS", reservation.CheckOutStatus);
            cmd.ExecuteNonQuery();
        }
        public void UpdateTwo(Reservation reservation)
        {
            string sql = "UPDATE Reservations SET ReservationID=@RESERVATIONID, CustomerID=@CUSTOMERID, " +
                "RoomID=@ROOMID, PaymentStatus=@PAYMENTSTATUS, " +
                "SpecialRequests=@SPECIALREQUESTS,NumberOfAdults=@NUMBEROFADULTS, NumberOfChildren=@NUMBEROFCHILDREN," +
                "CheckInDate=@CHECKINDATE, CheckOutDate=@CHECKOUTDATE, TotalAmount=@TOTALAMOUNT" +
                ", CheckInStatus=@CHECKINSTATUS, CheckOutStatus=@CHECKOUTSTATUS WHERE ReservationID=@RESERVATIONID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@RESERVATIONID", reservation.ReservationID);
            cmd.Parameters.AddWithValue("@CUSTOMERID", reservation.CustomerID);
            cmd.Parameters.AddWithValue("@ROOMID", reservation.RoomID);
            cmd.Parameters.AddWithValue("@PAYMENTSTATUS", reservation.PaymentStatus);
            cmd.Parameters.AddWithValue("@SPECIALREQUESTS", reservation.SpecialRequests);
            cmd.Parameters.AddWithValue("@NUMBEROFADULTS", reservation.NumberOfAdults);

            cmd.Parameters.AddWithValue("@NUMBEROFCHILDREN", reservation.NumberOfChildren);
            cmd.Parameters.AddWithValue("@CHECKINDATE", reservation.CheckInDate);
            cmd.Parameters.AddWithValue("@CHECKOUTDATE", reservation.CheckOutDate);
            cmd.Parameters.AddWithValue("@TOTALAMOUNT", reservation.TotalAmount);
            cmd.Parameters.AddWithValue("@CHECKINSTATUS", reservation.CheckInStatus);
            cmd.Parameters.AddWithValue("@CHECKOUTSTATUS", reservation.CheckOutStatus);
            cmd.ExecuteNonQuery();
        }
        public void DeleteTwo(int reservationid)
        {
            string sql = "DELETE FROM Reservations WHERE ReservationID=@RESERVATIONID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@USERID", reservationid);
            cmd.ExecuteNonQuery();
        }
    }
}
