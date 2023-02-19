using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GradesForm : Form
    {






        public GradesForm()
        {
            InitializeComponent();
            InitialStyle.setStyle(this);

            class_sel.Text = "All";
            teacher_sel.Text = "All";

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




        async private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homes form = new Homes();
            form.get_info();
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

        async private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingsForm x = new SettingsForm();
            x.add_info();
            x.ShowDialog();
            this.Hide();
        }

        async private void button4_Click(object sender, EventArgs e)
        {
            
            AssigmnmetsForm x = new AssigmnmetsForm();
            x.add_info();
            this.Hide();
            x.ShowDialog();
            this.Close();
        }



        async public Task add_info()
        {
            role_text.Text = parser.roles[parser.role];


            if (parser.role == 3)
            {

                classroom_text.Text = $"{WindowsFormsApp1.Homes.classes.classname}{WindowsFormsApp1.Homes.classes.class_number}";
                username_text.Text = $"{WindowsFormsApp1.Homes.stud.first_Name} {WindowsFormsApp1.Homes.stud.last_Name}";

                var y = await parser.getGrades();
       
                class_sel.Items.Add("All");
                teacher_sel.Items.Add("All");
                foreach (Grades g in y)
                {

                    gradesdatagrid.Rows.Add(g.subject_name.onoma, $"{g.teacher.first_name} {g.teacher.last_name}", g.classroom.classname + g.classroom.class_number, g.grade);
                    if (!class_sel.Items.Contains(g.classroom.classname +g.classroom.class_number))
                    {
                        class_sel.Items.Add(g.classroom.classname + g.classroom.class_number);



                    };


                    if (!teacher_sel.Items.Contains($"{g.teacher.first_name} {g.teacher.last_name}"))
                    {
                        teacher_sel.Items.Add($"{g.teacher.first_name} {g.teacher.last_name}");

                    };
                   


                }

                gradesdatagrid.Refresh();
                class_sel.Text = "All";
                teacher_sel.Text = "All";
            }
            else
            {
               
                username_text.Text = $"{Homes.teacher.first_name} {Homes.teacher.last_name}";


            }
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
