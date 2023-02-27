using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class gradeaddform : Form
    {


        public string scores;
        public gradeaddform(string ids,string scor)
        {
            InitializeComponent();
            id.Text= ids;
            score.Text = scor;
            scores = scor;
        }

        private async void add_butt_Click(object sender, EventArgs e)
        {


            if (Int32.Parse(score.Text) > 100 |  Int32.Parse(score.Text) <=1 )
            {
                MessageBox.Show("The grade should be bellow 100 and more than 1");
            }
            else
            {
                var y = await parser.addGradeAssignment(id.Text, score.Text);
                if (y)
                {
                    MessageBox.Show("Success");
                    scores = score.Text;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Fail");
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
