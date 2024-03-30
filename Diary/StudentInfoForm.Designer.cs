namespace Diary
{
    partial class StudentInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentInfoForm));
            this.label = new System.Windows.Forms.Label();
            this.picture_box = new System.Windows.Forms.PictureBox();
            this.RedactButton = new System.Windows.Forms.Button();
            this.open_file_dialog = new System.Windows.Forms.OpenFileDialog();
            this.change_icon_button = new System.Windows.Forms.Button();
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.surname_textbox = new System.Windows.Forms.TextBox();
            this.login_textbox = new System.Windows.Forms.TextBox();
            this.group_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.pass_button = new System.Windows.Forms.Button();
            this.pass_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tool_tip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.SteelBlue;
            this.label.Dock = System.Windows.Forms.DockStyle.Top;
            this.label.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(0, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(778, 63);
            this.label.TabIndex = 0;
            this.label.Text = "Информация";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picture_box
            // 
            this.picture_box.Enabled = false;
            this.picture_box.Image = ((System.Drawing.Image)(resources.GetObject("picture_box.Image")));
            this.picture_box.Location = new System.Drawing.Point(13, 78);
            this.picture_box.Name = "picture_box";
            this.picture_box.Size = new System.Drawing.Size(200, 215);
            this.picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_box.TabIndex = 2;
            this.picture_box.TabStop = false;
            // 
            // RedactButton
            // 
            this.RedactButton.Location = new System.Drawing.Point(624, 482);
            this.RedactButton.Name = "RedactButton";
            this.RedactButton.Size = new System.Drawing.Size(142, 50);
            this.RedactButton.TabIndex = 3;
            this.RedactButton.Text = "Редактировать";
            this.RedactButton.UseVisualStyleBackColor = true;
            // 
            // open_file_dialog
            // 
            this.open_file_dialog.FileName = "openFileDialog1";
            // 
            // change_icon_button
            // 
            this.change_icon_button.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_icon_button.Location = new System.Drawing.Point(13, 317);
            this.change_icon_button.Name = "change_icon_button";
            this.change_icon_button.Size = new System.Drawing.Size(200, 65);
            this.change_icon_button.TabIndex = 5;
            this.change_icon_button.Text = "Изменить изображение";
            this.change_icon_button.UseVisualStyleBackColor = true;
            this.change_icon_button.Click += new System.EventHandler(this.ChangeIconButtonClick);
            // 
            // id_textbox
            // 
            this.id_textbox.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_textbox.Location = new System.Drawing.Point(436, 76);
            this.id_textbox.Multiline = true;
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.ReadOnly = true;
            this.id_textbox.Size = new System.Drawing.Size(200, 50);
            this.id_textbox.TabIndex = 6;
            // 
            // name_textbox
            // 
            this.name_textbox.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_textbox.Location = new System.Drawing.Point(436, 145);
            this.name_textbox.Multiline = true;
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.ReadOnly = true;
            this.name_textbox.Size = new System.Drawing.Size(200, 50);
            this.name_textbox.TabIndex = 7;
            // 
            // surname_textbox
            // 
            this.surname_textbox.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname_textbox.Location = new System.Drawing.Point(436, 214);
            this.surname_textbox.Multiline = true;
            this.surname_textbox.Name = "surname_textbox";
            this.surname_textbox.ReadOnly = true;
            this.surname_textbox.Size = new System.Drawing.Size(200, 50);
            this.surname_textbox.TabIndex = 8;
            // 
            // login_textbox
            // 
            this.login_textbox.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_textbox.Location = new System.Drawing.Point(436, 283);
            this.login_textbox.Multiline = true;
            this.login_textbox.Name = "login_textbox";
            this.login_textbox.ReadOnly = true;
            this.login_textbox.Size = new System.Drawing.Size(200, 50);
            this.login_textbox.TabIndex = 9;
            // 
            // group_textbox
            // 
            this.group_textbox.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.group_textbox.Location = new System.Drawing.Point(436, 421);
            this.group_textbox.Multiline = true;
            this.group_textbox.Name = "group_textbox";
            this.group_textbox.ReadOnly = true;
            this.group_textbox.Size = new System.Drawing.Size(200, 50);
            this.group_textbox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(294, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(294, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 27);
            this.label2.TabIndex = 14;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(294, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 27);
            this.label3.TabIndex = 15;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(294, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 27);
            this.label4.TabIndex = 16;
            this.label4.Text = "Логин";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(294, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 27);
            this.label6.TabIndex = 18;
            this.label6.Text = "Группа";
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.SystemColors.Control;
            this.login_button.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_button.Location = new System.Drawing.Point(666, 283);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(100, 50);
            this.login_button.TabIndex = 20;
            this.login_button.Text = "Изменить логин";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.ChangeLoginButtonClick);
            // 
            // pass_button
            // 
            this.pass_button.BackColor = System.Drawing.SystemColors.Control;
            this.pass_button.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_button.Location = new System.Drawing.Point(666, 352);
            this.pass_button.Name = "pass_button";
            this.pass_button.Size = new System.Drawing.Size(100, 50);
            this.pass_button.TabIndex = 22;
            this.pass_button.Text = "Изменить пароль";
            this.pass_button.UseVisualStyleBackColor = false;
            this.pass_button.Click += new System.EventHandler(this.ChangePassButtonClick);
            // 
            // pass_textbox
            // 
            this.pass_textbox.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_textbox.Location = new System.Drawing.Point(436, 352);
            this.pass_textbox.Multiline = true;
            this.pass_textbox.Name = "pass_textbox";
            this.pass_textbox.ReadOnly = true;
            this.pass_textbox.Size = new System.Drawing.Size(200, 50);
            this.pass_textbox.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(294, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 27);
            this.label5.TabIndex = 24;
            this.label5.Text = "Пароль";
            // 
            // tool_tip
            // 
            this.tool_tip.AutomaticDelay = 100;
            this.tool_tip.AutoPopDelay = 5000;
            this.tool_tip.InitialDelay = 100;
            this.tool_tip.ReshowDelay = 20;
            tool_tip.SetToolTip(this.id_textbox, "ID нельзя изменить");
            tool_tip.SetToolTip(this.surname_textbox, "Фамилию нельзя изменить");
            tool_tip.SetToolTip(this.name_textbox, "Имя нельзя изменить");
            tool_tip.SetToolTip(this.login_textbox, "Для изменения информации необходимо нажать соответствующую кнопку");
            tool_tip.SetToolTip(this.pass_textbox, "Для изменения информации необходимо нажать соответствующую кнопку");
            tool_tip.SetToolTip(this.group_textbox, "Группу нельзя изменить");
            // 
            // StudentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(778, 474);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pass_textbox);
            this.Controls.Add(this.pass_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.group_textbox);
            this.Controls.Add(this.login_textbox);
            this.Controls.Add(this.surname_textbox);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.id_textbox);
            this.Controls.Add(this.change_icon_button);
            this.Controls.Add(this.RedactButton);
            this.Controls.Add(this.picture_box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentInfoForm";
            this.Text = "Информация о студенте";
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picture_box;
        private System.Windows.Forms.Button RedactButton;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.OpenFileDialog open_file_dialog;
        private System.Windows.Forms.Button change_icon_button;
        private System.Windows.Forms.TextBox id_textbox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox surname_textbox;
        private System.Windows.Forms.TextBox login_textbox;
        private System.Windows.Forms.TextBox group_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button pass_button;
        private System.Windows.Forms.TextBox pass_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip tool_tip;
    }
}