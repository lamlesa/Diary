namespace Diary
{
    partial class CheckAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckAdminForm));
            this.password = new System.Windows.Forms.TextBox();
            this.check_button = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(14, 87);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(300, 50);
            this.password.TabIndex = 0;
            // 
            // check_button
            // 
            this.check_button.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check_button.Location = new System.Drawing.Point(114, 167);
            this.check_button.Name = "check_button";
            this.check_button.Size = new System.Drawing.Size(100, 35);
            this.check_button.TabIndex = 1;
            this.check_button.Text = "Проверка";
            this.check_button.UseVisualStyleBackColor = true;
            this.check_button.Click += new System.EventHandler(this.CheckButtonClick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(18, 32);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(292, 21);
            this.label.TabIndex = 2;
            this.label.Text = "Введите пароль администратора :";
            // 
            // CheckAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 224);
            this.Controls.Add(this.label);
            this.Controls.Add(this.check_button);
            this.Controls.Add(this.password);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckAdminForm";
            this.Text = "Проверка пароля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button check_button;
        private System.Windows.Forms.Label label;
    }
}