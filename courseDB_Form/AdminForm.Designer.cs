namespace courseDB_Form
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRegistration = new Button();
            btnUpdateTeacher = new Button();
            btnScientificWorkUpdating = new Button();
            panelRegistration = new Panel();
            panelUpdateTeacher = new Panel();
            txtNewUsername = new TextBox();
            txtNewPassword = new TextBox();
            txtNewInterests = new TextBox();
            txtNewStay = new TextBox();
            pictureBoxUserPhoto = new PictureBox();
            btnUploadPhoto = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnRegister = new Button();
            txtNewPost = new TextBox();
            label5 = new Label();
            txtTeacherName = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtTeacherPassword = new TextBox();
            label8 = new Label();
            txtTeacherPost = new TextBox();
            label9 = new Label();
            txtTeacherStay = new TextBox();
            label10 = new Label();
            txtTeacherInterests = new TextBox();
            txtTeacherId = new TextBox();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            btnUpdateTeacherPhoto = new Button();
            btnUpdate = new Button();
            btnExit = new Button();
            btnSearchTeacher = new Button();
            panelUpdateDirection = new Panel();
            btnSearchDirection = new Button();
            btnExitDirection = new Button();
            btnUpdateDirection = new Button();
            label12 = new Label();
            txtDIrectionID = new TextBox();
            txtDirectionBrief = new TextBox();
            label13 = new Label();
            label17 = new Label();
            txtDIrectionName = new TextBox();
            label14 = new Label();
            txtParticipiantID = new TextBox();
            btnDeleteParticipiant = new Button();
            label15 = new Label();
            btnAddUser = new Button();
            txtUserID = new TextBox();
            txtParticipiant = new TextBox();
            label16 = new Label();
            btnAddDirection = new Button();
            panelAddDIrection = new Panel();
            label18 = new Label();
            txtAddParticipiant = new TextBox();
            txtIDAddDirection = new TextBox();
            btnAddUserToDirection = new Button();
            label19 = new Label();
            btnAddDirectionWork = new Button();
            txtAddDirectionBrief = new TextBox();
            label22 = new Label();
            label23 = new Label();
            txtAddDirectionName = new TextBox();
            btnDirectionHead = new Button();
            label20 = new Label();
            txtHeadID = new TextBox();
            panelRegistration.SuspendLayout();
            panelUpdateTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUserPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelUpdateDirection.SuspendLayout();
            panelAddDIrection.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegistration
            // 
            btnRegistration.Location = new Point(12, 12);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(184, 58);
            btnRegistration.TabIndex = 0;
            btnRegistration.Text = "Зарегистрировать нового пользователя";
            btnRegistration.UseVisualStyleBackColor = true;
            btnRegistration.Click += btnRegistration_Click;
            // 
            // btnUpdateTeacher
            // 
            btnUpdateTeacher.Location = new Point(202, 12);
            btnUpdateTeacher.Name = "btnUpdateTeacher";
            btnUpdateTeacher.Size = new Size(184, 58);
            btnUpdateTeacher.TabIndex = 1;
            btnUpdateTeacher.Text = "Обновить данные о преподавателях";
            btnUpdateTeacher.UseVisualStyleBackColor = true;
            btnUpdateTeacher.Click += btnUpdateTeacher_Click;
            // 
            // btnScientificWorkUpdating
            // 
            btnScientificWorkUpdating.Location = new Point(582, 12);
            btnScientificWorkUpdating.Name = "btnScientificWorkUpdating";
            btnScientificWorkUpdating.Size = new Size(184, 58);
            btnScientificWorkUpdating.TabIndex = 2;
            btnScientificWorkUpdating.Text = "Обновить данные о научной работе";
            btnScientificWorkUpdating.UseVisualStyleBackColor = true;
            btnScientificWorkUpdating.Click += scientificWorkUpdating_Click;
            // 
            // panelRegistration
            // 
            panelRegistration.Controls.Add(panelUpdateTeacher);
            panelRegistration.Controls.Add(label5);
            panelRegistration.Controls.Add(txtNewPost);
            panelRegistration.Controls.Add(btnRegister);
            panelRegistration.Controls.Add(label4);
            panelRegistration.Controls.Add(label3);
            panelRegistration.Controls.Add(label2);
            panelRegistration.Controls.Add(label1);
            panelRegistration.Controls.Add(btnUploadPhoto);
            panelRegistration.Controls.Add(pictureBoxUserPhoto);
            panelRegistration.Controls.Add(txtNewStay);
            panelRegistration.Controls.Add(txtNewInterests);
            panelRegistration.Controls.Add(txtNewPassword);
            panelRegistration.Controls.Add(txtNewUsername);
            panelRegistration.Location = new Point(12, 76);
            panelRegistration.Name = "panelRegistration";
            panelRegistration.Size = new Size(564, 432);
            panelRegistration.TabIndex = 3;
            // 
            // panelUpdateTeacher
            // 
            panelUpdateTeacher.Controls.Add(btnSearchTeacher);
            panelUpdateTeacher.Controls.Add(btnExit);
            panelUpdateTeacher.Controls.Add(btnUpdate);
            panelUpdateTeacher.Controls.Add(btnUpdateTeacherPhoto);
            panelUpdateTeacher.Controls.Add(pictureBox1);
            panelUpdateTeacher.Controls.Add(label11);
            panelUpdateTeacher.Controls.Add(txtTeacherId);
            panelUpdateTeacher.Controls.Add(txtTeacherInterests);
            panelUpdateTeacher.Controls.Add(label10);
            panelUpdateTeacher.Controls.Add(txtTeacherStay);
            panelUpdateTeacher.Controls.Add(label9);
            panelUpdateTeacher.Controls.Add(txtTeacherPost);
            panelUpdateTeacher.Controls.Add(label8);
            panelUpdateTeacher.Controls.Add(txtTeacherPassword);
            panelUpdateTeacher.Controls.Add(label7);
            panelUpdateTeacher.Controls.Add(label6);
            panelUpdateTeacher.Controls.Add(txtTeacherName);
            panelUpdateTeacher.Location = new Point(0, 0);
            panelUpdateTeacher.Name = "panelUpdateTeacher";
            panelUpdateTeacher.Size = new Size(564, 432);
            panelUpdateTeacher.TabIndex = 4;
            // 
            // txtNewUsername
            // 
            txtNewUsername.Location = new Point(3, 27);
            txtNewUsername.Name = "txtNewUsername";
            txtNewUsername.Size = new Size(263, 27);
            txtNewUsername.TabIndex = 0;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(3, 80);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(263, 27);
            txtNewPassword.TabIndex = 1;
            // 
            // txtNewInterests
            // 
            txtNewInterests.Location = new Point(3, 239);
            txtNewInterests.Multiline = true;
            txtNewInterests.Name = "txtNewInterests";
            txtNewInterests.Size = new Size(263, 123);
            txtNewInterests.TabIndex = 2;
            // 
            // txtNewStay
            // 
            txtNewStay.Location = new Point(3, 186);
            txtNewStay.Name = "txtNewStay";
            txtNewStay.Size = new Size(263, 27);
            txtNewStay.TabIndex = 3;
            // 
            // pictureBoxUserPhoto
            // 
            pictureBoxUserPhoto.Location = new Point(374, 167);
            pictureBoxUserPhoto.Name = "pictureBoxUserPhoto";
            pictureBoxUserPhoto.Size = new Size(187, 224);
            pictureBoxUserPhoto.TabIndex = 4;
            pictureBoxUserPhoto.TabStop = false;
            // 
            // btnUploadPhoto
            // 
            btnUploadPhoto.Location = new Point(374, 397);
            btnUploadPhoto.Name = "btnUploadPhoto";
            btnUploadPhoto.Size = new Size(187, 32);
            btnUploadPhoto.TabIndex = 5;
            btnUploadPhoto.Text = "Добавить фото";
            btnUploadPhoto.UseVisualStyleBackColor = true;
            btnUploadPhoto.Click += btnUploadPhoto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 6;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 110);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 7;
            label2.Text = "Должность";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 216);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 8;
            label3.Text = "Научные интересы";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 163);
            label4.Name = "label4";
            label4.Size = new Size(146, 20);
            label4.TabIndex = 9;
            label4.Text = "Время пребывания";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(24, 368);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(187, 61);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Зарегистрировать пользователя";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtNewPost
            // 
            txtNewPost.Location = new Point(3, 133);
            txtNewPost.Name = "txtNewPost";
            txtNewPost.Size = new Size(263, 27);
            txtNewPost.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 57);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 12;
            label5.Text = "Пароль";
            // 
            // txtTeacherName
            // 
            txtTeacherName.Location = new Point(3, 27);
            txtTeacherName.Name = "txtTeacherName";
            txtTeacherName.Size = new Size(263, 27);
            txtTeacherName.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 4);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 7;
            label6.Text = "Имя";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 57);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 13;
            label7.Text = "Пароль";
            // 
            // txtTeacherPassword
            // 
            txtTeacherPassword.Location = new Point(3, 80);
            txtTeacherPassword.Name = "txtTeacherPassword";
            txtTeacherPassword.Size = new Size(263, 27);
            txtTeacherPassword.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 110);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 15;
            label8.Text = "Должность";
            // 
            // txtTeacherPost
            // 
            txtTeacherPost.Location = new Point(3, 133);
            txtTeacherPost.Name = "txtTeacherPost";
            txtTeacherPost.Size = new Size(263, 27);
            txtTeacherPost.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 163);
            label9.Name = "label9";
            label9.Size = new Size(146, 20);
            label9.TabIndex = 17;
            label9.Text = "Время пребывания";
            // 
            // txtTeacherStay
            // 
            txtTeacherStay.Location = new Point(3, 186);
            txtTeacherStay.Name = "txtTeacherStay";
            txtTeacherStay.Size = new Size(263, 27);
            txtTeacherStay.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 216);
            label10.Name = "label10";
            label10.Size = new Size(142, 20);
            label10.TabIndex = 19;
            label10.Text = "Научные интересы";
            // 
            // txtTeacherInterests
            // 
            txtTeacherInterests.Location = new Point(3, 239);
            txtTeacherInterests.Multiline = true;
            txtTeacherInterests.Name = "txtTeacherInterests";
            txtTeacherInterests.Size = new Size(263, 123);
            txtTeacherInterests.TabIndex = 20;
            // 
            // txtTeacherId
            // 
            txtTeacherId.Location = new Point(272, 27);
            txtTeacherId.Name = "txtTeacherId";
            txtTeacherId.Size = new Size(263, 27);
            txtTeacherId.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(272, 4);
            label11.Name = "label11";
            label11.Size = new Size(194, 20);
            label11.TabIndex = 22;
            label11.Text = "Введите ID преподавателя";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(374, 167);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 224);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // btnUpdateTeacherPhoto
            // 
            btnUpdateTeacherPhoto.Location = new Point(374, 397);
            btnUpdateTeacherPhoto.Name = "btnUpdateTeacherPhoto";
            btnUpdateTeacherPhoto.Size = new Size(187, 32);
            btnUpdateTeacherPhoto.TabIndex = 24;
            btnUpdateTeacherPhoto.Text = "Добавить фото";
            btnUpdateTeacherPhoto.UseVisualStyleBackColor = true;
            btnUpdateTeacherPhoto.Click += btnUpdateTeacherPhoto_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(3, 368);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(142, 61);
            btnUpdate.TabIndex = 25;
            btnUpdate.Text = "Применить изменения";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(151, 368);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(146, 61);
            btnExit.TabIndex = 26;
            btnExit.Text = "Отменить изменения";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSearchTeacher
            // 
            btnSearchTeacher.Location = new Point(272, 60);
            btnSearchTeacher.Name = "btnSearchTeacher";
            btnSearchTeacher.Size = new Size(187, 32);
            btnSearchTeacher.TabIndex = 27;
            btnSearchTeacher.Text = "Найти преподавателя";
            btnSearchTeacher.UseVisualStyleBackColor = true;
            btnSearchTeacher.Click += btnSearchTeacher_Click;
            // 
            // panelUpdateDirection
            // 
            panelUpdateDirection.Controls.Add(panelAddDIrection);
            panelUpdateDirection.Controls.Add(label16);
            panelUpdateDirection.Controls.Add(txtParticipiant);
            panelUpdateDirection.Controls.Add(txtUserID);
            panelUpdateDirection.Controls.Add(btnAddUser);
            panelUpdateDirection.Controls.Add(label15);
            panelUpdateDirection.Controls.Add(btnDeleteParticipiant);
            panelUpdateDirection.Controls.Add(txtParticipiantID);
            panelUpdateDirection.Controls.Add(label14);
            panelUpdateDirection.Controls.Add(btnSearchDirection);
            panelUpdateDirection.Controls.Add(btnExitDirection);
            panelUpdateDirection.Controls.Add(btnUpdateDirection);
            panelUpdateDirection.Controls.Add(label12);
            panelUpdateDirection.Controls.Add(txtDIrectionID);
            panelUpdateDirection.Controls.Add(txtDirectionBrief);
            panelUpdateDirection.Controls.Add(label13);
            panelUpdateDirection.Controls.Add(label17);
            panelUpdateDirection.Controls.Add(txtDIrectionName);
            panelUpdateDirection.Location = new Point(12, 76);
            panelUpdateDirection.Name = "panelUpdateDirection";
            panelUpdateDirection.Size = new Size(564, 432);
            panelUpdateDirection.TabIndex = 5;
            // 
            // btnSearchDirection
            // 
            btnSearchDirection.Location = new Point(272, 60);
            btnSearchDirection.Name = "btnSearchDirection";
            btnSearchDirection.Size = new Size(238, 32);
            btnSearchDirection.TabIndex = 27;
            btnSearchDirection.Text = "Найти научное направление";
            btnSearchDirection.UseVisualStyleBackColor = true;
            btnSearchDirection.Click += btnSearchDirection_Click;
            // 
            // btnExitDirection
            // 
            btnExitDirection.Location = new Point(415, 368);
            btnExitDirection.Name = "btnExitDirection";
            btnExitDirection.Size = new Size(146, 61);
            btnExitDirection.TabIndex = 26;
            btnExitDirection.Text = "Отменить изменения";
            btnExitDirection.UseVisualStyleBackColor = true;
            btnExitDirection.Click += btnExitDirection_Click;
            // 
            // btnUpdateDirection
            // 
            btnUpdateDirection.Location = new Point(272, 368);
            btnUpdateDirection.Name = "btnUpdateDirection";
            btnUpdateDirection.Size = new Size(142, 61);
            btnUpdateDirection.TabIndex = 25;
            btnUpdateDirection.Text = "Применить изменения";
            btnUpdateDirection.UseVisualStyleBackColor = true;
            btnUpdateDirection.Click += btnUpdateDirection_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(272, 4);
            label12.Name = "label12";
            label12.Size = new Size(181, 20);
            label12.TabIndex = 22;
            label12.Text = "Введите ID направления";
            // 
            // txtDIrectionID
            // 
            txtDIrectionID.Location = new Point(272, 27);
            txtDIrectionID.Name = "txtDIrectionID";
            txtDIrectionID.Size = new Size(263, 27);
            txtDIrectionID.TabIndex = 21;
            // 
            // txtDirectionBrief
            // 
            txtDirectionBrief.Location = new Point(3, 80);
            txtDirectionBrief.Multiline = true;
            txtDirectionBrief.Name = "txtDirectionBrief";
            txtDirectionBrief.Size = new Size(263, 169);
            txtDirectionBrief.TabIndex = 20;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(3, 57);
            label13.Name = "label13";
            label13.Size = new Size(176, 20);
            label13.TabIndex = 19;
            label13.Text = "Краткая характеристика";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(3, 4);
            label17.Name = "label17";
            label17.Size = new Size(243, 20);
            label17.TabIndex = 7;
            label17.Text = "Название научного направления";
            // 
            // txtDIrectionName
            // 
            txtDIrectionName.Location = new Point(3, 27);
            txtDIrectionName.Name = "txtDIrectionName";
            txtDIrectionName.Size = new Size(263, 27);
            txtDIrectionName.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(272, 95);
            label14.Name = "label14";
            label14.Size = new Size(157, 20);
            label14.TabIndex = 28;
            label14.Text = "Введите ID участника";
            // 
            // txtParticipiantID
            // 
            txtParticipiantID.Location = new Point(272, 118);
            txtParticipiantID.Name = "txtParticipiantID";
            txtParticipiantID.Size = new Size(263, 27);
            txtParticipiantID.TabIndex = 29;
            // 
            // btnDeleteParticipiant
            // 
            btnDeleteParticipiant.Location = new Point(272, 151);
            btnDeleteParticipiant.Name = "btnDeleteParticipiant";
            btnDeleteParticipiant.Size = new Size(238, 32);
            btnDeleteParticipiant.TabIndex = 30;
            btnDeleteParticipiant.Text = "Удалить выбранного участника";
            btnDeleteParticipiant.UseVisualStyleBackColor = true;
            btnDeleteParticipiant.Click += btnDeleteParticipiant_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(272, 186);
            label15.Name = "label15";
            label15.Size = new Size(184, 20);
            label15.TabIndex = 31;
            label15.Text = "Введите ID пользователя";
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(272, 242);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(238, 48);
            btnAddUser.TabIndex = 32;
            btnAddUser.Text = "Добавить выбранного пользователя";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(272, 209);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(263, 27);
            txtUserID.TabIndex = 33;
            // 
            // txtParticipiant
            // 
            txtParticipiant.Location = new Point(3, 275);
            txtParticipiant.Multiline = true;
            txtParticipiant.Name = "txtParticipiant";
            txtParticipiant.Size = new Size(263, 154);
            txtParticipiant.TabIndex = 34;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(3, 252);
            label16.Name = "label16";
            label16.Size = new Size(81, 20);
            label16.TabIndex = 35;
            label16.Text = "Участники";
            // 
            // btnAddDirection
            // 
            btnAddDirection.Location = new Point(392, 12);
            btnAddDirection.Name = "btnAddDirection";
            btnAddDirection.Size = new Size(184, 58);
            btnAddDirection.TabIndex = 6;
            btnAddDirection.Text = "Добавить научную работу";
            btnAddDirection.UseVisualStyleBackColor = true;
            // 
            // panelAddDIrection
            // 
            panelAddDIrection.Controls.Add(label18);
            panelAddDIrection.Controls.Add(txtAddParticipiant);
            panelAddDIrection.Controls.Add(txtIDAddDirection);
            panelAddDIrection.Controls.Add(btnAddUserToDirection);
            panelAddDIrection.Controls.Add(label19);
            panelAddDIrection.Controls.Add(btnDirectionHead);
            panelAddDIrection.Controls.Add(txtHeadID);
            panelAddDIrection.Controls.Add(label20);
            panelAddDIrection.Controls.Add(btnAddDirectionWork);
            panelAddDIrection.Controls.Add(txtAddDirectionBrief);
            panelAddDIrection.Controls.Add(label22);
            panelAddDIrection.Controls.Add(label23);
            panelAddDIrection.Controls.Add(txtAddDirectionName);
            panelAddDIrection.Location = new Point(0, 0);
            panelAddDIrection.Name = "panelAddDIrection";
            panelAddDIrection.Size = new Size(564, 432);
            panelAddDIrection.TabIndex = 7;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(3, 252);
            label18.Name = "label18";
            label18.Size = new Size(81, 20);
            label18.TabIndex = 35;
            label18.Text = "Участники";
            // 
            // txtAddParticipiant
            // 
            txtAddParticipiant.Location = new Point(3, 275);
            txtAddParticipiant.Multiline = true;
            txtAddParticipiant.Name = "txtAddParticipiant";
            txtAddParticipiant.Size = new Size(263, 154);
            txtAddParticipiant.TabIndex = 34;
            // 
            // txtIDAddDirection
            // 
            txtIDAddDirection.Location = new Point(272, 141);
            txtIDAddDirection.Name = "txtIDAddDirection";
            txtIDAddDirection.Size = new Size(263, 27);
            txtIDAddDirection.TabIndex = 33;
            // 
            // btnAddUserToDirection
            // 
            btnAddUserToDirection.Location = new Point(272, 174);
            btnAddUserToDirection.Name = "btnAddUserToDirection";
            btnAddUserToDirection.Size = new Size(238, 48);
            btnAddUserToDirection.TabIndex = 32;
            btnAddUserToDirection.Text = "Добавить выбранного пользователя";
            btnAddUserToDirection.UseVisualStyleBackColor = true;
            btnAddUserToDirection.Click += btnAddUserToDirection_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(272, 118);
            label19.Name = "label19";
            label19.Size = new Size(184, 20);
            label19.TabIndex = 31;
            label19.Text = "Введите ID пользователя";
            // 
            // btnAddDirectionWork
            // 
            btnAddDirectionWork.Location = new Point(272, 368);
            btnAddDirectionWork.Name = "btnAddDirectionWork";
            btnAddDirectionWork.Size = new Size(157, 61);
            btnAddDirectionWork.TabIndex = 25;
            btnAddDirectionWork.Text = "Добавить научную работу";
            btnAddDirectionWork.UseVisualStyleBackColor = true;
            btnAddDirectionWork.Click += btnAddDirectionWork_Click;
            // 
            // txtAddDirectionBrief
            // 
            txtAddDirectionBrief.Location = new Point(3, 80);
            txtAddDirectionBrief.Multiline = true;
            txtAddDirectionBrief.Name = "txtAddDirectionBrief";
            txtAddDirectionBrief.Size = new Size(263, 169);
            txtAddDirectionBrief.TabIndex = 20;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(3, 57);
            label22.Name = "label22";
            label22.Size = new Size(176, 20);
            label22.TabIndex = 19;
            label22.Text = "Краткая характеристика";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(3, 4);
            label23.Name = "label23";
            label23.Size = new Size(243, 20);
            label23.TabIndex = 7;
            label23.Text = "Название научного направления";
            // 
            // txtAddDirectionName
            // 
            txtAddDirectionName.Location = new Point(3, 27);
            txtAddDirectionName.Name = "txtAddDirectionName";
            txtAddDirectionName.Size = new Size(263, 27);
            txtAddDirectionName.TabIndex = 1;
            // 
            // btnDirectionHead
            // 
            btnDirectionHead.Location = new Point(272, 60);
            btnDirectionHead.Name = "btnDirectionHead";
            btnDirectionHead.Size = new Size(238, 55);
            btnDirectionHead.TabIndex = 30;
            btnDirectionHead.Text = "Сделать преподавателя руководителем";
            btnDirectionHead.UseVisualStyleBackColor = true;
            btnDirectionHead.Click += btnDirectionHead_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(272, 4);
            label20.Name = "label20";
            label20.Size = new Size(194, 20);
            label20.TabIndex = 28;
            label20.Text = "Введите ID преподавателя";
            // 
            // txtHeadID
            // 
            txtHeadID.Location = new Point(272, 27);
            txtHeadID.Name = "txtHeadID";
            txtHeadID.Size = new Size(263, 27);
            txtHeadID.TabIndex = 29;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 539);
            Controls.Add(btnAddDirection);
            Controls.Add(panelUpdateDirection);
            Controls.Add(panelRegistration);
            Controls.Add(btnScientificWorkUpdating);
            Controls.Add(btnUpdateTeacher);
            Controls.Add(btnRegistration);
            Name = "AdminForm";
            Text = "AdminForm";
            panelRegistration.ResumeLayout(false);
            panelRegistration.PerformLayout();
            panelUpdateTeacher.ResumeLayout(false);
            panelUpdateTeacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUserPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelUpdateDirection.ResumeLayout(false);
            panelUpdateDirection.PerformLayout();
            panelAddDIrection.ResumeLayout(false);
            panelAddDIrection.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegistration;
        private Button btnUpdateTeacher;
        private Button btnScientificWorkUpdating;
        private Panel panelRegistration;
        private Panel panelUpdateTeacher;
        private Button btnUploadPhoto;
        private PictureBox pictureBoxUserPhoto;
        private TextBox txtNewStay;
        private TextBox txtNewInterests;
        private TextBox txtNewPassword;
        private TextBox txtNewUsername;
        private Label label5;
        private TextBox txtNewPost;
        private Button btnRegister;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label11;
        private TextBox txtTeacherId;
        private TextBox txtTeacherInterests;
        private Label label10;
        private TextBox txtTeacherStay;
        private Label label9;
        private TextBox txtTeacherPost;
        private Label label8;
        private TextBox txtTeacherPassword;
        private Label label7;
        private Label label6;
        private TextBox txtTeacherName;
        private Button btnSearchTeacher;
        private Button btnExit;
        private Button btnUpdate;
        private Button btnUpdateTeacherPhoto;
        private Panel panelUpdateDirection;
        private Button btnSearchDirection;
        private Button btnExitDirection;
        private Button btnUpdateDirection;
        private Label label12;
        private TextBox txtDIrectionID;
        private TextBox txtDirectionBrief;
        private Label label13;
        private Label label17;
        private TextBox txtDIrectionName;
        private Button btnDeleteParticipiant;
        private TextBox txtParticipiantID;
        private Label label14;
        private TextBox txtUserID;
        private Button btnAddUser;
        private Label label15;
        private Label label16;
        private TextBox txtParticipiant;
        private Button btnAddDirection;
        private Panel panelAddDIrection;
        private Label label18;
        private TextBox txtAddParticipiant;
        private TextBox txtIDAddDirection;
        private Button btnAddUserToDirection;
        private Label label19;
        private Button btnAddDirectionWork;
        private TextBox txtAddDirectionBrief;
        private Label label22;
        private Label label23;
        private TextBox txtAddDirectionName;
        private Button btnDirectionHead;
        private TextBox txtHeadID;
        private Label label20;
    }
}