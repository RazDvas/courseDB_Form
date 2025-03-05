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
            cbGroup = new ComboBox();
            panelUpdateTeacher = new Panel();
            btnSearchTeacher = new Button();
            btnExit = new Button();
            btnUpdate = new Button();
            btnUpdateTeacherPhoto = new Button();
            pictureBoxTeacherPhoto = new PictureBox();
            label11 = new Label();
            txtTeacherId = new TextBox();
            txtTeacherInterests = new TextBox();
            label10 = new Label();
            txtTeacherStay = new TextBox();
            label9 = new Label();
            txtTeacherPost = new TextBox();
            label8 = new Label();
            txtTeacherPassword = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtTeacherName = new TextBox();
            lbGroup = new Label();
            cbSelectUserRegistration = new ComboBox();
            lbPassword = new Label();
            txtNewPost = new TextBox();
            btnRegister = new Button();
            lbStay = new Label();
            lbInterest = new Label();
            lbPost = new Label();
            lbName = new Label();
            btnUploadPhoto = new Button();
            pictureBoxUserPhoto = new PictureBox();
            txtNewStay = new TextBox();
            txtNewInterests = new TextBox();
            txtNewPassword = new TextBox();
            txtNewUsername = new TextBox();
            panelUpdateDirection = new Panel();
            listBoxPracticant = new ListBox();
            label16 = new Label();
            txtUserID = new TextBox();
            btnAddUser = new Button();
            label15 = new Label();
            btnDeleteParticipiant = new Button();
            txtParticipiantID = new TextBox();
            label14 = new Label();
            btnSearchDirection = new Button();
            btnExitDirection = new Button();
            btnUpdateDirection = new Button();
            label12 = new Label();
            txtDIrectionID = new TextBox();
            txtDirectionBrief = new TextBox();
            label13 = new Label();
            label17 = new Label();
            txtDIrectionName = new TextBox();
            panelAddDIrection = new Panel();
            listBoxPracticantNew = new ListBox();
            label18 = new Label();
            txtIDAddDirection = new TextBox();
            btnAddUserToDirection = new Button();
            label19 = new Label();
            txtHeadID = new TextBox();
            label20 = new Label();
            btnAddDirectionWork = new Button();
            txtAddDirectionBrief = new TextBox();
            label22 = new Label();
            label23 = new Label();
            txtAddDirectionName = new TextBox();
            btnAddDirection = new Button();
            btnExitToLog = new Button();
            panelRegistration.SuspendLayout();
            panelUpdateTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTeacherPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUserPhoto).BeginInit();
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
            panelRegistration.Controls.Add(cbGroup);
            panelRegistration.Controls.Add(panelUpdateTeacher);
            panelRegistration.Controls.Add(lbGroup);
            panelRegistration.Controls.Add(cbSelectUserRegistration);
            panelRegistration.Controls.Add(lbPassword);
            panelRegistration.Controls.Add(txtNewPost);
            panelRegistration.Controls.Add(btnRegister);
            panelRegistration.Controls.Add(lbStay);
            panelRegistration.Controls.Add(lbInterest);
            panelRegistration.Controls.Add(lbPost);
            panelRegistration.Controls.Add(lbName);
            panelRegistration.Controls.Add(btnUploadPhoto);
            panelRegistration.Controls.Add(pictureBoxUserPhoto);
            panelRegistration.Controls.Add(txtNewStay);
            panelRegistration.Controls.Add(txtNewInterests);
            panelRegistration.Controls.Add(txtNewPassword);
            panelRegistration.Controls.Add(txtNewUsername);
            panelRegistration.Location = new Point(12, 77);
            panelRegistration.Name = "panelRegistration";
            panelRegistration.Size = new Size(564, 432);
            panelRegistration.TabIndex = 3;
            // 
            // cbGroup
            // 
            cbGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGroup.FormattingEnabled = true;
            cbGroup.Items.AddRange(new object[] { "Группа ПИН-121", "Группа ПИН-122", "Группа ПИН-123", "Группа ПИН-124", "Группа ИС-121", "Группа ИС-122", "Группа ИС-123", "Группа ИС-124", "Группа ФПМ-121", "Группа ФПМ-122", "Группа ФПМ-123", "Группа ФПМ-124", "Группа РТ-121", "Группа РТ-122", "Группа РТ-123", "Группа РТ-124", "Группа УКТС-121", "Группа УКТС-122", "Группа УКТС-123", "Группа УКТС-124" });
            cbGroup.Location = new Point(3, 132);
            cbGroup.Name = "cbGroup";
            cbGroup.Size = new Size(263, 28);
            cbGroup.TabIndex = 16;
            // 
            // panelUpdateTeacher
            // 
            panelUpdateTeacher.Controls.Add(btnSearchTeacher);
            panelUpdateTeacher.Controls.Add(btnExit);
            panelUpdateTeacher.Controls.Add(btnUpdate);
            panelUpdateTeacher.Controls.Add(btnUpdateTeacherPhoto);
            panelUpdateTeacher.Controls.Add(pictureBoxTeacherPhoto);
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
            panelUpdateTeacher.Location = new Point(26, 283);
            panelUpdateTeacher.Name = "panelUpdateTeacher";
            panelUpdateTeacher.Size = new Size(564, 432);
            panelUpdateTeacher.TabIndex = 4;
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
            // btnUpdateTeacherPhoto
            // 
            btnUpdateTeacherPhoto.Location = new Point(272, 328);
            btnUpdateTeacherPhoto.Name = "btnUpdateTeacherPhoto";
            btnUpdateTeacherPhoto.Size = new Size(187, 32);
            btnUpdateTeacherPhoto.TabIndex = 24;
            btnUpdateTeacherPhoto.Text = "Добавить фото";
            btnUpdateTeacherPhoto.UseVisualStyleBackColor = true;
            btnUpdateTeacherPhoto.Click += btnUpdateTeacherPhoto_Click;
            // 
            // pictureBoxTeacherPhoto
            // 
            pictureBoxTeacherPhoto.Location = new Point(272, 98);
            pictureBoxTeacherPhoto.Name = "pictureBoxTeacherPhoto";
            pictureBoxTeacherPhoto.Size = new Size(187, 224);
            pictureBoxTeacherPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTeacherPhoto.TabIndex = 23;
            pictureBoxTeacherPhoto.TabStop = false;
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
            // txtTeacherId
            // 
            txtTeacherId.Location = new Point(272, 27);
            txtTeacherId.Name = "txtTeacherId";
            txtTeacherId.Size = new Size(263, 27);
            txtTeacherId.TabIndex = 21;
            // 
            // txtTeacherInterests
            // 
            txtTeacherInterests.Location = new Point(3, 239);
            txtTeacherInterests.Multiline = true;
            txtTeacherInterests.Name = "txtTeacherInterests";
            txtTeacherInterests.Size = new Size(263, 123);
            txtTeacherInterests.TabIndex = 20;
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
            // txtTeacherStay
            // 
            txtTeacherStay.Location = new Point(3, 186);
            txtTeacherStay.Name = "txtTeacherStay";
            txtTeacherStay.Size = new Size(263, 27);
            txtTeacherStay.TabIndex = 18;
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
            // txtTeacherPost
            // 
            txtTeacherPost.Location = new Point(3, 133);
            txtTeacherPost.Name = "txtTeacherPost";
            txtTeacherPost.Size = new Size(263, 27);
            txtTeacherPost.TabIndex = 16;
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
            // txtTeacherPassword
            // 
            txtTeacherPassword.Location = new Point(3, 80);
            txtTeacherPassword.Name = "txtTeacherPassword";
            txtTeacherPassword.Size = new Size(263, 27);
            txtTeacherPassword.TabIndex = 14;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 4);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 7;
            label6.Text = "Имя";
            // 
            // txtTeacherName
            // 
            txtTeacherName.Location = new Point(3, 27);
            txtTeacherName.Name = "txtTeacherName";
            txtTeacherName.Size = new Size(263, 27);
            txtTeacherName.TabIndex = 1;
            // 
            // lbGroup
            // 
            lbGroup.AutoSize = true;
            lbGroup.Location = new Point(3, 110);
            lbGroup.Name = "lbGroup";
            lbGroup.Size = new Size(58, 20);
            lbGroup.TabIndex = 15;
            lbGroup.Text = "Группа";
            // 
            // cbSelectUserRegistration
            // 
            cbSelectUserRegistration.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSelectUserRegistration.FormattingEnabled = true;
            cbSelectUserRegistration.Items.AddRange(new object[] { "TEACHER", "STUDENT", "ADMIN" });
            cbSelectUserRegistration.Location = new Point(190, 397);
            cbSelectUserRegistration.Name = "cbSelectUserRegistration";
            cbSelectUserRegistration.Size = new Size(178, 28);
            cbSelectUserRegistration.TabIndex = 13;
            cbSelectUserRegistration.SelectedIndexChanged += cbSelectUserRegistration_SelectedIndexChanged;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(3, 57);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(62, 20);
            lbPassword.TabIndex = 12;
            lbPassword.Text = "Пароль";
            // 
            // txtNewPost
            // 
            txtNewPost.Location = new Point(3, 133);
            txtNewPost.Name = "txtNewPost";
            txtNewPost.Size = new Size(263, 27);
            txtNewPost.TabIndex = 11;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(3, 368);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(187, 61);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Зарегистрировать пользователя";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lbStay
            // 
            lbStay.AutoSize = true;
            lbStay.Location = new Point(3, 163);
            lbStay.Name = "lbStay";
            lbStay.Size = new Size(146, 20);
            lbStay.TabIndex = 9;
            lbStay.Text = "Время пребывания";
            // 
            // lbInterest
            // 
            lbInterest.AutoSize = true;
            lbInterest.Location = new Point(282, 4);
            lbInterest.Name = "lbInterest";
            lbInterest.Size = new Size(142, 20);
            lbInterest.TabIndex = 8;
            lbInterest.Text = "Научные интересы";
            // 
            // lbPost
            // 
            lbPost.AutoSize = true;
            lbPost.Location = new Point(3, 110);
            lbPost.Name = "lbPost";
            lbPost.Size = new Size(86, 20);
            lbPost.TabIndex = 7;
            lbPost.Text = "Должность";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(3, 4);
            lbName.Name = "lbName";
            lbName.Size = new Size(39, 20);
            lbName.TabIndex = 6;
            lbName.Text = "Имя";
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
            // pictureBoxUserPhoto
            // 
            pictureBoxUserPhoto.Location = new Point(374, 167);
            pictureBoxUserPhoto.Name = "pictureBoxUserPhoto";
            pictureBoxUserPhoto.Size = new Size(187, 224);
            pictureBoxUserPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUserPhoto.TabIndex = 4;
            pictureBoxUserPhoto.TabStop = false;
            // 
            // txtNewStay
            // 
            txtNewStay.Location = new Point(3, 186);
            txtNewStay.Name = "txtNewStay";
            txtNewStay.Size = new Size(263, 27);
            txtNewStay.TabIndex = 3;
            // 
            // txtNewInterests
            // 
            txtNewInterests.Location = new Point(282, 27);
            txtNewInterests.Multiline = true;
            txtNewInterests.Name = "txtNewInterests";
            txtNewInterests.Size = new Size(263, 123);
            txtNewInterests.TabIndex = 2;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(3, 80);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(263, 27);
            txtNewPassword.TabIndex = 1;
            // 
            // txtNewUsername
            // 
            txtNewUsername.Location = new Point(3, 27);
            txtNewUsername.Name = "txtNewUsername";
            txtNewUsername.Size = new Size(263, 27);
            txtNewUsername.TabIndex = 0;
            // 
            // panelUpdateDirection
            // 
            panelUpdateDirection.Controls.Add(listBoxPracticant);
            panelUpdateDirection.Controls.Add(label16);
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
            panelUpdateDirection.Location = new Point(989, 627);
            panelUpdateDirection.Name = "panelUpdateDirection";
            panelUpdateDirection.Size = new Size(564, 432);
            panelUpdateDirection.TabIndex = 5;
            // 
            // listBoxPracticant
            // 
            listBoxPracticant.FormattingEnabled = true;
            listBoxPracticant.Location = new Point(3, 275);
            listBoxPracticant.Name = "listBoxPracticant";
            listBoxPracticant.Size = new Size(263, 144);
            listBoxPracticant.TabIndex = 36;
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
            // txtUserID
            // 
            txtUserID.Location = new Point(272, 209);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(263, 27);
            txtUserID.TabIndex = 33;
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
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(272, 186);
            label15.Name = "label15";
            label15.Size = new Size(184, 20);
            label15.TabIndex = 31;
            label15.Text = "Введите ID пользователя";
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
            // txtParticipiantID
            // 
            txtParticipiantID.Location = new Point(272, 118);
            txtParticipiantID.Name = "txtParticipiantID";
            txtParticipiantID.Size = new Size(263, 27);
            txtParticipiantID.TabIndex = 29;
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
            // panelAddDIrection
            // 
            panelAddDIrection.Controls.Add(listBoxPracticantNew);
            panelAddDIrection.Controls.Add(label18);
            panelAddDIrection.Controls.Add(txtIDAddDirection);
            panelAddDIrection.Controls.Add(btnAddUserToDirection);
            panelAddDIrection.Controls.Add(label19);
            panelAddDIrection.Controls.Add(txtHeadID);
            panelAddDIrection.Controls.Add(label20);
            panelAddDIrection.Controls.Add(btnAddDirectionWork);
            panelAddDIrection.Controls.Add(txtAddDirectionBrief);
            panelAddDIrection.Controls.Add(label22);
            panelAddDIrection.Controls.Add(label23);
            panelAddDIrection.Controls.Add(txtAddDirectionName);
            panelAddDIrection.Location = new Point(795, 81);
            panelAddDIrection.Name = "panelAddDIrection";
            panelAddDIrection.Size = new Size(564, 432);
            panelAddDIrection.TabIndex = 7;
            // 
            // listBoxPracticantNew
            // 
            listBoxPracticantNew.FormattingEnabled = true;
            listBoxPracticantNew.Location = new Point(3, 279);
            listBoxPracticantNew.Name = "listBoxPracticantNew";
            listBoxPracticantNew.Size = new Size(263, 144);
            listBoxPracticantNew.TabIndex = 37;
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
            // txtIDAddDirection
            // 
            txtIDAddDirection.Location = new Point(272, 80);
            txtIDAddDirection.Name = "txtIDAddDirection";
            txtIDAddDirection.Size = new Size(263, 27);
            txtIDAddDirection.TabIndex = 33;
            // 
            // btnAddUserToDirection
            // 
            btnAddUserToDirection.Location = new Point(272, 113);
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
            label19.Location = new Point(272, 57);
            label19.Name = "label19";
            label19.Size = new Size(184, 20);
            label19.TabIndex = 31;
            label19.Text = "Введите ID пользователя";
            // 
            // txtHeadID
            // 
            txtHeadID.Location = new Point(272, 27);
            txtHeadID.Name = "txtHeadID";
            txtHeadID.Size = new Size(263, 27);
            txtHeadID.TabIndex = 29;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(272, 5);
            label20.Name = "label20";
            label20.Size = new Size(194, 20);
            label20.TabIndex = 28;
            label20.Text = "Введите ID преподавателя";
            // 
            // btnAddDirectionWork
            // 
            btnAddDirectionWork.Location = new Point(272, 362);
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
            // btnAddDirection
            // 
            btnAddDirection.Location = new Point(392, 12);
            btnAddDirection.Name = "btnAddDirection";
            btnAddDirection.Size = new Size(184, 58);
            btnAddDirection.TabIndex = 6;
            btnAddDirection.Text = "Добавить научную работу";
            btnAddDirection.UseVisualStyleBackColor = true;
            // 
            // btnExitToLog
            // 
            btnExitToLog.Location = new Point(582, 77);
            btnExitToLog.Name = "btnExitToLog";
            btnExitToLog.Size = new Size(184, 58);
            btnExitToLog.TabIndex = 8;
            btnExitToLog.Text = "Выход";
            btnExitToLog.UseVisualStyleBackColor = true;
            btnExitToLog.Click += btnExitToLog_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1513, 699);
            Controls.Add(btnExitToLog);
            Controls.Add(panelAddDIrection);
            Controls.Add(btnAddDirection);
            Controls.Add(panelUpdateDirection);
            Controls.Add(panelRegistration);
            Controls.Add(btnScientificWorkUpdating);
            Controls.Add(btnUpdateTeacher);
            Controls.Add(btnRegistration);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminForm";
            Text = "AdminForm";
            panelRegistration.ResumeLayout(false);
            panelRegistration.PerformLayout();
            panelUpdateTeacher.ResumeLayout(false);
            panelUpdateTeacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTeacherPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUserPhoto).EndInit();
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
        private Label lbPassword;
        private TextBox txtNewPost;
        private Button btnRegister;
        private Label lbStay;
        private Label lbInterest;
        private Label lbPost;
        private Label lbName;
        private PictureBox pictureBoxTeacherPhoto;
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
        private Button btnAddDirection;
        private Panel panelAddDIrection;
        private Label label18;
        private TextBox txtIDAddDirection;
        private Button btnAddUserToDirection;
        private Label label19;
        private Button btnAddDirectionWork;
        private TextBox txtAddDirectionBrief;
        private Label label22;
        private Label label23;
        private TextBox txtAddDirectionName;
        private TextBox txtHeadID;
        private Label label20;
        private ListBox listBoxPracticant;
        private ListBox listBoxPracticantNew;
        private ComboBox cbSelectUserRegistration;
        private Label lbGroup;
        private ComboBox cbGroup;
        private Button btnExitToLog;
    }
}