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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.group_label = new System.Windows.Forms.Label();
            this.group_textbox = new System.Windows.Forms.TextBox();
            this.student_label = new System.Windows.Forms.Label();
            this.datagrid_students = new System.Windows.Forms.DataGridView();
            this.selectedStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectedStudentSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creategroup_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.addstudent_button = new System.Windows.Forms.Button();
            this.deletestudent_button = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tool_tip = new System.Windows.Forms.ToolTip(this.components);
            this.surname_textbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // name_textbox
            // 
            this.name_textbox.BackColor = System.Drawing.Color.SteelBlue;
            this.name_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_textbox.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_textbox.Location = new System.Drawing.Point(16, 61);
            this.name_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name_textbox.Multiline = true;
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(239, 30);
            this.name_textbox.TabIndex = 16;
            this.name_textbox.Text = "Имя";
            // 
            // group_label
            // 
            this.group_label.AutoSize = true;
            this.group_label.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.group_label.Location = new System.Drawing.Point(290, 27);
            this.group_label.Name = "group_label";
            this.group_label.Size = new System.Drawing.Size(128, 29);
            this.group_label.TabIndex = 17;
            this.group_label.Text = "Группа №";
            // 
            // group_textbox
            // 
            this.group_textbox.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.group_textbox.Location = new System.Drawing.Point(424, 27);
            this.group_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.group_textbox.Multiline = true;
            this.group_textbox.Name = "group_textbox";
            this.group_textbox.Size = new System.Drawing.Size(128, 29);
            this.group_textbox.TabIndex = 18;
            this.tool_tip.SetToolTip(this.group_textbox, "Поле для номера группы, информацию о которой вы хотите увидеть");
            this.group_textbox.TextChanged += new System.EventHandler(this.textBoxGroupName_TextChanged);
            // 
            // student_label
            // 
            this.student_label.AutoSize = true;
            this.student_label.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.student_label.Location = new System.Drawing.Point(290, 64);
            this.student_label.Name = "student_label";
            this.student_label.Size = new System.Drawing.Size(224, 29);
            this.student_label.TabIndex = 19;
            this.student_label.Text = "Список студентов :";
            // 
            // datagrid_students
            // 
            this.datagrid_students.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_students.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datagrid_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_students.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectedStudentName,
            this.selectedStudentSurname});
            this.datagrid_students.Location = new System.Drawing.Point(295, 112);
            this.datagrid_students.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datagrid_students.Name = "datagrid_students";
            this.datagrid_students.RowHeadersWidth = 51;
            this.datagrid_students.RowTemplate.Height = 24;
            this.datagrid_students.Size = new System.Drawing.Size(570, 505);
            this.datagrid_students.TabIndex = 20;
            this.datagrid_students.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellContentClick);
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
            // creategroup_button
            // 
            this.creategroup_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.creategroup_button.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.creategroup_button.Location = new System.Drawing.Point(14, 15);
            this.creategroup_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.creategroup_button.Name = "creategroup_button";
            this.creategroup_button.Size = new System.Drawing.Size(165, 55);
            this.creategroup_button.TabIndex = 21;
            this.creategroup_button.Text = "Создать группу";
            this.creategroup_button.UseVisualStyleBackColor = true;
            this.creategroup_button.Click += new System.EventHandler(this.CreateGroupButtonClick);
            // 
            // edit_button
            // 
            this.edit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_button.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_button.Location = new System.Drawing.Point(14, 78);
            this.edit_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(165, 55);
            this.edit_button.TabIndex = 22;
            this.edit_button.Text = "Редактировать";
            this.edit_button.UseVisualStyleBackColor = true;
            // 
            // addstudent_button
            // 
            this.addstudent_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addstudent_button.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addstudent_button.Location = new System.Drawing.Point(14, 141);
            this.addstudent_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addstudent_button.Name = "addstudent_button";
            this.addstudent_button.Size = new System.Drawing.Size(165, 55);
            this.addstudent_button.TabIndex = 23;
            this.addstudent_button.Text = "Добавить студента";
            this.addstudent_button.UseVisualStyleBackColor = true;
            this.addstudent_button.Click += new System.EventHandler(this.AddStudentButtonClick);
            // 
            // deletestudent_button
            // 
            this.deletestudent_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletestudent_button.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deletestudent_button.Location = new System.Drawing.Point(14, 204);
            this.deletestudent_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deletestudent_button.Name = "deletestudent_button";
            this.deletestudent_button.Size = new System.Drawing.Size(165, 55);
            this.deletestudent_button.TabIndex = 24;
            this.deletestudent_button.Text = "Удалить студента";
            this.deletestudent_button.UseVisualStyleBackColor = true;
            this.deletestudent_button.Click += new System.EventHandler(this.DeleteStudentButtonClick);
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
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.group_textbox);
            this.splitContainer1.Panel1.Controls.Add(this.student_label);
            this.splitContainer1.Panel1.Controls.Add(this.group_label);
            this.splitContainer1.Panel1.Controls.Add(this.datagrid_students);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.splitContainer1.Panel2.Controls.Add(this.deletestudent_button);
            this.splitContainer1.Panel2.Controls.Add(this.creategroup_button);
            this.splitContainer1.Panel2.Controls.Add(this.addstudent_button);
            this.splitContainer1.Panel2.Controls.Add(this.edit_button);
            this.splitContainer1.Size = new System.Drawing.Size(1087, 624);
            this.splitContainer1.SplitterDistance = 889;
            this.splitContainer1.TabIndex = 25;
            // 
            // tool_tip
            // 
            this.tool_tip.AutoPopDelay = 5000;
            this.tool_tip.InitialDelay = 1000;
            this.tool_tip.IsBalloon = true;
            this.tool_tip.ReshowDelay = 500;
            this.tool_tip.ShowAlways = true;
            // 
            // surname_textbox
            // 
            this.surname_textbox.BackColor = System.Drawing.Color.SteelBlue;
            this.surname_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surname_textbox.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname_textbox.Location = new System.Drawing.Point(16, 31);
            this.surname_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.surname_textbox.Multiline = true;
            this.surname_textbox.Name = "surname_textbox";
            this.surname_textbox.Size = new System.Drawing.Size(239, 30);
            this.surname_textbox.TabIndex = 14;
            this.surname_textbox.Text = "Фамилия";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.surname_textbox);
            this.panel1.Controls.Add(this.name_textbox);
            this.panel1.Location = new System.Drawing.Point(11, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 93);
            this.panel1.TabIndex = 21;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(16, 3);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(154, 24);
            this.label.TabIndex = 22;
            this.label.Text = "Администратор";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1087, 624);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminForm";
            this.Text = "Электронный дневник (админ)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_students)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label group_label;
        private System.Windows.Forms.TextBox group_textbox;
        private System.Windows.Forms.Label student_label;
        private System.Windows.Forms.DataGridView datagrid_students;
        private System.Windows.Forms.Button creategroup_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button addstudent_button;
        private System.Windows.Forms.Button deletestudent_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn selectedStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn selectedStudentSurname;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolTip tool_tip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox surname_textbox;
    }
}