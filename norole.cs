using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class norole : Form
    {
        public norole()
        {
            InitializeComponent();
            InitialStyle.setStyle(this);
        }



        async private void StudentButton_Click(object sender, EventArgs e)
        {
            parser x = new parser();


            StudentRegisterForm frm = new StudentRegisterForm(await x.getClassrooms());
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void TeacherButton_Click(object sender, EventArgs e)
        {
            TeacherRegisterForm frm = new TeacherRegisterForm();
            this.Hide();
            frm.ShowDialog();
            this.Close();

        }
    }
}
