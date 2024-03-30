namespace Diary
{
    partial class ScheduleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleForm));
            this.timer = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.weekday_box = new System.Windows.Forms.ComboBox();
            this.panel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.aud = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.professor = new System.Windows.Forms.TextBox();
            this.weekday = new System.Windows.Forms.TextBox();
            this.schedule = new System.Windows.Forms.DataGridView();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedule)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timer.Location = new System.Drawing.Point(112, 93);
            this.timer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.timer.Name = "timer";
            this.timer.ShowUpDown = true;
            this.timer.Size = new System.Drawing.Size(120, 26);
            this.timer.TabIndex = 1;
            this.timer.Value = new System.DateTime(2024, 3, 30, 20, 17, 0, 0);
            // 
            // addButton
            // 
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(160, 305);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(136, 58);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(798, 127);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(112, 29);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(798, 74);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(119, 29);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.Save);
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
            this.weekday_box.Location = new System.Drawing.Point(791, 13);
            this.weekday_box.Name = "weekday_box";
            this.weekday_box.Size = new System.Drawing.Size(150, 29);
            this.weekday_box.TabIndex = 10;
            this.weekday_box.Text = "День недели";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.SteelBlue;
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label);
            this.panel.Controls.Add(this.aud);
            this.panel.Controls.Add(this.name);
            this.panel.Controls.Add(this.professor);
            this.panel.Controls.Add(this.weekday);
            this.panel.Controls.Add(this.addButton);
            this.panel.Controls.Add(this.timer);
            this.panel.Location = new System.Drawing.Point(782, 268);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(306, 375);
            this.panel.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "День недели";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(15, 17);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(281, 24);
            this.label.TabIndex = 8;
            this.label.Text = "Добавление нового занятия :";
            // 
            // aud
            // 
            this.aud.Location = new System.Drawing.Point(112, 190);
            this.aud.Name = "aud";
            this.aud.Size = new System.Drawing.Size(100, 26);
            this.aud.TabIndex = 7;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(112, 158);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 26);
            this.name.TabIndex = 6;
            // 
            // professor
            // 
            this.professor.Location = new System.Drawing.Point(112, 126);
            this.professor.Name = "professor";
            this.professor.Size = new System.Drawing.Size(100, 26);
            this.professor.TabIndex = 5;
            // 
            // weekday
            // 
            this.weekday.Location = new System.Drawing.Point(132, 57);
            this.weekday.Name = "weekday";
            this.weekday.Size = new System.Drawing.Size(100, 26);
            this.weekday.TabIndex = 4;
            // 
            // schedule
            // 
            this.schedule.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schedule.Location = new System.Drawing.Point(13, 28);
            this.schedule.Name = "schedule";
            this.schedule.RowHeadersWidth = 62;
            this.schedule.RowTemplate.Height = 28;
            this.schedule.Size = new System.Drawing.Size(763, 615);
            this.schedule.TabIndex = 12;
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1098, 644);
            this.Controls.Add(this.schedule);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.weekday_box);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScheduleForm";
            this.Text = "Расписание";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker timer;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox weekday_box;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox professor;
        private System.Windows.Forms.TextBox weekday;
        private System.Windows.Forms.TextBox aud;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridView schedule;
    }

}