using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMO_EX
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }
        UserAdd userAdd = new UserAdd();
        private void button1_Click(object sender, EventArgs e)
        {
            string user_name = textBoxName.Text;
            string user_surname = textBoxSurname.Text;
            string user_patrnymic = textBoxPatrnymic.Text;
            string user_login = textBoxLogin.Text;
            string user_password = PasswordHashercs.HashPassword(textBoxPassword.Text);
            string user_role = comboBoxRole.Text;
            userAdd.AddUser(
                user_surname,
                user_name,
                user_patrnymic,
                user_login,
                user_password,
                user_role
            );
        }

        private void print_all_user_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = userAdd.printAllUser();
        }
    }
}
