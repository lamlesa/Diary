namespace Diary
{
    partial class ChangeInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeInfoForm));
            this.new_field = new System.Windows.Forms.TextBox();
            this.accept_button = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // new_field
            // 
            this.new_field.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.new_field.Location = new System.Drawing.Point(19, 92);
            this.new_field.Multiline = true;
            this.new_field.Name = "new_field";
            this.new_field.Size = new System.Drawing.Size(240, 60);
            this.new_field.TabIndex = 0;
            // 
            // accept_button
            // 
            this.accept_button.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accept_button.Location = new System.Drawing.Point(79, 174);
            this.accept_button.Name = "accept_button";
            this.accept_button.Size = new System.Drawing.Size(120, 40);
            this.accept_button.TabIndex = 1;
            this.accept_button.Text = "Изменить";
            this.accept_button.UseVisualStyleBackColor = true;
            this.accept_button.Click += new System.EventHandler(this.AcceptButtonClick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(6, 37);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(267, 21);
            this.label.TabIndex = 2;
            this.label.Text = "Введите изменённые данные :";
            // 
            // ChangeInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Controls.Add(this.label);
            this.Controls.Add(this.accept_button);
            this.Controls.Add(this.new_field);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeInfoForm";
            this.Text = "Изменения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox new_field;
        private System.Windows.Forms.Button accept_button;
        private System.Windows.Forms.Label label;
    }
}