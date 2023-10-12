using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaci_za_vjezbu_1
{
    public class UserRepository
    {
        private static List<User> Users = new List<User>();

        public static void addUser(User user)
        {
            Users.Add(user);
        }
        public static User findUserByUsername(string username)
        {
            return Users.Find(user => user.Username.Equals(username));
        }
    }
}
