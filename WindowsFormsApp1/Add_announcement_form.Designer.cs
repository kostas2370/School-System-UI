namespace WindowsFormsApp1
{
    partial class Add_announcement_form
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
            this.title = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.RichTextBox();
            this.imagebutsel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.titlelab = new System.Windows.Forms.Label();
            this.publish_but = new System.Windows.Forms.Button();
            this.filepath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(27, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:*";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(179, 85);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(223, 52);
            this.title.TabIndex = 1;
            this.title.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(27, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Content:*";
            // 
            // content
            // 
            this.content.Location = new System.Drawing.Point(179, 173);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(223, 155);
            this.content.TabIndex = 3;
            this.content.Text = "";
            // 
            // imagebutsel
            // 
            this.imagebutsel.AutoSize = true;
            this.imagebutsel.BackColor = System.Drawing.SystemColors.Highlight;
            this.imagebutsel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.imagebutsel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imagebutsel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.imagebutsel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imagebutsel.Location = new System.Drawing.Point(179, 358);
            this.imagebutsel.Name = "imagebutsel";
            this.imagebutsel.Size = new System.Drawing.Size(223, 54);
            this.imagebutsel.TabIndex = 18;
            this.imagebutsel.Text = "Select Image";
            this.imagebutsel.UseVisualStyleBackColor = false;
            this.imagebutsel.Click += new System.EventHandler(this.imagebutsel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(27, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 33);
            this.label3.TabIndex = 19;
            this.label3.Text = "Image :";
            // 
            // titlelab
            // 
            this.titlelab.AutoSize = true;
            this.titlelab.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.titlelab.Location = new System.Drawing.Point(127, 19);
            this.titlelab.Name = "titlelab";
            this.titlelab.Size = new System.Drawing.Size(300, 33);
            this.titlelab.TabIndex = 20;
            this.titlelab.Text = "Add announcement :";
            // 
            // publish_but
            // 
            this.publish_but.AutoSize = true;
            this.publish_but.BackColor = System.Drawing.SystemColors.Highlight;
            this.publish_but.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.publish_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.publish_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.publish_but.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.publish_but.Location = new System.Drawing.Point(211, 515);
            this.publish_but.Name = "publish_but";
            this.publish_but.Size = new System.Drawing.Size(150, 54);
            this.publish_but.TabIndex = 21;
            this.publish_but.Text = "Publish";
            this.publish_but.UseVisualStyleBackColor = false;
            this.publish_but.Click += new System.EventHandler(this.publish_but_Click);
            // 
            // filepath
            // 
            this.filepath.AutoSize = true;
            this.filepath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.filepath.Location = new System.Drawing.Point(271, 415);
            this.filepath.Name = "filepath";
            this.filepath.Size = new System.Drawing.Size(0, 18);
            this.filepath.TabIndex = 22;
            // 
            // Add_announcement_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(507, 581);
            this.Controls.Add(this.filepath);
            this.Controls.Add(this.publish_but);
            this.Controls.Add(this.titlelab);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.imagebutsel);
            this.Controls.Add(this.content);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label1);
            this.Name = "Add_announcement_form";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox content;
        private System.Windows.Forms.Button imagebutsel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label titlelab;
        private System.Windows.Forms.Button publish_but;
        private System.Windows.Forms.Label filepath;
    }
}