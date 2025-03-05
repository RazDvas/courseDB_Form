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
    public partial class teachers : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=268413;Database=testDB";
        public teachers()
        {
            InitializeComponent();
            LoadTeacherNames(); // Загрузка списка преподавателей при открытии формы
        }


        // Загрузка имен преподавателей в listBox
        private void LoadTeacherNames()
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT teacher_name FROM teachers";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lbTeachers.Items.Add(reader["teacher_name"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки преподавателей: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Загрузка информации о преподавателе
        private void LoadTeacherInfo(string teacherName)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT teacher_name, post, scientific_interests, teacher_image, schedule_of_stay
                        FROM Teachers 
                        WHERE teacher_name = @name";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("name", teacherName);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Должность
                                lblPosition.Text = reader["post"]?.ToString() ?? "Не указано";

                                // Научные интересы
                                lblResearchInterests.Text = reader["scientific_interests"]?.ToString() ?? "Не указано";

                                lblSchelduleOfStay.Text = reader["schedule_of_stay"]?.ToString() ?? "Не указано";

                                // Фото
                                if (reader["teacher_image"] != DBNull.Value)
                                {
                                    byte[] photoBytes = (byte[])reader["teacher_image"];
                                    using (var ms = new MemoryStream(photoBytes))
                                    {
                                        pictureBoxPhoto.Image = Image.FromStream(ms);
                                    }
                                }
                                else
                                {
                                    pictureBoxPhoto.Image = null;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Преподаватель не найден.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки информации: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void beck_deportament_structure_Click(object sender, EventArgs e)
        {
            Hide();
            deportament_structure deportament = new deportament_structure();
            deportament.Show();
        }

        private void updating_teacers_Click(object sender, EventArgs e)
        {

        }

        private void course_Click(object sender, EventArgs e)
        {
            string selectedTeacher = lbTeachers.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedTeacher))
            {
                MessageBox.Show("Пожалуйста, выберите преподавателя.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Открываем форму с курсами
            Hide();
            var courseForm = new corse(selectedTeacher);
            courseForm.ShowDialog();
        }

        private void lbTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTeacher = lbTeachers.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedTeacher))
            {
                LoadTeacherInfo(selectedTeacher);
            }
        }
    }
}

