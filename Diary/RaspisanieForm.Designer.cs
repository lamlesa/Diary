namespace Diary
{
    partial class RaspisanieForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1_CellEndEdit = new System.Windows.Forms.DataGridView();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prepod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auditory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_CellEndEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(751, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dataGridView1_CellEndEdit
            // 
            this.dataGridView1_CellEndEdit.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dataGridView1_CellEndEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_CellEndEdit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day,
            this.Time,
            this.prepod,
            this.subject,
            this.Auditory});
            this.dataGridView1_CellEndEdit.Location = new System.Drawing.Point(104, 83);
            this.dataGridView1_CellEndEdit.Name = "dataGridView1_CellEndEdit";
            this.dataGridView1_CellEndEdit.RowHeadersWidth = 51;
            this.dataGridView1_CellEndEdit.RowTemplate.Height = 24;
            this.dataGridView1_CellEndEdit.Size = new System.Drawing.Size(678, 413);
            this.dataGridView1_CellEndEdit.TabIndex = 2;
            this.dataGridView1_CellEndEdit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit_CellContentClick);
            // 
            // Day
            // 
            this.Day.HeaderText = "День недели";
            this.Day.MinimumWidth = 6;
            this.Day.Name = "Day";
            this.Day.Width = 125;
            // 
            // Time
            // 
            this.Time.HeaderText = "Время пар";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.Width = 125;
            // 
            // prepod
            // 
            this.prepod.HeaderText = "Преподаватель";
            this.prepod.MinimumWidth = 6;
            this.prepod.Name = "prepod";
            this.prepod.Width = 125;
            // 
            // subject
            // 
            this.subject.HeaderText = "Предмет";
            this.subject.MinimumWidth = 6;
            this.subject.Name = "subject";
            this.subject.Width = 125;
            // 
            // Auditory
            // 
            this.Auditory.HeaderText = "Аудитория";
            this.Auditory.MinimumWidth = 6;
            this.Auditory.Name = "Auditory";
            this.Auditory.Width = 125;
            // 
            // addButton
            // 
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Location = new System.Drawing.Point(104, 525);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(95, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Location = new System.Drawing.Point(315, 525);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(83, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Location = new System.Drawing.Point(214, 525);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(89, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // RaspisanieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1006, 560);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataGridView1_CellEndEdit);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "RaspisanieForm";
            this.Text = "Raspisanie";
            this.Load += new System.EventHandler(this.Raspisanie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_CellEndEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1_CellEndEdit;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn prepod;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auditory;
    }

}