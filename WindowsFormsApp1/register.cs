using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
            InitialStyle.setStyle(this);

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            parser parserx = new parser();
            if (await parser.check_server() == false)
            {
                MessageBox.Show("Server is down ! \n Try again later !");
                this.Close();

            }
            else if (username.Text == "")
            {

                MessageBox.Show("You need to insert username");
            }
            else if (password.Text == "")
            {
                MessageBox.Show("You need to insert password");
            }
            else if (password_ver.Text == "")
            {

                MessageBox.Show("You need to insert password verification");
            }
            else if (password.Text != password_ver.Text)
            {
                MessageBox.Show("Wrong password verification");
            }
            else
            {
                var x = await parserx.registeruser(username.Text, password.Text);




                if (x == true)
                {
                    MessageBox.Show("User register succesfully");
                    loginform login = new loginform();
                    this.Hide();
                    login.ShowDialog();
                    this.Close();
                }
                else

                {
                    MessageBox.Show("This user already exists ");
                }
            }



        }

        private void loginbut_Click(object sender, EventArgs e)
        {
            loginform login = new loginform();
            this.Hide();
            login.ShowDialog();
            this.Close();

        }
    }
}

