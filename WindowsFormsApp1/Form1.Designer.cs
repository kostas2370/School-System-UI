namespace WindowsFormsApp1
{
    partial class Form1
    {
   
        private System.ComponentModel.IContainer components = null;

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
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.loginbut = new System.Windows.Forms.Button();
            this.registerbutt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(184, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(184, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password  :";
            // 
            // username
            // 
            this.username.AccessibleName = "username";
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.username.Location = new System.Drawing.Point(402, 115);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(226, 32);
            this.username.TabIndex = 2;
            // 
            // password
            // 
            this.password.AccessibleName = "password";
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.password.Location = new System.Drawing.Point(402, 183);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(226, 32);
            this.password.TabIndex = 3;
            this.password.UseSystemPasswordChar = true;
            // 
            // loginbut
            // 
            this.loginbut.BackColor = System.Drawing.SystemColors.Highlight;
            this.loginbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.loginbut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginbut.Location = new System.Drawing.Point(189, 268);
            this.loginbut.Name = "loginbut";
            this.loginbut.Size = new System.Drawing.Size(174, 69);
            this.loginbut.TabIndex = 4;
            this.loginbut.Text = "Login";
            this.loginbut.UseVisualStyleBackColor = false;
            this.loginbut.Click += new System.EventHandler(this.loginbut_Click);
            // 
            // registerbutt
            // 
            this.registerbutt.BackColor = System.Drawing.SystemColors.Highlight;
            this.registerbutt.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.registerbutt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerbutt.Location = new System.Drawing.Point(466, 268);
            this.registerbutt.Name = "registerbutt";
            this.registerbutt.Size = new System.Drawing.Size(162, 69);
            this.registerbutt.TabIndex = 5;
            this.registerbutt.Text = "Register";
            this.registerbutt.UseVisualStyleBackColor = false;
            this.registerbutt.Click += new System.EventHandler(this.registerbutt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registerbutt);
            this.Controls.Add(this.loginbut);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button loginbut;
        private System.Windows.Forms.Button registerbutt;
    }
}

