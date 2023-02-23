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
    public partial class AddAssignmentForm : Form
    {
        private OpenFileDialog ofd = null;

        private Dictionary<string, int> name_to_id = new Dictionary<string, int>() ;
        public AddAssignmentForm()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
        }

       async private void publish_but_Click(object sender, EventArgs e)
        {
            if (ofd is null)
            {
                MessageBox.Show("You must insert PDF!");
            }
            else
            {
                MessageBox.Show(dateTimePicker1.ToString());
                var y = await parser.addAssigment(title.Text, question.Text, dateTimePicker1.Text, name_to_id[subject_choice.Text].ToString() ,ofd.FileName);
                if (y)
                {
                    MessageBox.Show("success");
                    this.Close();
                }
            }
        }

        async public void add_info(assigments x=null)
        {


            if (x is null)
            {
                var y = await parser.getSubjects(teacher: Homes.teacher.teacher_id);

                foreach (var subject in y)
                {
                    subject_choice.Items.Add(subject.onoma);
                    name_to_id.Add(subject.onoma, subject.subject_id);

                }




            }
        }

        private void button1_Click(object sender, EventArgs e)
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
