using Npgsql;
using System.Configuration;

namespace DEMO_EX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void logIn_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text;
            var password = textBoxPassword.Text;

            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres; User Id = postgres;Password=0000"))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;

                    // Запрос на получение хешированного пароля и роли пользователя
                    cmd.CommandText = "SELECT password, role FROM \"User\" WHERE login = @login;";
                    cmd.Parameters.AddWithValue("login", login);

                    // Выполняем команду и получаем результат
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string hashedPassword = reader.GetString(0); // Получаем хешированный пароль
                            string role = reader.GetString(1); // Получаем роль

                            // Проверяем пароль
                            if (PasswordHashercs.VerifyPassword(password, hashedPassword))
                            {

                                if (role == "manager")
                                {
                                    AdminForm adminForm = new AdminForm();
                                    adminForm.Show();
                                    this.Hide();
                                }
                                if (role == "client")
                                {
                                    
                                }
                            }
                            else
                            {
                                // Неверный пароль
                                MessageBox.Show("Неверный логин или пароль.");
                            }
                        }
                        else
                        {
                            // Пользователь не найден
                            MessageBox.Show("Неверный логин или пароль.");
                        }
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
        }
    }
}
