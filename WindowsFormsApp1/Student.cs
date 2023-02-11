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

  

        public Student(Students xd, Classroom cls)
        {
            InitializeComponent();



            stud = xd;
            classes = cls;
            InitialStyle.setStyle(this);
            username_text.Text = $"{stud.first_Name} {stud.last_Name}";
            classroom_text.Text = $"{classes.classname}{classes.class_number}";
        }

        public Student()
        {
            InitializeComponent();
            InitialStyle.setStyle(this);

            username_text.Text = $"{stud.first_Name} {stud.last_Name}";
            classroom_text.Text = $"{classes.classname}{classes.class_number}";

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
            form.add_info();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Home_Click(object sender, EventArgs e)
        {

        }



       async public  Task get_info()
        {

            parser x = new parser();
            var y = await x.getAnnouncements();
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
                title.Height = 40;

                title.Font = new Font("Calibri", 12, FontStyle.Bold);
                title.Text = $"{announcement.title}";
                title.Location = new Point(300, 10);


                //text
                Label text = new Label();


                Base.Controls.Add(panel);
                panel.Controls.Add(image);
                panel.Controls.Add(title);
                panel.Controls.Add(title);

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
         
            studentsettings x = new studentsettings();

            x.ShowDialog();
            this.Hide();
        }
    }
}
