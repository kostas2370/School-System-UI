using System;
using System.Linq;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class loginform : Form
    {
        public loginform()
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
                return;


            }
            if (pass == "")
            {
                MessageBox.Show("You need to insert Password !");
                return;
            }



            var s = await x.getToken(user, pass);

            if (s == "down")
            {
                MessageBox.Show("server is down , try again later !");
                return;
            }

            if (s == null)
            {
                MessageBox.Show("Wrong login info , try again !");
                return;
            }




            parser.role = await parser.getrole();

            if (parser.role < 4)
            {
                MessageBox.Show("user Logined");
                Homes roles = new Homes();
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

        private void registerbutt_Click(object sender, EventArgs e)
        {


            register regist = new register();
            this.Hide();
            regist.ShowDialog();
            this.Close();




        }
    }


}


