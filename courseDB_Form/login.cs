using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace courseDB_Form
{
    public partial class Login : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=268413;");
        public Login()
        {
            InitializeComponent(); 
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            Hide();

            try
            {
                using (var connection = conn)
                {
                    try
                    {
                        connection.Open();

                        string query = "SELECT Id, Role FROM Users WHERE Username = @username AND PasswordHash = @passwordHash";
                        string username = txtUsername.Text.Trim(); // Имя пользователя
                        string password = txtPassword.Text.Trim(); // Пароль
                        using (var cmd = new NpgsqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("username", username);
                            cmd.Parameters.AddWithValue("passwordHash", HashPassword(password)); // Функция для хэширования пароля

                            using (var reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    int userId = reader.GetInt32(0);
                                    string role = reader.GetString(1);

                                    // Перенаправляем в зависимости от роли
                                    if(role == "ADMIN")
                                    {
                                        new AdminForm().Show();
                                    }
                                    else new deportament_structure(userId).Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Неверный логин или пароль.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка подключения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                var hash = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hash);
            }
        }

    }
}
