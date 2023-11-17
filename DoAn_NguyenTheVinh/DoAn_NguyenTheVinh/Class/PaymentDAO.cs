using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_NguyenTheVinh.Class
{
    internal class PaymentDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        KetNoi kn = new KetNoi();
        public PaymentDAO()
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
                sql = "SELECT Payments.PaymentID, Payments.ReservationID, Payments.PaymentDate, " +
                    "Payments.PaymentMethod, Payments.PaymentStatus, Payments.Amount," +
                    " Payments.RefundAmount, Payments.RefundStatus FROM Payments " +
                    "INNER JOIN Reservations ON Reservations.ReservationID=Payments.ReservationID";
            }
            else
            {
                sql = "SELECT Payments.PaymentID, Payments.ReservationID, Payments.PaymentDate, " +
                    "Payments.PaymentMethod, Payments.PaymentStatus, Payments.Amount," +
                    " Payments.RefundAmount, Payments.RefundStatus FROM Payments " +
                    "INNER JOIN Reservations ON Reservations.ReservationID=Payments.ReservationID";
            }
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt;
        }
        public int getCount()
        {
            string sql = "SELECT COUNT(Payments.PaymentID) FROM Payments INNER JOIN Reservations ON Reservations.ReservationID=Payments.ReservationID";
            cmd = new SqlCommand(sql, conn);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        public DataRow getRow(int paymentid)
        {
            string sql = "SELECT Payments.PaymentID, Payments.ReservationID, Payments.PaymentDate, " +
                    "Payments.PaymentMethod, Payments.PaymentStatus, Payments.Amount" +
                    " Payments.RefundAmount, Payments.RefundStatus FROM Payments " +
                    "INNER JOIN Reservations ON Reservations.ReservationID=Payments.ReservationID " +
                    "WHERE Payments.PaymentID='" + paymentid + "'";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            DataRow row = dt.Rows[0];
            return row;
        }
        public void InsertTwo(Payment payment)
        {
            string sql = "INSERT INTO Payments(PaymentID,ReservationID,PaymentDate,PaymentMethod," +
                "PaymentStatus, Amount, RefundAmount, RefundStatus) " +
                "VALUES(@PAYMENTID, @RESERVATIONID, @PAYMENTDATE, " +
                "@PAYMENTMETHOD, @PAYMENTSTATUS, " +
                "@AMOUNT, @REFUNDAMOUNT, @REFUNDSTATUS)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@PAYMENTID", payment.PaymentID);
            cmd.Parameters.AddWithValue("@RESERVATIONID", payment.ReservationID);
            cmd.Parameters.AddWithValue("@PAYMENTDATE", payment.PaymentDate);

            cmd.Parameters.AddWithValue("@PAYMENTMETHOD", payment.PaymentMethod);
            cmd.Parameters.AddWithValue("@PAYMENTSTATUS", payment.PaymentStatus);
            cmd.Parameters.AddWithValue("@AMOUNT", payment.Amount);

            cmd.Parameters.AddWithValue("@REFUNDAMOUNT", payment.RefundAmount);
            cmd.Parameters.AddWithValue("@REFUNDSTATUS", payment.RefundStatus);
            cmd.ExecuteNonQuery();
        }
        public void UpdateTwo(Payment payment)
        {
            string sql = "UPDATE Payments SET PaymentID=@PAYMENTID, ReservationID=@RESERVATIONID, " +
                "PaymentDate=@PAYMENTDATE, PaymentMethod=@PAYMENTMETHOD, PaymentStatus=@PAYMENTSTATUS, " +
                "Amount=@AMOUNT,RefundAmount=@REFUNDAMOUNT, RefundStatus=@REFUNDSTATUS" +
                " WHERE ReservationID=@RESERVATIONID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@PAYMENTID", payment.PaymentID);
            cmd.Parameters.AddWithValue("@RESERVATIONID", payment.ReservationID);
            cmd.Parameters.AddWithValue("@PAYMENTDATE", payment.PaymentDate);

            cmd.Parameters.AddWithValue("@PAYMENTMETHOD", payment.PaymentMethod);
            cmd.Parameters.AddWithValue("@PAYMENTSTATUS", payment.PaymentStatus);
            cmd.Parameters.AddWithValue("@AMOUNT", payment.Amount);

            cmd.Parameters.AddWithValue("@REFUNDAMOUNT", payment.RefundAmount);
            cmd.Parameters.AddWithValue("@REFUNDSTATUS", payment.RefundStatus);
            cmd.ExecuteNonQuery();
        }
        public void DeleteTwo(int paymentid)
        {
            string sql = "DELETE FROM Payments WHERE PaymentID=@PAYMENTID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@PAYMENTID", paymentid);
            cmd.ExecuteNonQuery();
        }
    }
}
