namespace Diary
{
    partial class GroupCreator
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupCreator));
            this.allstudents = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.Label();
            this.creategroup_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.TextBox();
            this.tool_tip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.allstudents)).BeginInit();
            this.SuspendLayout();
            // 
            // allstudents
            // 
            this.allstudents.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allstudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.allstudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allstudents.Location = new System.Drawing.Point(12, 40);
            this.allstudents.Name = "allstudents";
            this.allstudents.RowHeadersWidth = 62;
            this.allstudents.RowTemplate.Height = 28;
            this.allstudents.Size = new System.Drawing.Size(660, 470);
            this.allstudents.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(8, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(229, 24);
            this.label.TabIndex = 1;
            this.label.Text = "Список всех студентов :";
            // 
            // creategroup_button
            // 
            this.creategroup_button.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.creategroup_button.Location = new System.Drawing.Point(710, 79);
            this.creategroup_button.Name = "creategroup_button";
            this.creategroup_button.Size = new System.Drawing.Size(85, 50);
            this.creategroup_button.TabIndex = 2;
            this.creategroup_button.Text = "Создать группу";
            this.tool_tip.SetToolTip(this.creategroup_button, "Прежде чем создать группу, выберите студентов и введите будущий номер группы");
            this.creategroup_button.UseVisualStyleBackColor = true;
            this.creategroup_button.Click += new System.EventHandler(this.CreateGroup);
            // 
            // update_button
            // 
            this.update_button.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update_button.Location = new System.Drawing.Point(688, 480);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(100, 30);
            this.update_button.TabIndex = 3;
            this.update_button.Text = "Обновить";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.Update);
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number.Location = new System.Drawing.Point(678, 40);
            this.number.Multiline = true;
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(117, 33);
            this.number.TabIndex = 4;
            this.number.Text = "Номер";
            // 
            // tool_tip
            // 
            this.tool_tip.AutomaticDelay = 100;
            this.tool_tip.AutoPopDelay = 5000;
            this.tool_tip.InitialDelay = 100;
            this.tool_tip.ReshowDelay = 20;
            // 
            // GroupCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(803, 524);
            this.Controls.Add(this.number);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.creategroup_button);
            this.Controls.Add(this.label);
            this.Controls.Add(this.allstudents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GroupCreator";
            this.Text = "Создать  группу";
            ((System.ComponentModel.ISupportInitialize)(this.allstudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView allstudents;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button creategroup_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.ToolTip tool_tip;
    }
}