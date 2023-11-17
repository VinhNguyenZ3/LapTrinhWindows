using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_NguyenTheVinh.Class
{
    internal class RoomService
    {
        public int ServiceID { get; set; }
        public int ReservationID { get; set; }
        public string ServiceName { get; set; }
        public decimal ServiceCharge { get; set; }
        public RoomService(int serviceid, int reservationid, string servicename, decimal servicecharge)
        {
            ServiceID = serviceid;
            ReservationID = reservationid;
            ServiceName = servicename;
            ServiceCharge = servicecharge;
        }
    }
}
