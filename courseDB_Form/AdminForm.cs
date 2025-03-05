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
using System.Xml.Linq;

namespace courseDB_Form
{
    public partial class AdminForm : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=268413;Database=testDB";
        public AdminForm()
        {
            InitializeComponent();
            panelRegistration.Visible = false;
            panelAddDIrection.Visible = false;
            panelUpdateDirection.Visible = false;
            panelUpdateTeacher.Visible = false;
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            cbGroup.Visible = false;

            txtNewPost.Visible = false;
            txtNewStay.Visible = false;
            txtNewInterests.Visible = false;

            pictureBoxTeacherPhoto.Visible = false;

            panelRegistration.Visible = true;
            panelAddDIrection.Visible = false;
            panelUpdateDirection.Visible = false;
            panelUpdateTeacher.Visible = false;

            btnUploadPhoto.Visible = false;

            lbGroup.Visible = false;
            lbInterest.Visible = false;
            lbPost.Visible = false;
            lbStay.Visible = false;

        }

        private void btnUpdateTeacher_Click(object sender, EventArgs e)
        {
            panelRegistration.Visible = false;
            panelAddDIrection.Visible = false;
            panelUpdateDirection.Visible = false;
            panelUpdateTeacher.Visible = true;
        }

        private void scientificWorkUpdating_Click(object sender, EventArgs e)
        {
            panelRegistration.Visible = false;
            panelAddDIrection.Visible = true;
            panelUpdateDirection.Visible = false;
            panelUpdateTeacher.Visible = false;
        }
        // Сделано
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtNewUsername.Text;
            string password = txtNewPassword.Text;
            string post = txtNewPost.Text;
            string stay = txtNewStay.Text;
            string researchInterests = txtNewInterests.Text;
            string role = cbSelectUserRegistration.SelectedItem.ToString();
            string group = cbGroup.SelectedItem.ToString();
            RegisterUser(name, password, role, group, post, stay, researchInterests, ConvertImageToByteArray());
        }
        // Кнопка для добавлени фото
        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxUserPhoto.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        // Переделать метод
        private void btnSearchTeacher_Click(object sender, EventArgs e)
        {
            int userId;
            if (!int.TryParse(txtTeacherId.Text, out userId))
            {
                MessageBox.Show("Введите корректный ID пользователя!");
                return;
            }

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT name, password, position, duration, research_interests, photo_path FROM users WHERE id = @id";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", userId);
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtTeacherName.Text = reader["name"].ToString();
                                txtTeacherPassword.Text = reader["password"].ToString();
                                txtTeacherPost.Text = reader["position"].ToString();
                                txtTeacherStay.Text = reader["duration"].ToString();
                                txtTeacherInterests.Text = reader["research_interests"].ToString();

                                string photoPath = reader["photo_path"].ToString();
                                if (File.Exists(photoPath))
                                {
                                    pictureBoxTeacherPhoto.Image = Image.FromFile(photoPath);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Преподаватель не найден!");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateTeacherPhoto_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchDirection_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteParticipiant_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            int userId;
            if (!int.TryParse(txtIDAddDirection.Text, out userId))
            {
                MessageBox.Show("Введите корректный ID пользователя!");
                return;
            }

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT name FROM users WHERE id = @id";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", userId);
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string participantName = reader["name"].ToString();
                                listBoxPracticantNew.Items.Add(participantName);
                            }
                            else
                            {
                                MessageBox.Show("Пользователь не найден!");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void btnUpdateDirection_Click(object sender, EventArgs e)
        {
            panelRegistration.Visible = false;
            panelAddDIrection.Visible = false;
            panelUpdateDirection.Visible = true;
            panelUpdateTeacher.Visible = false;
        }


        private void btnExitDirection_Click(object sender, EventArgs e)
        {

        }


        // Кнопка для добавления пользователя к научной работе
        private void btnAddUserToDirection_Click(object sender, EventArgs e)
        {

        }

        // Кнопка для добавления новой научной работы
        private void btnAddDirectionWork_Click(object sender, EventArgs e)
        {
            string researchField = txtAddDirectionName.Text;
            int leaderId;
            if (!int.TryParse(txtHeadID.Text, out leaderId))
            {
                MessageBox.Show("Введите корректный ID лидера!");
                return;
            }
            string description = txtAddDirectionBrief.Text;
            List<int> participantIds = new List<int>();

            foreach (var item in listBoxPracticantNew.SelectedItems)
            {
                if (int.TryParse(item.ToString(), out int participantId))
                {
                    participantIds.Add(participantId);
                }
            }

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO researchdirections (brief_description, teacher_id, direction_name) VALUES (@research_field, @leader_id, @description) RETURNING id";
                    int researchId;

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@research_field", researchField);
                        cmd.Parameters.AddWithValue("@leader_id", leaderId);
                        cmd.Parameters.AddWithValue("@description", description);
                        researchId = (int)cmd.ExecuteScalar();
                    }

                    foreach (int participantId in participantIds)
                    {
                        string participantQuery = "INSERT INTO research_participants (research_id, participant_id) VALUES (@research_id, @participant_id)";
                        using (NpgsqlCommand cmd = new NpgsqlCommand(participantQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@research_id", researchId);
                            cmd.Parameters.AddWithValue("@participant_id", participantId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Научная работа успешно добавлена!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        // Кнопка для выхода из админской панели
        private void btnExitToLog_Click(object sender, EventArgs e)
        {
            Hide();
            new Login().Show();
        }

        // Обработчик выбора роли пользователя в comboBox
        private void cbSelectUserRegistration_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelectUserRegistration.SelectedItem.ToString() == "TEACHER")
            {
                txtNewPost.Visible = true;
                txtNewStay.Visible = true;
                txtNewInterests.Visible = true;

                cbGroup.Visible = false;

                pictureBoxTeacherPhoto.Visible = true;

                btnUploadPhoto.Visible = true;

                lbGroup.Visible = false;
                lbInterest.Visible = true;
                lbPost.Visible = true;
                lbStay.Visible = true;

            }
            else if (cbSelectUserRegistration.SelectedItem.ToString() == "STUDENT")
            {
                cbGroup.Visible = true;

                txtNewPost.Visible = false;
                txtNewStay.Visible = false;
                txtNewInterests.Visible = false;

                pictureBoxTeacherPhoto.Visible = false;

                btnUploadPhoto.Visible = false;

                lbGroup.Visible = true;
                lbInterest.Visible = false;
                lbPost.Visible = false;
                lbStay.Visible = false;
            }
            else if (cbSelectUserRegistration.SelectedItem.ToString() == "ADMIN")
            {
                cbGroup.Visible = false;

                txtNewPost.Visible = false;
                txtNewStay.Visible = false;
                txtNewInterests.Visible = false;

                pictureBoxTeacherPhoto.Visible = false;

                btnUploadPhoto.Visible = false;

                lbGroup.Visible = false;
                lbInterest.Visible = false;
                lbPost.Visible = false;
                lbStay.Visible = false;
            }
        }

        // Метод для геристрации нового пользователя
        public void RegisterUser(string userName, string password, string role, string group, string post, string scientificInterests, string scheduleOfStay, byte[] teacherImage)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Начинаем транзакцию
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Вставляем данные в таблицу Users
                            string userQuery = "INSERT INTO Users (user_name, user_password, user_role) VALUES (@user_name, @password, @role) RETURNING user_ID;";
                            int userId;

                            using (var userCmd = new NpgsqlCommand(userQuery, connection, transaction))
                            {
                                userCmd.Parameters.AddWithValue("@user_name", userName);
                                userCmd.Parameters.AddWithValue("@password", HashPassword(password)); // Хэшируем пароль
                                userCmd.Parameters.AddWithValue("@role", role);

                                userId = (int)userCmd.ExecuteScalar(); // Получаем ID нового пользователя
                            }

                            // В зависимости от роли, вставляем данные в соответствующую таблицу
                            switch (role)
                            {
                                case "STUDENT":
                                    if (string.IsNullOrEmpty(group))
                                        throw new ArgumentException("Группа не указана для студента.");

                                    string studentQuery = "INSERT INTO Students (student_name, group_ID, user_ID) VALUES (@student_name, @group_ID, @user_ID);";
                                    using (var studentCmd = new NpgsqlCommand(studentQuery, connection, transaction))
                                    {
                                        studentCmd.Parameters.AddWithValue("@student_name", userName);
                                        studentCmd.Parameters.AddWithValue("@group_ID", GetGroupIdByName(group)); // Предполагаем, что group_ID — это число
                                        studentCmd.Parameters.AddWithValue("@user_ID", userId);
                                        studentCmd.ExecuteNonQuery();
                                    }
                                    break;

                                case "TEACHER":
                                    if (string.IsNullOrEmpty(post) || string.IsNullOrEmpty(scientificInterests) || string.IsNullOrEmpty(scheduleOfStay))
                                        throw new ArgumentException("Не все данные преподавателя указаны.");

                                    string teacherQuery = "INSERT INTO Teachers (teacher_name, post, scientific_interests, schedule_of_stay, teacher_image, user_ID) VALUES (@teacher_name, @post, @scientific_interests, @schedule_of_stay, @teacher_image, @user_ID);";
                                    using (var teacherCmd = new NpgsqlCommand(teacherQuery, connection, transaction))
                                    {
                                        teacherCmd.Parameters.AddWithValue("@teacher_name", userName);
                                        teacherCmd.Parameters.AddWithValue("@post", post);
                                        teacherCmd.Parameters.AddWithValue("@scientific_interests", scientificInterests);
                                        teacherCmd.Parameters.AddWithValue("@schedule_of_stay", scheduleOfStay);
                                        teacherCmd.Parameters.AddWithValue("@teacher_image", teacherImage != null ? (object)teacherImage : DBNull.Value); // Если фото не указано, сохраняем NULL
                                        teacherCmd.Parameters.AddWithValue("@user_ID", userId);
                                        teacherCmd.ExecuteNonQuery();
                                    }
                                    break;

                                case "ADMIN":
                                    // Для администратора не нужно дополнительных данных
                                    break;

                                default:
                                    throw new ArgumentException("Неизвестная роль пользователя.");
                            }

                            // Подтверждаем транзакцию
                            transaction.Commit();
                            MessageBox.Show("Регистрация прошла успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            // Откатываем транзакцию в случае ошибки
                            transaction.Rollback();
                            MessageBox.Show($"Ошибка регистрации: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод для хэширования пароля (с использованием SHA-256)
        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        // Метод для получения id группы по ее названию
        public int GetGroupIdByName(string groupName)
        {
            int groupId = -1; 

            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

          
                    string query = "SELECT group_ID FROM groups WHERE group_name = @group_name;";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@group_name", groupName);

 
                        var result = cmd.ExecuteScalar();

                      
                        if (result != null && result != DBNull.Value)
                        {
                            groupId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении ID группы: {ex.Message}");
            }

            return groupId;
        }


        public byte[] ConvertImageToByteArray()
        {
            if (pictureBoxUserPhoto.Image == null)
            {
                return null;
            }

            // Преобразуем изображение в массив байтов
            using (MemoryStream ms = new MemoryStream())
            {
                // Сохраняем изображение в MemoryStream в формате JPEG (или другом формате)
                pictureBoxUserPhoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                // Возвращаем массив байтов
                return ms.ToArray();
            }
        }
    }
}
