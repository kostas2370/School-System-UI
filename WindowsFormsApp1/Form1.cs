using System;
using System.Linq;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {


            InitializeComponent();
            InitialStyle.setStyle(this);




        }

        private async void loginbut_Click(object sender, EventArgs e)
        {
            parser x = new parser();
            string user = username.Text;
            string pass = password.Text;


            if (user == "")
            {

                MessageBox.Show("You need to insert Username !");


            }
            else if (pass == "")
            {
                MessageBox.Show("You need to insert Password !");

            }
            else
            {

                var s = await x.getToken(user, pass);

                if (s == "down")
                {
                    MessageBox.Show("server is down , try again later !");
                    this.Close();
                }

                else if (s == null)
                {
                    MessageBox.Show("Wrong login info , try again !");
                }
                else
                {


                    
                    int role = await parser.getrole();

                    if (role == 1)
                    {

                        MessageBox.Show("School Manager logined");
                        SchoolManager roles = new SchoolManager();
                        roles.ShowDialog();

                    }
                    else if (role == 2)
                    {
                        MessageBox.Show("Teacher logined");
                        Teacher roles = new Teacher();
                        roles.ShowDialog();

                    }
                    else if (role == 3)
                    {
                        MessageBox.Show("Student Logined");

                        var j = await parser.getStudents();
                        var cls = await parser.getClassrooms(id: j.First().classroom);



                        Student roles = new Student();
                        await roles.get_info();
                        this.Hide();
                        roles.ShowDialog();







                    }
                    else
                    {
                        MessageBox.Show("No role logined !");
                        norole roles = new norole();
                        roles.ShowDialog();
                    }



                    this.Close();


                }
            }



        }

        private void registerbutt_Click(object sender, EventArgs e)
        {


            register regist = new register();
            this.Hide();
            regist.ShowDialog();
            this.Close();




        }
    }


}


