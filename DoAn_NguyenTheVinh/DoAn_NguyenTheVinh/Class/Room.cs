using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_NguyenTheVinh.Class
{
    internal class Room
    {
        public int RoomID { get; set; }
        public string RoomNumber { get; set; }
        public string RoomType { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public Room(int roomid, string roomnumber,
            string roomtype, decimal price, string description,
           string status)
        {
            RoomID = roomid;
            RoomNumber = roomnumber;
            RoomType = roomtype;
            Price = price;
            Description = description;
            Status = status;
        }
    }
}
