using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Registration_LMS
{
    public partial class Form1 : Form
    {
         List<Teacher> Teachers = new List<Teacher>();
         List<Student> Students = new List<Student>();
         List<Course>  Courses = new List<Course>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int f = 0;
            foreach(Course c in Courses)
            {
                if (c.Course_Code == Student_Course_Box.Text && c.Semester == Student_Semester_Box.Text)
                    f = 1;
            }

            if(f == 1)
            {
                Student dummy = new Student();
                dummy.Name = Student_Name_Box.Text;
                dummy.Semester = Student_Semester_Box.Text;
                dummy.course = Student_Course_Box.Text;

                Students.Add(dummy);
                Student_Info_Box.Items.Add(dummy.Name);
                MessageBox.Show("Student Added");
            }

            else
            {
                MessageBox.Show("Course Not Available !!!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student_List_Box.Items.Clear();

            foreach(Student s in Students)
            {
                if(s.Name == Student_Info_Box.Text)
                {

                string sp = "  ";
                Student_List_Box.Items.Add(s.Name + sp + s.Semester + sp + s.course);
                    break;
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Teacher_List_Box.Items.Clear();
            foreach (Teacher t in Teachers)
            {
                if(t.Name == Teacher_Info_Box.Text)
                {

                Teacher_List_Box.Items.Add(t.Name + "  " + t.Type + " " + t.Course
                    + " " + t.Credit);
                    break;
                }
            }
        }

        private void Teacher_Button_Click(object sender, EventArgs e)
        {
            Teacher dummy = new Teacher();
            dummy.Name = Teacher_Name_Box.Text;
            dummy.Type = Teacher_Type_Box.Text;

            Teachers.Add(dummy);
            Course_Teacher_Box.Items.Add(dummy.Name);
            Teacher_Info_Box.Items.Add(dummy.Name);
            MessageBox.Show("Teacher Added");
        }

        private void Course_Button_Click(object sender, EventArgs e)
        {
            Course dummy = new Course();
            dummy.Course_Code = Course_Code_Box.Text;
            dummy.Course_Type = Course_Type_Box.Text;
            dummy.Course_Title = Course_Title_Box.Text;
            dummy.Semester = Course_Semester_Box.Text;
            dummy.Teacher = Course_Teacher_Box.Text;
            Courses.Add(dummy);
            Student_Course_Box.Items.Add(dummy.Course_Code);
            string s, s3;
            if (dummy.Course_Code[0] == '1')
            {
                s = "Professor";
                s3 = "Theory";
            }
            else
            {
                s = "Lecturer";
                s3 = "Lab";
            }

                int f = 0;
            foreach (Teacher t in Teachers)
            {
                // name = A, Type = Professor , course == 1
                if (t.Name == Course_Teacher_Box.Text && t.Type == s)
                {
                     f = 1;
                     t.Course = dummy.Course_Title;
                    if (s == "Professor") t.Credit = 3;
                    else t.Credit = 1;
                     
                }
            }

            if (f == 0)
                MessageBox.Show("NOT AVAILABLE !!!");
            else
                MessageBox.Show("Course Added");

        }
    }
}
