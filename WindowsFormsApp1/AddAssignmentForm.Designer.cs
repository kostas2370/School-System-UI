namespace WindowsFormsApp1
{
    partial class AddAssignmentForm
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
            this.titlelab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.question = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.subject_choice = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.publish_but = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.filepath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titlelab
            // 
            this.titlelab.AutoSize = true;
            this.titlelab.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.titlelab.Location = new System.Drawing.Point(152, 28);
            this.titlelab.Name = "titlelab";
            this.titlelab.Size = new System.Drawing.Size(265, 33);
            this.titlelab.TabIndex = 21;
            this.titlelab.Text = "Add assignment  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(23, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 33);
            this.label1.TabIndex = 22;
            this.label1.Text = "Title:*";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(232, 91);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(223, 52);
            this.title.TabIndex = 23;
            this.title.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(23, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 33);
            this.label2.TabIndex = 24;
            this.label2.Text = "Question :*";
            // 
            // question
            // 
            this.question.Location = new System.Drawing.Point(232, 160);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(223, 97);
            this.question.TabIndex = 25;
            this.question.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(23, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 33);
            this.label3.TabIndex = 26;
            this.label3.Text = "Subject :*";
            // 
            // subject_choice
            // 
            this.subject_choice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.subject_choice.FormattingEnabled = true;
            this.subject_choice.Location = new System.Drawing.Point(232, 294);
            this.subject_choice.Name = "subject_choice";
            this.subject_choice.Size = new System.Drawing.Size(223, 32);
            this.subject_choice.TabIndex = 27;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dateTimePicker1.Location = new System.Drawing.Point(232, 356);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(223, 29);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(23, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 33);
            this.label4.TabIndex = 29;
            this.label4.Text = "Deadline :*";
            // 
            // publish_but
            // 
            this.publish_but.AutoSize = true;
            this.publish_but.BackColor = System.Drawing.SystemColors.Highlight;
            this.publish_but.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.publish_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.publish_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.publish_but.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.publish_but.Location = new System.Drawing.Point(180, 514);
            this.publish_but.Name = "publish_but";
            this.publish_but.Size = new System.Drawing.Size(150, 54);
            this.publish_but.TabIndex = 30;
            this.publish_but.Text = "Publish";
            this.publish_but.UseVisualStyleBackColor = false;
            this.publish_but.Click += new System.EventHandler(this.publish_but_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(25, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 33);
            this.label5.TabIndex = 31;
            this.label5.Text = "File :";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(232, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 41);
            this.button1.TabIndex = 32;
            this.button1.Text = "Select file";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filepath
            // 
            this.filepath.AutoSize = true;
            this.filepath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.filepath.Location = new System.Drawing.Point(232, 468);
            this.filepath.Name = "filepath";
            this.filepath.Size = new System.Drawing.Size(0, 16);
            this.filepath.TabIndex = 33;
            // 
            // AddAssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(512, 580);
            this.Controls.Add(this.filepath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.publish_but);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.subject_choice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.question);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titlelab);
            this.Name = "AddAssignmentForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox question;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox subject_choice;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button publish_but;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label filepath;
    }
}