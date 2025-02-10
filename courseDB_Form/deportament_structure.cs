using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace courseDB_Form
{
    public partial class deportament_structure : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=yourpassword;Database=YourDatabase";
        public deportament_structure(int UserID)
        {
            InitializeComponent();
            LoadDepartmentStructure();
        }


        // Загрузка структуры кафедры
        private void LoadDepartmentStructure()
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Запрос для получения данных о кафедре и секциях
                    string departmentQuery = "SELECT Name, Head, DeputyHead FROM Departments WHERE Id = 1"; // Измените Id, если нужно

                    using (var departmentCmd = new NpgsqlCommand(departmentQuery, connection))
                    using (var reader = departmentCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblHead.Text = $"{reader["Head"]}";
                            lblDeputyHead.Text = $"{reader["DeputyHead"]}";
                        }
                    }

                    string sectionQuery = "SELECT Name, Leader FROM Sections WHERE DepartmentId = 1"; // Измените Id, если нужно

                    using (var sectionCmd = new NpgsqlCommand(sectionQuery, connection))
                    using (var reader = sectionCmd.ExecuteReader())
                    {
                        /*lbSection.item.Clear();
                        while (reader.Read())
                        {
                            lbSections.Items.Add($"{reader["Name"]} ({reader["Leader"]})");
                        }*/
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void beck_department_Click(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login();
            login.Show();
        }

        private void scientific_worck_show_Click(object sender, EventArgs e)
        {
            Hide();
            scientific_work scientific = new scientific_work();
            scientific.Show();
        }

        private void show_teaher_Click(object sender, EventArgs e)
        {
            Hide();
            teachers teacher = new teachers();
            teacher.Show();
        }
    }
}
