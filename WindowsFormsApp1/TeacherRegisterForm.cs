using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TeacherRegisterForm : Form
    {
        public TeacherRegisterForm()
        {
            InitializeComponent();
            InitialStyle.setStyle(this);
        }

        private async void RegisterBut_Click(object sender, EventArgs e)
        {
            string first_name = firstname.Text;
            string last_name = lastname.Text;
            string phones = phone.Text;
            string emails = email.Text;


            if (first_name == "")
            {
                MessageBox.Show("First Name field is required !");

            }
            else if (last_name == "")
            {
                MessageBox.Show("Last Name field is required !");

            }
            else if (phones == "")
            {
                MessageBox.Show("Phone field is required !");

            }
            else if (emails == "")
            {
                MessageBox.Show("EmailField is required");
            }
            else if (parser.check_if_valid_mail(emails) == false)
            {
                MessageBox.Show("Invaled email");


            }
            else
            {

               
                var j = await parser.registerTeacher(first_name, last_name, emails, phones);
                if (j == true)
                {
                    MessageBox.Show("Teacher got registered");
                    loginform home = new loginform();
                    this.Hide();
                    home.ShowDialog();
                    this.Close();


                }
                else
                {

                    MessageBox.Show("Registration Failed because this email adress is used !");
                }

            }






        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
