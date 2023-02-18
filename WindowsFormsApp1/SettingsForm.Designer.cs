namespace WindowsFormsApp1
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.classroom_text = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Button();
            this.role_text = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.username_text = new System.Windows.Forms.Label();
            this.Logbutt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.PictureBox();
            this.updatedbut = new System.Windows.Forms.Button();
            this.imagebutsel = new System.Windows.Forms.Button();
            this.filepath = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.classroom_text);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Home);
            this.panel1.Controls.Add(this.role_text);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.username_text);
            this.panel1.Controls.Add(this.Logbutt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 654);
            this.panel1.TabIndex = 3;
            // 
            // classroom_text
            // 
            this.classroom_text.AutoSize = true;
            this.classroom_text.Font = new System.Drawing.Font("Frank Ruehl CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.classroom_text.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.classroom_text.Location = new System.Drawing.Point(97, 192);
            this.classroom_text.Name = "classroom_text";
            this.classroom_text.Size = new System.Drawing.Size(0, 17);
            this.classroom_text.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Frank Ruehl CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Classroom :";
            // 
            // Home
            // 
            this.Home.AutoSize = true;
            this.Home.BackColor = System.Drawing.SystemColors.Highlight;
            this.Home.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Home.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Home.Location = new System.Drawing.Point(0, 233);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(159, 54);
            this.Home.TabIndex = 2;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // role_text
            // 
            this.role_text.AutoSize = true;
            this.role_text.Font = new System.Drawing.Font("Frank Ruehl CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.role_text.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.role_text.Location = new System.Drawing.Point(68, 163);
            this.role_text.Name = "role_text";
            this.role_text.Size = new System.Drawing.Size(64, 17);
            this.role_text.TabIndex = 7;
            this.role_text.Text = "Student";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Frank Ruehl CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(13, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Role :";
            // 
            // username_text
            // 
            this.username_text.AutoSize = true;
            this.username_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.username_text.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.username_text.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.username_text.Location = new System.Drawing.Point(68, 140);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(0, 12);
            this.username_text.TabIndex = 5;
            // 
            // Logbutt
            // 
            this.Logbutt.AutoSize = true;
            this.Logbutt.BackColor = System.Drawing.SystemColors.Highlight;
            this.Logbutt.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.Logbutt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logbutt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Logbutt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Logbutt.Location = new System.Drawing.Point(16, 573);
            this.Logbutt.Name = "Logbutt";
            this.Logbutt.Size = new System.Drawing.Size(107, 37);
            this.Logbutt.TabIndex = 3;
            this.Logbutt.Text = "Logout";
            this.Logbutt.UseVisualStyleBackColor = false;
            this.Logbutt.Click += new System.EventHandler(this.Logbutt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Frank Ruehl CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User :";
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.SystemColors.Highlight;
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(0, 447);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 54);
            this.button4.TabIndex = 3;
            this.button4.Text = "Assigments";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(0, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 54);
            this.button3.TabIndex = 4;
            this.button3.Text = "Settings";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(0, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 54);
            this.button2.TabIndex = 3;
            this.button2.Text = "My grades";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 109);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(161, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 100);
            this.panel2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(274, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 63);
            this.label4.TabIndex = 3;
            this.label4.Text = "Settings :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(173, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "First Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.Location = new System.Drawing.Point(509, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Last name :";
            // 
            // firstname
            // 
            this.firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.firstname.Location = new System.Drawing.Point(307, 163);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(184, 38);
            this.firstname.TabIndex = 8;
            // 
            // lastname
            // 
            this.lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lastname.Location = new System.Drawing.Point(639, 163);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(184, 38);
            this.lastname.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.Location = new System.Drawing.Point(173, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Phone :";
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.phone.Location = new System.Drawing.Point(307, 233);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(184, 38);
            this.phone.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.Location = new System.Drawing.Point(509, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Email :";
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.email.Location = new System.Drawing.Point(639, 229);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(184, 38);
            this.email.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label9.Location = new System.Drawing.Point(173, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Image  :";
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(307, 322);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(184, 184);
            this.image.TabIndex = 15;
            this.image.TabStop = false;
            // 
            // updatedbut
            // 
            this.updatedbut.AutoSize = true;
            this.updatedbut.BackColor = System.Drawing.SystemColors.Highlight;
            this.updatedbut.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.updatedbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatedbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.updatedbut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updatedbut.Location = new System.Drawing.Point(425, 556);
            this.updatedbut.Name = "updatedbut";
            this.updatedbut.Size = new System.Drawing.Size(161, 54);
            this.updatedbut.TabIndex = 16;
            this.updatedbut.Text = "Update";
            this.updatedbut.UseVisualStyleBackColor = false;
            this.updatedbut.Click += new System.EventHandler(this.updatedbut_Click);
            // 
            // imagebutsel
            // 
            this.imagebutsel.AutoSize = true;
            this.imagebutsel.BackColor = System.Drawing.SystemColors.Highlight;
            this.imagebutsel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.imagebutsel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imagebutsel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.imagebutsel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imagebutsel.Location = new System.Drawing.Point(583, 381);
            this.imagebutsel.Name = "imagebutsel";
            this.imagebutsel.Size = new System.Drawing.Size(212, 54);
            this.imagebutsel.TabIndex = 17;
            this.imagebutsel.Text = "Select New Image";
            this.imagebutsel.UseVisualStyleBackColor = false;
            this.imagebutsel.Click += new System.EventHandler(this.imagebutsel_Click);
            // 
            // filepath
            // 
            this.filepath.AutoSize = true;
            this.filepath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.filepath.Location = new System.Drawing.Point(580, 447);
            this.filepath.Name = "filepath";
            this.filepath.Size = new System.Drawing.Size(0, 16);
            this.filepath.TabIndex = 18;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 648);
            this.Controls.Add(this.filepath);
            this.Controls.Add(this.imagebutsel);
            this.Controls.Add(this.updatedbut);
            this.Controls.Add(this.image);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SettingsForm";
            this.Text = "s";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label classroom_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label role_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label username_text;
        private System.Windows.Forms.Button Logbutt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Button updatedbut;
        private System.Windows.Forms.Button imagebutsel;
        private System.Windows.Forms.Label filepath;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}