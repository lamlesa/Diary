namespace Diary
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.label5 = new System.Windows.Forms.Label();
            this.pass_textbox = new System.Windows.Forms.TextBox();
            this.pass_button = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.group_textbox = new System.Windows.Forms.TextBox();
            this.login_textbox = new System.Windows.Forms.TextBox();
            this.surname_textbox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.change_icon_button = new System.Windows.Forms.Button();
            this.picture_box = new System.Windows.Forms.PictureBox();
            this.open_file_dialog = new System.Windows.Forms.OpenFileDialog();
            this.surname_button = new System.Windows.Forms.Button();
            this.name_button = new System.Windows.Forms.Button();
            this.group_button = new System.Windows.Forms.Button();
            this.tool_tip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(305, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 27);
            this.label5.TabIndex = 40;
            this.label5.Text = "Пароль";
            // 
            // pass_textbox
            // 
            this.pass_textbox.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_textbox.Location = new System.Drawing.Point(447, 304);
            this.pass_textbox.Multiline = true;
            this.pass_textbox.Name = "pass_textbox";
            this.pass_textbox.ReadOnly = true;
            this.pass_textbox.Size = new System.Drawing.Size(200, 50);
            this.pass_textbox.TabIndex = 39;
            // 
            // pass_button
            // 
            this.pass_button.BackColor = System.Drawing.SystemColors.Control;
            this.pass_button.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_button.Location = new System.Drawing.Point(677, 304);
            this.pass_button.Name = "pass_button";
            this.pass_button.Size = new System.Drawing.Size(100, 50);
            this.pass_button.TabIndex = 38;
            this.pass_button.Text = "Изменить пароль";
            this.pass_button.UseVisualStyleBackColor = false;
            this.pass_button.Click += new System.EventHandler(this.ChangePassButtonClick);
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.SystemColors.Control;
            this.login_button.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_button.Location = new System.Drawing.Point(677, 235);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(100, 50);
            this.login_button.TabIndex = 37;
            this.login_button.Text = "Изменить логин";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.ChangeLoginButtonClick);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(305, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 27);
            this.label6.TabIndex = 36;
            this.label6.Text = "Группа";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(305, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 27);
            this.label4.TabIndex = 35;
            this.label4.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(305, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 27);
            this.label3.TabIndex = 34;
            this.label3.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(305, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 27);
            this.label2.TabIndex = 33;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(305, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 27);
            this.label1.TabIndex = 32;
            this.label1.Text = "ID";
            // 
            // group_textbox
            // 
            this.group_textbox.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.group_textbox.Location = new System.Drawing.Point(447, 373);
            this.group_textbox.Multiline = true;
            this.group_textbox.Name = "group_textbox";
            this.group_textbox.ReadOnly = true;
            this.group_textbox.Size = new System.Drawing.Size(200, 50);
            this.group_textbox.TabIndex = 31;
            // 
            // login_textbox
            // 
            this.login_textbox.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_textbox.Location = new System.Drawing.Point(447, 235);
            this.login_textbox.Multiline = true;
            this.login_textbox.Name = "login_textbox";
            this.login_textbox.ReadOnly = true;
            this.login_textbox.Size = new System.Drawing.Size(200, 50);
            this.login_textbox.TabIndex = 30;
            // 
            // surname_textbox
            // 
            this.surname_textbox.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname_textbox.Location = new System.Drawing.Point(447, 166);
            this.surname_textbox.Multiline = true;
            this.surname_textbox.Name = "surname_textbox";
            this.surname_textbox.ReadOnly = true;
            this.surname_textbox.Size = new System.Drawing.Size(200, 50);
            this.surname_textbox.TabIndex = 29;
            // 
            // name_textbox
            // 
            this.name_textbox.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_textbox.Location = new System.Drawing.Point(447, 97);
            this.name_textbox.Multiline = true;
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.ReadOnly = true;
            this.name_textbox.Size = new System.Drawing.Size(200, 50);
            this.name_textbox.TabIndex = 28;
            // 
            // id_textbox
            // 
            this.id_textbox.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_textbox.Location = new System.Drawing.Point(447, 28);
            this.id_textbox.Multiline = true;
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.ReadOnly = true;
            this.id_textbox.Size = new System.Drawing.Size(200, 50);
            this.id_textbox.TabIndex = 27;
            // 
            // change_icon_button
            // 
            this.change_icon_button.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_icon_button.Location = new System.Drawing.Point(24, 269);
            this.change_icon_button.Name = "change_icon_button";
            this.change_icon_button.Size = new System.Drawing.Size(200, 65);
            this.change_icon_button.TabIndex = 26;
            this.change_icon_button.Text = "Изменить изображение";
            this.change_icon_button.UseVisualStyleBackColor = true;
            this.change_icon_button.Click += new System.EventHandler(this.ChangeIconButtonClick);
            // 
            // picture_box
            // 
            this.picture_box.Enabled = false;
            this.picture_box.Image = ((System.Drawing.Image)(resources.GetObject("picture_box.Image")));
            this.picture_box.Location = new System.Drawing.Point(24, 30);
            this.picture_box.Name = "picture_box";
            this.picture_box.Size = new System.Drawing.Size(200, 215);
            this.picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_box.TabIndex = 25;
            this.picture_box.TabStop = false;
            // 
            // open_file_dialog
            // 
            this.open_file_dialog.FileName = "openFileDialog1";
            // 
            // surname_button
            // 
            this.surname_button.BackColor = System.Drawing.SystemColors.Control;
            this.surname_button.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname_button.Location = new System.Drawing.Point(677, 166);
            this.surname_button.Name = "surname_button";
            this.surname_button.Size = new System.Drawing.Size(100, 50);
            this.surname_button.TabIndex = 41;
            this.surname_button.Text = "Изменить фамилию";
            this.surname_button.UseVisualStyleBackColor = false;
            this.surname_button.Click += new System.EventHandler(this.ChangeSurnameButtonClick);
            // 
            // name_button
            // 
            this.name_button.BackColor = System.Drawing.SystemColors.Control;
            this.name_button.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_button.Location = new System.Drawing.Point(677, 97);
            this.name_button.Name = "name_button";
            this.name_button.Size = new System.Drawing.Size(100, 50);
            this.name_button.TabIndex = 42;
            this.name_button.Text = "Изменить имя";
            this.name_button.UseVisualStyleBackColor = false;
            this.name_button.Click += new System.EventHandler(this.ChangeNameButtonClick);
            // 
            // group_button
            // 
            this.group_button.BackColor = System.Drawing.SystemColors.Control;
            this.group_button.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.group_button.Location = new System.Drawing.Point(677, 373);
            this.group_button.Name = "group_button";
            this.group_button.Size = new System.Drawing.Size(100, 50);
            this.group_button.TabIndex = 44;
            this.group_button.Text = "Изменить группу";
            this.group_button.UseVisualStyleBackColor = false;
            this.group_button.Click += new System.EventHandler(this.ChangeGroupButtonClick);
            // 
            // tool_tip
            // 
            this.tool_tip.AutomaticDelay = 100;
            this.tool_tip.AutoPopDelay = 5000;
            this.tool_tip.InitialDelay = 500;
            this.tool_tip.ReshowDelay = 20;
            tool_tip.SetToolTip(this.id_textbox, "ID нельзя изменить");
            tool_tip.SetToolTip(this.surname_textbox, "Для изменения информации необходимо нажать соответствующую кнопку");
            tool_tip.SetToolTip(this.name_textbox, "Для изменения информации необходимо нажать соответствующую кнопку");
            tool_tip.SetToolTip(this.login_textbox, "Для изменения информации необходимо нажать соответствующую кнопку");
            tool_tip.SetToolTip(this.pass_textbox, "Для изменения информации необходимо нажать соответствующую кнопку");
            tool_tip.SetToolTip(this.group_textbox, "Для изменения информации необходимо нажать соответствующую кнопку");
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.group_button);
            this.Controls.Add(this.name_button);
            this.Controls.Add(this.surname_button);
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
            this.Controls.Add(this.id_textbox);
            this.Controls.Add(this.change_icon_button);
            this.Controls.Add(this.picture_box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditForm";
            this.Text = "Редактирование информации о студенте";
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pass_textbox;
        private System.Windows.Forms.Button pass_button;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox group_textbox;
        private System.Windows.Forms.TextBox login_textbox;
        private System.Windows.Forms.TextBox surname_textbox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox id_textbox;
        private System.Windows.Forms.Button change_icon_button;
        private System.Windows.Forms.PictureBox picture_box;
        private System.Windows.Forms.OpenFileDialog open_file_dialog;
        private System.Windows.Forms.Button surname_button;
        private System.Windows.Forms.Button name_button;
        private System.Windows.Forms.Button group_button;
        private System.Windows.Forms.ToolTip tool_tip;
    }
}