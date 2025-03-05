namespace courseDB_Form
{
    partial class corse
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblCourseName = new TextBox();
            txtCourseProgram = new TextBox();
            txtCourseMaterials = new TextBox();
            txtTeacher = new TextBox();
            label4 = new Label();
            beck_teachers = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 0;
            label1.Text = "Название кукрса";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(183, 20);
            label2.TabIndex = 1;
            label2.Text = "Программа дисциплины";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(438, 75);
            label3.Name = "label3";
            label3.Size = new Size(191, 20);
            label3.TabIndex = 2;
            label3.Text = "Методические материалы";
            // 
            // lblCourseName
            // 
            lblCourseName.Location = new Point(12, 32);
            lblCourseName.Name = "lblCourseName";
            lblCourseName.ReadOnly = true;
            lblCourseName.Size = new Size(272, 27);
            lblCourseName.TabIndex = 3;
            // 
            // txtCourseProgram
            // 
            txtCourseProgram.Location = new Point(13, 98);
            txtCourseProgram.Multiline = true;
            txtCourseProgram.Name = "txtCourseProgram";
            txtCourseProgram.ReadOnly = true;
            txtCourseProgram.Size = new Size(419, 340);
            txtCourseProgram.TabIndex = 4;
            txtCourseProgram.TextChanged += textBox2_TextChanged;
            // 
            // txtCourseMaterials
            // 
            txtCourseMaterials.Location = new Point(438, 98);
            txtCourseMaterials.Multiline = true;
            txtCourseMaterials.Name = "txtCourseMaterials";
            txtCourseMaterials.ReadOnly = true;
            txtCourseMaterials.Size = new Size(350, 340);
            txtCourseMaterials.TabIndex = 5;
            // 
            // txtTeacher
            // 
            txtTeacher.Location = new Point(305, 32);
            txtTeacher.Name = "txtTeacher";
            txtTeacher.ReadOnly = true;
            txtTeacher.Size = new Size(483, 27);
            txtTeacher.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(305, 9);
            label4.Name = "label4";
            label4.Size = new Size(152, 20);
            label4.TabIndex = 7;
            label4.Text = "ФИО преподавателя";
            // 
            // beck_teachers
            // 
            beck_teachers.Location = new Point(12, 444);
            beck_teachers.Name = "beck_teachers";
            beck_teachers.Size = new Size(135, 48);
            beck_teachers.TabIndex = 8;
            beck_teachers.Text = "Назад";
            beck_teachers.UseVisualStyleBackColor = true;
            beck_teachers.Click += beck_teachers_Click;
            // 
            // corse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 504);
            Controls.Add(beck_teachers);
            Controls.Add(label4);
            Controls.Add(txtTeacher);
            Controls.Add(txtCourseMaterials);
            Controls.Add(txtCourseProgram);
            Controls.Add(lblCourseName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "corse";
            Text = "Курс";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox lblCourseName;
        private TextBox txtCourseProgram;
        private TextBox txtCourseMaterials;
        private TextBox txtTeacher;
        private Label label4;
        private Button beck_teachers;
    }
}