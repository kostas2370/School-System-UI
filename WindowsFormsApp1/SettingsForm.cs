using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SettingsForm : Form
    {
        public OpenFileDialog ofd = null;
        public SettingsForm()
        {
            InitializeComponent();


            if (parser.role == 3)
            {
                classroom_text.Text = $"{Homes.classes.classname}{Homes.classes.class_number}";
                username_text.Text = $"{Homes.stud.first_Name} {Homes.stud.last_Name}";
                firstname.Text = Homes.stud.first_Name;
                lastname.Text = Homes.stud.last_Name;
                phone.Text = Homes.stud.phone;
                email.Text = Homes.stud.email;
                image.ImageLocation = parser.url + Homes.stud.photo;
            }
            else
            {
                username_text.Text = $"{Homes.teacher.first_name} {Homes.teacher.last_name}";
                firstname.Text = Homes.teacher.first_name;
                lastname.Text = Homes.teacher.last_name;
                phone.Text = Homes.teacher.phone;
                email.Text = Homes.teacher.email;
                image.Visible = false;
                imagebutsel.Visible = false;
                label9.Visible = false;

            }
            InitialStyle.setStyle(this);

        }

        async private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homes form = new Homes();
            form.get_info();
            form.ShowDialog();
            this.Close();
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
            await form.add_info();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        async private void button4_Click(object sender, EventArgs e)
        {
            
            AssigmnmetsForm x = new AssigmnmetsForm();
           await x.add_info();
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


                WindowsFormsApp1.Homes.stud.first_Name = firstname.Text;
                WindowsFormsApp1.Homes.stud.last_Name = lastname.Text;
                WindowsFormsApp1.Homes.stud.email = email.Text;
                WindowsFormsApp1.Homes.stud.phone = phone.Text;
                
                Students m;
                if (!(ofd is null))
                {

                    m = await parser.updateStudent(WindowsFormsApp1.Homes.stud.first_Name, WindowsFormsApp1.Homes.stud.last_Name, WindowsFormsApp1.Homes.stud.email, WindowsFormsApp1.Homes.stud.phone, WindowsFormsApp1.Homes.stud.classroom, "3", photo: ofd.FileName);



                }
                else
                {
                    m = await parser.updateStudent(WindowsFormsApp1.Homes.stud.first_Name, WindowsFormsApp1.Homes.stud.last_Name, WindowsFormsApp1.Homes.stud.email, WindowsFormsApp1.Homes.stud.phone, WindowsFormsApp1.Homes.stud.classroom, "3");
                }



                if (!(m is null))
                {

                    WindowsFormsApp1.Homes.stud.photo = m.photo;
                    MessageBox.Show("Success");
                    SettingsForm form = new SettingsForm();
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
