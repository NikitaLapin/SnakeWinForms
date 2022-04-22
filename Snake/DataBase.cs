using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Snake
{
    public static class DataBase
    {
        private static readonly MySqlConnection Connection =
            new MySqlConnection(
                "server=localhost; port=3307; username=root; password=root; database=usersandpasswords");

        private static void OpenConnection()
        {
            if (Connection.State == ConnectionState.Closed) Connection.Open();
        }

        private static void CloseConnection()
        {
            if (Connection.State == ConnectionState.Open) Connection.Close();
        }

        public static string GetBestScore(string login)
        {
            var dataTable = new DataTable();
            var adapter = new MySqlDataAdapter();
            var command = new MySqlCommand("SELECT `best_score` FROM `users` WHERE `login` = @L", GetConnection());
            command.Parameters.Add("@L", MySqlDbType.VarChar).Value = login;
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            return Convert.ToString(dataTable.Rows[0][0]);
        }

        public static void NewBestScore(string login, int value)
        {
            OpenConnection();
            var command = new MySqlCommand("UPDATE `users` SET `best_score` = @B WHERE `login` = @L", GetConnection());
            command.Parameters.Add("@L", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@B", MySqlDbType.VarChar).Value = value;
            command.ExecuteNonQuery();
            CloseConnection();
        }

        private static MySqlConnection GetConnection()
        {
            return Connection;
        }

        public static void CreateNewAccount(string login, string password)
        {
            OpenConnection();
            var command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `best_score`) VALUES (@L, @P, 0)",
                DataBase.GetConnection());
            command.Parameters.Add("@L", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@P", MySqlDbType.VarChar).Value = password;
            command.ExecuteNonQuery();
            CloseConnection();
        }

        public static bool IsAccountExists(string login, string password)
        {
            var dataTable = new DataTable();
            var adapter = new MySqlDataAdapter();
            var command = new MySqlCommand("SELECT * FROM `users` WHERE `login`=@L AND `password`=@P",
                DataBase.GetConnection());
            command.Parameters.Add("@L", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@P", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0) return true;
            return false;
        }

        public static bool IsNewLogin(string login)
        {
            var dataTable = new DataTable();
            var adapter = new MySqlDataAdapter();
            var command = new MySqlCommand("SELECT * FROM `users` WHERE `login`=@L", GetConnection());
            command.Parameters.Add("@L", MySqlDbType.VarChar).Value = login;
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            return dataTable.Rows.Count <= 0;
        }
    }
}