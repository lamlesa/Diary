namespace Diary
{
    partial class SubjectCardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectCardForm));
            this.note_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // note_textbox
            // 
            this.note_textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.note_textbox.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.note_textbox.Location = new System.Drawing.Point(0, 0);
            this.note_textbox.Multiline = true;
            this.note_textbox.Name = "note_textbox";
            this.note_textbox.Size = new System.Drawing.Size(538, 414);
            this.note_textbox.TabIndex = 0;
            // 
            // SubjectCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 414);
            this.Controls.Add(this.note_textbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SubjectCardForm";
            this.Text = "Заметки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox note_textbox;
    }
}