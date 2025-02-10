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

        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=yourpassword;Database=YourDatabase";
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

                    string query = "SELECT Id, Name FROM ResearchDirections";

                    using (var command = new NpgsqlCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        /*while (reader.Read())
                        {
                            lstDirections.Items.Add(new Direction
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1)
                            });
                        }*/
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки направлений: {ex.Message}");
            }
        }

        private void lstDirections_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (lstDirections.SelectedItem is Direction selectedDirection)
            {
                LoadDirectionDetails(selectedDirection.Id);
            }*/
        }

        private void LoadDirectionDetails(int directionId)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Получаем описание направления
                    string descriptionQuery = "SELECT Description FROM ResearchDirections WHERE Id = @Id";
                    using (var descriptionCommand = new NpgsqlCommand(descriptionQuery, connection))
                    {
                        descriptionCommand.Parameters.AddWithValue("@Id", directionId);
                        txtDescription.Text = descriptionCommand.ExecuteScalar()?.ToString();
                    }

                    // Получаем участников направления
                    string participantsQuery = "SELECT Name FROM Participants WHERE ResearchDirectionId = @Id";
                    using (var participantsCommand = new NpgsqlCommand(participantsQuery, connection))
                    {
                        participantsCommand.Parameters.AddWithValue("@Id", directionId);

                        using (var reader = participantsCommand.ExecuteReader())
                        {
                            txtParticipants.Clear();
                            while (reader.Read())
                            {
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
            int userID = 0;
            Hide();
            new deportament_structure(userID).Show();

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
