namespace WindowsFormsApp1
{
    partial class StudentRegisterForm
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
            this.firstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.classrooms = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Filebutt = new System.Windows.Forms.Button();
            this.Registerbutt = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.filename = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(243, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Register Form ";
            // 
            // firstname
            // 
            this.firstname.AccessibleName = "firstname";
            this.firstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.firstname.Location = new System.Drawing.Point(172, 120);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(198, 32);
            this.firstname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "First Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.label3.Location = new System.Drawing.Point(416, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name :";
            // 
            // lastname
            // 
            this.lastname.AccessibleName = "lastname";
            this.lastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lastname.Location = new System.Drawing.Point(584, 119);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(195, 32);
            this.lastname.TabIndex = 6;
            // 
            // phone
            // 
            this.phone.AccessibleName = "phone";
            this.phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.phone.Location = new System.Drawing.Point(172, 181);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(201, 32);
            this.phone.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.label5.Location = new System.Drawing.Point(416, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email :";
            // 
            // email
            // 
            this.email.AccessibleName = "email";
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.email.Location = new System.Drawing.Point(581, 181);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(198, 32);
            this.email.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.label6.Location = new System.Drawing.Point(12, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 30);
            this.label6.TabIndex = 11;
            this.label6.Text = "Classroom :";
            // 
            // classrooms
            // 
            this.classrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.classrooms.FormattingEnabled = true;
            this.classrooms.Location = new System.Drawing.Point(172, 236);
            this.classrooms.Name = "classrooms";
            this.classrooms.Size = new System.Drawing.Size(201, 34);
            this.classrooms.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.label7.Location = new System.Drawing.Point(416, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 30);
            this.label7.TabIndex = 13;
            this.label7.Text = "Photo :";
            // 
            // Filebutt
            // 
            this.Filebutt.BackColor = System.Drawing.SystemColors.Highlight;
            this.Filebutt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.Filebutt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Filebutt.Location = new System.Drawing.Point(581, 240);
            this.Filebutt.Name = "Filebutt";
            this.Filebutt.Size = new System.Drawing.Size(198, 43);
            this.Filebutt.TabIndex = 14;
            this.Filebutt.Text = "Find File";
            this.Filebutt.UseVisualStyleBackColor = false;
            this.Filebutt.Click += new System.EventHandler(this.Filebutt_Click);
            // 
            // Registerbutt
            // 
            this.Registerbutt.BackColor = System.Drawing.SystemColors.Highlight;
            this.Registerbutt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.Registerbutt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Registerbutt.Location = new System.Drawing.Point(466, 331);
            this.Registerbutt.Name = "Registerbutt";
            this.Registerbutt.Size = new System.Drawing.Size(259, 71);
            this.Registerbutt.TabIndex = 15;
            this.Registerbutt.Text = "Register";
            this.Registerbutt.UseVisualStyleBackColor = false;
            this.Registerbutt.Click += new System.EventHandler(this.Registerbutt_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.BackButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackButton.Location = new System.Drawing.Point(95, 331);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(259, 71);
            this.BackButton.TabIndex = 16;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // filename
            // 
            this.filename.AutoSize = true;
            this.filename.Location = new System.Drawing.Point(581, 290);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(0, 13);
            this.filename.TabIndex = 17;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // StudentRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.Registerbutt);
            this.Controls.Add(this.Filebutt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.classrooms);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.label1);
            this.Name = "StudentRegisterForm";
            this.Text = "StudentRegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox classrooms;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Filebutt;
        private System.Windows.Forms.Button Registerbutt;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label filename;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}