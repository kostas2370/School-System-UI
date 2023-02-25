using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddGradeAssignment : Form
    {

        private assigments assignment;
        public AddGradeAssignment()
        {
            InitializeComponent();
            
        }

        private void answers_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(answers_grid.Columns[e.ColumnIndex].Name == "download")
            {
              string url=  answers_grid.Rows[e.RowIndex].Cells["answer_down"].FormattedValue.ToString();

                System.Diagnostics.Process.Start($"{url}");


            }
            else if (answers_grid.Columns[e.ColumnIndex].Name == "grade")
            {

                string id = answers_grid.Rows[e.RowIndex].Cells["assignmentid"].FormattedValue.ToString();
                string score = answers_grid.Rows[e.RowIndex].Cells["Score"].FormattedValue.ToString();


                gradeaddform form = new gradeaddform(id,score);
                form.ShowDialog();
                answers_grid.Rows[e.RowIndex].Cells["Score"].Value = form.scores;

            }


        }

        async public void add_info(string id)
        {
            var y = await parser.getAssigments(id: id);
            assignment = y.First();
            title.Text= assignment.question;
            answers_grid.AllowUserToAddRows = false;
            answers_grid.AllowUserToDeleteRows = false;
            answers_grid.ReadOnly = false;

            var student_replies =await parser.getStudentAssigments(role:2,assigment:id);

            foreach (var student in student_replies)
            {

                var student_info = await parser.getStudents(student_id: student.student.ToString());
                answers_grid.Rows.Add(student.id,$"{parser.url}{student.file}",$"{student_info.First().first_Name}  {student_info.First().last_Name}",student.student,"Download",student.score) ;


            }


        }
    }
}
