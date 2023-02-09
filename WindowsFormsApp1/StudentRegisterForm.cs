﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StudentRegisterForm : Form
    {
        public OpenFileDialog ofd = null;
        private List<Classroom> lista;
        Dictionary<string, int> listb = new Dictionary<string, int>();

        public StudentRegisterForm(List<Classroom> x)
        {

            InitializeComponent();

            foreach (var classroom in x)
            {
                InitialStyle.setStyle(this);


                classrooms.Items.Add($"{classroom.classname}{classroom.class_number} ({classroom.students_in}/{classroom.maximum})");
                listb.Add($"{classroom.classname}{classroom.class_number} ({classroom.students_in}/{classroom.maximum})", classroom.id);
            }


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Filebutt_Click(object sender, EventArgs e)
        {
            using (ofd = new OpenFileDialog() { Filter = "All files|*.*" })
            {

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filename.Text = ofd.FileName;

                }
            }
        }

        async private void Registerbutt_Click(object sender, EventArgs e)
        {
            string first_name = firstname.Text;
            string last_name = lastname.Text;
            string emails = email.Text;
            string phones = phone.Text;

            int id;
            try
            {
                id = listb[classrooms.Text];




            }

            catch (Exception x)
            {

                MessageBox.Show(x.ToString());
                id = 0;

            }
            string image = filename.Text;
            if (!(await parser.check_server()))
            {
                MessageBox.Show("Server is Down , Try again later !");

            }
            else if (first_name == "")
            {
                MessageBox.Show("You need to add First Name");

            }
            else if (last_name == "")
            {
                MessageBox.Show("You need to add Last Name");

            }
            else if (emails == "")
            {
                MessageBox.Show("You need to add email");
            }
            else if (!parser.check_if_valid_mail(emails))
            {
                MessageBox.Show("You need to insert a valid email");

            }
            else if (id == 0)
            {
                MessageBox.Show("You need to insert a classroom");

            }
            else if (phones == "")
            {
                MessageBox.Show("You need to insert phone");

            }


            else
            {
                bool s;
                parser x = new parser();
                if (image != "")
                {
                    s = await x.addStudent(first_name, last_name, emails, phones, id, image);
                }
                else
                {
                    s = await x.addStudent(first_name, last_name, emails, phones, id);

                }
                if (s == true)
                {
                    MessageBox.Show("Success");
                    this.Hide();
                    List<Students> lista = await x.getStudents();
                    var cls = await x.getClassrooms(id: lista.First().classroom);
                    Student student = new Student(lista.First(), cls.First());

                    student.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("This classroom is full");

                }

            }




        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            norole norole = new norole();
            norole.ShowDialog();
            this.Close();
        }
    }
}