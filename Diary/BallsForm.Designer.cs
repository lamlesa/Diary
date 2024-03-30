namespace Diary
{
    partial class BallsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgw_student = new System.Windows.Forms.DataGridView();
            this.proga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fizra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProgrammingHomework = new System.Windows.Forms.TextBox();
            this.txtMathControl = new System.Windows.Forms.TextBox();
            this.txtPhysicalEducationQuiz = new System.Windows.Forms.TextBox();
            this.txtProgrammingControl = new System.Windows.Forms.TextBox();
            this.txtPhysicalEducationControl = new System.Windows.Forms.TextBox();
            this.txtMathQuiz = new System.Windows.Forms.TextBox();
            this.txtProgrammingQuiz = new System.Windows.Forms.TextBox();
            this.txtMathHomework = new System.Windows.Forms.TextBox();
            this.txtPhysicalEducationHomework = new System.Windows.Forms.TextBox();
            this.txtProgrammingExam = new System.Windows.Forms.TextBox();
            this.txtMathExam = new System.Windows.Forms.TextBox();
            this.txtPhysicalEducationExam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_student)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(125, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(130, 73);
            this.textBoxSurname.Multiline = true;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(151, 39);
            this.textBoxSurname.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
        "321",
        "322"});
            this.comboBox1.Location = new System.Drawing.Point(130, 264);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // dgw_student
            // 
            this.dgw_student.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dgw_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
        this.proga,
        this.fizra,
        this.matan});
            this.dgw_student.Location = new System.Drawing.Point(430, 104);
            this.dgw_student.Name = "dgw_student";
            this.dgw_student.RowHeadersWidth = 51;
            this.dgw_student.RowTemplate.Height = 24;
            this.dgw_student.Size = new System.Drawing.Size(427, 39);
            this.dgw_student.TabIndex = 3;
            this.dgw_student.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_student_CellContentClick);
            // 
            // proga
            // 
            this.proga.HeaderText = "Программирование";
            this.proga.MinimumWidth = 6;
            this.proga.Name = "proga";
            this.proga.Width = 125;
            // 
            // fizra
            // 
            this.fizra.HeaderText = "Физкультура";
            this.fizra.MinimumWidth = 6;
            this.fizra.Name = "fizra";
            this.fizra.Width = 125;
            // 
            // matan
            // 
            this.matan.HeaderText = "Мат.Анализ";
            this.matan.MinimumWidth = 6;
            this.matan.Name = "matan";
            this.matan.Width = 125;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(506, 307);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 39);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(125, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Имя";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(130, 161);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(151, 39);
            this.textBoxName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(125, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Группа";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(632, 307);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 39);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(467, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Баллы по предметам";
            // 
            // txtProgrammingHomework
            // 
            this.txtProgrammingHomework.Location = new System.Drawing.Point(490, 149);
            this.txtProgrammingHomework.Name = "txtProgrammingHomework";
            this.txtProgrammingHomework.Size = new System.Drawing.Size(100, 22);
            this.txtProgrammingHomework.TabIndex = 13;
            // 
            // txtMathControl
            // 
            this.txtMathControl.Location = new System.Drawing.Point(737, 178);
            this.txtMathControl.Name = "txtMathControl";
            this.txtMathControl.Size = new System.Drawing.Size(100, 22);
            this.txtMathControl.TabIndex = 14;
            // 
            // txtPhysicalEducationQuiz
            // 
            this.txtPhysicalEducationQuiz.Location = new System.Drawing.Point(610, 206);
            this.txtPhysicalEducationQuiz.Name = "txtPhysicalEducationQuiz";
            this.txtPhysicalEducationQuiz.Size = new System.Drawing.Size(100, 22);
            this.txtPhysicalEducationQuiz.TabIndex = 15;
            // 
            // txtProgrammingControl
            // 
            this.txtProgrammingControl.Location = new System.Drawing.Point(490, 178);
            this.txtProgrammingControl.Name = "txtProgrammingControl";
            this.txtProgrammingControl.Size = new System.Drawing.Size(100, 22);
            this.txtProgrammingControl.TabIndex = 16;
            // 
            // txtPhysicalEducationControl
            // 
            this.txtPhysicalEducationControl.Location = new System.Drawing.Point(610, 178);
            this.txtPhysicalEducationControl.Name = "txtPhysicalEducationControl";
            this.txtPhysicalEducationControl.Size = new System.Drawing.Size(100, 22);
            this.txtPhysicalEducationControl.TabIndex = 17;
            // 
            // txtMathQuiz
            // 
            this.txtMathQuiz.Location = new System.Drawing.Point(737, 206);
            this.txtMathQuiz.Name = "txtMathQuiz";
            this.txtMathQuiz.Size = new System.Drawing.Size(100, 22);
            this.txtMathQuiz.TabIndex = 18;
            // 
            // txtProgrammingQuiz
            // 
            this.txtProgrammingQuiz.Location = new System.Drawing.Point(490, 206);
            this.txtProgrammingQuiz.Name = "txtProgrammingQuiz";
            this.txtProgrammingQuiz.Size = new System.Drawing.Size(100, 22);
            this.txtProgrammingQuiz.TabIndex = 19;
            // 
            // txtMathHomework
            // 
            this.txtMathHomework.Location = new System.Drawing.Point(737, 149);
            this.txtMathHomework.Name = "txtMathHomework";
            this.txtMathHomework.Size = new System.Drawing.Size(100, 22);
            this.txtMathHomework.TabIndex = 20;
            // 
            // txtPhysicalEducationHomework
            // 
            this.txtPhysicalEducationHomework.Location = new System.Drawing.Point(610, 149);
            this.txtPhysicalEducationHomework.Name = "txtPhysicalEducationHomework";
            this.txtPhysicalEducationHomework.Size = new System.Drawing.Size(100, 22);
            this.txtPhysicalEducationHomework.TabIndex = 21;
            // 
            // txtProgrammingExam
            // 
            this.txtProgrammingExam.Location = new System.Drawing.Point(490, 239);
            this.txtProgrammingExam.Name = "txtProgrammingExam";
            this.txtProgrammingExam.Size = new System.Drawing.Size(100, 22);
            this.txtProgrammingExam.TabIndex = 24;
            // 
            // txtMathExam
            // 
            this.txtMathExam.Location = new System.Drawing.Point(737, 239);
            this.txtMathExam.Name = "txtMathExam";
            this.txtMathExam.Size = new System.Drawing.Size(100, 22);
            this.txtMathExam.TabIndex = 26;
            // 
            // txtPhysicalEducationExam
            // 
            this.txtPhysicalEducationExam.Location = new System.Drawing.Point(610, 239);
            this.txtPhysicalEducationExam.Name = "txtPhysicalEducationExam";
            this.txtPhysicalEducationExam.Size = new System.Drawing.Size(100, 22);
            this.txtPhysicalEducationExam.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(445, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "ДЗ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(418, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Зачет";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(402, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Экзамен";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(448, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "КР";
            // 
            // BallsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1163, 540);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPhysicalEducationExam);
            this.Controls.Add(this.txtMathExam);
            this.Controls.Add(this.txtProgrammingExam);
            this.Controls.Add(this.txtPhysicalEducationHomework);
            this.Controls.Add(this.txtMathHomework);
            this.Controls.Add(this.txtProgrammingQuiz);
            this.Controls.Add(this.txtMathQuiz);
            this.Controls.Add(this.txtPhysicalEducationControl);
            this.Controls.Add(this.txtProgrammingControl);
            this.Controls.Add(this.txtPhysicalEducationQuiz);
            this.Controls.Add(this.txtMathControl);
            this.Controls.Add(this.txtProgrammingHomework);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgw_student);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.label1);
            this.Name = "BallsForm";
            this.Text = "BallsForm";
            this.Load += new System.EventHandler(this.BallsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgw_student;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn proga;
        private System.Windows.Forms.DataGridViewTextBoxColumn fizra;
        private System.Windows.Forms.DataGridViewTextBoxColumn matan;
        private System.Windows.Forms.TextBox txtProgrammingHomework;
        private System.Windows.Forms.TextBox txtMathControl;
        private System.Windows.Forms.TextBox txtPhysicalEducationQuiz;
        private System.Windows.Forms.TextBox txtProgrammingControl;
        private System.Windows.Forms.TextBox txtPhysicalEducationControl;
        private System.Windows.Forms.TextBox txtMathQuiz;
        private System.Windows.Forms.TextBox txtProgrammingQuiz;
        private System.Windows.Forms.TextBox txtMathHomework;
        private System.Windows.Forms.TextBox txtPhysicalEducationHomework;
        private System.Windows.Forms.TextBox txtProgrammingExam;
        private System.Windows.Forms.TextBox txtMathExam;
        private System.Windows.Forms.TextBox txtPhysicalEducationExam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }

}