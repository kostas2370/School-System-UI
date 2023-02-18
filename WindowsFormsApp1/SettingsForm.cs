using System;
using System.Linq;
using System.Threading.Tasks;
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
            await form.get_info();
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

                if (parser.role == 3)
                {
              

                    bool m;
                    if (!(ofd is null))
                    {

                        m = await parser.updateStudent(WindowsFormsApp1.Homes.stud.first_Name, WindowsFormsApp1.Homes.stud.last_Name, WindowsFormsApp1.Homes.stud.email, WindowsFormsApp1.Homes.stud.phone, WindowsFormsApp1.Homes.stud.classroom, "3", photo: ofd.FileName);
                        Homes.stud.photo = ofd.FileName;
                    }
                    else
                    {
                        m = await parser.updateStudent(WindowsFormsApp1.Homes.stud.first_Name, WindowsFormsApp1.Homes.stud.last_Name, WindowsFormsApp1.Homes.stud.email, WindowsFormsApp1.Homes.stud.phone, WindowsFormsApp1.Homes.stud.classroom, "3");
                        Homes.stud.photo= parser.url + Homes.stud.photo;
                    }


                    if (m)
                    {
                        Homes.stud.first_Name = firstname.Text;
                        Homes.stud.last_Name = lastname.Text;
                        Homes.stud.email = email.Text;
                        Homes.stud.phone = phone.Text;
                        
                        MessageBox.Show("Success");

                        image.ImageLocation = Homes.stud.photo;
                    }
                    else
                    {
                        MessageBox.Show("Fail");

                    }


                }
                else
                {
                    var y = await parser.updateTeacher(Homes.teacher.teacher_id.ToString(), firstname.Text, lastname.Text, phone.Text, email.Text);

                    if (y) {
                        Homes.teacher.first_name = firstname.Text;
                        Homes.teacher.last_name = lastname.Text;
                        Homes.teacher.email = email.Text;
                        Homes.teacher.phone = phone.Text;
                        MessageBox.Show("Success");

                    }
                    else
                    {
                        MessageBox.Show("Fail");
                    }


                }        
                
            }


        }

        async public void add_info()
        {
            if (parser.role == 2){

                
                DataGridView dataGridView = new DataGridView();
                dataGridView.Location = new System.Drawing.Point(307, 293);
                dataGridView.Size= new System.Drawing.Size(326,150);

                Label label=new Label();
                label.Text = "Subjects : ";
                label.Location=new System.Drawing.Point(173,361);
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15);
                dataGridView.ColumnCount = 3;
                dataGridView.ReadOnly = true;
                
                dataGridView.Columns[0].Name =  "Subject_Name";
                dataGridView.Columns[1].Name = "Teacher";
                dataGridView.Columns[2].Name = "Classroom";


                var y = await parser.getSubjects(teacher:Homes.teacher.teacher_id) ;


                foreach (var subject in y)
                {
                    dataGridView.Rows.Add(subject.onoma,$"{subject.teacher.first_name} {subject.teacher.last_name}",$"{subject.classroom.classname}{subject.classroom.class_number}");
                }
                
                this.Controls.Add(dataGridView);
                this.Controls.Add(label);
            
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
