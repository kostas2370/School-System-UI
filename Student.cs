using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
         
            studentsettings x = new studentsettings();

            x.ShowDialog();
            this.Hide();
        }
    }
}
