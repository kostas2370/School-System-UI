using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GradesForm : Form
    {


        private Dictionary<string, int> subjids = new Dictionary<string, int>();
        private OpenFileDialog ofd = new OpenFileDialog();
        private Label filename = new Label();
        private ComboBox subject = new ComboBox();


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

                classroom_text.Text = $"{Homes.classes.classname}{Homes.classes.class_number}";
                username_text.Text = $"{Homes.stud.first_Name} {Homes.stud.last_Name}";

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
                gradesdatagrid.Visible = false;
                class_sel.Visible = false;
                teacher_sel.Visible = false;
                class_label.Visible = false;
                teacher_label.Visible = false;

                Panel add_panel= new Panel();
                add_panel.Location= new Point(160, 99);
                add_panel.Size = new Size(343, 555);
                add_panel.BackColor = Color.FromArgb(191, 219, 255);

                Panel search_panel = new Panel();
                search_panel.Location = new Point(505, 99);
                search_panel.Size = new Size(343, 555);
                search_panel.BackColor = Color.FromArgb(191, 219, 255);

                Label add_panel_title = new Label();
                add_panel_title.Text = "Add Grade :";
                add_panel_title.AutoSize = true;
                add_panel_title.Font = new Font("Calibri", 18, FontStyle.Bold);
                add_panel_title.Location = new Point(115, 20);


                Label search_panel_title = new Label();
                search_panel_title.Text = "Search Student :";
                search_panel_title.AutoSize = true;
                search_panel_title.Font = new Font("Calibri", 18, FontStyle.Bold);
                search_panel_title.Location = new Point(100, 20);


                //ADD BUTTONS
                Button add_csv = new Button();
                add_csv.Text = "Add CSV";
                add_csv.AutoSize = true;
                add_csv.BackColor = Color.FromArgb(36, 160, 237);
                add_csv.ForeColor = Color.White;
                add_csv.FlatStyle = FlatStyle.Flat;
                add_csv.Font = new Font("Lato", 16);
                add_csv.Location = new Point(30, 450);
                add_csv.Click += new EventHandler(add_csv_Click);

                Button add_spec = new Button();
                add_spec.Text = "Edit student";
                add_spec.AutoSize = true;
                add_spec.BackColor = Color.FromArgb(36, 160, 237);
                add_spec.ForeColor = Color.White;
                add_spec.FlatStyle = FlatStyle.Flat;
                add_spec.Font = new Font("Lato", 16);
                add_spec.Location = new Point(165, 450);



                Label subject_lab = new Label();
                subject_lab.Text = "Subject :";
                subject_lab.Font = new Font("Lato", 16);
                subject_lab.Location = new Point(20, 60);
                

                
                Label file_lab = new Label();
                file_lab.Text = "Select File :";
                file_lab.Font = new Font("Lato", 16);
                file_lab.Location = new Point(20, 95);
                file_lab.Size = new Size(130, 23);

                Button add_file = new Button();
                add_file.Text = "Select CSV File";
                add_file.AutoSize = true;
                add_file.BackColor = Color.FromArgb(36, 160, 237);
                add_file.ForeColor = Color.White;
                add_file.FlatStyle = FlatStyle.Flat;
                add_file.Font = new Font("Lato", 16);
                add_file.Location = new Point(150, 90);
                add_file.Click += new EventHandler(Filebutt_Click);
                
                filename.Font = new Font("Lato", 9);
                filename.Location = new Point(140, 125);
                filename.Size = new Size(200, 15);


                var subjects = await parser.getSubjects(teacher:Homes.teacher.teacher_id);
                
                
                
                

                foreach (var subj in subjects)
                {
                    subject.Items.Add(subj.onoma);
                    subjids.Add(subj.onoma, subj.subject_id);
                }

                subject.Text = subjects.First().onoma;
                subject.Location = new Point(150, 63);

                //SEARCH BUTTONS:

                Button search_stud = new Button();
                search_stud.Text = "Search student";
                search_stud.AutoSize = true;
                search_stud.BackColor = Color.FromArgb(36, 160, 237);
                search_stud.ForeColor = Color.White;
                search_stud.FlatStyle = FlatStyle.Flat;
                search_stud.Font = new Font("Lato", 16);
                search_stud.Location = new Point(105, 450);

                




                add_panel.Controls.Add(add_panel_title);
                add_panel.Controls.Add(add_csv);
                add_panel.Controls.Add(add_spec);
                add_panel.Controls.Add(subject_lab);
                add_panel.Controls.Add(subject);
                add_panel.Controls.Add(file_lab);
                add_panel.Controls.Add(add_file);
                add_panel.Controls.Add(filename);


                search_panel.Controls.Add(search_panel_title);
                search_panel.Controls.Add(search_stud);

                base.Controls.Add(add_panel);
                base.Controls.Add(search_panel);

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


        private void Filebutt_Click(object sender, EventArgs e)
        {
            using (ofd = new OpenFileDialog() { Filter = "Excel files (*.xlsx)|*.xlsx" })
            {
                
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filename.Text = ofd.FileName;

                }
            }
        }

        async private void add_csv_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filename.Text))
            {
                var j = await parser.addGradeCsv(subjids[subject.Text].ToString(), ofd.FileName);
                MessageBox.Show(j.Content.ReadAsStringAsync().Result);

            }
        }



        private void gradesdatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
