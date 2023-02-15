using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Add_announcement_form : Form
    {

        public OpenFileDialog ofd = null;

        public Add_announcement_form()
        {
            InitializeComponent();
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

      async  private void publish_but_Click(object sender, EventArgs e)
        {



            if (title.Text == "")
            {
                MessageBox.Show("You need to add a title !");
            }else if (content.Text == ""){
                MessageBox.Show("You need to add content");
            }
            else {



                bool y;

                if (!(ofd is null))
                {
                     y = await parser.postAnnouncement(title.Text, content.Text, ofd.FileName);

                }
                else
                {
                     y = await parser.postAnnouncement(title.Text, content.Text);


                }


                if (y)
                    {

                        MessageBox.Show("Success");


                    }
              else
                    {
                        MessageBox.Show("Fail");
                    }
                }
            }
        }
    }

