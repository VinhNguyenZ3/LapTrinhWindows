using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_NguyenTheVinh.Class
{
    internal class RoomDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        KetNoi kn = new KetNoi();
        public RoomDAO()
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
                sql = "SELECT Rooms.RoomID, Rooms.RoomNumber, Rooms.RoomType, " +
                    "Rooms.Price, Rooms.Description, Rooms.Status FROM Rooms";
            }
            else
            {
                sql = "SELECT Rooms.RoomID, Rooms.RoomNumber, Rooms.RoomType, " +
                     "Rooms.Price, Rooms.Description, Rooms.Status FROM Rooms";
            }
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt;
        }
        public int getCount()
        {
            string sql = "SELECT COUNT(Rooms.RoomID) FROM Rooms";
            cmd = new SqlCommand(sql, conn);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        public DataRow getRow(int roomid)
        {
            string sql = "SELECT Rooms.RoomID, Rooms.RoomNumber, Rooms.RoomType, " +
                     "Rooms.Price, Rooms.Description, Rooms.Status FROM Rooms WHERE" +
                     " Rooms.ReservationID='" + roomid + "'";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            DataRow row = dt.Rows[0];
            return row;
        }
        public void InsertTwo(Room room)
        {
            string sql = "INSERT INTO Rooms(RoomID,RoomNumber,RoomType,Price," +
                "Description, Status) VALUES(@ROOMID, @ROOMNUMBER, @ROOMTYPE," +
                " @PRICE, @DESCRIPTION, @STATUS)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ROOMID", room.RoomID);
            cmd.Parameters.AddWithValue("@ROOMNUMBER", room.RoomNumber);
            cmd.Parameters.AddWithValue("@ROOMTYPE", room.RoomType);
            cmd.Parameters.AddWithValue("@PRICE", room.Price);
            cmd.Parameters.AddWithValue("@DESCRIPTION", room.Description);
            cmd.Parameters.AddWithValue("@STATUS", room.Status);

            cmd.ExecuteNonQuery();
        }
        public void UpdateTwo(Room room)
        {
            string sql = "UPDATE Rooms SET RoomID=@ROOMID, RoomNumber=@ROOMNUMBER, " +
                "RoomType=@ROOMTYPE, Price=@PRICE, Description=@DESCRIPTION, Status=@STATUS" +
                " WHERE RoomID=@ROOMID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ROOMID", room.RoomID);
            cmd.Parameters.AddWithValue("@ROOMNUMBER", room.RoomNumber);
            cmd.Parameters.AddWithValue("@ROOMTYPE", room.RoomType);
            cmd.Parameters.AddWithValue("@PRICE", room.Price);
            cmd.Parameters.AddWithValue("@DESCRIPTION", room.Description);
            cmd.Parameters.AddWithValue("@STATUS", room.Status);
            cmd.ExecuteNonQuery();
        }
        public void DeleteTwo(int roomid)
        {
            string sql = "DELETE FROM Rooms WHERE RoomID=@ROOMID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ROOMID", roomid);
            cmd.ExecuteNonQuery();
        }
    }
}
