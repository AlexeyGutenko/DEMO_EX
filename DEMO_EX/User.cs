using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMO_EX
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        Task task = new Task();
        private void get_task_for_number_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNumberTask_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDateCreate_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeskriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPriority_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxExecutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void status_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void get_task_find_by_status_Click(object sender, EventArgs e)
        {
            string task_status = status.Text.ToString();
            task.get_task_find_by_status(task_status);
        }

        private void get_task_find_by_prioryty_Click(object sender, EventArgs e)
        {
            string priority = textBoxPriority.Text.ToString();
            task.get_task_find_by_prioryty(priority);
        }

        private void print_All_Click(object sender, EventArgs e)
        {
            task.get_all_task();
        }

        private void alter_the_status_Click(object sender, EventArgs e)
        {
            string priority = textBoxPriority.Text.ToString();
            task.get_task_find_by_prioryty(priority);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Hide();
        }
    }
}
