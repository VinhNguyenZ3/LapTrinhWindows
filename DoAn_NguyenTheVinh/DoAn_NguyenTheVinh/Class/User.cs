using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_NguyenTheVinh.Class
{
    internal class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Status { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Role { get; set; }
        public User(string password)
        {
            Password = password;
        }
        public User(int userid, string username, string password, string fullname,
            string status, string phonenumber, string address, DateTime dateofbirth,
            string role)
        {
            UserID = userid;
            Username = username;
            Password = password;
            FullName = fullname;
            Status = status;
            PhoneNumber = phonenumber;
            Address = address;
            DateOfBirth = dateofbirth;
            Role = role;
        }
    }
}
