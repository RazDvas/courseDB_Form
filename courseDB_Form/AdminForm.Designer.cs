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
            panelUpdateTeacher = new Panel();
            txtUpGroup = new TextBox();
            txtUpTeacherPost = new TextBox();
            lbUpGroup = new Label();
            lbUpStay = new Label();
            lbUpPost = new Label();
            lbUpPassword = new Label();
            lbUpName = new Label();
            cbUpSearch = new ComboBox();
            cbUpRole = new ComboBox();
            btnUpdate = new Button();
            btnUpPhoto = new Button();
            pbUpPhoto = new PictureBox();
            label11 = new Label();
            txtUpInterest = new TextBox();
            lbUpInterest = new Label();
            txtUpStay = new TextBox();
            txtUpPassword = new TextBox();
            txtUpName = new TextBox();
            panelAddDIrection = new Panel();
            cbAddHead = new ComboBox();
            label20 = new Label();
            btnAddDirectionWork = new Button();
            txtAddDirectionBrief = new TextBox();
            label22 = new Label();
            label23 = new Label();
            txtAddDirectionName = new TextBox();
            panelAddCourse = new Panel();
            label4 = new Label();
            txtNewMaterials = new TextBox();
            cbAddTeacherToCourse = new ComboBox();
            label1 = new Label();
            btnAddNewCourse = new Button();
            txtNewDiscipline = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtNewCourseName = new TextBox();
            panelUpdateDirection = new Panel();
            cbAddUserToDIrection = new ComboBox();
            cbDirectionUp = new ComboBox();
            lbPracticant = new ListBox();
            label16 = new Label();
            btnAddUser = new Button();
            btnDeleteParticipiant = new Button();
            label14 = new Label();
            btnUpdateDirection = new Button();
            label12 = new Label();
            txtDirectionBrief = new TextBox();
            label13 = new Label();
            label17 = new Label();
            txtDirectionLiderName = new TextBox();
            btnAddDirection = new Button();
            btnExitToLog = new Button();
            btnAddCourse = new Button();
            panelRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUserPhoto).BeginInit();
            panelUpdateTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUpPhoto).BeginInit();
            panelAddDIrection.SuspendLayout();
            panelAddCourse.SuspendLayout();
            panelUpdateDirection.SuspendLayout();
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
            btnUpdateTeacher.Text = "Обновить данные о пользователях";
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
            cbGroup.Location = new Point(3, 133);
            cbGroup.Name = "cbGroup";
            cbGroup.Size = new Size(263, 28);
            cbGroup.TabIndex = 16;
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
            // panelUpdateTeacher
            // 
            panelUpdateTeacher.Controls.Add(txtUpGroup);
            panelUpdateTeacher.Controls.Add(txtUpTeacherPost);
            panelUpdateTeacher.Controls.Add(lbUpGroup);
            panelUpdateTeacher.Controls.Add(lbUpStay);
            panelUpdateTeacher.Controls.Add(lbUpPost);
            panelUpdateTeacher.Controls.Add(lbUpPassword);
            panelUpdateTeacher.Controls.Add(lbUpName);
            panelUpdateTeacher.Controls.Add(cbUpSearch);
            panelUpdateTeacher.Controls.Add(cbUpRole);
            panelUpdateTeacher.Controls.Add(btnUpdate);
            panelUpdateTeacher.Controls.Add(btnUpPhoto);
            panelUpdateTeacher.Controls.Add(pbUpPhoto);
            panelUpdateTeacher.Controls.Add(label11);
            panelUpdateTeacher.Controls.Add(txtUpInterest);
            panelUpdateTeacher.Controls.Add(lbUpInterest);
            panelUpdateTeacher.Controls.Add(txtUpStay);
            panelUpdateTeacher.Controls.Add(txtUpPassword);
            panelUpdateTeacher.Controls.Add(txtUpName);
            panelUpdateTeacher.Location = new Point(12, 76);
            panelUpdateTeacher.Name = "panelUpdateTeacher";
            panelUpdateTeacher.Size = new Size(564, 432);
            panelUpdateTeacher.TabIndex = 4;
            // 
            // txtUpGroup
            // 
            txtUpGroup.Location = new Point(3, 133);
            txtUpGroup.Name = "txtUpGroup";
            txtUpGroup.Size = new Size(263, 27);
            txtUpGroup.TabIndex = 37;
            // 
            // txtUpTeacherPost
            // 
            txtUpTeacherPost.Location = new Point(3, 133);
            txtUpTeacherPost.Name = "txtUpTeacherPost";
            txtUpTeacherPost.Size = new Size(263, 27);
            txtUpTeacherPost.TabIndex = 36;
            // 
            // lbUpGroup
            // 
            lbUpGroup.AutoSize = true;
            lbUpGroup.Location = new Point(3, 110);
            lbUpGroup.Name = "lbUpGroup";
            lbUpGroup.Size = new Size(58, 20);
            lbUpGroup.TabIndex = 35;
            lbUpGroup.Text = "Группа";
            // 
            // lbUpStay
            // 
            lbUpStay.AutoSize = true;
            lbUpStay.Location = new Point(3, 164);
            lbUpStay.Name = "lbUpStay";
            lbUpStay.Size = new Size(146, 20);
            lbUpStay.TabIndex = 34;
            lbUpStay.Text = "Время пребывания";
            // 
            // lbUpPost
            // 
            lbUpPost.AutoSize = true;
            lbUpPost.Location = new Point(3, 110);
            lbUpPost.Name = "lbUpPost";
            lbUpPost.Size = new Size(86, 20);
            lbUpPost.TabIndex = 33;
            lbUpPost.Text = "Должность";
            // 
            // lbUpPassword
            // 
            lbUpPassword.AutoSize = true;
            lbUpPassword.Location = new Point(3, 57);
            lbUpPassword.Name = "lbUpPassword";
            lbUpPassword.Size = new Size(62, 20);
            lbUpPassword.TabIndex = 32;
            lbUpPassword.Text = "Пароль";
            // 
            // lbUpName
            // 
            lbUpName.AutoSize = true;
            lbUpName.Location = new Point(3, 4);
            lbUpName.Name = "lbUpName";
            lbUpName.Size = new Size(39, 20);
            lbUpName.TabIndex = 31;
            lbUpName.Text = "Имя";
            // 
            // cbUpSearch
            // 
            cbUpSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUpSearch.FormattingEnabled = true;
            cbUpSearch.Location = new Point(272, 27);
            cbUpSearch.Name = "cbUpSearch";
            cbUpSearch.Size = new Size(263, 28);
            cbUpSearch.TabIndex = 30;
            cbUpSearch.SelectedIndexChanged += cbUpSearch_SelectedIndexChanged;
            // 
            // cbUpRole
            // 
            cbUpRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUpRole.FormattingEnabled = true;
            cbUpRole.Items.AddRange(new object[] { "TEACHER", "STUDENT", "ADMIN" });
            cbUpRole.Location = new Point(151, 398);
            cbUpRole.Name = "cbUpRole";
            cbUpRole.Size = new Size(178, 28);
            cbUpRole.TabIndex = 29;
            cbUpRole.SelectedIndexChanged += cbUpRole_SelectedIndexChanged;
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
            // btnUpPhoto
            // 
            btnUpPhoto.Location = new Point(335, 394);
            btnUpPhoto.Name = "btnUpPhoto";
            btnUpPhoto.Size = new Size(187, 32);
            btnUpPhoto.TabIndex = 24;
            btnUpPhoto.Text = "Добавить фото";
            btnUpPhoto.UseVisualStyleBackColor = true;
            btnUpPhoto.Click += btnUpdateTeacherPhoto_Click;
            // 
            // pbUpPhoto
            // 
            pbUpPhoto.Location = new Point(335, 164);
            pbUpPhoto.Name = "pbUpPhoto";
            pbUpPhoto.Size = new Size(187, 224);
            pbUpPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUpPhoto.TabIndex = 23;
            pbUpPhoto.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(272, 4);
            label11.Name = "label11";
            label11.Size = new Size(242, 20);
            label11.TabIndex = 22;
            label11.Text = "Выберите нужного пользователя";
            // 
            // txtUpInterest
            // 
            txtUpInterest.Location = new Point(3, 239);
            txtUpInterest.Multiline = true;
            txtUpInterest.Name = "txtUpInterest";
            txtUpInterest.Size = new Size(263, 123);
            txtUpInterest.TabIndex = 20;
            // 
            // lbUpInterest
            // 
            lbUpInterest.AutoSize = true;
            lbUpInterest.Location = new Point(3, 216);
            lbUpInterest.Name = "lbUpInterest";
            lbUpInterest.Size = new Size(142, 20);
            lbUpInterest.TabIndex = 19;
            lbUpInterest.Text = "Научные интересы";
            // 
            // txtUpStay
            // 
            txtUpStay.Location = new Point(3, 186);
            txtUpStay.Name = "txtUpStay";
            txtUpStay.Size = new Size(263, 27);
            txtUpStay.TabIndex = 18;
            // 
            // txtUpPassword
            // 
            txtUpPassword.Location = new Point(3, 80);
            txtUpPassword.Name = "txtUpPassword";
            txtUpPassword.Size = new Size(263, 27);
            txtUpPassword.TabIndex = 14;
            // 
            // txtUpName
            // 
            txtUpName.Location = new Point(3, 27);
            txtUpName.Name = "txtUpName";
            txtUpName.Size = new Size(263, 27);
            txtUpName.TabIndex = 1;
            // 
            // panelAddDIrection
            // 
            panelAddDIrection.Controls.Add(cbAddHead);
            panelAddDIrection.Controls.Add(label20);
            panelAddDIrection.Controls.Add(btnAddDirectionWork);
            panelAddDIrection.Controls.Add(txtAddDirectionBrief);
            panelAddDIrection.Controls.Add(label22);
            panelAddDIrection.Controls.Add(label23);
            panelAddDIrection.Controls.Add(txtAddDirectionName);
            panelAddDIrection.Location = new Point(12, 73);
            panelAddDIrection.Name = "panelAddDIrection";
            panelAddDIrection.Size = new Size(564, 432);
            panelAddDIrection.TabIndex = 7;
            // 
            // cbAddHead
            // 
            cbAddHead.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAddHead.FormattingEnabled = true;
            cbAddHead.Location = new Point(272, 27);
            cbAddHead.Name = "cbAddHead";
            cbAddHead.Size = new Size(263, 28);
            cbAddHead.TabIndex = 31;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(272, 5);
            label20.Name = "label20";
            label20.Size = new Size(188, 20);
            label20.TabIndex = 28;
            label20.Text = "Выберите преподавателя";
            // 
            // btnAddDirectionWork
            // 
            btnAddDirectionWork.Location = new Point(3, 368);
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
            txtAddDirectionBrief.Size = new Size(263, 282);
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
            // panelAddCourse
            // 
            panelAddCourse.Controls.Add(label4);
            panelAddCourse.Controls.Add(txtNewMaterials);
            panelAddCourse.Controls.Add(cbAddTeacherToCourse);
            panelAddCourse.Controls.Add(label1);
            panelAddCourse.Controls.Add(btnAddNewCourse);
            panelAddCourse.Controls.Add(txtNewDiscipline);
            panelAddCourse.Controls.Add(label2);
            panelAddCourse.Controls.Add(label3);
            panelAddCourse.Controls.Add(txtNewCourseName);
            panelAddCourse.Location = new Point(12, 71);
            panelAddCourse.Name = "panelAddCourse";
            panelAddCourse.Size = new Size(564, 432);
            panelAddCourse.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(272, 58);
            label4.Name = "label4";
            label4.Size = new Size(191, 20);
            label4.TabIndex = 33;
            label4.Text = "Методические материалы";
            // 
            // txtNewMaterials
            // 
            txtNewMaterials.Location = new Point(272, 81);
            txtNewMaterials.Multiline = true;
            txtNewMaterials.Name = "txtNewMaterials";
            txtNewMaterials.Size = new Size(263, 282);
            txtNewMaterials.TabIndex = 32;
            // 
            // cbAddTeacherToCourse
            // 
            cbAddTeacherToCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAddTeacherToCourse.FormattingEnabled = true;
            cbAddTeacherToCourse.Location = new Point(272, 27);
            cbAddTeacherToCourse.Name = "cbAddTeacherToCourse";
            cbAddTeacherToCourse.Size = new Size(263, 28);
            cbAddTeacherToCourse.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(272, 5);
            label1.Name = "label1";
            label1.Size = new Size(188, 20);
            label1.TabIndex = 28;
            label1.Text = "Выберите преподавателя";
            // 
            // btnAddNewCourse
            // 
            btnAddNewCourse.Location = new Point(3, 368);
            btnAddNewCourse.Name = "btnAddNewCourse";
            btnAddNewCourse.Size = new Size(157, 61);
            btnAddNewCourse.TabIndex = 25;
            btnAddNewCourse.Text = "Добавить курс";
            btnAddNewCourse.UseVisualStyleBackColor = true;
            btnAddNewCourse.Click += btnAddNewCourse_Click;
            // 
            // txtNewDiscipline
            // 
            txtNewDiscipline.Location = new Point(3, 80);
            txtNewDiscipline.Multiline = true;
            txtNewDiscipline.Name = "txtNewDiscipline";
            txtNewDiscipline.Size = new Size(263, 282);
            txtNewDiscipline.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 57);
            label2.Name = "label2";
            label2.Size = new Size(183, 20);
            label2.TabIndex = 19;
            label2.Text = "Программа дисциплины";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 4);
            label3.Name = "label3";
            label3.Size = new Size(169, 20);
            label3.TabIndex = 7;
            label3.Text = "Название дисциплины";
            // 
            // txtNewCourseName
            // 
            txtNewCourseName.Location = new Point(3, 27);
            txtNewCourseName.Name = "txtNewCourseName";
            txtNewCourseName.Size = new Size(263, 27);
            txtNewCourseName.TabIndex = 1;
            // 
            // panelUpdateDirection
            // 
            panelUpdateDirection.Controls.Add(cbAddUserToDIrection);
            panelUpdateDirection.Controls.Add(cbDirectionUp);
            panelUpdateDirection.Controls.Add(lbPracticant);
            panelUpdateDirection.Controls.Add(label16);
            panelUpdateDirection.Controls.Add(btnAddUser);
            panelUpdateDirection.Controls.Add(btnDeleteParticipiant);
            panelUpdateDirection.Controls.Add(label14);
            panelUpdateDirection.Controls.Add(btnUpdateDirection);
            panelUpdateDirection.Controls.Add(label12);
            panelUpdateDirection.Controls.Add(txtDirectionBrief);
            panelUpdateDirection.Controls.Add(label13);
            panelUpdateDirection.Controls.Add(label17);
            panelUpdateDirection.Controls.Add(txtDirectionLiderName);
            panelUpdateDirection.Location = new Point(12, 74);
            panelUpdateDirection.Name = "panelUpdateDirection";
            panelUpdateDirection.Size = new Size(564, 432);
            panelUpdateDirection.TabIndex = 5;
            // 
            // cbAddUserToDIrection
            // 
            cbAddUserToDIrection.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAddUserToDIrection.FormattingEnabled = true;
            cbAddUserToDIrection.Location = new Point(272, 84);
            cbAddUserToDIrection.Name = "cbAddUserToDIrection";
            cbAddUserToDIrection.Size = new Size(263, 28);
            cbAddUserToDIrection.TabIndex = 38;
            // 
            // cbDirectionUp
            // 
            cbDirectionUp.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDirectionUp.FormattingEnabled = true;
            cbDirectionUp.Location = new Point(272, 26);
            cbDirectionUp.Name = "cbDirectionUp";
            cbDirectionUp.Size = new Size(263, 28);
            cbDirectionUp.TabIndex = 37;
            cbDirectionUp.SelectedIndexChanged += cbDirectionUp_SelectedIndexChanged;
            // 
            // lbPracticant
            // 
            lbPracticant.FormattingEnabled = true;
            lbPracticant.Location = new Point(3, 275);
            lbPracticant.Name = "lbPracticant";
            lbPracticant.Size = new Size(263, 144);
            lbPracticant.TabIndex = 36;
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
            // btnAddUser
            // 
            btnAddUser.Location = new Point(272, 118);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(181, 48);
            btnAddUser.TabIndex = 32;
            btnAddUser.Text = "Добавить выбранного пользователя";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnDeleteParticipiant
            // 
            btnDeleteParticipiant.Location = new Point(271, 348);
            btnDeleteParticipiant.Name = "btnDeleteParticipiant";
            btnDeleteParticipiant.Size = new Size(142, 71);
            btnDeleteParticipiant.TabIndex = 30;
            btnDeleteParticipiant.Text = "Удалить выбранного участника";
            btnDeleteParticipiant.UseVisualStyleBackColor = true;
            btnDeleteParticipiant.Click += btnDeleteParticipiant_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(272, 57);
            label14.Name = "label14";
            label14.Size = new Size(138, 20);
            label14.TabIndex = 28;
            label14.Text = "Введите участника";
            // 
            // btnUpdateDirection
            // 
            btnUpdateDirection.Location = new Point(419, 348);
            btnUpdateDirection.Name = "btnUpdateDirection";
            btnUpdateDirection.Size = new Size(142, 71);
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
            label12.Size = new Size(179, 20);
            label12.TabIndex = 22;
            label12.Text = "Выберите  направление";
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
            label17.Size = new Size(214, 20);
            label17.TabIndex = 7;
            label17.Text = "Глава научного направления";
            // 
            // txtDirectionLiderName
            // 
            txtDirectionLiderName.Location = new Point(3, 27);
            txtDirectionLiderName.Name = "txtDirectionLiderName";
            txtDirectionLiderName.ReadOnly = true;
            txtDirectionLiderName.Size = new Size(263, 27);
            txtDirectionLiderName.TabIndex = 1;
            // 
            // btnAddDirection
            // 
            btnAddDirection.Location = new Point(392, 12);
            btnAddDirection.Name = "btnAddDirection";
            btnAddDirection.Size = new Size(184, 58);
            btnAddDirection.TabIndex = 6;
            btnAddDirection.Text = "Добавить научную работу";
            btnAddDirection.UseVisualStyleBackColor = true;
            btnAddDirection.Click += btnAddDirection_Click;
            // 
            // btnExitToLog
            // 
            btnExitToLog.Location = new Point(582, 140);
            btnExitToLog.Name = "btnExitToLog";
            btnExitToLog.Size = new Size(184, 58);
            btnExitToLog.TabIndex = 8;
            btnExitToLog.Text = "Выход";
            btnExitToLog.UseVisualStyleBackColor = true;
            btnExitToLog.Click += btnExitToLog_Click;
            // 
            // btnAddCourse
            // 
            btnAddCourse.Location = new Point(582, 76);
            btnAddCourse.Name = "btnAddCourse";
            btnAddCourse.Size = new Size(184, 58);
            btnAddCourse.TabIndex = 10;
            btnAddCourse.Text = "Добавить курс";
            btnAddCourse.UseVisualStyleBackColor = true;
            btnAddCourse.Click += btnAddCourse_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 517);
            Controls.Add(btnAddCourse);
            Controls.Add(btnExitToLog);
            Controls.Add(panelAddCourse);
            Controls.Add(panelAddDIrection);
            Controls.Add(panelUpdateTeacher);
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
            ((System.ComponentModel.ISupportInitialize)pictureBoxUserPhoto).EndInit();
            panelUpdateTeacher.ResumeLayout(false);
            panelUpdateTeacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbUpPhoto).EndInit();
            panelAddDIrection.ResumeLayout(false);
            panelAddDIrection.PerformLayout();
            panelAddCourse.ResumeLayout(false);
            panelAddCourse.PerformLayout();
            panelUpdateDirection.ResumeLayout(false);
            panelUpdateDirection.PerformLayout();
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
        private PictureBox pbUpPhoto;
        private Label label11;
        private TextBox txtTeacherId;
        private TextBox txtUpInterest;
        private TextBox txtUpStay;
        private Label label9;
        private TextBox txtUpPost;
        private Label label8;
        private TextBox txtUpPassword;
        private Label label7;
        private Label label6;
        private TextBox txtUpName;
        private Button btnUpdate;
        private Button btnUpPhoto;
        private Panel panelUpdateDirection;
        private Button btnUpdateDirection;
        private Label label12;
        private TextBox txtDirectionBrief;
        private Label label13;
        private Label label17;
        private TextBox txtDirectionLiderName;
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
        private Label label20;
        private ListBox lbPracticant;
        private ListBox listBoxPracticantNew;
        private ComboBox cbSelectUserRegistration;
        private Label lbGroup;
        private ComboBox cbGroup;
        private Button btnExitToLog;
        private ComboBox cbUpRole;
        private ComboBox cbUpSearch;
        private Button btnSearchTeacher;
        private Label lbUpStay;
        private Label lbUpPost;
        private Label lbUpPassword;
        private Label lbUpName;
        private Label lbUpInterest;
        private Label lbUpGroup;
        private TextBox txtUpTeacherPost;
        private TextBox txtUpGroup;
        private ComboBox cbAddHead;
        private ComboBox cbAddUserToDIrection;
        private ComboBox cbDirectionUp;
        private Button btnAddUser;
        private Button btnDeleteParticipiant;
        private Label label14;
        private Panel panelAddCourse;
        private Label label4;
        private TextBox txtNewMaterials;
        private ComboBox cbAddTeacherToCourse;
        private Label label1;
        private Button btnAddNewCourse;
        private TextBox txtNewDiscipline;
        private Label label2;
        private Label label3;
        private TextBox txtNewCourseName;
        private Button btnAddCourse;
    }
}