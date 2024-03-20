namespace Diary
{
    partial class RegistrationForm
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
            this.login = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.group = new System.Windows.Forms.TextBox();
            this.role_box = new System.Windows.Forms.ComboBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.register_button = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.little_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.little_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(50, 163);
            this.login.Multiline = true;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(250, 50);
            this.login.TabIndex = 1;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.LightGreen;
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.group);
            this.panel.Controls.Add(this.role_box);
            this.panel.Controls.Add(this.surname);
            this.panel.Controls.Add(this.name);
            this.panel.Controls.Add(this.register_button);
            this.panel.Controls.Add(this.password);
            this.panel.Controls.Add(this.login);
            this.panel.Controls.Add(this.little_panel);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(678, 454);
            this.panel.TabIndex = 1;
            // 
            // group
            // 
            this.group.Location = new System.Drawing.Point(375, 362);
            this.group.Multiline = true;
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(197, 44);
            this.group.TabIndex = 8;
            // 
            // role_box
            // 
            this.role_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.role_box.FormattingEnabled = true;
            this.role_box.Items.AddRange(new object[] {
            "Admin",
            "Student"});
            this.role_box.Location = new System.Drawing.Point(50, 346);
            this.role_box.Name = "role_box";
            this.role_box.Size = new System.Drawing.Size(137, 28);
            this.role_box.TabIndex = 7;
            this.role_box.Text = "Роль";
            // 
            // surname
            // 
            this.surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname.Location = new System.Drawing.Point(375, 274);
            this.surname.Multiline = true;
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(250, 50);
            this.surname.TabIndex = 5;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(375, 163);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(250, 50);
            this.name.TabIndex = 4;
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(246, 412);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(181, 40);
            this.register_button.TabIndex = 3;
            this.register_button.Text = "Зарегистрироваться";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.RegisterButtonClick);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(50, 274);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(250, 50);
            this.password.TabIndex = 2;
            this.password.UseSystemPasswordChar = true;
            // 
            // little_panel
            // 
            this.little_panel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.little_panel.Controls.Add(this.label1);
            this.little_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.little_panel.Location = new System.Drawing.Point(0, 0);
            this.little_panel.Name = "little_panel";
            this.little_panel.Size = new System.Drawing.Size(678, 100);
            this.little_panel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(678, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(45, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Введите логин :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(45, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Введите пароль :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(370, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Введите имя :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(370, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Введите фамилию :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(375, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Номер группы :";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 454);
            this.Controls.Add(this.panel);
            this.Name = "RegistrationForm";
            this.Text = "Регистрация";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.little_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Panel little_panel;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.ComboBox role_box;
        private System.Windows.Forms.TextBox group;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}