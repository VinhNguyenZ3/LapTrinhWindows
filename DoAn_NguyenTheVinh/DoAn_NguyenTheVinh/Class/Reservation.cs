using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_NguyenTheVinh.Class
{
    internal class Reservation
    {
        public int ReservationID { get; set; }
        public int CustomerID { get; set; }
        public int RoomID { get; set; }
        public string PaymentStatus { get; set; }
        public string SpecialRequests { get; set; }
        public int NumberOfAdults { get; set; }
        public int NumberOfChildren { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string CheckInStatus { get; set; }
        public string CheckOutStatus { get; set; }
        public Reservation(int reservationid, int customerid, int roomid, string paymentstatus,
            string specialrequests, int numberofadults, int numberofchildren, DateTime checkindate,
             DateTime checkoutdate, decimal totalamount, string checkinstatus,
           string checkoutstatus)
        {
            ReservationID = reservationid;
            CustomerID = customerid;
            RoomID = roomid;
            PaymentStatus = paymentstatus;
            SpecialRequests = specialrequests;
            NumberOfAdults = numberofadults;
            NumberOfChildren = numberofchildren;
            CheckInDate = checkindate;
            CheckOutDate = checkoutdate;
            TotalAmount = totalamount;
            CheckInStatus = checkinstatus;
            CheckOutStatus = checkoutstatus;
        }
    }
}
