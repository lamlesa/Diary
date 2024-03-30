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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.surname_textbox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.buttonCreateGroup_Click = new System.Windows.Forms.Button();
            this.buttonEdit_Click = new System.Windows.Forms.Button();
            this.button_AddStudent = new System.Windows.Forms.Button();
            this.buttonDeleteStudent = new System.Windows.Forms.Button();
            this.schedule_button = new System.Windows.Forms.Button();
            this.marks_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.group_box = new System.Windows.Forms.ComboBox();
            this.show_students = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.datagrid_students = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_students)).BeginInit();
            this.SuspendLayout();
            // 
            // name_textbox
            // 
            this.name_textbox.BackColor = System.Drawing.Color.SteelBlue;
            this.name_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_textbox.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_textbox.Location = new System.Drawing.Point(12, 233);
            this.name_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.ReadOnly = true;
            this.name_textbox.Size = new System.Drawing.Size(240, 28);
            this.name_textbox.TabIndex = 14;
            this.name_textbox.Text = "Имя";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "Администратор";
            // 
            // surname_textbox
            // 
            this.surname_textbox.BackColor = System.Drawing.Color.SteelBlue;
            this.surname_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surname_textbox.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname_textbox.Location = new System.Drawing.Point(12, 263);
            this.surname_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.surname_textbox.Name = "surname_textbox";
            this.surname_textbox.ReadOnly = true;
            this.surname_textbox.Size = new System.Drawing.Size(240, 28);
            this.surname_textbox.TabIndex = 16;
            this.surname_textbox.Text = "Фамилия";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(4, 8);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(334, 29);
            this.label.TabIndex = 19;
            this.label.Text = "Список студентов группы №";
            // 
            // buttonCreateGroup_Click
            // 
            this.buttonCreateGroup_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateGroup_Click.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateGroup_Click.Location = new System.Drawing.Point(590, 93);
            this.buttonCreateGroup_Click.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCreateGroup_Click.Name = "buttonCreateGroup_Click";
            this.buttonCreateGroup_Click.Size = new System.Drawing.Size(154, 29);
            this.buttonCreateGroup_Click.TabIndex = 21;
            this.buttonCreateGroup_Click.Text = "Создать группу";
            this.buttonCreateGroup_Click.UseVisualStyleBackColor = true;
            this.buttonCreateGroup_Click.Click += new System.EventHandler(this.CreateGroup);
            // 
            // buttonEdit_Click
            // 
            this.buttonEdit_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit_Click.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit_Click.Location = new System.Drawing.Point(590, 133);
            this.buttonEdit_Click.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEdit_Click.Name = "buttonEdit_Click";
            this.buttonEdit_Click.Size = new System.Drawing.Size(154, 29);
            this.buttonEdit_Click.TabIndex = 22;
            this.buttonEdit_Click.Text = "Редактировать";
            this.buttonEdit_Click.UseVisualStyleBackColor = true;
            this.buttonEdit_Click.Click += new System.EventHandler(this.Edit);
            // 
            // button_AddStudent
            // 
            this.button_AddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AddStudent.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AddStudent.Location = new System.Drawing.Point(590, 173);
            this.button_AddStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_AddStudent.Name = "button_AddStudent";
            this.button_AddStudent.Size = new System.Drawing.Size(154, 29);
            this.button_AddStudent.TabIndex = 23;
            this.button_AddStudent.Text = "Добавить студента";
            this.button_AddStudent.UseVisualStyleBackColor = true;
            this.button_AddStudent.Click += new System.EventHandler(this.AddStudentClick);
            // 
            // buttonDeleteStudent
            // 
            this.buttonDeleteStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteStudent.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteStudent.Location = new System.Drawing.Point(590, 213);
            this.buttonDeleteStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDeleteStudent.Name = "buttonDeleteStudent";
            this.buttonDeleteStudent.Size = new System.Drawing.Size(154, 29);
            this.buttonDeleteStudent.TabIndex = 24;
            this.buttonDeleteStudent.Text = "Удалить студента";
            this.buttonDeleteStudent.UseVisualStyleBackColor = true;
            this.buttonDeleteStudent.Click += new System.EventHandler(this.DeleteStudent);
            // 
            // schedule_button
            // 
            this.schedule_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.schedule_button.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.schedule_button.Location = new System.Drawing.Point(30, 333);
            this.schedule_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.schedule_button.Name = "schedule_button";
            this.schedule_button.Size = new System.Drawing.Size(200, 38);
            this.schedule_button.TabIndex = 25;
            this.schedule_button.Text = "Расписание";
            this.schedule_button.UseVisualStyleBackColor = true;
            this.schedule_button.Click += new System.EventHandler(this.ShowScheduleForm);
            // 
            // marks_button
            // 
            this.marks_button.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.marks_button.Location = new System.Drawing.Point(30, 385);
            this.marks_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.marks_button.Name = "marks_button";
            this.marks_button.Size = new System.Drawing.Size(200, 38);
            this.marks_button.TabIndex = 26;
            this.marks_button.Text = "Проставить баллы";
            this.marks_button.UseVisualStyleBackColor = true;
            this.marks_button.Click += new System.EventHandler(this.ShowMarksForm);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // group_box
            // 
            this.group_box.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.group_box.FormattingEnabled = true;
            this.group_box.Items.AddRange(new object[] {
            "09-321",
            "09-322"});
            this.group_box.Location = new System.Drawing.Point(344, 9);
            this.group_box.Name = "group_box";
            this.group_box.Size = new System.Drawing.Size(110, 26);
            this.group_box.TabIndex = 27;
            // 
            // show_students
            // 
            this.show_students.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.show_students.Location = new System.Drawing.Point(479, 8);
            this.show_students.Name = "show_students";
            this.show_students.Size = new System.Drawing.Size(105, 30);
            this.show_students.TabIndex = 28;
            this.show_students.Text = "Просмотр";
            this.show_students.UseVisualStyleBackColor = true;
            this.show_students.Click += new System.EventHandler(this.ShowStudents);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.marks_button);
            this.splitContainer1.Panel1.Controls.Add(this.schedule_button);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonDeleteStudent);
            this.splitContainer1.Panel2.Controls.Add(this.datagrid_students);
            this.splitContainer1.Panel2.Controls.Add(this.button_AddStudent);
            this.splitContainer1.Panel2.Controls.Add(this.group_box);
            this.splitContainer1.Panel2.Controls.Add(this.buttonEdit_Click);
            this.splitContainer1.Panel2.Controls.Add(this.show_students);
            this.splitContainer1.Panel2.Controls.Add(this.buttonCreateGroup_Click);
            this.splitContainer1.Panel2.Controls.Add(this.label);
            this.splitContainer1.Size = new System.Drawing.Size(1015, 602);
            this.splitContainer1.SplitterDistance = 262;
            this.splitContainer1.TabIndex = 29;
            // 
            // datagrid_students
            // 
            this.datagrid_students.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_students.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_students.Location = new System.Drawing.Point(9, 47);
            this.datagrid_students.Name = "datagrid_students";
            this.datagrid_students.RowHeadersWidth = 62;
            this.datagrid_students.RowTemplate.Height = 28;
            this.datagrid_students.Size = new System.Drawing.Size(575, 550);
            this.datagrid_students.TabIndex = 29;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1015, 602);
            this.Controls.Add(this.surname_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminForm";
            this.Text = "Электронный дневник (админ)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_students)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox surname_textbox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button buttonCreateGroup_Click;
        private System.Windows.Forms.Button buttonEdit_Click;
        private System.Windows.Forms.Button button_AddStudent;
        private System.Windows.Forms.Button buttonDeleteStudent;
        private System.Windows.Forms.Button schedule_button;
        private System.Windows.Forms.Button marks_button;
        private System.Windows.Forms.ComboBox group_box;
        private System.Windows.Forms.Button show_students;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView datagrid_students;
    }

}