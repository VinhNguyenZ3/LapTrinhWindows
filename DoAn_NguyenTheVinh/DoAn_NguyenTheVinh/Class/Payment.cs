using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_NguyenTheVinh.Class
{
    internal class Payment
    {
        public int PaymentID { get; set; }
        public int ReservationID { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
        public decimal Amount { get; set; }
        public decimal RefundAmount { get; set; }
        public string RefundStatus { get; set; }
        public Payment(int paymentid, int reservationid, DateTime paymentdate, string paymentmethod,
            string paymentstatus, decimal amount, decimal refundamount, string refundstatus)
        {
            PaymentID = paymentid;
            ReservationID = reservationid;
            PaymentDate = paymentdate;
            PaymentMethod = paymentmethod;
            PaymentStatus = paymentstatus;
            Amount = amount;
            RefundAmount = refundamount;
            RefundStatus = refundstatus;
        }
    }
}
