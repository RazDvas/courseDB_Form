using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System.Text;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace courseDB_Form
{
    public partial class Login : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=268413;Database=testDB");
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

                        string query = "SELECT user_ID, user_role FROM users WHERE user_name = @username AND user_password = @password";
                        string username = txtUsername.Text.Trim(); // ��� ������������
                        string password = txtPassword.Text.Trim(); // ������
                        using (var cmd = new NpgsqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("username", username);
                            cmd.Parameters.AddWithValue("password", HashPassword(password)); // ������� ��� ����������� ������

                            using (var reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    int userId = reader.GetInt32(0);
                                    string role = reader.GetString(1);

                                    // �������������� � ����������� �� ����
                                    if(role == "ADMIN")
                                    {
                                        new AdminForm().Show();
                                    }
                                    else new deportament_structure().Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("�������� ����� ��� ������.");
                                    new Login().Show();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"������ �����������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"������: {ex.Message}");
            }
        }

        private string HashPassword(string password)
        {
            // ������� ������ SHA-256
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ����������� ������ � ������ ������ � ��������� ���
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // ����������� ������ ������ � ������ � ����������������� �������
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2")); // "x2" �������� ����������������� ������
                }

                return builder.ToString();
            }
        }

    }
}
