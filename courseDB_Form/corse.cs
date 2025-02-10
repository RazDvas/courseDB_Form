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
    public partial class corse : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=yourpassword;Database=YourDatabase";
        private string teacherName;
        public corse(string teacher)
        {
            InitializeComponent();
            this.teacherName = teacherName;
            LoadCourseInfo();
        }


        // Метод для загрузки информации о курсе
        private void LoadCourseInfo()
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT c.Name, c.Program, c.Materials
                        FROM Courses c
                        JOIN Teachers t ON c.TeacherId = t.Id
                        WHERE t.FullName = @teacherName";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("teacherName", teacherName);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblCourseName.Text = reader["Name"].ToString();
                                txtCourseProgram.Text = reader["Program"].ToString();
                                txtCourseMaterials.Text = reader["Materials"]?.ToString() ?? "Методические материалы отсутствуют.";
                            }
                            else
                            {
                                lblCourseName.Text = "Курс не найден.";
                                txtCourseProgram.Text = "Программа отсутствует.";
                                txtCourseMaterials.Text = "Методические материалы отсутствуют.";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки курса: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void beck_teachers_Click(object sender, EventArgs e)
        {
            Hide();
            teachers teachers = new teachers();
            teachers.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
