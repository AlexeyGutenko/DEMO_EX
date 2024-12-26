using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DEMO_EX
{
    internal class UserAdd
    {//(user_surname character varying, user_name character varying, user_patrnymic character varying, user_login character varying, user_password character varying, user_role role) returns void

        public void AddUser(string surname, string name, string patrnymic, string login, string password, string role)
        {

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres; User Id = postgres;Password=0000");
            conn.Open();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select from add_user(\'{surname}\',\'{name}\',\'{patrnymic}\',\'{login}\',\'{password}\',\'{role}\');";

            NpgsqlDataReader dataReader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            cmd.Dispose();
            conn.Close();

        }
        public DataTable printAllUser()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres; User Id = postgres;Password=0000");
            conn.Open();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select print_all_user();";

            NpgsqlDataReader dataReader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            cmd.Dispose();
            conn.Close();

            return dataTable;
        }

    }
}
