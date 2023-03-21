using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StudentRegisterForm : Form
    {
        public OpenFileDialog ofd = null;
        
        Dictionary<string, int> listb = new Dictionary<string, int>();

        public StudentRegisterForm(List<Classroom> x)
        {

            InitializeComponent();

            foreach (var classroom in x)
            {
                InitialStyle.setStyle(this);


                classrooms.Items.Add($"{classroom.classname}{classroom.class_number} ({classroom.students_in}/{classroom.maximum})");
                listb.Add($"{classroom.classname}{classroom.class_number} ({classroom.students_in}/{classroom.maximum})", classroom.id);
            }


        }


        private void Filebutt_Click(object sender, EventArgs e)
        {
            using (ofd = new OpenFileDialog() { Filter = "All files|*.*" })
            {

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filename.Text = ofd.FileName;

                }
            }
        }

        async private void Registerbutt_Click(object sender, EventArgs e)
        {
            string first_name = firstname.Text;
            string last_name = lastname.Text;
            string emails = email.Text;
            string phones = phone.Text;

            int id;
            try
            {
                id = listb[classrooms.Text];




            }

            catch (Exception x)
            {

                MessageBox.Show(x.ToString());
                id = 0;

            }
            string image = filename.Text;
            if (!(await parser.check_server()))
            {
                MessageBox.Show("Server is Down , Try again later !");
                return;

            }
             if (first_name == "")
            {
                MessageBox.Show("You need to add First Name");
                return;

            }
             if (last_name == "")
            {
                MessageBox.Show("You need to add Last Name");
                return;

            }
             if (emails == "")
            {
                MessageBox.Show("You need to add email");
                return;
            }
             if (!parser.check_if_valid_mail(emails))
            {
                MessageBox.Show("You need to insert a valid email");
                return;

            }
             if (id == 0)
            {
                MessageBox.Show("You need to insert a classroom");
                return;

            }
             if (phones == "")
            {
                MessageBox.Show("You need to insert phone");
                return;

            }


          
                bool s;
                
                if (image != "")
                {
                    s = await parser.addStudent(first_name, last_name, emails, phones, id, image);
                }
                else
                {
                    s = await parser.addStudent(first_name, last_name, emails, phones, id);

                }
                if (s is true)
                {
                    MessageBox.Show("Success");

                    Homes student = new Homes();
                    this.Hide();
                    await student.get_info();
                    student.ShowDialog();
                    
                    this.Close();
                }
                else
                {
                    MessageBox.Show("This classroom is full");

                }

            }




        

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            norole norole = new norole();
            norole.ShowDialog();
            this.Close();
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }
    }
}
