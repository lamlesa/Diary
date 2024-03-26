namespace Diary
{
    partial class StudentForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.info_button = new System.Windows.Forms.Button();
            this.subjects_box = new System.Windows.Forms.ComboBox();
            this.SubjectDataGrid = new System.Windows.Forms.DataGridView();
            this.info_subject_button = new System.Windows.Forms.Button();
            this.schedule_button = new System.Windows.Forms.Button();
            this.ScheduleGrid = new System.Windows.Forms.DataGridView();
            this.weekday_box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // info_button
            // 
            this.info_button.Location = new System.Drawing.Point(24, 63);
            this.info_button.Name = "info_button";
            this.info_button.Size = new System.Drawing.Size(135, 37);
            this.info_button.TabIndex = 0;
            this.info_button.Text = "Информация";
            this.info_button.UseVisualStyleBackColor = true;
            this.info_button.Click += new System.EventHandler(this.InfoButtonClick);
            // 
            // subjects_box
            // 
            this.subjects_box.FormattingEnabled = true;
            this.subjects_box.Items.AddRange(new object[] {
            "Матанализ",
            "Английский язык",
            "Алгебра и геометрия",
            "Русский язык и культура речи",
            "Физическая культура",
            "Программирование",
            "Основы правоведения"});
            this.subjects_box.Location = new System.Drawing.Point(943, 63);
            this.subjects_box.Name = "subjects_box";
            this.subjects_box.Size = new System.Drawing.Size(160, 28);
            this.subjects_box.TabIndex = 1;
            this.subjects_box.Text = "Занятия";
            // 
            // SubjectDataGrid
            // 
            this.SubjectDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectDataGrid.Location = new System.Drawing.Point(930, 100);
            this.SubjectDataGrid.Name = "SubjectDataGrid";
            this.SubjectDataGrid.RowHeadersWidth = 62;
            this.SubjectDataGrid.RowTemplate.Height = 28;
            this.SubjectDataGrid.Size = new System.Drawing.Size(240, 150);
            this.SubjectDataGrid.TabIndex = 4;
            // 
            // info_subject_button
            // 
            this.info_subject_button.Location = new System.Drawing.Point(930, 272);
            this.info_subject_button.Name = "info_subject_button";
            this.info_subject_button.Size = new System.Drawing.Size(149, 45);
            this.info_subject_button.TabIndex = 5;
            this.info_subject_button.Text = "Занятие";
            this.info_subject_button.UseVisualStyleBackColor = true;
            this.info_subject_button.Click += new System.EventHandler(this.SubjectsInfo);
            // 
            // schedule_button
            // 
            this.schedule_button.Location = new System.Drawing.Point(512, 12);
            this.schedule_button.Name = "schedule_button";
            this.schedule_button.Size = new System.Drawing.Size(195, 51);
            this.schedule_button.TabIndex = 6;
            this.schedule_button.Text = "Расписание";
            this.schedule_button.UseVisualStyleBackColor = true;
            this.schedule_button.Click += new System.EventHandler(this.ShowSchedule);
            // 
            // ScheduleGrid
            // 
            this.ScheduleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleGrid.Location = new System.Drawing.Point(403, 100);
            this.ScheduleGrid.Name = "ScheduleGrid";
            this.ScheduleGrid.RowHeadersWidth = 62;
            this.ScheduleGrid.RowTemplate.Height = 28;
            this.ScheduleGrid.Size = new System.Drawing.Size(464, 324);
            this.ScheduleGrid.TabIndex = 8;
            // 
            // weekday_box
            // 
            this.weekday_box.FormattingEnabled = true;
            this.weekday_box.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота"});
            this.weekday_box.Location = new System.Drawing.Point(403, 66);
            this.weekday_box.Name = "weekday_box";
            this.weekday_box.Size = new System.Drawing.Size(160, 28);
            this.weekday_box.TabIndex = 9;
            this.weekday_box.Text = "Дни недели";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(939, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Карточки занятий";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Добавить заметку";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 168);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 217);
            this.textBox1.TabIndex = 12;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "нужно";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 599);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weekday_box);
            this.Controls.Add(this.ScheduleGrid);
            this.Controls.Add(this.schedule_button);
            this.Controls.Add(this.info_subject_button);
            this.Controls.Add(this.SubjectDataGrid);
            this.Controls.Add(this.subjects_box);
            this.Controls.Add(this.info_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentForm";
            this.Text = "Электронный дневник";
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button info_button;
        private System.Windows.Forms.ComboBox subjects_box;
        private System.Windows.Forms.DataGridView SubjectDataGrid;
        private System.Windows.Forms.Button info_subject_button;
        private System.Windows.Forms.Button schedule_button;
        private System.Windows.Forms.DataGridView ScheduleGrid;
        private System.Windows.Forms.ComboBox weekday_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

