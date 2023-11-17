using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_NguyenTheVinh.Class
{
    internal class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Nationality { get; set; }
        public string IDCardNumber { get; set; }
        public Customer(int customerid, string firstname, string lastname, string email,
            string phone, string address, DateTime dateofbirth, string nationality, string idcardnumber)
        {
            CustomerID = customerid;
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            Phone = phone;
            Address = address;
            DateOfBirth = dateofbirth;
            Nationality = nationality;
            IDCardNumber = idcardnumber;
        }
    }
}
