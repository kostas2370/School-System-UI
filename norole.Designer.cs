namespace WindowsFormsApp1
{
    partial class norole
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
            this.label1 = new System.Windows.Forms.Label();
            this.StudentButton = new System.Windows.Forms.Button();
            this.TeacherButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you student or teacher ?";
            // 
            // StudentButton
            // 
            this.StudentButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.StudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.StudentButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StudentButton.Location = new System.Drawing.Point(171, 205);
            this.StudentButton.Name = "StudentButton";
            this.StudentButton.Size = new System.Drawing.Size(185, 70);
            this.StudentButton.TabIndex = 1;
            this.StudentButton.Text = "Student";
            this.StudentButton.UseVisualStyleBackColor = false;
            this.StudentButton.Click += new System.EventHandler(this.StudentButton_Click);
            // 
            // TeacherButton
            // 
            this.TeacherButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.TeacherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.TeacherButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TeacherButton.Location = new System.Drawing.Point(446, 205);
            this.TeacherButton.Name = "TeacherButton";
            this.TeacherButton.Size = new System.Drawing.Size(185, 70);
            this.TeacherButton.TabIndex = 2;
            this.TeacherButton.Text = "Teacher";
            this.TeacherButton.UseVisualStyleBackColor = false;
            this.TeacherButton.Click += new System.EventHandler(this.TeacherButton_Click);
            // 
            // norole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TeacherButton);
            this.Controls.Add(this.StudentButton);
            this.Controls.Add(this.label1);
            this.Name = "norole";
            this.Text = "norole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StudentButton;
        private System.Windows.Forms.Button TeacherButton;
    }
}