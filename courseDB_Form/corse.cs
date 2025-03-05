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
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=268413;Database=testDB";
        private string teacherName;
        public corse(string teacher)
        {
            InitializeComponent();
            this.teacherName = teacher;
            LoadCourseInfo();
            txtTeacher.Text = teacher;
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
                        SELECT course_name, discipline_program, methodological_material
                        FROM courses
                        JOIN teachers ON courses.teacher_ID = teachers.teacher_ID
                        WHERE teachers.teacher_name = @teacher_name;";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("teacher_name", teacherName);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblCourseName.Text = reader["course_name"].ToString();
                                txtCourseProgram.Text = reader["discipline_program"].ToString();
                                txtCourseMaterials.Text = reader["methodological_material"]?.ToString() ?? "Методические материалы отсутствуют.";
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
