using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AssigmnmetsForm : Form
    {
        public AssigmnmetsForm()
        {
            InitializeComponent();
            InitialStyle.setStyle(this);

 


        }

        private void Logbutt_Click(object sender, EventArgs e)
        {
            parser.logout();

            this.Hide();
            loginform form = new loginform();
            form.ShowDialog();
            this.Close();
        }

        async private void button2_Click(object sender, EventArgs e)
        {



            GradesForm form = new GradesForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        async private void button3_Click(object sender, EventArgs e)
        {
            
            SettingsForm x = new SettingsForm();
            this.Hide();
            x.ShowDialog();
            this.Hide();
        }

        async private void Home_Click(object sender, EventArgs e)
        {

            Homes form = new Homes();
            await form.get_info();
            this.Hide(); 
            form.ShowDialog();
            this.Close();
        }

   
        async public void add_info()
        {


            role_text.Text = parser.roles[parser.role];

            List<assigments> y;
            if (parser.role == 3)
            {



                classroom_text.Text = $"{Homes.classes.classname}{Homes.classes.class_number}";
                username_text.Text = $"{Homes.stud.first_Name} {Homes.stud.last_Name}";
                add_butt.Visible = false;

                y = await parser.getAssigments(classroom: Homes.classes.id.ToString());
            }
            else
            {
                username_text.Text = $"{Homes.teacher.first_name} {Homes.teacher.last_name}";

                button2.Text = "Grades";

                y = await parser.getAssigments(teacher:Homes.teacher.teacher_id.ToString());


            }

            foreach (var assigment in y)
            {
                Panel panel = new Panel();
                panel.BackColor = System.Drawing.Color.FromArgb(240, 130, 39);
                panel.Width = 650;
                panel.Height += 80;
                panel.Tag= assigment.id;

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


                //Teacher
                
                Label teacher = new Label();
                teacher.MaximumSize = new Size(600, 0);
                teacher.AutoSize = true;
                teacher.Font = new Font("MADE Coachella", 12);
                teacher.Text = $"Teacher :{assigment.Subject.teacher.first_name} {assigment.Subject.teacher.last_name}";
                teacher.Location = new Point(10, 85);


                //Subject

                Label subject = new Label();
                subject.MaximumSize = new Size(600, 0);
                subject.AutoSize = true;
                subject.Font = new Font("MADE Coachella", 12);
                subject.Text = $"Subject :{assigment.Subject.onoma}";
                subject.Location = new Point(10, 105);




                // release date :

                Label release_date = new Label();
                release_date.MaximumSize = new Size(600, 0);
                release_date.AutoSize = true;
                release_date.Font = new Font("MADE Coachella", 12);
                release_date.Text = $"Release :{assigment.created}";
                release_date.Location = new Point(10, 135);


                // deadline :

                Label deadline = new Label();
                deadline.MaximumSize = new Size(600, 0);
                deadline.AutoSize = true;
                deadline.Font = new Font("MADE Coachella", 12);
                deadline.Text = $"Deadline :{assigment.deadline}";
                deadline.Location = new Point(10, 155);
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


                List<StudentAssigments> sa=null;
                if (parser.role == 3)
                {
                   

                    sa = await parser.getStudentAssigments(3, assigment: assigment.id.ToString());

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

                    else if (sa.Count == 0)
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

                        Label score = new Label();
                        score.Text = $"Score : {sa.First().score}";

                        if (sa.First().score == "1")
                        {
                            score.Text = $"Score : - ";
                        }
                        else if (int.Parse(sa.First().score) < 50)
                        {
                            score.ForeColor = Color.Red;

                        }
                        else { score.ForeColor = Color.Green; }
                        score.Width = 600;
                        score.Font = new Font("Calibri", 18, FontStyle.Italic);
                        score.Location = new Point(510, 105);


                       
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
                }
                else
                {
                    Button check_but = new Button();
                    check_but.Text = "Check";
                    check_but.Height = 40;
                    check_but.Width = 100;
                    check_but.BackColor = Color.FromArgb(36, 160, 237);
                    check_but.Tag = assigment.id;
                    check_but.ForeColor = Color.White;
                    check_but.FlatStyle = FlatStyle.Flat;
                    check_but.Font = new Font("Lato", 16);
                    check_but.Location = new Point(510, 105);
                    check_but.Click += new EventHandler(check_butt_click);


                    Button delete_butt = new Button();
                    delete_butt.Text = "Delete";
                    delete_butt.Height = 50;
                    delete_butt.Width = 100;
                    delete_butt.BackColor = Color.Red;
                    delete_butt.Tag = assigment.id;
                    delete_butt.ForeColor = Color.White;
                    delete_butt.FlatStyle = FlatStyle.Flat;
                    delete_butt.Font = new Font("Lato", 10);
                    delete_butt.Location = new Point(440, 0);
                    delete_butt.Click += new EventHandler(delete_butt_Click);


                    Button update_butt = new Button();
                    update_butt.Text = "Edit";
                    update_butt.Height = 50;
                    update_butt.Width = 100;
                    update_butt.BackColor = Color.Green;
                    update_butt.Tag = assigment.id;
                    update_butt.ForeColor = Color.White;
                    update_butt.FlatStyle = FlatStyle.Flat;
                    update_butt.Font = new Font("Lato", 10);
                    update_butt.Location = new Point(540, 0);
                    update_butt.Click += new EventHandler(edit_butt_Click);
             

                    panel.Controls.Add(check_but);
                    panel.Controls.Add(delete_butt);
                    panel.Controls.Add(update_butt);


                }



                //add panels :
                panel.Controls.Add(title);
                panel.Controls.Add(info);
                panel.Controls.Add(down_but);
                panel.Controls.Add(release_date);
                panel.Controls.Add(deadline);
                panel.Controls.Add(teacher);
                panel.Controls.Add(subject);
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


                if (parser.role == 3)
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        filepath = ofd.FileName;
                        var y = await parser.addStudentAssigment(WindowsFormsApp1.Homes.stud.student_id, b.Tag.ToString(), filepath);

                        if (y)
                        {
                            b.Visible = false;
                            MessageBox.Show("Success");
                        }

                    }
                }
            }


        }

       async private void add_butt_Click(object sender, EventArgs e)
        {
            AddAssignmentForm x = new AddAssignmentForm();
            x.add_info();
            x.ShowDialog();
            Base.Controls.Clear();
            this.add_info();

        }
        async private void delete_butt_Click(object sender, EventArgs e)
        {
            
                Button b = sender as Button;

                var y = await parser.deleteAssignment(b.Tag.ToString());
                if (y)
                {
                    MessageBox.Show("Success !");
                }
                else
                {
                    MessageBox.Show("Fail !");
                }
                
                
                for (int i = Base.Controls.Count - 1; i >= 0; i--)
                {
                    Control c = Base.Controls[i];
                    if (c.Tag.ToString() == b.Tag.ToString())
                    {
                        Base.Controls.RemoveAt(i);

                    }
                                      
                   
                }

            

        }

        async private void edit_butt_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            var ass =await parser.getAssigments(id: b.Tag.ToString());
            
            AddAssignmentForm x = new AddAssignmentForm();

            x.add_info(ass.First());
            x.ShowDialog();
            Base.Controls.Clear();
            this.add_info();

        }

        private void check_butt_click(object sender,EventArgs e)
        {
            Button b = sender as Button;

            AddGradeAssignment form = new AddGradeAssignment();
            form.add_info(b.Tag.ToString());
            form.ShowDialog();
           
        }
    }
}

