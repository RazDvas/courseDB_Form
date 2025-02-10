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
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=yourpassword;Database=YourDatabase";
        public teachers()
        {
            InitializeComponent();
            LoadTeacherNames(); // Загрузка списка преподавателей при открытии формы
        }


        // Загрузка имен преподавателей в ComboBox
        private void LoadTeacherNames()
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT FullName FROM Teachers";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    using (var reader = cmd.ExecuteReader())
                    {
                        /*while (reader.Read())
                        {
                            cbTeachers.Items.Add(reader["FullName"].ToString());
                        }*/
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки преподавателей: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обработчик выбора преподавателя
        private void cbTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string selectedTeacher = cbTeachers.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedTeacher))
            {
                LoadTeacherInfo(selectedTeacher);
            }*/
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
                        SELECT t.FullName, t.Position, t.ResearchInterests, t.Photo
                        FROM Teachers t
                        WHERE t.FullName = @name";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("name", teacherName);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Должность
                                lblPosition.Text = reader["Position"]?.ToString() ?? "Не указано";

                                // Научные интересы
                                lblResearchInterests.Text = reader["ResearchInterests"]?.ToString() ?? "Не указано";

                                // Фото
                                if (reader["Photo"] != DBNull.Value)
                                {
                                    byte[] photoBytes = (byte[])reader["Photo"];
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
            int userID = 0;
            deportament_structure deportament = new deportament_structure(userID);
            deportament.Show();
        }

        private void updating_teacers_Click(object sender, EventArgs e)
        {

        }

        private void course_Click(object sender, EventArgs e)
        {
            //string selectedTeacher = cbTeachers.SelectedItem?.ToString();
            string selectedTeacher = "";
            if (string.IsNullOrEmpty(selectedTeacher))
            {
                MessageBox.Show("Пожалуйста, выберите преподавателя.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Открываем форму с курсами
            var courseForm = new corse(selectedTeacher);
            courseForm.ShowDialog();
        }
    }
}

