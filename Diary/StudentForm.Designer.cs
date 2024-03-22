namespace Diary
{
    partial class StudentForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.info_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // info_button
            // 
            this.info_button.Location = new System.Drawing.Point(639, 401);
            this.info_button.Name = "info_button";
            this.info_button.Size = new System.Drawing.Size(135, 37);
            this.info_button.TabIndex = 0;
            this.info_button.Text = "Информация";
            this.info_button.UseVisualStyleBackColor = true;
            this.info_button.Click += new System.EventHandler(this.InfoButtonClick);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.info_button);
            this.Name = "StudentForm";
            this.Text = "Электронный дневник";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button info_button;
    }
}

