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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.surname_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Фамилия :";
            // 
            // surname_textbox
            // 
            this.surname_textbox.Location = new System.Drawing.Point(18, 92);
            this.surname_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.surname_textbox.Multiline = true;
            this.surname_textbox.Name = "surname_textbox";
            this.surname_textbox.Size = new System.Drawing.Size(190, 40);
            this.surname_textbox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Имя :";
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(18, 169);
            this.name_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name_textbox.Multiline = true;
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(190, 40);
            this.name_textbox.TabIndex = 16;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_students.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.creategroup_button.Click += new System.EventHandler(this.buttonCreateGroup_Click_Click);
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
            this.addstudent_button.Click += new System.EventHandler(this.button_AddStudent_Click);
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
            this.deletestudent_button.Click += new System.EventHandler(this.buttonDeleteStudent_Click_Click);
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
            this.splitContainer1.Panel1.Controls.Add(this.group_textbox);
            this.splitContainer1.Panel1.Controls.Add(this.student_label);
            this.splitContainer1.Panel1.Controls.Add(this.group_label);
            this.splitContainer1.Panel1.Controls.Add(this.datagrid_students);
            this.splitContainer1.Panel1.Controls.Add(this.panel);
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
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.SteelBlue;
            this.panel.Controls.Add(this.name_textbox);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.surname_textbox);
            this.panel.Location = new System.Drawing.Point(11, 204);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(255, 233);
            this.panel.TabIndex = 21;
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
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox surname_textbox;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Panel panel;
    }
}