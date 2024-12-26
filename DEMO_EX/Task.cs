using Npgsql;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace DEMO_EX
{
    internal class Task
    {//Demo_connection
        public void AddTask(int number,string data,string deskription,string priority,string executor,string status)
        {

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres; User Id = postgres;Password=0000");
            conn.Open();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select  from  add_task(\'{number}\',\'{data}\',\'{deskription}\',\'{priority}\',\'{executor}\',\'{status}\');";

            NpgsqlDataReader dataReader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            cmd.Dispose();
            conn.Close();
        }
        public DataTable alter_the_status(int id_task,string status)    
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres; User Id = postgres;Password=0000");
            conn.Open();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from  alter_the_status(\'{id_task}\',\'{status}\');";

            NpgsqlDataReader dataReader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            cmd.Dispose();
            conn.Close();

            return dataTable;
        }

        public DataTable assign_executor(int task_id , int user_id )
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres; User Id = postgres;Password=0000");
            conn.Open();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from  alter_the_status(\'{task_id}\',\'{user_id}\');";

            NpgsqlDataReader dataReader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            cmd.Dispose();
            conn.Close();

            return dataTable;
        }
        public DataTable change_the_description(int task_id , string deskription)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres; User Id = postgres;Password=0000");
            conn.Open();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from  alter_the_status(\'{task_id}\',\'{deskription}\');";

            NpgsqlDataReader dataReader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            cmd.Dispose();
            conn.Close();

            return dataTable;
        }
        public DataTable get_all_task()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres; User Id = postgres;Password=0000");
            conn.Open();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"SELECT * FROM get_all_task();";

            NpgsqlDataReader dataReader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            cmd.Dispose();
            conn.Close();

            return dataTable;
        }
        public DataTable get_task_find_by_prioryty(string priority)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres; User Id = postgres;Password=0000");
            conn.Open();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select get_task_find_by_prioryty(\'{priority}\');";

            NpgsqlDataReader dataReader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            cmd.Dispose();
            conn.Close();

            return dataTable;
        }
        public DataTable get_task_find_by_status(string status)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres; User Id = postgres;Password=0000");
            conn.Open();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select get_task_find_by_prioryty(\'{status}\');";

            NpgsqlDataReader dataReader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            cmd.Dispose();
            conn.Close();

            return dataTable;
        }

        public DataTable get_task_for_number(int task_number)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres; User Id = postgres;Password=0000");
            conn.Open();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select get_task_find_by_prioryty(\'{task_number}\');";

            NpgsqlDataReader dataReader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            cmd.Dispose();
            conn.Close();

            return dataTable;
        }
        public void to_change_the_priority(string task_id , string priority )
        {
            

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres; User Id = postgres;Password=0000");
            conn.Open();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select to_change_the_priority(\'{task_id}\',\'{priority}\');";

            NpgsqlDataReader dataReader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            cmd.Dispose();
            conn.Close();
        }
    }
}
