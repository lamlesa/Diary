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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.info_button = new System.Windows.Forms.Button();
            this.subject_data_grid = new System.Windows.Forms.DataGridView();
            this.info_subject_button = new System.Windows.Forms.Button();
            this.schedule_button = new System.Windows.Forms.Button();
            this.schedule_grid = new System.Windows.Forms.DataGridView();
            this.weekday_box = new System.Windows.Forms.ComboBox();
            this.subject_label = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.surname_textbox = new System.Windows.Forms.TextBox();
            this.picture_box = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.schedule_label = new System.Windows.Forms.Label();
            this.card_panel = new System.Windows.Forms.Panel();
            this.note_button = new System.Windows.Forms.Button();
            this.sub_label = new System.Windows.Forms.Label();
            this.subject_combobox = new System.Windows.Forms.ComboBox();
            this.writenote_button = new System.Windows.Forms.Button();
            this.subjects_box = new System.Windows.Forms.ComboBox();
            this.note_textbox = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.note_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.subject_data_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedule_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.card_panel.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // info_button
            // 
            this.info_button.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_button.Location = new System.Drawing.Point(307, 100);
            this.info_button.Name = "info_button";
            this.info_button.Size = new System.Drawing.Size(135, 44);
            this.info_button.TabIndex = 0;
            this.info_button.Text = "Подробная информация";
            this.info_button.UseVisualStyleBackColor = true;
            this.info_button.Click += new System.EventHandler(this.InfoButtonClick);
            // 
            // subject_data_grid
            // 
            this.subject_data_grid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.subject_data_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.subject_data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subject_data_grid.Location = new System.Drawing.Point(269, 31);
            this.subject_data_grid.Name = "subject_data_grid";
            this.subject_data_grid.RowHeadersWidth = 62;
            this.subject_data_grid.RowTemplate.Height = 28;
            this.subject_data_grid.Size = new System.Drawing.Size(394, 97);
            this.subject_data_grid.TabIndex = 4;
            // 
            // info_subject_button
            // 
            this.info_subject_button.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_subject_button.Location = new System.Drawing.Point(19, 131);
            this.info_subject_button.Name = "info_subject_button";
            this.info_subject_button.Size = new System.Drawing.Size(149, 45);
            this.info_subject_button.TabIndex = 5;
            this.info_subject_button.Text = "Просмотреть";
            this.info_subject_button.UseVisualStyleBackColor = true;
            this.info_subject_button.Click += new System.EventHandler(this.SubjectsInfo);
            // 
            // schedule_button
            // 
            this.schedule_button.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.schedule_button.Location = new System.Drawing.Point(528, 387);
            this.schedule_button.Name = "schedule_button";
            this.schedule_button.Size = new System.Drawing.Size(150, 50);
            this.schedule_button.TabIndex = 6;
            this.schedule_button.Text = "Посмотреть расписание";
            this.schedule_button.UseVisualStyleBackColor = true;
            this.schedule_button.Click += new System.EventHandler(this.ShowSchedule);
            // 
            // schedule_grid
            // 
            this.schedule_grid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.schedule_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.schedule_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schedule_grid.Location = new System.Drawing.Point(7, 249);
            this.schedule_grid.Name = "schedule_grid";
            this.schedule_grid.RowHeadersWidth = 62;
            this.schedule_grid.RowTemplate.Height = 28;
            this.schedule_grid.Size = new System.Drawing.Size(514, 386);
            this.schedule_grid.TabIndex = 8;
            // 
            // weekday_box
            // 
            this.weekday_box.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weekday_box.FormattingEnabled = true;
            this.weekday_box.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота"});
            this.weekday_box.Location = new System.Drawing.Point(528, 279);
            this.weekday_box.Name = "weekday_box";
            this.weekday_box.Size = new System.Drawing.Size(150, 29);
            this.weekday_box.TabIndex = 9;
            this.weekday_box.Text = "День недели";
            // 
            // subject_label
            // 
            this.subject_label.AutoSize = true;
            this.subject_label.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subject_label.Location = new System.Drawing.Point(15, 11);
            this.subject_label.Name = "subject_label";
            this.subject_label.Size = new System.Drawing.Size(176, 63);
            this.subject_label.TabIndex = 10;
            this.subject_label.Text = "В этом поле можно \r\nпросмотреть\r\nкарточки занятий.";
            // 
            // name_textbox
            // 
            this.name_textbox.BackColor = System.Drawing.Color.PowderBlue;
            this.name_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_textbox.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_textbox.Location = new System.Drawing.Point(307, 12);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.ReadOnly = true;
            this.name_textbox.Size = new System.Drawing.Size(190, 32);
            this.name_textbox.TabIndex = 13;
            this.name_textbox.Text = "Имя";
            // 
            // surname_textbox
            // 
            this.surname_textbox.BackColor = System.Drawing.Color.PowderBlue;
            this.surname_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surname_textbox.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname_textbox.Location = new System.Drawing.Point(307, 50);
            this.surname_textbox.Name = "surname_textbox";
            this.surname_textbox.ReadOnly = true;
            this.surname_textbox.Size = new System.Drawing.Size(190, 32);
            this.surname_textbox.TabIndex = 14;
            this.surname_textbox.Text = "Фамилия";
            // 
            // picture_box
            // 
            this.picture_box.Image = ((System.Drawing.Image)(resources.GetObject("picture_box.Image")));
            this.picture_box.Location = new System.Drawing.Point(9, 9);
            this.picture_box.Name = "picture_box";
            this.picture_box.Size = new System.Drawing.Size(280, 205);
            this.picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_box.TabIndex = 15;
            this.picture_box.TabStop = false;
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
            this.splitContainer1.Panel1.Controls.Add(this.picture_box);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.schedule_label);
            this.splitContainer1.Panel2.Controls.Add(this.schedule_grid);
            this.splitContainer1.Panel2.Controls.Add(this.schedule_button);
            this.splitContainer1.Panel2.Controls.Add(this.weekday_box);
            this.splitContainer1.Panel2.Controls.Add(this.card_panel);
            this.splitContainer1.Size = new System.Drawing.Size(1193, 649);
            this.splitContainer1.SplitterDistance = 503;
            this.splitContainer1.TabIndex = 17;
            // 
            // schedule_label
            // 
            this.schedule_label.BackColor = System.Drawing.Color.SteelBlue;
            this.schedule_label.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.schedule_label.Location = new System.Drawing.Point(7, 224);
            this.schedule_label.Name = "schedule_label";
            this.schedule_label.Size = new System.Drawing.Size(514, 25);
            this.schedule_label.TabIndex = 10;
            this.schedule_label.Text = "Расписание";
            this.schedule_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // card_panel
            // 
            this.card_panel.BackColor = System.Drawing.Color.SteelBlue;
            this.card_panel.Controls.Add(this.note_button);
            this.card_panel.Controls.Add(this.sub_label);
            this.card_panel.Controls.Add(this.subject_combobox);
            this.card_panel.Controls.Add(this.subject_data_grid);
            this.card_panel.Controls.Add(this.info_subject_button);
            this.card_panel.Controls.Add(this.subject_label);
            this.card_panel.Location = new System.Drawing.Point(7, 9);
            this.card_panel.Name = "card_panel";
            this.card_panel.Size = new System.Drawing.Size(666, 191);
            this.card_panel.TabIndex = 11;
            // 
            // note_button
            // 
            this.note_button.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note_button.Location = new System.Drawing.Point(557, 136);
            this.note_button.Name = "note_button";
            this.note_button.Size = new System.Drawing.Size(93, 45);
            this.note_button.TabIndex = 13;
            this.note_button.Text = "Просмотр заметки";
            this.note_button.UseVisualStyleBackColor = true;
            this.note_button.Click += new System.EventHandler(this.NoteButtonClick);
            // 
            // sub_label
            // 
            this.sub_label.BackColor = System.Drawing.Color.LightBlue;
            this.sub_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sub_label.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sub_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sub_label.Location = new System.Drawing.Point(269, 8);
            this.sub_label.Name = "sub_label";
            this.sub_label.Size = new System.Drawing.Size(394, 23);
            this.sub_label.TabIndex = 12;
            this.sub_label.Text = "Карточка занятия";
            this.sub_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subject_combobox
            // 
            this.subject_combobox.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subject_combobox.FormattingEnabled = true;
            this.subject_combobox.Items.AddRange(new object[] {
            "Матанализ",
            "Английский",
            "Алгебра и геометрия",
            "История",
            "Русский",
            "Программирование",
            "Физическая культура",
            "Правоведение"});
            this.subject_combobox.Location = new System.Drawing.Point(19, 90);
            this.subject_combobox.Name = "subject_combobox";
            this.subject_combobox.Size = new System.Drawing.Size(209, 26);
            this.subject_combobox.TabIndex = 11;
            this.subject_combobox.Text = "Дисциплины";
            // 
            // writenote_button
            // 
            this.writenote_button.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.writenote_button.Location = new System.Drawing.Point(147, 365);
            this.writenote_button.Name = "writenote_button";
            this.writenote_button.Size = new System.Drawing.Size(190, 37);
            this.writenote_button.TabIndex = 11;
            this.writenote_button.Text = "Добавить заметку";
            this.writenote_button.UseVisualStyleBackColor = true;
            this.writenote_button.Click += new System.EventHandler(this.WriteNoteButtonClick);
            // 
            // subjects_box
            // 
            this.subjects_box.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjects_box.FormattingEnabled = true;
            this.subjects_box.Items.AddRange(new object[] {
            "Матанализ",
            "Английский",
            "Алгебра и геометрия",
            "История",
            "Русский",
            "Программирование",
            "Физическая культура",
            "Правоведение"});
            this.subjects_box.Location = new System.Drawing.Point(12, 55);
            this.subjects_box.Name = "subjects_box";
            this.subjects_box.Size = new System.Drawing.Size(209, 26);
            this.subjects_box.TabIndex = 1;
            this.subjects_box.Text = "Дисциплины";
            // 
            // note_textbox
            // 
            this.note_textbox.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.note_textbox.Location = new System.Drawing.Point(12, 91);
            this.note_textbox.Multiline = true;
            this.note_textbox.Name = "note_textbox";
            this.note_textbox.Size = new System.Drawing.Size(460, 265);
            this.note_textbox.TabIndex = 12;
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel.BackColor = System.Drawing.Color.SteelBlue;
            this.panel.Controls.Add(this.note_label);
            this.panel.Controls.Add(this.note_textbox);
            this.panel.Controls.Add(this.subjects_box);
            this.panel.Controls.Add(this.writenote_button);
            this.panel.Location = new System.Drawing.Point(10, 225);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(485, 412);
            this.panel.TabIndex = 16;
            // 
            // note_label
            // 
            this.note_label.AutoSize = true;
            this.note_label.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.note_label.Location = new System.Drawing.Point(9, 6);
            this.note_label.Name = "note_label";
            this.note_label.Size = new System.Drawing.Size(383, 42);
            this.note_label.TabIndex = 13;
            this.note_label.Text = "В этом поле можно к выбранному предмету \r\nдобавить заметку.";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1193, 649);
            this.Controls.Add(this.surname_textbox);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.info_button);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentForm";
            this.Text = "Электронный дневник";
            ((System.ComponentModel.ISupportInitialize)(this.subject_data_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedule_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.card_panel.ResumeLayout(false);
            this.card_panel.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button info_button;
        private System.Windows.Forms.DataGridView subject_data_grid;
        private System.Windows.Forms.Button info_subject_button;
        private System.Windows.Forms.Button schedule_button;
        private System.Windows.Forms.DataGridView schedule_grid;
        private System.Windows.Forms.ComboBox weekday_box;
        private System.Windows.Forms.Label subject_label;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox surname_textbox;
        private System.Windows.Forms.PictureBox picture_box;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button writenote_button;
        private System.Windows.Forms.ComboBox subjects_box;
        private System.Windows.Forms.TextBox note_textbox;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label note_label;
        private System.Windows.Forms.Label schedule_label;
        private System.Windows.Forms.Panel card_panel;
        private System.Windows.Forms.ComboBox subject_combobox;
        private System.Windows.Forms.Label sub_label;
        private System.Windows.Forms.Button note_button;
    }
}

