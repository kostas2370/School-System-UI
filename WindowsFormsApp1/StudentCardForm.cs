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
    public partial class StudentCardForm : Form
    {

        private Students student;
        public StudentCardForm(Students student)
        {
            InitializeComponent();
            this.student = student;
        }

       async private void StudentCardForm_Load(object sender, EventArgs e)
        {
            var stud_grades =await parser.getGrades(stud:student.student_id);

            studentPic.ImageLocation = parser.url + student.photo;
            firstlab.Text = student.first_Name;
            lastlab.Text = student.last_Name;
            emaillab.Text= student.email;
            phonelab.Text = student.phone;
            classlab.Text = student.classroom.classname + student.classroom.class_number;
            absencelab.Text = student.apouseies;
            idlab.Text = student.student_id;


            foreach(var grade in stud_grades)
            {
                gradedataview.Rows.Add(grade.subject_name.onoma, grade.classroom.classname, grade.grade);
            }
            gradedataview.ReadOnly = true;
            gradedataview.AllowUserToAddRows = false;
            gradedataview.AllowUserToDeleteRows = false;

        }
    }
}
