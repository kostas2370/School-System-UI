namespace WindowsFormsApp1
{
    partial class GradesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradesForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.classroom_text = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.role_text = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.username_text = new System.Windows.Forms.Label();
            this.Logbutt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gradesdatagrid = new System.Windows.Forms.DataGridView();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classroom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.class_sel = new System.Windows.Forms.ComboBox();
            this.class_label = new System.Windows.Forms.Label();
            this.teacher_label = new System.Windows.Forms.Label();
            this.teacher_sel = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradesdatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.classroom_text);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.role_text);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.username_text);
            this.panel1.Controls.Add(this.Logbutt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Home);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 654);
            this.panel1.TabIndex = 2;
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
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
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
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
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
            // 
            // Home
            // 
            this.Home.AutoSize = true;
            this.Home.BackColor = System.Drawing.SystemColors.Highlight;
            this.Home.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Home.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Home.Location = new System.Drawing.Point(-4, 223);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(165, 54);
            this.Home.TabIndex = 2;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(274, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 63);
            this.label4.TabIndex = 3;
            this.label4.Text = "Grades :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(160, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 100);
            this.panel2.TabIndex = 4;
            // 
            // gradesdatagrid
            // 
            this.gradesdatagrid.AllowUserToAddRows = false;
            this.gradesdatagrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gradesdatagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gradesdatagrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gradesdatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gradesdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradesdatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Subject,
            this.teacher,
            this.classroom,
            this.grade});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gradesdatagrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.gradesdatagrid.EnableHeadersVisualStyles = false;
            this.gradesdatagrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.gradesdatagrid.Location = new System.Drawing.Point(160, 99);
            this.gradesdatagrid.Name = "gradesdatagrid";
            this.gradesdatagrid.ReadOnly = true;
            this.gradesdatagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gradesdatagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gradesdatagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gradesdatagrid.Size = new System.Drawing.Size(423, 555);
            this.gradesdatagrid.TabIndex = 2;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            // 
            // teacher
            // 
            this.teacher.HeaderText = "Teacher";
            this.teacher.Name = "teacher";
            this.teacher.ReadOnly = true;
            // 
            // classroom
            // 
            this.classroom.HeaderText = "Classroom";
            this.classroom.Name = "classroom";
            this.classroom.ReadOnly = true;
            // 
            // grade
            // 
            this.grade.HeaderText = "Grade";
            this.grade.Name = "grade";
            this.grade.ReadOnly = true;
            // 
            // class_sel
            // 
            this.class_sel.FormattingEnabled = true;
            this.class_sel.Location = new System.Drawing.Point(641, 244);
            this.class_sel.Name = "class_sel";
            this.class_sel.Size = new System.Drawing.Size(147, 21);
            this.class_sel.TabIndex = 5;
            this.class_sel.SelectedIndexChanged += new System.EventHandler(this.class_sel_SelectedIndexChanged_1);
            // 
            // class_label
            // 
            this.class_label.AutoSize = true;
            this.class_label.Font = new System.Drawing.Font("Miriam Libre", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_label.Location = new System.Drawing.Point(668, 192);
            this.class_label.Name = "class_label";
            this.class_label.Size = new System.Drawing.Size(87, 38);
            this.class_label.TabIndex = 6;
            this.class_label.Text = "Class";
            // 
            // teacher_label
            // 
            this.teacher_label.AutoSize = true;
            this.teacher_label.Font = new System.Drawing.Font("Miriam Libre", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher_label.Location = new System.Drawing.Point(652, 366);
            this.teacher_label.Name = "teacher_label";
            this.teacher_label.Size = new System.Drawing.Size(123, 38);
            this.teacher_label.TabIndex = 7;
            this.teacher_label.Text = "Teacher";
            // 
            // teacher_sel
            // 
            this.teacher_sel.FormattingEnabled = true;
            this.teacher_sel.Location = new System.Drawing.Point(641, 447);
            this.teacher_sel.Name = "teacher_sel";
            this.teacher_sel.Size = new System.Drawing.Size(147, 21);
            this.teacher_sel.TabIndex = 8;
            this.teacher_sel.SelectedIndexChanged += new System.EventHandler(this.teacher_sel_SelectedIndexChanged);
            // 
            // GradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 648);
            this.Controls.Add(this.teacher_sel);
            this.Controls.Add(this.teacher_label);
            this.Controls.Add(this.class_label);
            this.Controls.Add(this.class_sel);
            this.Controls.Add(this.gradesdatagrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GradesForm";
            this.Text = "Studentgradesform";
            this.Load += new System.EventHandler(this.GradesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradesdatagrid)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn classroom;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox class_sel;
        private System.Windows.Forms.Label class_label;
        internal System.Windows.Forms.DataGridView gradesdatagrid;
        private System.Windows.Forms.Label teacher_label;
        private System.Windows.Forms.ComboBox teacher_sel;
    }
}