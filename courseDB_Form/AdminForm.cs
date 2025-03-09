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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            panelAddCourse.Visible = false;

        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            cbSelectUserRegistration.SelectionStart = cbSelectUserRegistration.SelectedIndex = 0;
            cbGroup.Visible = false;

            txtNewPost.Visible = true;
            txtNewStay.Visible = true;
            txtNewInterests.Visible = true;

            pbUpPhoto.Visible = true;

            panelAddCourse.Visible = false;
            panelRegistration.Visible = true;
            panelAddDIrection.Visible = false;
            panelUpdateDirection.Visible = false;
            panelUpdateTeacher.Visible = false;

            btnUploadPhoto.Visible = true;

            lbGroup.Visible = false;
            lbInterest.Visible = true;
            lbPost.Visible = true;
            lbStay.Visible = true;

        }

        private void btnUpdateTeacher_Click(object sender, EventArgs e)
        {
            cbUpRole.SelectionStart = cbUpRole.SelectedIndex = 0;
            panelAddCourse.Visible = false;
            panelUpdateTeacher.Visible = true;
            panelRegistration.Visible = false;
            panelAddDIrection.Visible = false;
            panelUpdateDirection.Visible = false;
        }

        private void scientificWorkUpdating_Click(object sender, EventArgs e)
        {
            panelAddCourse.Visible = false;
            panelRegistration.Visible = false;
            panelAddDIrection.Visible = false;
            panelUpdateDirection.Visible = true;
            panelUpdateTeacher.Visible = false;
            LoadScientificDirectionsIntoComboBox(cbDirectionUp);
            LoadStudentsIntoComboBox(cbAddUserToDIrection);

        }
        // Кнопка для регистрации нового пользователя
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtNewUsername.Text;
            string password = txtNewPassword.Text;
            string post = txtNewPost.Text;
            string stay = txtNewStay.Text;
            string researchInterests = txtNewInterests.Text;
            string role = cbSelectUserRegistration.SelectedItem.ToString();
            string group = "";
            if (cbGroup.SelectedItem != null)
            {
                group = cbGroup.SelectedItem.ToString();
            }
            RegisterUser(name, password, role, group, post, stay, researchInterests, ConvertImageToByteArray());
        }
        // Кнопка для добавления фото при регистрации
        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            addPhoto(pictureBoxUserPhoto);
        }
        // Метод для добавления фото
        private void addPhoto(PictureBox box)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Настройка фильтра для выбора только изображений
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                // Если пользователь выбрал файл и нажал "ОК"
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Загружаем выбранное изображение в PictureBox
                        box.Image = Image.FromFile(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при загрузке изображения: " + ex.Message, "Ошибка");
                    }
                }
            }
        }
        // Кнопка обновления данных о пользователях
        private void btnUpdate_Click(object sender, EventArgs e)
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
                            // Получаем данные из текстовых полей
                            string newUserName = txtUpName.Text;
                            string newPassword = txtUpPassword.Text;
                            string newRole = cbUpRole.SelectedItem.ToString(); // Роль пользователя (STUDENT или TEACHER)

                            // Обновляем данные в таблице Users
                            string updateUserQuery = @"
                            UPDATE users
                            SET user_name = @new_user_name, user_password = @new_password
                            WHERE user_name = @user_name;";

                            using (var userCmd = new NpgsqlCommand(updateUserQuery, connection, transaction))
                            {
                                userCmd.Parameters.AddWithValue("@new_user_name", newUserName);
                                userCmd.Parameters.AddWithValue("@new_password", HashPassword(newPassword)); // Хэшируем пароль
                                userCmd.Parameters.AddWithValue("@user_name", cbUpSearch.SelectedItem.ToString());

                                userCmd.ExecuteNonQuery();
                            }

                            // В зависимости от роли, обновляем данные в соответствующей таблице
                            switch (newRole)
                            {
                                case "STUDENT":
                                    // Получаем данные о группе
                                    string newGroup = txtUpGroup.Text;

                                    // Обновляем данные в таблице Students
                                    string updateStudentQuery = @"
                                    UPDATE students
                                    SET group_ID = @group_ID
                                    WHERE user_ID = (SELECT user_ID FROM users WHERE user_name = @user_name);";

                                    using (var studentCmd = new NpgsqlCommand(updateStudentQuery, connection, transaction))
                                    {
                                        studentCmd.Parameters.AddWithValue("@group_ID", int.Parse(newGroup)); // Предполагаем, что group_ID — это число
                                        studentCmd.Parameters.AddWithValue("@user_name", newUserName);

                                        studentCmd.ExecuteNonQuery();
                                    }
                                    break;

                                case "TEACHER":
                                    // Получаем данные о должности, научных интересах, времени пребывания и фото
                                    string newPost = txtUpTeacherPost.Text;
                                    string newScientificInterests = txtUpInterest.Text;
                                    string newScheduleOfStay = txtUpStay.Text;
                                    byte[] teacherImageBytes = null;

                                    // Если фото было загружено, преобразуем его в массив байтов
                                    if (pbUpPhoto.Image == null)
                                    {
                                        teacherImageBytes = null;
                                    }
                                    else
                                    {
                                        using (MemoryStream ms = new MemoryStream())
                                        {
                                            // Сохраняем изображение в MemoryStream в формате JPEG (или другом формате)
                                            pbUpPhoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                                            // Возвращаем массив байтов
                                            teacherImageBytes = ms.ToArray();
                                        }
                                    }

                                    

                                    // Обновляем данные в таблице Teachers
                                    string updateTeacherQuery = @"
                                        UPDATE teachers
                                        SET post = @post, 
                                            scientific_interests = @scientific_interests, 
                                            schedule_of_stay = @schedule_of_stay, 
                                            teacher_image = @teacher_image
                                        WHERE user_ID = (SELECT user_ID FROM users WHERE user_name = @user_name);";

                                    using (var teacherCmd = new NpgsqlCommand(updateTeacherQuery, connection, transaction))
                                    {
                                        teacherCmd.Parameters.AddWithValue("@post", newPost);
                                        teacherCmd.Parameters.AddWithValue("@scientific_interests", newScientificInterests);
                                        teacherCmd.Parameters.AddWithValue("@schedule_of_stay", newScheduleOfStay);
                                        teacherCmd.Parameters.AddWithValue("@user_name", newUserName);

                                        // Если фото было загружено, передаем массив байтов, иначе передаем NULL
                                        if (teacherImageBytes != null)
                                        {
                                            teacherCmd.Parameters.AddWithValue("@teacher_image", teacherImageBytes);
                                        }
                                        else
                                        {
                                            teacherCmd.Parameters.AddWithValue("@teacher_image", DBNull.Value); // Если фото отсутствует, передаем NULL
                                        }

                                        teacherCmd.ExecuteNonQuery();
                                    }
                                    break;

                                case "ADMIN":
                                    // Для администратора обновляем только данные в таблице Users
                                    // Никаких дополнительных действий не требуется, так как данные уже обновлены в таблице Users
                                    MessageBox.Show("Данные администратора обновлены в таблице Users.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    break;

                                default:
                                    throw new ArgumentException("Неизвестная роль пользователя.");
                            }

                            // Подтверждаем транзакцию
                            transaction.Commit();
                            MessageBox.Show("Данные пользователя успешно обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            // Откатываем транзакцию в случае ошибки
                            transaction.Rollback();
                            MessageBox.Show($"Ошибка при обновлении данных пользователя: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // кнопка для обновлнения фото
        private void btnUpdateTeacherPhoto_Click(object sender, EventArgs e)
        {
            addPhoto(pbUpPhoto);
        }


        // Метод удаления студента из участников работы
        private void btnDeleteParticipiant_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем имя студента из ListBox
                string studentName = lbPracticant.SelectedItem.ToString();

                // Получаем название направления из ComboBox
                string directionName = cbDirectionUp.SelectedItem.ToString();

                // Получаем student_id по имени студента
                int studentId = GetStudentIdByName(studentName);

                if (studentId == 0)
                {
                    MessageBox.Show("Студент не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Получаем direction_id по названию направления
                int directionId = GetDirectionIdByName(directionName);

                if (directionId == 0)
                {
                    MessageBox.Show("Научное направление не найдено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Удаляем студента из участников направления
                RemoveParticipantFromDirection(studentId, directionId);

                MessageBox.Show("Студент успешно удален из научного направления!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Обновляем список участников
                LoadParticipantsByDirectionId(directionId, lbPracticant);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении студента: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // кнопка добавления студенка к научной работе
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем имя студента и название направления из ComboBox
                string studentName = cbAddUserToDIrection.SelectedItem.ToString();
                string directionName = cbDirectionUp.SelectedItem.ToString();

                // Получаем student_id по имени студента
                int studentId = GetStudentIdByName(studentName);

                if (studentId == 0)
                {
                    MessageBox.Show("Студент не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Получаем direction_id по названию направления
                int directionId = GetDirectionIdByName(directionName);

                if (directionId == 0)
                {
                    MessageBox.Show("Научное направление не найдено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Добавляем студента в таблицу участников
                AddParticipantToDirection(studentId, directionId);

                MessageBox.Show("Студент успешно добавлен в научное направление!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении студента: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Кнопка обновления научного направления
        private void btnUpdateDirection_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем название направления из ComboBox
                string directionName = cbDirectionUp.SelectedItem.ToString();

                // Получаем новую характеристику направления из текстового поля
                string newDescription = txtDirectionBrief.Text;

                // Проверяем, что поле с характеристикой не пустое
                if (string.IsNullOrEmpty(newDescription))
                {
                    MessageBox.Show("Поле характеристики не может быть пустым.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Получаем direction_id по названию направления
                int directionId = GetDirectionIdByName(directionName);

                if (directionId == 0)
                {
                    MessageBox.Show("Научное направление не найдено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Обновляем характеристику направления
                UpdateDirectionDescription(directionId, newDescription);

                MessageBox.Show("Характеристика направления успешно обновлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении характеристики направления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        // Кнопка для добавления новой научной работы
        private void btnAddDirectionWork_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем данные из текстовых полей и ComboBox
                string workTitle = txtAddDirectionName.Text; // Название научной работы
                string workDescription = txtAddDirectionBrief.Text; // Описание научной работы
                string teacherName = cbAddHead.SelectedItem.ToString(); // Имя преподавателя

                // Получаем teacher_id по имени преподавателя

                int teacherId = GetTeacherIdByName(teacherName);

                if (teacherId == -1)
                {
                    MessageBox.Show("Преподаватель не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Создаем новую научную работу
                CreateScientificWork(workTitle, workDescription, teacherId);

                MessageBox.Show("Научная работа успешно создана!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании научной работы: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                pbUpPhoto.Visible = true;

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

                pbUpPhoto.Visible = false;

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

                pbUpPhoto.Visible = false;

                btnUploadPhoto.Visible = false;

                lbGroup.Visible = false;
                lbInterest.Visible = false;
                lbPost.Visible = false;
                lbStay.Visible = false;
            }
        }

        // Метод для регистрации нового пользователя
        public void RegisterUser(string userName, string password, string role, string group, string post, string scientificInterests, string scheduleOfStay, byte[] teacherImage)//byte[] teacherImage
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

                                    int groupId = GetGroupIdByName(group);
                                    if (groupId == 0) // Предположим, что 0 — это недопустимое значение
                                    {
                                        throw new ArgumentException("Группа не найдена.");
                                    }

                                    string studentQuery = "INSERT INTO Students (student_name, group_ID, user_ID) VALUES (@student_name, @group_ID, @user_ID);";
                                    using (var studentCmd = new NpgsqlCommand(studentQuery, connection, transaction))
                                    {
                                        studentCmd.Parameters.AddWithValue("@student_name", userName);
                                        studentCmd.Parameters.AddWithValue("@group_ID", groupId);
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
        // Метод для получение айди преподавателя по имени
        private int GetTeacherIdByName(string teacherName)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT teacher_id FROM teachers WHERE teacher_name = @teacher_name;";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@teacher_name", teacherName);

                        var result = command.ExecuteScalar();

                        if (result != null)
                        {
                            return Convert.ToInt32(result); // Возвращаем teacher_id
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при получении teacher_id: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return -1; // Если преподаватель не найден
        }
        // Метод для получения student_id по имени студента
        private int GetStudentIdByName(string studentName)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT student_id FROM students WHERE student_name = @student_name;";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@student_name", studentName);

                        var result = command.ExecuteScalar();

                        if (result != null)
                        {
                            return Convert.ToInt32(result); // Возвращаем student_id
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при получении student_id: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return 0; // Если студент не найден
        }

        // Метод для получения direction_id по названию направления
        private int GetDirectionIdByName(string directionName)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT direction_id FROM researchdirections WHERE direction_name = @direction_name;";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@direction_name", directionName);

                        var result = command.ExecuteScalar();

                        if (result != null)
                        {
                            return Convert.ToInt32(result); // Возвращаем direction_id
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при получении direction_id: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return 0; // Если направление не найдено
        }

        // метод преобразования фото в массив байтов
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
        // метод преобразования массива байтов в фото
        private void LoadImageFromByteArray(byte[] imageBytes, PictureBox pictureBox)
        {
            try
            {
                // Проверяем, что массив байтов не пустой
                if (imageBytes == null || imageBytes.Length == 0)
                {
                    MessageBox.Show("Изображение отсутствует или пустое.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Преобразуем массив байтов в изображение
                using (var ms = new MemoryStream(imageBytes))
                {
                    Image image = Image.FromStream(ms);

                    // Загружаем изображение в PictureBox
                    pictureBox.Image = image;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке изображения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbUpSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Получаем выбранное имя пользователя
            string selectedUserName = cbUpSearch.SelectedItem.ToString();

            // Загружаем данные о пользователе
            LoadUserData(selectedUserName);
        }

        private void cbUpGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // Метод для добавления студента в таблицу участников
        private void AddParticipantToDirection(int studentId, int directionId)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Проверяем, существует ли уже запись с таким student_id и direction_id
                    string checkQuery = @"
                SELECT COUNT(*)
                FROM researchparticipants
                WHERE student_id = @student_id AND direction_id = @direction_id;";

                    using (var checkCommand = new NpgsqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@student_id", studentId);
                        checkCommand.Parameters.AddWithValue("@direction_id", directionId);

                        int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Этот студент уже является участником данного направления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Если дубликатов нет, добавляем запись
                    string insertQuery = @"
                INSERT INTO researchparticipants (student_id, direction_id)
                VALUES (@student_id, @direction_id);";

                    using (var insertCommand = new NpgsqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@student_id", studentId);
                        insertCommand.Parameters.AddWithValue("@direction_id", directionId);

                        insertCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Студент успешно добавлен в научное направление!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении студента в направление: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Комбо бокс для выбора роли
        private void cbUpRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Загружаем имена пользователей с выбранной ролью
            GetUserNamesByRole(cbUpRole.SelectedItem.ToString());

            if (cbUpRole.SelectedItem.ToString() == "TEACHER")
            {
                txtUpTeacherPost.Visible = true;
                txtUpStay.Visible = true;
                txtUpInterest.Visible = true;
                txtUpGroup.Visible = false;

                pbUpPhoto.Visible = true;

                btnUpPhoto.Visible = true;

                lbUpGroup.Visible = false;
                lbUpInterest.Visible = true;
                lbUpPost.Visible = true;
                lbUpStay.Visible = true;

            }
            else if (cbUpRole.SelectedItem.ToString() == "STUDENT")
            {
                txtUpGroup.Visible = true;
                txtUpTeacherPost.Visible = false;
                txtUpStay.Visible = false;
                txtUpInterest.Visible = false;

                pbUpPhoto.Visible = false;

                btnUpPhoto.Visible = false;

                lbUpGroup.Visible = true;
                lbUpInterest.Visible = false;
                lbUpPost.Visible = false;
                lbUpStay.Visible = false;
            }
            else if (cbUpRole.SelectedItem.ToString() == "ADMIN")
            {
                txtUpGroup.Visible = false;
                txtUpTeacherPost.Visible = false;
                txtUpStay.Visible = false;
                txtUpInterest.Visible = false;

                pbUpPhoto.Visible = false;

                btnUpPhoto.Visible = false;

                lbUpGroup.Visible = false;
                lbUpInterest.Visible = false;
                lbUpPost.Visible = false;
                lbUpStay.Visible = false;
            }
        }
        // Метод получения имен по роли
        private void GetUserNamesByRole(string role)
        {
            List<string> userNames = new List<string>();
            cbUpSearch.Items.Clear();
            try
            {
                if (role != null)
                {
                    using (var connection = new NpgsqlConnection(connectionString))
                    {
                        connection.Open();

                        // SQL-запрос для получения имен пользователей с выбранной ролью
                        string query = "SELECT user_name FROM Users WHERE user_role = @role;";

                        using (var command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@role", role);

                            using (var reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string userName = reader.GetString(0); // Получаем user_name
                                    userNames.Add(userName);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке пользователей: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (string userName in userNames)
            {
                cbUpSearch.Items.Add(userName);
            }
        }
        // Метод загрузки данных о пользователях в обновлении
        private void LoadUserData(string userName)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Исправленный SQL-запрос
                    string query = @"
                SELECT 
                    u.user_name, 
                    u.user_role, 
                    u.user_password, 
                    t.post, 
                    t.scientific_interests, 
                    t.schedule_of_stay, 
                    t.teacher_image,
                    s.group_ID
                FROM users u
                LEFT JOIN teachers t ON u.user_ID = t.user_ID
                LEFT JOIN students s ON u.user_ID = s.user_ID
                WHERE u.user_name = @user_name;";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@user_name", userName);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Заполняем данные о пользователе
                                txtUpName.Text = reader.GetString(0); // user_name
                                txtUpPassword.Text = reader.GetString(2); // user_password

                                // Получаем роль пользователя
                                string userRole = reader.GetString(1); // user_role

                                // Если пользователь — преподаватель, отображаем данные из таблицы Teachers
                                if (userRole == "TEACHER")
                                {
                                    if (!reader.IsDBNull(3)) // post
                                    {
                                        txtUpTeacherPost.Text = reader.GetString(3);
                                    }
                                    else
                                    {
                                        txtUpTeacherPost.Text = "Нет данных";
                                    }

                                    if (!reader.IsDBNull(4)) // scientific_interests
                                    {
                                        txtUpInterest.Text = reader.GetString(4);
                                    }
                                    else
                                    {
                                        txtUpInterest.Text = "Нет данных";
                                    }

                                    if (!reader.IsDBNull(5)) // schedule_of_stay
                                    {
                                        txtUpStay.Text = reader.GetString(5);
                                    }
                                    else
                                    {
                                        txtUpStay.Text = "Нет данных";
                                    }

                                    // Загружаем фото преподавателя, если оно есть
                                    if (!reader.IsDBNull(6)) // teacher_photo
                                    {

                                        try
                                        {
                                            // Получаем массив байтов из колонки teacher_photo
                                            byte[] teacherPhotoBytes = reader.GetFieldValue<byte[]>(6);

                                            // Передаем массив байтов в метод для загрузки изображения
                                            LoadImageFromByteArray(teacherPhotoBytes, pbUpPhoto);
                                        }
                                        catch (Exception ex) // Ловим все исключения (например, проблемы с форматом данных)
                                        {
                                            MessageBox.Show($"Ошибка при загрузке изображения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            pbUpPhoto.Image = null; // Очищаем PictureBox
                                        }
                                    }
                                    else
                                    {
                                        pbUpPhoto.Image = null; // Очищаем PictureBox, если фото отсутствует
                                    }
                                }

                                // Если пользователь — студент, отображаем данные из таблицы Students
                                if (userRole == "STUDENT")
                                {
                                    if (!reader.IsDBNull(7)) // group_ID
                                    {
                                        txtUpGroup.Text = reader.GetInt32(7).ToString();
                                    }
                                    else
                                    {
                                        txtUpGroup.Text = "Нет данных";
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Пользователь не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных о пользователе: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // метод загрузки преподавателей в комбобокс
        private void LoadTeachersIntoComboBox(ComboBox comboBox)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL-запрос для получения имен преподавателей
                    string query = "SELECT teacher_name FROM teachers;";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            // Очищаем ComboBox перед загрузкой новых данных
                            comboBox.Items.Clear();

                            // Добавляем имена преподавателей в ComboBox
                            while (reader.Read())
                            {
                                string teacherName = reader.GetString(0); // Получаем имя преподавателя
                                comboBox.Items.Add(teacherName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке имен преподавателей: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //кнопка открытия меню добавления научного направления
        private void btnAddDirection_Click(object sender, EventArgs e)
        {
            panelAddCourse.Visible = false;
            panelRegistration.Visible = false;
            panelAddDIrection.Visible = true;
            panelUpdateDirection.Visible = false;
            panelUpdateTeacher.Visible = false;
            LoadTeachersIntoComboBox(cbAddHead);
        }

        // Метод для создания новой научной работы
        private void CreateScientificWork(string title, string description, int teacherId)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL-запрос для вставки новой научной работы
                    string query = @"
                INSERT INTO researchdirections (direction_name, brief_description, teacher_id)
                VALUES (@work_title, @work_description, @teacher_id);";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@work_title", title);
                        command.Parameters.AddWithValue("@work_description", description);
                        command.Parameters.AddWithValue("@teacher_id", teacherId);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании научной работы: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Метод добалвения названий научной работы в комбо бокс
        private void LoadScientificDirectionsIntoComboBox(ComboBox comboBox)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL-запрос для получения названий научных направлений
                    string query = "SELECT direction_name FROM researchdirections;";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            // Очищаем ComboBox перед загрузкой новых данных
                            comboBox.Items.Clear();

                            // Добавляем названия научных направлений в ComboBox
                            while (reader.Read())
                            {
                                string directionName = reader.GetString(0); // Получаем название направления
                                comboBox.Items.Add(directionName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке научных направлений: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Метд добавления имен студентов в комбо бокс
        private void LoadStudentsIntoComboBox(ComboBox comboBox)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT student_name FROM students;";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            comboBox.Items.Clear();

                            while (reader.Read())
                            {
                                string studentName = reader.GetString(0);
                                comboBox.Items.Add(studentName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке имен студентов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // загрузка данных от выбора научного направления
        private void cbDirectionUp_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDirectionDetailsAndParticipants(cbDirectionUp, txtDirectionLiderName, txtDirectionBrief, lbPracticant);
        }
        private void LoadDirectionDetailsAndParticipants(ComboBox comboBoxDirections, TextBox txtLeaderName, TextBox txtDirectionDescription, ListBox listBoxParticipants)
        {
            try
            {
                // Получаем выбранное научное направление из ComboBox
                string selectedDirection = comboBoxDirections.SelectedItem.ToString();

                // Получаем direction_id по названию направления
                int directionId = GetDirectionIdByName(selectedDirection);

                if (directionId == 0)
                {
                    MessageBox.Show("Научное направление не найдено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Загружаем данные о направлении (имя лидера и характеристика)
                LoadDirectionDetails(directionId, txtLeaderName, txtDirectionDescription);

                // Загружаем участников направления
                LoadParticipantsByDirectionId(directionId, listBoxParticipants);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод для загрузки данных о направлении (имя лидера и характеристика)
        private void LoadDirectionDetails(int directionId, TextBox txtLeaderName, TextBox txtDirectionDescription)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL-запрос с JOIN между researchdirections и teachers
                    string query = @"
                        SELECT t.teacher_name, sd.brief_description
                        FROM researchdirections sd
                        JOIN teachers t ON sd.teacher_id = t.teacher_id
                        WHERE sd.direction_id = @direction_id;";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@direction_id", directionId);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Заполняем данные о направлении
                                txtLeaderName.Text = reader.GetString(0); // Имя лидера (преподавателя)
                                txtDirectionDescription.Text = reader.GetString(1); // Характеристика направления
                            }
                            else
                            {
                                MessageBox.Show("Данные о направлении не найдены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных о направлении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод для загрузки участников направления
        private void LoadParticipantsByDirectionId(int directionId, ListBox listBoxParticipants)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL-запрос с JOIN между researchparticipants и students
                    string query = @"
                        SELECT s.student_name
                        FROM researchparticipants rp
                        JOIN students s ON rp.student_id = s.student_id
                        WHERE rp.direction_id = @direction_id;";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@direction_id", directionId);

                        using (var reader = command.ExecuteReader())
                        {
                            // Очищаем ListBox перед загрузкой новых данных
                            listBoxParticipants.Items.Clear();

                            // Добавляем участников в ListBox
                            while (reader.Read())
                            {
                                string participantName = reader.GetString(0); // Имя студента
                                listBoxParticipants.Items.Add(participantName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке участников: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateDirectionDescription(int directionId, string newDescription)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL-запрос для обновления характеристики направления
                    string query = @"
                UPDATE researchdirections
                SET brief_description = @direction_description
                WHERE direction_id = @direction_id;";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@direction_description", newDescription);
                        command.Parameters.AddWithValue("@direction_id", directionId);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении характеристики направления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Метод для удаления студента из участников направления
        private void RemoveParticipantFromDirection(int studentId, int directionId)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL-запрос для удаления записи из таблицы researchparticipants
                    string query = @"
                DELETE FROM researchparticipants
                WHERE student_id = @student_id AND direction_id = @direction_id;";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@student_id", studentId);
                        command.Parameters.AddWithValue("@direction_id", directionId);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении студента из направления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Кнопка открытия панели для добавлкния курса
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            panelAddCourse.Visible = true;
            panelRegistration.Visible = false;
            panelAddDIrection.Visible = false;
            panelUpdateDirection.Visible = false;
            panelUpdateTeacher.Visible = false;
            LoadTeachersIntoComboBox(cbAddTeacherToCourse);
        }

        private void btnAddNewCourse_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем данные из текстовых полей
                string courseName = txtNewCourseName.Text; // Название курса
                string program = txtNewDiscipline.Text; // Программа дисциплин
                string materials = txtNewMaterials.Text; // Методические материалы

                // Получаем имя преподавателя из ComboBox
                string teacherName = cbAddTeacherToCourse.SelectedItem.ToString();

                // Получаем teacher_id по имени преподавателя
                int teacherId = GetTeacherIdByName(teacherName);

                if (teacherId == 0)
                {
                    MessageBox.Show("Преподаватель не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Создаем новый курс
                CreateCourse(courseName, program, materials, teacherId);

                MessageBox.Show("Курс успешно создан!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании курса: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        // Метод для создания нового курса
        private void CreateCourse(string courseName, string program, string materials, int teacherId)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL-запрос для добавления нового курса
                    string query = @"
                    INSERT INTO courses (course_name, discipline_program, methodological_material, teacher_id)
                    VALUES (@course_name, @program, @materials, @teacher_id);";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@course_name", courseName);
                        command.Parameters.AddWithValue("@program", program);
                        command.Parameters.AddWithValue("@materials", materials);
                        command.Parameters.AddWithValue("@teacher_id", teacherId);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании курса: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

