namespace WindowsFormsApp1
{
    partial class AddGradeAssignment
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
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.answers_grid = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.assignmentid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answer_down = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.download = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.answers_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(50, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title :";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.title.Location = new System.Drawing.Point(152, 27);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(0, 31);
            this.title.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(50, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student assignments :";
            // 
            // answers_grid
            // 
            this.answers_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.answers_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assignmentid,
            this.answer_down,
            this.studentname,
            this.studentid,
            this.download,
            this.Score,
            this.grade});
            this.answers_grid.Location = new System.Drawing.Point(121, 145);
            this.answers_grid.Name = "answers_grid";
            this.answers_grid.Size = new System.Drawing.Size(544, 293);
            this.answers_grid.TabIndex = 3;
            this.answers_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.answers_grid_CellContentClick);
            // 
            // assignmentid
            // 
            this.assignmentid.HeaderText = "assignmentid";
            this.assignmentid.Name = "assignmentid";
            this.assignmentid.Visible = false;
            // 
            // answer_down
            // 
            this.answer_down.HeaderText = "answer_down";
            this.answer_down.Name = "answer_down";
            this.answer_down.Visible = false;
            // 
            // studentname
            // 
            this.studentname.HeaderText = "Student name";
            this.studentname.Name = "studentname";
            // 
            // studentid
            // 
            this.studentid.HeaderText = "Student ID";
            this.studentid.Name = "studentid";
            // 
            // download
            // 
            this.download.HeaderText = "Answer";
            this.download.Name = "download";
            this.download.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.download.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Score
            // 
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            // 
            // grade
            // 
            this.grade.HeaderText = "Add Grade";
            this.grade.Name = "grade";
            this.grade.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.grade.Text = "Add Grade";
            this.grade.UseColumnTextForButtonValue = true;
            // 
            // AddGradeAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(716, 450);
            this.Controls.Add(this.answers_grid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label1);
            this.Name = "AddGradeAssignment";
            this.Text = "AddGradeAssignment";
            ((System.ComponentModel.ISupportInitialize)(this.answers_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView answers_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignmentid;
        private System.Windows.Forms.DataGridViewTextBoxColumn answer_down;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentname;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentid;
        private System.Windows.Forms.DataGridViewButtonColumn download;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewButtonColumn grade;
    }
}