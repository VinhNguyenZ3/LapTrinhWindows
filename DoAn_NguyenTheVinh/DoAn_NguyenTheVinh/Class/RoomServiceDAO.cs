using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_NguyenTheVinh.Class
{
    internal class RoomServiceDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        KetNoi kn = new KetNoi();
        public RoomServiceDAO()
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
                sql = "SELECT RoomServices.ServiceID, RoomServices.ReservationID, RoomServices.ServiceName, " +
                    "RoomServices.ServiceCharge FROM RoomServices " +
                    "INNER JOIN Reservations ON Reservations.ReservationID=RoomServices.ReservationID";
            }
            else
            {
                sql = "SELECT RoomServices.ServiceID, RoomServices.ReservationID, RoomServices.ServiceName, " +
                    "RoomServices.ServiceCharge FROM RoomServices " +
                    "INNER JOIN Reservations ON Reservations.ReservationID=RoomServices.ReservationID";
            }
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt;
        }
        public int getCount()
        {
            string sql = "SELECT COUNT(RoomServices.ServiceID) FROM RoomServices " +
                "INNER JOIN Reservations ON Reservations.ReservationID=RoomServices.ReservationID";
            cmd = new SqlCommand(sql, conn);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        public DataRow getRow(int serviceid)
        {
            string sql = "SELECT RoomServices.ServiceID, RoomServices.ReservationID, RoomServices.ServiceName, " +
                    "RoomServices.ServiceCharge FROM RoomServices " +
                    "INNER JOIN Reservations ON Reservations.ReservationID=RoomServices.ReservationID" +
                    " WHERE RoomServices.ServiceID='" + serviceid + "'";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            DataRow row = dt.Rows[0];
            return row;
        }
        public void InsertTwo(RoomService roomservice)
        {
            string sql = "INSERT INTO RoomServices(ServiceID,ReservationID,ServiceName,ServiceCharge)" +
                " VALUES(@SERVICEID, @RESERVATIONID, @SERVICENAME,  @SERVICECHARGE)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@SERVICEID", roomservice.ServiceID);
            cmd.Parameters.AddWithValue("@RESERVATIONID", roomservice.ReservationID);
            cmd.Parameters.AddWithValue("@SERVICENAME", roomservice.ServiceName);
            cmd.Parameters.AddWithValue("@SERVICECHARGE", roomservice.ServiceCharge);

            cmd.ExecuteNonQuery();
        }
        public void UpdateTwo(RoomService roomservice)
        {
            string sql = "UPDATE RoomServices SET ServiceID=@SERVICEID, ReservationID=@RESERVATIONID, " +
                "ServiceName=@SERVICENAME, ServiceCharge=@SERVICECHARGE WHERE ServiceID=@SERVICEID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@SERVICEID", roomservice.ServiceID);
            cmd.Parameters.AddWithValue("@RESERVATIONID", roomservice.ReservationID);
            cmd.Parameters.AddWithValue("@SERVICENAME", roomservice.ServiceName);
            cmd.Parameters.AddWithValue("@SERVICECHARGE", roomservice.ServiceCharge);
            cmd.ExecuteNonQuery();
        }
        public void DeleteTwo(int serviceid)
        {
            string sql = "DELETE FROM RoomServices WHERE ServiceID=@SERVICEID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@SERVICEID", serviceid);
            cmd.ExecuteNonQuery();
        }
    }
}
