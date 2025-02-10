using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseDB_Form
{
    class CheckingUser
    {
        private string connectionString = "Host=localhost;Port=5432;Database=YourDatabase;Username=YourUsername;Password=YourPassword";
        private Microsoft.VisualBasic.ApplicationServices.User GetUserFromDatabase(string username, string password)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Username, Role FROM Users WHERE Username = @Username AND Password = @Password";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Microsoft.VisualBasic.ApplicationServices.User
                                {
                                    /*Username = reader["Username"].ToString(),
                                    Role = reader["Role"].ToString()*/
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}");
            }

            return null; // Если пользователь не найден
        }
    }
    public class User
    {
        public string Username { get; set; }
        public string Role { get; set; } // "Admin" или "User"
    }
}
