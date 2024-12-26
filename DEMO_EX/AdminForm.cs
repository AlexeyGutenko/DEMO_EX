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
    public partial class AdminForm : Form
    {
        Task task = new Task();
        public AdminForm()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBoxDateCreate_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxNumberTask_TextChanged(object sender, EventArgs e)
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

        private void print_All_Click(object sender, EventArgs e)
        {
            task.get_all_task();
        }
        private void add_task_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBoxNumberTask.Text);
            string data = textBoxDateCreate.Text.ToString();
            string deskription = DeskriptionTextBox.Text.ToString();
            string priority = textBoxPriority.Text.ToString();
            string executer = textBoxExecutor.Text.ToString();
            string task_status = status.Text.ToString();
            task.AddTask(number, data, deskription, priority, executer, task_status);
        }
        private void alter_the_status_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);
            string task_status = status.Text.ToString();
            task.alter_the_status(id, task_status);
        }

        private void assign_executor_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);
            int userId = Convert.ToInt32(textBoxUserID.Text);
            task.assign_executor(id, userId);
        }

        private void change_the_description_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);
            string deskription = DeskriptionTextBox.Text.ToString();

            task.change_the_description(id, deskription);
        }

        private void get_task_find_by_prioryty_Click(object sender, EventArgs e)
        {

            string priority = textBoxPriority.Text.ToString();
            task.get_task_find_by_prioryty(priority);
        }

        private void get_task_find_by_status_Click(object sender, EventArgs e)
        {
            string task_status = status.Text.ToString();
            task.get_task_find_by_status(task_status);
        }

        private void get_task_for_number_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBoxNumberTask.Text);
            task.get_task_for_number(number);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Hide();
        }

        private void addUSer_Click(object sender, EventArgs e)
        {

        }
    }
}
