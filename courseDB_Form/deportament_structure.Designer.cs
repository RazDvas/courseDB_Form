namespace courseDB_Form
{
    partial class deportament_structure
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
            DepartmentName = new TextBox();
            lblHead = new TextBox();
            lblDeputyHead = new TextBox();
            show_teaher = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            beck_department = new Button();
            scientific_worck_show = new Button();
            lbSection = new ListBox();
            SuspendLayout();
            // 
            // DepartmentName
            // 
            DepartmentName.Location = new Point(12, 28);
            DepartmentName.Name = "DepartmentName";
            DepartmentName.ReadOnly = true;
            DepartmentName.Size = new Size(404, 27);
            DepartmentName.TabIndex = 0;
            // 
            // lblHead
            // 
            lblHead.Location = new Point(12, 86);
            lblHead.Name = "lblHead";
            lblHead.ReadOnly = true;
            lblHead.Size = new Size(279, 27);
            lblHead.TabIndex = 1;
            // 
            // lblDeputyHead
            // 
            lblDeputyHead.Location = new Point(12, 139);
            lblDeputyHead.Name = "lblDeputyHead";
            lblDeputyHead.ReadOnly = true;
            lblDeputyHead.Size = new Size(279, 27);
            lblDeputyHead.TabIndex = 2;
            // 
            // show_teaher
            // 
            show_teaher.Location = new Point(12, 278);
            show_teaher.Name = "show_teaher";
            show_teaher.Size = new Size(142, 85);
            show_teaher.TabIndex = 5;
            show_teaher.Text = "Список преподавателей";
            show_teaher.UseVisualStyleBackColor = true;
            show_teaher.Click += show_teaher_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 6;
            label1.Text = "Название кафедры";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(170, 20);
            label2.TabIndex = 7;
            label2.Text = "Заведующий кафедрой";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 116);
            label3.Name = "label3";
            label3.Size = new Size(193, 20);
            label3.TabIndex = 8;
            label3.Text = "Заместитель заведующего";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 169);
            label5.Name = "label5";
            label5.Size = new Size(296, 20);
            label5.TabIndex = 10;
            label5.Text = "Название секций и руководитель секции";
            // 
            // beck_department
            // 
            beck_department.Location = new Point(308, 278);
            beck_department.Name = "beck_department";
            beck_department.Size = new Size(142, 85);
            beck_department.TabIndex = 11;
            beck_department.Text = "Назад";
            beck_department.UseVisualStyleBackColor = true;
            beck_department.Click += beck_department_Click;
            // 
            // scientific_worck_show
            // 
            scientific_worck_show.Location = new Point(160, 278);
            scientific_worck_show.Name = "scientific_worck_show";
            scientific_worck_show.Size = new Size(142, 85);
            scientific_worck_show.TabIndex = 12;
            scientific_worck_show.Text = "Направления научной работы";
            scientific_worck_show.UseVisualStyleBackColor = true;
            scientific_worck_show.Click += scientific_worck_show_Click;
            // 
            // lbSection
            // 
            lbSection.FormattingEnabled = true;
            lbSection.Location = new Point(12, 192);
            lbSection.Name = "lbSection";
            lbSection.Size = new Size(436, 64);
            lbSection.TabIndex = 13;
            // 
            // deportament_structure
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 375);
            Controls.Add(lbSection);
            Controls.Add(scientific_worck_show);
            Controls.Add(beck_department);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(show_teaher);
            Controls.Add(lblDeputyHead);
            Controls.Add(lblHead);
            Controls.Add(DepartmentName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "deportament_structure";
            Text = "Структура кафедры";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DepartmentName;
        private TextBox lblHead;
        private TextBox lblDeputyHead;
        private Button show_teaher;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Button beck_department;
        private Button scientific_worck_show;
        private ListBox lbSection;
    }
}