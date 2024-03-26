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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.login = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.group_box = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.surname_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.pass_label = new System.Windows.Forms.Label();
            this.login_label = new System.Windows.Forms.Label();
            this.role_box = new System.Windows.Forms.ComboBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.register_button = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(83, 142);
            this.login.Multiline = true;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(250, 50);
            this.login.TabIndex = 1;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.PowderBlue;
            this.panel.Controls.Add(this.group_box);
            this.panel.Controls.Add(this.label);
            this.panel.Controls.Add(this.surname_label);
            this.panel.Controls.Add(this.name_label);
            this.panel.Controls.Add(this.pass_label);
            this.panel.Controls.Add(this.login_label);
            this.panel.Controls.Add(this.role_box);
            this.panel.Controls.Add(this.surname);
            this.panel.Controls.Add(this.name);
            this.panel.Controls.Add(this.register_button);
            this.panel.Controls.Add(this.password);
            this.panel.Controls.Add(this.login);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(723, 539);
            this.panel.TabIndex = 1;
            // 
            // group_box
            // 
            this.group_box.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.group_box.FormattingEnabled = true;
            this.group_box.Items.AddRange(new object[] {
            "09-321",
            "09-322"});
            this.group_box.Location = new System.Drawing.Point(395, 385);
            this.group_box.Name = "group_box";
            this.group_box.Size = new System.Drawing.Size(250, 32);
            this.group_box.TabIndex = 15;
            this.group_box.Text = "Номер группы";
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.SteelBlue;
            this.label.Dock = System.Windows.Forms.DockStyle.Top;
            this.label.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(0, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(723, 63);
            this.label.TabIndex = 14;
            this.label.Text = "Регистрация";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // surname_label
            // 
            this.surname_label.AutoSize = true;
            this.surname_label.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname_label.Location = new System.Drawing.Point(390, 228);
            this.surname_label.Name = "surname_label";
            this.surname_label.Size = new System.Drawing.Size(120, 27);
            this.surname_label.TabIndex = 12;
            this.surname_label.Text = "Фамилия :";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_label.Location = new System.Drawing.Point(390, 101);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(70, 27);
            this.name_label.TabIndex = 11;
            this.name_label.Text = "Имя :";
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_label.Location = new System.Drawing.Point(78, 228);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(102, 27);
            this.pass_label.TabIndex = 10;
            this.pass_label.Text = "Пароль :";
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_label.Location = new System.Drawing.Point(78, 101);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(89, 27);
            this.login_label.TabIndex = 9;
            this.login_label.Text = "Логин :";
            // 
            // role_box
            // 
            this.role_box.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.role_box.FormattingEnabled = true;
            this.role_box.Items.AddRange(new object[] {
            "Admin",
            "Student"});
            this.role_box.Location = new System.Drawing.Point(83, 385);
            this.role_box.Name = "role_box";
            this.role_box.Size = new System.Drawing.Size(250, 32);
            this.role_box.TabIndex = 7;
            this.role_box.Text = "Роль";
            // 
            // surname
            // 
            this.surname.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname.Location = new System.Drawing.Point(395, 270);
            this.surname.Multiline = true;
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(250, 50);
            this.surname.TabIndex = 5;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(395, 142);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(250, 50);
            this.name.TabIndex = 4;
            // 
            // register_button
            // 
            this.register_button.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.register_button.Location = new System.Drawing.Point(256, 464);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(210, 60);
            this.register_button.TabIndex = 3;
            this.register_button.Text = "Зарегистрироваться";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.RegisterButtonClick);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(83, 270);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(250, 50);
            this.password.TabIndex = 2;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 539);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrationForm";
            this.Text = "Регистрация";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.ComboBox role_box;
        private System.Windows.Forms.Label surname_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label pass_label;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox group_box;
    }
}