namespace Diary
{
    partial class StudentInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentInfo));
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.panel = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.RedactButton = new System.Windows.Forms.Button();
            this.ViewInfoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(13, 125);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersWidth = 62;
            this.DataGrid.RowTemplate.Height = 28;
            this.DataGrid.Size = new System.Drawing.Size(282, 167);
            this.DataGrid.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Khaki;
            this.panel.Controls.Add(this.label);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(478, 100);
            this.panel.TabIndex = 1;
            // 
            // label
            // 
            this.label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(0, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(478, 100);
            this.label.TabIndex = 0;
            this.label.Text = "Информация";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBox
            // 
            this.PictureBox.Enabled = false;
            this.PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox.Image")));
            this.PictureBox.Location = new System.Drawing.Point(315, 125);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(150, 170);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 2;
            this.PictureBox.TabStop = false;
            // 
            // RedactButton
            // 
            this.RedactButton.Location = new System.Drawing.Point(324, 382);
            this.RedactButton.Name = "RedactButton";
            this.RedactButton.Size = new System.Drawing.Size(142, 50);
            this.RedactButton.TabIndex = 3;
            this.RedactButton.Text = "Редактировать";
            this.RedactButton.UseVisualStyleBackColor = true;
            this.RedactButton.Click += new System.EventHandler(this.RedactButtonClick);
            // 
            // ViewInfoButton
            // 
            this.ViewInfoButton.Font = new System.Drawing.Font("Microsoft Yi Baiti", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewInfoButton.Location = new System.Drawing.Point(13, 319);
            this.ViewInfoButton.Name = "ViewInfoButton";
            this.ViewInfoButton.Size = new System.Drawing.Size(100, 50);
            this.ViewInfoButton.TabIndex = 4;
            this.ViewInfoButton.Text = "Посмотреть информацию";
            this.ViewInfoButton.UseVisualStyleBackColor = true;
            this.ViewInfoButton.Click += new System.EventHandler(this.ViewInfoButtonClick);
            // 
            // StudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(478, 444);
            this.Controls.Add(this.ViewInfoButton);
            this.Controls.Add(this.RedactButton);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.DataGrid);
            this.Name = "StudentInfo";
            this.Text = "Информация о студенте";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button RedactButton;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button ViewInfoButton;
    }
}