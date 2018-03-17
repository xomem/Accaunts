using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Data;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Data;

namespace Accounts
{
    public static class Querys
    {
        const string ConnectionAdres = @"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\MainDatabase.mdf;MultipleActiveResultSets=True;";

        public static bool Enter(string login, string password)
        {
            var query = $"SELECT * FROM [Пользователи] WHERE [Пользователи].Логин = N'{login}' AND [Пользователи].Пароль = N'{password}';";
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConnectionAdres))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                result = command.ExecuteNonQuery() >= 1;
                connection.Close();
            }
            return result;
        }
    }
}
