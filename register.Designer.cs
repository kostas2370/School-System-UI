﻿namespace WindowsFormsApp1
{
    partial class register
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loginbut = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.password_ver = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(469, 271);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(182, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(171, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(171, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(171, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Verify Password :";
            // 
            // loginbut
            // 
            this.loginbut.AccessibleName = "loginbut";
            this.loginbut.BackColor = System.Drawing.SystemColors.Highlight;
            this.loginbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.loginbut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginbut.Location = new System.Drawing.Point(176, 271);
            this.loginbut.Name = "loginbut";
            this.loginbut.Size = new System.Drawing.Size(182, 69);
            this.loginbut.TabIndex = 7;
            this.loginbut.Text = "Login";
            this.loginbut.UseVisualStyleBackColor = false;
            this.loginbut.Click += new System.EventHandler(this.loginbut_Click);
            // 
            // password
            // 
            this.password.AccessibleName = "password";
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.password.Location = new System.Drawing.Point(409, 129);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(242, 29);
            this.password.TabIndex = 8;
            this.password.UseSystemPasswordChar = true;
            // 
            // password_ver
            // 
            this.password_ver.AccessibleName = "password_ver";
            this.password_ver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.password_ver.Location = new System.Drawing.Point(409, 193);
            this.password_ver.Name = "password_ver";
            this.password_ver.Size = new System.Drawing.Size(242, 29);
            this.password_ver.TabIndex = 9;
            this.password_ver.UseSystemPasswordChar = true;
            // 
            // username
            // 
            this.username.AccessibleName = "username";
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.username.Location = new System.Drawing.Point(409, 66);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(242, 29);
            this.username.TabIndex = 10;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.username);
            this.Controls.Add(this.password_ver);
            this.Controls.Add(this.password);
            this.Controls.Add(this.loginbut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "register";
            this.Text = "register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loginbut;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox password_ver;
        private System.Windows.Forms.TextBox username;
    }
}