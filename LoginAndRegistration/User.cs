using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaci_za_vjezbu_1
{
    public class User
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserType Usertype { get; set; }

        public override string ToString()
        {
            return Firstname + " " + Lastname;
        }

        public enum UserType
        {
            Guest,
            Employee,
            Admin
        }
    }
}
