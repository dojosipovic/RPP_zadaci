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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var username = tbUsername.Text.Trim();
            var password = tbPassword.Text.Trim();

            User user = UserRepository.findUserByUsername(username);
            if (user == null)
            {
                MessageBox.Show("Wrong username!");
            }
            else
            {
                if (user.Password == password)
                {
                    MessageBox.Show($"{user} is successfuly loged in!");
                }
                else
                {
                    MessageBox.Show("Entered credentials are not valid!");
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form registerForm = new Register();
            this.Hide();
            registerForm.ShowDialog();
            this.Show();
        }
    }
}
