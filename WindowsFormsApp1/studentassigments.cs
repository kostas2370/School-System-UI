﻿using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace WindowsFormsApp1
{
    public partial class studentassigments : Form
    {
        public studentassigments()
        {
            InitializeComponent();
            InitialStyle.setStyle(this);

 


        }

        private void Logbutt_Click(object sender, EventArgs e)
        {
            parser.logout();

            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }

        async private void button2_Click(object sender, EventArgs e)
        {



            Studentgradesform form = new Studentgradesform();
            await form.add_info();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentsettings x = new studentsettings();
            x.ShowDialog();
            this.Hide();
        }

        async private void Home_Click(object sender, EventArgs e)
        {

            Student form = new Student();
            await form.get_info();
            this.Hide(); 
            form.ShowDialog();
            this.Close();
        }

        private void Assigments_Click(object sender, EventArgs e)
        {

        }
        async public Task add_info()
        {

            classroom_text.Text = $"{Student.classes.classname}{Student.classes.class_number}";
            username_text.Text = $"{Student.stud.first_Name} {Student.stud.last_Name}";
            var y = await parser.getAssigments(classroom:Student.classes.id.ToString());
            foreach (var assigment in y)
            {
                Panel panel = new Panel();
                panel.BackColor = System.Drawing.Color.FromArgb(240, 130, 39);
                panel.Width = 650;
                panel.Height += 50;

                //TITLE :
                Label title = new Label();
                title.Width = 600;
                title.Font = new Font("Calibri", 18, FontStyle.Bold);
                title.Text = $"Title : {assigment.title.ToLower()}";

                //INFO :

                Label info = new Label();
                info.MaximumSize = new Size(600, 0);
                info.AutoSize = true;
                info.Font = new Font("Calibri", 11);
                info.Text = $"{assigment.question}";
                info.Location = new Point(10, 40);


                // release date :

                Label release_date = new Label();
                release_date.MaximumSize = new Size(600, 0);
                release_date.AutoSize = true;
                release_date.Font = new Font("MADE Coachella", 12);
                release_date.Text = $"Release :{assigment.created}";
                release_date.Location = new Point(10, 95);


                // deadline :

                Label deadline = new Label();
                deadline.MaximumSize = new Size(600, 0);
                deadline.AutoSize = true;
                deadline.Font = new Font("MADE Coachella", 12);
                deadline.Text = $"Deadline :{assigment.deadline}";
                deadline.Location = new Point(10, 115);
                deadline.ForeColor = Color.Green;
                DateTime dateTime = DateTime.ParseExact(assigment.deadline, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                //download button
                Button down_but = new Button();
                down_but.Text = "PDF";
                down_but.Height = 40;
                down_but.Width = 80;
                down_but.BackColor = Color.FromArgb(36, 160, 237);
                down_but.Tag = assigment.pdf_question;
                down_but.Click += new EventHandler(down_butt);
                down_but.ForeColor = Color.White;
                down_but.FlatStyle = FlatStyle.Flat;
                down_but.Font = new Font("Lato", 16);
                down_but.Location = new Point(410, 105);


                //upload button
                var sa = await parser.GetStudentAssigments(3, assigment: assigment.id.ToString());


                if (dateTime <= DateTime.Today & sa.Count == 0)
                {

                    deadline.Font = new Font(deadline.Font, FontStyle.Strikeout);
                    deadline.ForeColor = Color.Red;
                    Label dead = new Label();
                    dead.Text = $"Exceeded";
                    dead.Width = 600;
                    dead.Font = new Font("Calibri", 18, FontStyle.Italic);
                    dead.ForeColor = Color.Red;
                    dead.Location = new Point(510, 105);
                    panel.Controls.Add(dead);

                }

                else if (sa.Count == 0 )
                {
                    //upload buttom
                    Button upload_but = new Button();
                    upload_but.Text = "Upload";
                    upload_but.Height = 40;
                    upload_but.Width = 100;
                    upload_but.BackColor = Color.FromArgb(36, 160, 237);
                    upload_but.Tag = assigment.id;
                    upload_but.Click += new EventHandler(upload_butt);
                    upload_but.ForeColor = Color.White;
                    upload_but.FlatStyle = FlatStyle.Flat;
                    upload_but.Font = new Font("Lato", 16);
                    upload_but.Location = new Point(510, 105);

              


                    panel.Controls.Add(upload_but);
                }




                else
                {
                   
                    Label score=new Label();
                    score.Text = $"Score : {sa.First().score}";
                    
                    if (sa.First().score == "1")
                    {
                        score.Text = $"Score : - ";
                    }
                    else if (int.Parse( sa.First().score)<50)
                    {
                        score.ForeColor=Color.Red;

                    }
                    else { score.ForeColor=Color.Green; }
                    score.Width = 600;
                    score.Font = new Font("Calibri", 18, FontStyle.Italic);
                    score.Location = new Point(510, 105);


                    //answer_but:
                    //answer button
                    Button answer_but = new Button();
                    answer_but.Text = "Answer";
                    answer_but.Height = 40;
                    answer_but.Width = 120;
                    answer_but.BackColor = Color.FromArgb(36, 160, 237);
                    answer_but.Tag = sa.First().file;
                    answer_but.Click += new EventHandler(down_butt);
                    answer_but.ForeColor = Color.White;
                    answer_but.FlatStyle = FlatStyle.Flat;
                    answer_but.Font = new Font("Lato", 16);
                    answer_but.Location = new Point(260, 105);



                    panel.Controls.Add(score);
                    panel.Controls.Add(answer_but);

                }


                //add panels :
                panel.Controls.Add(title);
                panel.Controls.Add(info);
                panel.Controls.Add(down_but);
                panel.Controls.Add(release_date);
                panel.Controls.Add(deadline);
                Base.Controls.Add(panel);
               
                
            }
            for (int i = Base.Controls.Count - 1; i >= 0; i--)
            {
                Control c = Base.Controls[i];
                Base.Controls.RemoveAt(i);
                Base.Controls.Add(c);
            }
        }
        private void down_butt(object sender, EventArgs e)
        {
            Button b = sender as Button;

                System.Diagnostics.Process.Start($"{parser.url}{b.Tag}");

        }

        
        
        
        async private void upload_butt(object sender, EventArgs e)
        {
            Button b = sender as Button;
            
            using (var ofd = new OpenFileDialog() {})


            {
                string filepath;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filepath = ofd.FileName;
                    var y = await parser.addStudentAssigment(Student.stud.student_id,b.Tag.ToString(),filepath);

                    if (y)
                    {
                        b.Visible = false;
                        MessageBox.Show("Success");
                    }

                }
            }


        }

        private void Base_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

