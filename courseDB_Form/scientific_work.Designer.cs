namespace courseDB_Form
{
    partial class scientific_work
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
            txtDescription = new TextBox();
            label3 = new Label();
            txtParticipants = new TextBox();
            beck_deportament = new Button();
            lbDirections = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(223, 20);
            label1.TabIndex = 1;
            label1.Text = "Направления научной работы";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 9);
            label2.Name = "label2";
            label2.Size = new Size(176, 20);
            label2.TabIndex = 2;
            label2.Text = "Краткая характеристика";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(267, 32);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(372, 147);
            txtDescription.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(267, 182);
            label3.Name = "label3";
            label3.Size = new Size(200, 20);
            label3.TabIndex = 4;
            label3.Text = "Участники научной работы";
            // 
            // txtParticipants
            // 
            txtParticipants.Location = new Point(265, 205);
            txtParticipants.Multiline = true;
            txtParticipants.Name = "txtParticipants";
            txtParticipants.ReadOnly = true;
            txtParticipants.Size = new Size(247, 231);
            txtParticipants.TabIndex = 5;
            // 
            // beck_deportament
            // 
            beck_deportament.Location = new Point(518, 367);
            beck_deportament.Name = "beck_deportament";
            beck_deportament.Size = new Size(121, 69);
            beck_deportament.TabIndex = 7;
            beck_deportament.Text = "Назад";
            beck_deportament.UseVisualStyleBackColor = true;
            beck_deportament.Click += beck_deportament_Click;
            // 
            // lbDirections
            // 
            lbDirections.FormattingEnabled = true;
            lbDirections.Location = new Point(12, 32);
            lbDirections.Name = "lbDirections";
            lbDirections.Size = new Size(247, 404);
            lbDirections.TabIndex = 8;
            lbDirections.SelectedIndexChanged += lbDirections_SelectedIndexChanged;
            // 
            // scientific_work
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 439);
            Controls.Add(lbDirections);
            Controls.Add(beck_deportament);
            Controls.Add(txtParticipants);
            Controls.Add(label3);
            Controls.Add(txtDescription);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "scientific_work";
            Text = "Направления научной работы кафедры";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox txtDescription;
        private Label label3;
        private TextBox txtParticipants;
        private Button beck_deportament;
        private ListBox lbDirections;
    }
}