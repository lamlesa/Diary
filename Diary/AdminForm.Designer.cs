namespace Diary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.label_admin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxGroupName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.selectedStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectedStudentSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCreateGroup_Click = new System.Windows.Forms.Button();
            this.buttonEdit_Click = new System.Windows.Forms.Button();
            this.button_AddStudent = new System.Windows.Forms.Button();
            this.buttonDeleteStudent_Click = new System.Windows.Forms.Button();
            this.raspisanie_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_admin
            // 
            this.label_admin.AutoSize = true;
            this.label_admin.Location = new System.Drawing.Point(25, 30);
            this.label_admin.Name = "label_admin";
            this.label_admin.Size = new System.Drawing.Size(60, 20);
            this.label_admin.TabIndex = 11;
            this.label_admin.Text = "Админ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Фамилия";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(28, 214);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(112, 26);
            this.textBox9.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Имя";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(28, 292);
            this.textBox10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(112, 26);
            this.textBox10.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(483, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Группа №";
            // 
            // textBoxGroupName
            // 
            this.textBoxGroupName.Location = new System.Drawing.Point(593, 29);
            this.textBoxGroupName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxGroupName.Name = "textBoxGroupName";
            this.textBoxGroupName.Size = new System.Drawing.Size(112, 26);
            this.textBoxGroupName.TabIndex = 18;
            this.textBoxGroupName.TextChanged += new System.EventHandler(this.textBoxGroupName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(430, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 32);
            this.label4.TabIndex = 19;
            this.label4.Text = "Список студентов";
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectedStudentName,
            this.selectedStudentSurname});
            this.dataGridViewStudents.Location = new System.Drawing.Point(376, 180);
            this.dataGridViewStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.RowTemplate.Height = 24;
            this.dataGridViewStudents.Size = new System.Drawing.Size(340, 472);
            this.dataGridViewStudents.TabIndex = 20;
            this.dataGridViewStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellContentClick);
            // 
            // selectedStudentName
            // 
            this.selectedStudentName.HeaderText = "Имя";
            this.selectedStudentName.MinimumWidth = 6;
            this.selectedStudentName.Name = "selectedStudentName";
            this.selectedStudentName.Width = 125;
            // 
            // selectedStudentSurname
            // 
            this.selectedStudentSurname.HeaderText = "Фамилия";
            this.selectedStudentSurname.MinimumWidth = 6;
            this.selectedStudentSurname.Name = "selectedStudentSurname";
            this.selectedStudentSurname.Width = 125;
            // 
            // buttonCreateGroup_Click
            // 
            this.buttonCreateGroup_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateGroup_Click.Location = new System.Drawing.Point(738, 212);
            this.buttonCreateGroup_Click.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCreateGroup_Click.Name = "buttonCreateGroup_Click";
            this.buttonCreateGroup_Click.Size = new System.Drawing.Size(164, 29);
            this.buttonCreateGroup_Click.TabIndex = 21;
            this.buttonCreateGroup_Click.Text = "Создать группу";
            this.buttonCreateGroup_Click.UseVisualStyleBackColor = true;
            this.buttonCreateGroup_Click.Click += new System.EventHandler(this.buttonCreateGroup_Click_Click);
            // 
            // buttonEdit_Click
            // 
            this.buttonEdit_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit_Click.Location = new System.Drawing.Point(738, 249);
            this.buttonEdit_Click.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEdit_Click.Name = "buttonEdit_Click";
            this.buttonEdit_Click.Size = new System.Drawing.Size(164, 29);
            this.buttonEdit_Click.TabIndex = 22;
            this.buttonEdit_Click.Text = "Редактировать";
            this.buttonEdit_Click.UseVisualStyleBackColor = true;
            this.buttonEdit_Click.Click += new System.EventHandler(this.buttonEdit_Click_Click);
            // 
            // button_AddStudent
            // 
            this.button_AddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AddStudent.Location = new System.Drawing.Point(738, 285);
            this.button_AddStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_AddStudent.Name = "button_AddStudent";
            this.button_AddStudent.Size = new System.Drawing.Size(164, 29);
            this.button_AddStudent.TabIndex = 23;
            this.button_AddStudent.Text = "Добавить студента";
            this.button_AddStudent.UseVisualStyleBackColor = true;
            this.button_AddStudent.Click += new System.EventHandler(this.button_AddStudent_Click);
            // 
            // buttonDeleteStudent_Click
            // 
            this.buttonDeleteStudent_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteStudent_Click.Location = new System.Drawing.Point(738, 321);
            this.buttonDeleteStudent_Click.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDeleteStudent_Click.Name = "buttonDeleteStudent_Click";
            this.buttonDeleteStudent_Click.Size = new System.Drawing.Size(164, 29);
            this.buttonDeleteStudent_Click.TabIndex = 24;
            this.buttonDeleteStudent_Click.Text = "Удалить студента";
            this.buttonDeleteStudent_Click.UseVisualStyleBackColor = true;
            this.buttonDeleteStudent_Click.Click += new System.EventHandler(this.buttonDeleteStudent_Click_Click);
            // 
            // raspisanie_button
            // 
            this.raspisanie_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.raspisanie_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.raspisanie_button.Location = new System.Drawing.Point(784, 15);
            this.raspisanie_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.raspisanie_button.Name = "raspisanie_button";
            this.raspisanie_button.Size = new System.Drawing.Size(212, 75);
            this.raspisanie_button.TabIndex = 25;
            this.raspisanie_button.Text = "Расписание";
            this.raspisanie_button.UseVisualStyleBackColor = true;
            this.raspisanie_button.Click += new System.EventHandler(this.raspisanie_button_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(784, 109);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 68);
            this.button1.TabIndex = 26;
            this.button1.Text = "Баллы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 54);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1060, 668);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.raspisanie_button);
            this.Controls.Add(this.buttonDeleteStudent_Click);
            this.Controls.Add(this.button_AddStudent);
            this.Controls.Add(this.buttonEdit_Click);
            this.Controls.Add(this.buttonCreateGroup_Click);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxGroupName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_admin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminForm";
            this.Text = "Электронный дневник (админ)";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_admin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxGroupName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.Button buttonCreateGroup_Click;
        private System.Windows.Forms.Button buttonEdit_Click;
        private System.Windows.Forms.Button button_AddStudent;
        private System.Windows.Forms.Button buttonDeleteStudent_Click;
        private System.Windows.Forms.DataGridViewTextBoxColumn selectedStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn selectedStudentSurname;
        private System.Windows.Forms.Button raspisanie_button;
        private System.Windows.Forms.Button button1;
    }

}