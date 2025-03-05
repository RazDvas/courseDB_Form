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
    public partial class scientific_work : Form
    {

        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=268413;Database=testDB";
        public scientific_work()
        {
            InitializeComponent();
            LoadResearchDirections();
        }

        private void LoadResearchDirections()
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT direction_ID, direction_name FROM researchdirections";

                    using (var command = new NpgsqlCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lbDirections.Items.Add(new Direction
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки направлений: {ex.Message}");
            }
        }


        private void LoadDirectionDetails(int directionId)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Получаем описание направления
                    string descriptionQuery = "SELECT brief_description FROM researchdirections WHERE direction_ID = @Id";
                    using (var descriptionCommand = new NpgsqlCommand(descriptionQuery, connection))
                    {
                        descriptionCommand.Parameters.AddWithValue("@Id", directionId);
                        txtDescription.Text = descriptionCommand.ExecuteScalar()?.ToString();
                    }

                    // Получаем участников направления
                    string participantsQuery = @"
                        SELECT s.student_name 
                        FROM students s
                        JOIN researchparticipants rp ON s.student_ID = rp.student_ID
                        WHERE rp.direction_ID = @directionId;";

                    using (var participantsCommand = new NpgsqlCommand(participantsQuery, connection))
                    {
                        // Передаём параметр directionId
                        participantsCommand.Parameters.AddWithValue("@directionId", directionId);

                        using (var reader = participantsCommand.ExecuteReader())
                        {
                            txtParticipants.Clear(); // Очищаем текстовое поле перед заполнением
                            while (reader.Read())
                            {
                                // Добавляем имя студента в текстовое поле
                                txtParticipants.AppendText(reader.GetString(0) + Environment.NewLine);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных направления: {ex.Message}");
            }
        }

        private void updating_scientific_Click(object sender, EventArgs e)
        {
        }

        private void beck_deportament_Click(object sender, EventArgs e)
        {
            Hide();
            new deportament_structure().Show();
        }

        private void lbDirections_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDirections.SelectedItem is Direction selectedDirection)
            {
                LoadDirectionDetails(selectedDirection.Id);
            }
        }
    }

    public class Direction
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name; // Отображаем название направления в ListBox
        }
    }
}
