using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class studentsettings : Form
    {
        public OpenFileDialog ofd = null;
        public studentsettings()
        {
            InitializeComponent();

            classroom_text.Text = $"{Student.classes.classname}{Student.classes.class_number}";
            username_text.Text = $"{Student.stud.first_Name} {Student.stud.last_Name}";

            firstname.Text = Student.stud.first_Name;
            lastname.Text = Student.stud.last_Name;
            phone.Text = Student.stud.phone;
            email.Text = Student.stud.email;
            image.ImageLocation = parser.url + Student.stud.photo;

            InitialStyle.setStyle(this);

        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student form = new Student();
            form.ShowDialog();
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

        private void button4_Click(object sender, EventArgs e)
        {
            
            studentassigments x = new studentassigments();
            x.add_info();
            this.Hide();
            x.ShowDialog();
            this.Close();
        }


        async private void updatedbut_Click(object sender, EventArgs e)
        {

            if (firstname.Text == "")
            {
                MessageBox.Show("You need to insert first name !");
            }
            else if (lastname.Text == "")
            {
                MessageBox.Show("you need to insert lastname");

            }
            else if (email.Text == "")
            {
                MessageBox.Show("you need to insert email");

            }
            else if (phone.Text == "")
            {
                MessageBox.Show("you need to insert phone");

            }

            else if (!(parser.check_if_valid_mail(email.Text)))
            {
                MessageBox.Show("you need to insert a valid email");

            }

            else
            {


                Student.stud.first_Name = firstname.Text;
                Student.stud.last_Name = lastname.Text;
                Student.stud.email = email.Text;
                Student.stud.phone = phone.Text;
                parser j = new parser();
                Students m;
                if (!(ofd is null))
                {

                    m = await j.updateStudent(Student.stud.first_Name, Student.stud.last_Name, Student.stud.email, Student.stud.phone, Student.stud.classroom, "3", photo: ofd.FileName);



                }
                else
                {
                    m = await j.updateStudent(Student.stud.first_Name, Student.stud.last_Name, Student.stud.email, Student.stud.phone, Student.stud.classroom, "3");
                }



                if (!(m is null))
                {

                    Student.stud.photo = m.photo;
                    MessageBox.Show("Success");
                    Student form = new Student();
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Fail");

                }
            }


        }

        private void imagebutsel_Click(object sender, EventArgs e)
        {
            using (ofd = new OpenFileDialog() { Filter = "png|*.*" })
            {

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filepath.Text = ofd.FileName;

                }
            }

        }
    }
}
