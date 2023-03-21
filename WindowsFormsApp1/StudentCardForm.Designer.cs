namespace WindowsFormsApp1
{
    partial class StudentCardForm
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
            this.studentPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.idlab = new System.Windows.Forms.Label();
            this.firstlab = new System.Windows.Forms.Label();
            this.lastlab = new System.Windows.Forms.Label();
            this.classlab = new System.Windows.Forms.Label();
            this.phonelab = new System.Windows.Forms.Label();
            this.emaillab = new System.Windows.Forms.Label();
            this.absencelab = new System.Windows.Forms.Label();
            this.gradedataview = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classroom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.studentPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradedataview)).BeginInit();
            this.SuspendLayout();
            // 
            // studentPic
            // 
            this.studentPic.Location = new System.Drawing.Point(40, 34);
            this.studentPic.Name = "studentPic";
            this.studentPic.Size = new System.Drawing.Size(188, 154);
            this.studentPic.TabIndex = 0;
            this.studentPic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(38, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(37, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(39, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(38, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Classroom :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(39, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phone :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.Location = new System.Drawing.Point(39, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.Location = new System.Drawing.Point(39, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Absence :";
            // 
            // idlab
            // 
            this.idlab.AutoSize = true;
            this.idlab.Location = new System.Drawing.Point(168, 214);
            this.idlab.Name = "idlab";
            this.idlab.Size = new System.Drawing.Size(35, 13);
            this.idlab.TabIndex = 8;
            this.idlab.Text = "label8";
            // 
            // firstlab
            // 
            this.firstlab.AutoSize = true;
            this.firstlab.Location = new System.Drawing.Point(168, 245);
            this.firstlab.Name = "firstlab";
            this.firstlab.Size = new System.Drawing.Size(35, 13);
            this.firstlab.TabIndex = 9;
            this.firstlab.Text = "label9";
            // 
            // lastlab
            // 
            this.lastlab.AutoSize = true;
            this.lastlab.Location = new System.Drawing.Point(168, 271);
            this.lastlab.Name = "lastlab";
            this.lastlab.Size = new System.Drawing.Size(41, 13);
            this.lastlab.TabIndex = 10;
            this.lastlab.Text = "label10";
            // 
            // classlab
            // 
            this.classlab.AutoSize = true;
            this.classlab.Location = new System.Drawing.Point(168, 298);
            this.classlab.Name = "classlab";
            this.classlab.Size = new System.Drawing.Size(41, 13);
            this.classlab.TabIndex = 11;
            this.classlab.Text = "label11";
            // 
            // phonelab
            // 
            this.phonelab.AutoSize = true;
            this.phonelab.Location = new System.Drawing.Point(168, 325);
            this.phonelab.Name = "phonelab";
            this.phonelab.Size = new System.Drawing.Size(41, 13);
            this.phonelab.TabIndex = 12;
            this.phonelab.Text = "label12";
            // 
            // emaillab
            // 
            this.emaillab.AutoSize = true;
            this.emaillab.Location = new System.Drawing.Point(124, 354);
            this.emaillab.Name = "emaillab";
            this.emaillab.Size = new System.Drawing.Size(41, 13);
            this.emaillab.TabIndex = 13;
            this.emaillab.Text = "label13";
            // 
            // absencelab
            // 
            this.absencelab.AutoSize = true;
            this.absencelab.Location = new System.Drawing.Point(168, 384);
            this.absencelab.Name = "absencelab";
            this.absencelab.Size = new System.Drawing.Size(41, 13);
            this.absencelab.TabIndex = 14;
            this.absencelab.Text = "label14";
            // 
            // gradedataview
            // 
            this.gradedataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradedataview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subject,
            this.classroom,
            this.grade});
            this.gradedataview.Location = new System.Drawing.Point(245, 125);
            this.gradedataview.Name = "gradedataview";
            this.gradedataview.ReadOnly = true;
            this.gradedataview.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gradedataview.Size = new System.Drawing.Size(343, 272);
            this.gradedataview.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.Location = new System.Drawing.Point(357, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 31);
            this.label8.TabIndex = 16;
            this.label8.Text = "Grades :";
            // 
            // subject
            // 
            this.subject.HeaderText = "Subject Name";
            this.subject.Name = "subject";
            this.subject.ReadOnly = true;
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
            // StudentCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(600, 474);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gradedataview);
            this.Controls.Add(this.absencelab);
            this.Controls.Add(this.emaillab);
            this.Controls.Add(this.phonelab);
            this.Controls.Add(this.classlab);
            this.Controls.Add(this.lastlab);
            this.Controls.Add(this.firstlab);
            this.Controls.Add(this.idlab);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentPic);
            this.Name = "StudentCardForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StudentCardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradedataview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox studentPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label idlab;
        private System.Windows.Forms.Label firstlab;
        private System.Windows.Forms.Label lastlab;
        private System.Windows.Forms.Label classlab;
        private System.Windows.Forms.Label phonelab;
        private System.Windows.Forms.Label emaillab;
        private System.Windows.Forms.Label absencelab;
        private System.Windows.Forms.DataGridView gradedataview;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn classroom;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
        private System.Windows.Forms.Label label8;
    }
}