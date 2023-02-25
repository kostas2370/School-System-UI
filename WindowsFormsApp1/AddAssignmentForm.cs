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
        private assigments assigments = null;
        private bool y;
        private Dictionary<string, int> name_to_id = new Dictionary<string, int>() ;
        public AddAssignmentForm()
        {
            InitializeComponent();
    
        }

       async private void publish_but_Click(object sender, EventArgs e)
        {
            if (publish_but.Text == "Update")
            {
                

                if (!(ofd is null))
                {

                    y = await parser.addAssigment(title.Text, question.Text, dateTimePicker1.Text, name_to_id[subject_choice.Text].ToString(), file: ofd.FileName, id: assigments.id.ToString());


                }
                else
                {
                    y = await parser.addAssigment(title.Text, question.Text, dateTimePicker1.Text, name_to_id[subject_choice.Text].ToString(), id: assigments.id.ToString());
                }

             
            }

            else
            {

                if (ofd is null)
                {
                    MessageBox.Show("You must insert PDF!");
                }
                else
                {
                     y = await parser.addAssigment(title.Text, question.Text, dateTimePicker1.Text, name_to_id[subject_choice.Text].ToString(), file: ofd.FileName);
                 
                }

            }
            if (y)
            {
                MessageBox.Show("Success");
                this.Close();

            }
            else
            {
                MessageBox.Show("Fail");
            }

        }

        async public void add_info(assigments x=null)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";

            var y = await parser.getSubjects(teacher: Homes.teacher.teacher_id);

                foreach (var subject in y)
                {
                    subject_choice.Items.Add(subject.onoma);
                    name_to_id.Add(subject.onoma, subject.subject_id);

                }




            
            if(!(x is null))
            {
                title.Text=x.title;
                question.Text=x.question;
                dateTimePicker1.Text = x.deadline;
                filepath.Text = x.pdf_question;
                subject_choice.Text = x.Subject.onoma;
                publish_but.Text = "Update";
                titlelab.Text = "Update :";
                assigments = x;
                
            
            
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
