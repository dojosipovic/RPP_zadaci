using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadaci_za_vjezbu_1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var firstname = tbFirstname.Text;
            var lastname = tbLastname.Text;
            var username = tbUsername.Text;
            var password = tbPassword.Text;
            var userType = User.UserType.Guest;

            var isAdmin = rbAdmin.Checked;
            var isEmployee = rbEmployee.Checked;

            if (isAdmin)
            {
                userType = User.UserType.Admin;
            }
            if (isEmployee)
            {
                userType = User.UserType.Employee;
            }

            User newUser = new User();
            newUser.Username = username;
            newUser.Password = password;
            newUser.Firstname = firstname;
            newUser.Lastname = lastname;
            newUser.Usertype = userType;

            UserRepository.addUser(newUser);

            this.Close();
        }
    }
}
