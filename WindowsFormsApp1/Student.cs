using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Student : Form
    {
        public static Students stud;
        public static Classroom classes;
        public static Teachers teacher;

  

 

        public Student()
        {
            InitializeComponent();
    
            InitialStyle.setStyle(this);

        }



        async  private void button4_Click(object sender, EventArgs e)
        {
          
            studentassigments x = new studentassigments();
            
            await x.add_info();
            this.Hide();
            x.ShowDialog();
            this.Close();
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

    



       async public  Task get_info()
        {


            if (parser.role == 3)
            {
                List<Students> lista = await parser.getStudents();
                var cls = await parser.getClassrooms(id: lista.First().classroom);
                stud = lista.First();
                classes = cls.First();
                username_text.Text = $"{stud.first_Name} {stud.last_Name}";
                classroom_text.Text = $"{classes.classname}{classes.class_number}";
                add_butt.Visible = false;
                
            }
            else if(parser.role == 2)
            {
                List<Teachers> lista = await parser.getTeachers();
                teacher=lista.First();
                button2.Text = "Grades";
                username_text.Text = $"{teacher.first_name} {teacher.last_name}";
                add_butt.Visible = true;


            }


            role_text.Text = parser.roles[parser.role];

            var y = await parser.getAnnouncements();
           foreach (var announcement in y)
            {

                //PANEL
                Panel panel = new Panel();
                panel.BackColor = System.Drawing.Color.FromArgb(128, 185, 238);
                panel.Width = 650;
                panel.Height += 100;
                //IMAGE:


                PictureBox image = new PictureBox();
                image.ImageLocation = parser.url +announcement.image_post;
                image.Width = 290;
                image.Height = 240;
                image.Location = new Point(10, 10);


                
                //TITLE :
                Label title = new Label();
                title.Width = 310;
                title.Height = 15;

                title.Font = new Font("Calibri", 12, FontStyle.Bold);
                title.Text = $"{announcement.title}";
                title.Location = new Point(300, 10);


                //release_date
                Label release_date = new Label();
                release_date.MaximumSize = new Size(600, 0);
                release_date.AutoSize = true;
                release_date.Font = new Font("MADE Coachella", 10);
                release_date.Text = $"Release :{announcement.created}";
                release_date.Location = new Point(300, 26);

                //ΤextBox
                RichTextBox leptomeries = new RichTextBox();
                leptomeries.Text = announcement.content;
                leptomeries.ReadOnly = true;
                leptomeries.Width = 310;
                leptomeries.Height = 120;
                leptomeries.Location = new Point(300,50);
                leptomeries.BackColor= System.Drawing.Color.FromArgb(128, 185, 238);
                leptomeries.BorderStyle = BorderStyle.None;
                leptomeries.Multiline= true;


                //Published_by
               

                Label publisher = new Label();
                string publ= await parser.getusername(announcement.publisher.ToString());
                publisher.Text = $"Published by :{publ}";
                publisher.Font = new Font("Calibri", 10, FontStyle.Bold);
                publisher.Location = new Point(300, 180);
                publisher.Width = 200;


                if (parser.role == 2  )
                {
                    if (teacher.user == announcement.publisher)
                    {
                        Button delete_butt = new Button();
                        delete_butt.Text = "Delete";
                        delete_butt.Height = 50;
                        delete_butt.Width = 100;
                        delete_butt.BackColor = Color.Red;
                        delete_butt.Tag = announcement.id;
                        delete_butt.ForeColor = Color.White;
                        delete_butt.FlatStyle = FlatStyle.Flat;
                        delete_butt.Font = new Font("Lato", 10);
                        delete_butt.Location = new Point(0, 0);

                        Button update_butt = new Button();
                        update_butt.Text = "Update";
                        update_butt.Height = 50;
                        update_butt.Width = 100;
                        update_butt.BackColor = Color.Green;
                        update_butt.Tag = announcement.id;
                        update_butt.ForeColor = Color.White;
                        update_butt.FlatStyle = FlatStyle.Flat;
                        update_butt.Font = new Font("Lato", 10);
                        update_butt.Location = new Point(100, 0);

                        panel.Controls.Add(delete_butt);
                        panel.Controls.Add(update_butt);
                    }
                }


                Base.Controls.Add(panel);
                panel.Controls.Add(image);
                panel.Controls.Add(title);
                panel.Controls.Add(release_date);
                panel.Controls.Add(leptomeries);
                panel.Controls.Add(publisher);






            }
            for (int i = Base.Controls.Count - 1; i >= 0; i--)
            {
                Control c = Base.Controls[i];
                Base.Controls.RemoveAt(i);
                Base.Controls.Add(c);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
         
            studentsettings x = new studentsettings();

            x.ShowDialog();
            this.Hide();
        }

        async private void add_butt_Click(object sender, EventArgs e)
        {
            Add_announcement_form form = new Add_announcement_form();
            form.ShowDialog();
            Student newform = new Student();
            
            await newform.get_info();
            this.Hide();
            newform.ShowDialog();
            this.Close();


        }
    }
}
