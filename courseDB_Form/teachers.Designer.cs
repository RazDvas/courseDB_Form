namespace courseDB_Form
{
    partial class teachers
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
            pictureBoxPhoto = new PictureBox();
            lblPosition = new TextBox();
            lblResearchInterests = new TextBox();
            lblSchelduleOfStay = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            course = new Button();
            beck_deportament_structure = new Button();
            lbTeachers = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxPhoto
            // 
            pictureBoxPhoto.Location = new Point(581, 30);
            pictureBoxPhoto.Name = "pictureBoxPhoto";
            pictureBoxPhoto.Size = new Size(198, 208);
            pictureBoxPhoto.TabIndex = 1;
            pictureBoxPhoto.TabStop = false;
            // 
            // lblPosition
            // 
            lblPosition.Location = new Point(304, 30);
            lblPosition.Name = "lblPosition";
            lblPosition.ReadOnly = true;
            lblPosition.Size = new Size(271, 27);
            lblPosition.TabIndex = 2;
            // 
            // lblResearchInterests
            // 
            lblResearchInterests.Location = new Point(304, 83);
            lblResearchInterests.Multiline = true;
            lblResearchInterests.Name = "lblResearchInterests";
            lblResearchInterests.ReadOnly = true;
            lblResearchInterests.Size = new Size(271, 270);
            lblResearchInterests.TabIndex = 3;
            // 
            // lblSchelduleOfStay
            // 
            lblSchelduleOfStay.Location = new Point(304, 379);
            lblSchelduleOfStay.Multiline = true;
            lblSchelduleOfStay.Name = "lblSchelduleOfStay";
            lblSchelduleOfStay.ReadOnly = true;
            lblSchelduleOfStay.Size = new Size(271, 175);
            lblSchelduleOfStay.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(178, 20);
            label1.TabIndex = 5;
            label1.Text = "Список преподавателей";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(581, 7);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 6;
            label2.Text = "Фото преподавателя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(304, 7);
            label3.Name = "label3";
            label3.Size = new Size(196, 20);
            label3.TabIndex = 7;
            label3.Text = "Должность преподавателя";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(304, 60);
            label4.Name = "label4";
            label4.Size = new Size(142, 20);
            label4.TabIndex = 8;
            label4.Text = "Научные интересы";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(304, 356);
            label5.Name = "label5";
            label5.Size = new Size(183, 20);
            label5.TabIndex = 9;
            label5.Text = "Расписание пребывания";
            // 
            // course
            // 
            course.Location = new Point(585, 262);
            course.Name = "course";
            course.Size = new Size(194, 67);
            course.TabIndex = 10;
            course.Text = "Перейти к курсу";
            course.UseVisualStyleBackColor = true;
            course.Click += course_Click;
            // 
            // beck_deportament_structure
            // 
            beck_deportament_structure.Location = new Point(585, 335);
            beck_deportament_structure.Name = "beck_deportament_structure";
            beck_deportament_structure.Size = new Size(194, 65);
            beck_deportament_structure.TabIndex = 11;
            beck_deportament_structure.Text = "Назад";
            beck_deportament_structure.UseVisualStyleBackColor = true;
            beck_deportament_structure.Click += beck_deportament_structure_Click;
            // 
            // lbTeachers
            // 
            lbTeachers.FormattingEnabled = true;
            lbTeachers.Location = new Point(12, 30);
            lbTeachers.Name = "lbTeachers";
            lbTeachers.Size = new Size(286, 524);
            lbTeachers.TabIndex = 12;
            lbTeachers.SelectedIndexChanged += lbTeachers_SelectedIndexChanged;
            // 
            // teachers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 563);
            Controls.Add(lbTeachers);
            Controls.Add(beck_deportament_structure);
            Controls.Add(course);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblSchelduleOfStay);
            Controls.Add(lblResearchInterests);
            Controls.Add(lblPosition);
            Controls.Add(pictureBoxPhoto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "teachers";
            Text = "Перподаватели";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxPhoto;
        private TextBox lblPosition;
        private TextBox lblResearchInterests;
        private TextBox lblSchelduleOfStay;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button course;
        private Button beck_deportament_structure;
        private ListBox lbTeachers;
    }
}