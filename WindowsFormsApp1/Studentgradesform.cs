using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Studentgradesform : Form
    {






        public Studentgradesform()
        {
            InitializeComponent();
            InitialStyle.setStyle(this);

            class_sel.Text = "All";
            teacher_sel.Text = "All";

            gradesdatagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gradesdatagrid.DefaultCellStyle.Font = new Font("Arial", 11);
            gradesdatagrid.RowTemplate.Height = 40;
            gradesdatagrid.AlternatingRowsDefaultCellStyle = null;
            gradesdatagrid.DefaultCellStyle.BackColor = Color.LightBlue;
            gradesdatagrid.ColumnHeadersHeight = 50;
            gradesdatagrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14);
            gradesdatagrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gradesdatagrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(61, 90, 128);

            foreach (DataGridViewColumn column in gradesdatagrid.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }



        }




        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student form = new Student();
            form.ShowDialog();
            this.Close();
        }

        private void Logbutt_Click(object sender, EventArgs e)
        {
            parser.logout();

            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentsettings x = new studentsettings();
            x.ShowDialog();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            studentassigments x = new studentassigments();
            x.add_info();
            this.Hide();
            x.ShowDialog();
            this.Close();
        }

       
        
       async public Task add_info()
        {


            parser x = new parser();
            var y = await x.GetGrades();
            List<Classroom> clss = new List<Classroom>();
            List<Subjects> subjs = new List<Subjects>();
            List<Teachers> teach = new List<Teachers>();

            foreach (var grade in y)
            {
                var bryh = await x.getClassrooms(id: grade.classroom);
                var jj = await x.getSubjects(id: Int32.Parse(grade.subject_name));
                var tj = await x.getTeachers(id: Int32.Parse(grade.teacher));

                clss.Add(bryh.First());
                subjs.Add(jj.First());
                teach.Add(tj.First());

            }


            classroom_text.Text = $"{Student.classes.classname}{Student.classes.class_number}";
            username_text.Text = $"{Student.stud.first_Name} {Student.stud.last_Name}";

            int j = 0;
            class_sel.Items.Add("All");
            teacher_sel.Items.Add("All");
            foreach (Grades g in y)
            {

                gradesdatagrid.Rows.Add(subjs[j].onoma, $"{teach[j].first_name} {teach[j].last_name}", clss[j].classname + clss[j].class_number, y[j].grade);
                if (!class_sel.Items.Contains(clss[j].classname + clss[j].class_number))
                {
                    class_sel.Items.Add(clss[j].classname + clss[j].class_number);



                };


                if (!teacher_sel.Items.Contains($"{teach[j].first_name} {teach[j].last_name}"))
                {
                    teacher_sel.Items.Add($"{teach[j].first_name} {teach[j].last_name}");



                };
                j++;


            }

            gradesdatagrid.Refresh();
            class_sel.Text = "All";
            teacher_sel.Text = "All";
        }

        private void class_sel_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ComboBox cmb = sender as ComboBox;


            for (int u = 0; u < gradesdatagrid.Rows.Count; u++)
            {

                if (cmb.Text == "All" && teacher_sel.Text == "All")
                {
                    gradesdatagrid.Rows[u].Visible = true;
                }

                else if ((gradesdatagrid.Rows[u].Cells[2].Value.ToString() == cmb.Text | cmb.Text == "All") && (teacher_sel.Text == "All" | cmb.Text == "All" | teacher_sel.Text == gradesdatagrid.Rows[u].Cells[1].Value.ToString()))
                {
                    gradesdatagrid.Rows[u].Visible = true;


                }
                else
                {
                    gradesdatagrid.Rows[u].Visible = false;
                }





            }
        }

        private void teacher_sel_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBox cmb = sender as ComboBox;


            for (int u = 0; u < gradesdatagrid.Rows.Count; u++)
            {

                if (cmb.Text == "All" && class_sel.Text == "All")
                {
                    gradesdatagrid.Rows[u].Visible = true;
                }

                else if ((gradesdatagrid.Rows[u].Cells[1].Value.ToString() == cmb.Text | cmb.Text == "All") && (class_sel.Text == "All" | class_sel.Text == gradesdatagrid.Rows[u].Cells[2].Value.ToString()))
                {
                    gradesdatagrid.Rows[u].Visible = true;


                }
                else
                {
                    gradesdatagrid.Rows[u].Visible = false;
                }




            }



        }

        private void gradesdatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
