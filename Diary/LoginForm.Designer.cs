namespace Diary
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.register_button = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.little_panel = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.tool_tip = new System.Windows.Forms.ToolTip(this.components);
            this.panel.SuspendLayout();
            this.little_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.PowderBlue;
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.password);
            this.panel.Controls.Add(this.login);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.register_button);
            this.panel.Controls.Add(this.login_button);
            this.panel.Controls.Add(this.little_panel);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(618, 444);
            this.panel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(182, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введите пароль :";
            // 
            // password
            // 
            this.password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(187, 239);
            this.password.MaxLength = 11;
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(250, 50);
            this.password.TabIndex = 2;
            this.tool_tip.SetToolTip(this.password, "Поле для пароля");
            // 
            // login
            // 
            this.login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(187, 128);
            this.login.Multiline = true;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(250, 50);
            this.login.TabIndex = 1;
            this.tool_tip.SetToolTip(this.login, "Поле для логина");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(182, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите логин :";
            // 
            // register_button
            // 
            this.register_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.register_button.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.register_button.Location = new System.Drawing.Point(3, 390);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(206, 51);
            this.register_button.TabIndex = 4;
            this.register_button.Text = "Зарегистрироваться ?";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.RegisterButtonClick);
            // 
            // login_button
            // 
            this.login_button.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_button.Location = new System.Drawing.Point(264, 329);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(90, 30);
            this.login_button.TabIndex = 3;
            this.login_button.Text = "Войти";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.LoginButtonClick);
            // 
            // little_panel
            // 
            this.little_panel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.little_panel.Controls.Add(this.label);
            this.little_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.little_panel.Location = new System.Drawing.Point(0, 0);
            this.little_panel.Name = "little_panel";
            this.little_panel.Size = new System.Drawing.Size(618, 63);
            this.little_panel.TabIndex = 0;
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.SteelBlue;
            this.label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(0, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(618, 63);
            this.label.TabIndex = 0;
            this.label.Text = "Авторизация";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tool_tip
            // 
            this.tool_tip.AutoPopDelay = 5000;
            this.tool_tip.InitialDelay = 1000;
            this.tool_tip.ReshowDelay = 500;
            this.tool_tip.ShowAlways = true;
            tool_tip.SetToolTip(this.register_button, "Нажмите, если ещё не зарегистрированы");
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 444);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Вход";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.little_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel little_panel;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ToolTip tool_tip;
    }
}