using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Lab_final_Result_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Student
        {
            public string Name, ID, Grade;
            public int Attendance, Quiz1, Quiz2, Quiz3, Quiz4, MID, Final, Viva;
            public double Percent, Total;
        }
        List<Student> students = new List<Student>();
        private void Form1_Load(object sender, EventArgs e)
        {

            using (var reader = new StreamReader(@"E:\CLASSWORKS\SWE OOP LAB\Lab final Result system\SWE4201MarkSheet.csv"))
            {
                /**/int x = 0;
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    Student dummy = new Student();
                    dummy.ID = values[0];
                    dummy.Name = values[1];
                    string s = values[2];
                    dummy.Attendance = Convert.ToInt32(s);
                    dummy.Quiz1 = Convert.ToInt32(values[3]);
                    dummy.Quiz2 = Convert.ToInt32(values[4]);
                    dummy.Quiz3 = Convert.ToInt32(values[5]);
                    dummy.Quiz4 = Convert.ToInt32(values[6]);
                    dummy.MID = Convert.ToInt32(values[7]);
                    dummy.Final = Convert.ToInt32(values[8]);
                    dummy.Viva = Convert.ToInt32(values[9]);
                    //dummy.DEPARTMENT_ID = values[10];
                        double total = dummy.Attendance + dummy.MID + dummy.Final + dummy.Viva;
                        int[] quizes = { dummy.Quiz1, dummy.Quiz2, dummy.Quiz3, dummy.Quiz4 };
                        Array.Sort(quizes);
                        double quiz_total = quizes[3] + quizes[2] + quizes[1];
                        total = total + quiz_total;
                    dummy.Total = total;
                        double Percentage = total / 3;
                    dummy.Percent = Percentage;
                        PERCENTAGE_BOX.Items.Add(Convert.ToString(Percentage));
                        string Grade;
                        if(Percentage >= 80)
                        {
                            Grade = "A+";
                        }
                        else if(Percentage >= 75)
                        {
                            Grade = "A";
                        }
                        else if (Percentage >= 70)
                        {
                            Grade = "A-";
                        }
                        else if (Percentage >= 65)
                        {
                            Grade = "B+";
                        }
                        else if (Percentage >= 60)
                        {
                            Grade = "B";
                        }
                        else if (Percentage >= 55)
                        {
                            Grade = "B-";
                        }
                        else if (Percentage >= 50)
                        {
                            Grade = "C+";
                        }
                        else if (Percentage >= 45)
                        {
                            Grade = "C";
                        }
                        else if (Percentage >= 4075)
                        {
                            Grade = "D";
                        }
                        else
                        {
                            Grade = "F";
                        }
                        dummy.Grade = Grade;
                    students.Add(dummy);

                    }
                    foreach(var ss in students)
                    {
                        ID_BOX.Items.Add(ss.ID);
                        NAME_BOX.Items.Add(ss.Name);
                        double total = ss.Attendance + ss.MID + ss.Final + ss.Viva;
                        int[] quizes = { ss.Quiz1, ss.Quiz2, ss.Quiz3, ss.Quiz4 };
                        Array.Sort(quizes);
                        double quiz_total = quizes[3] + quizes[2] + quizes[1];
                        total = total + quiz_total;
                        double Percentage = total / 3;
                        PERCENTAGE_BOX.Items.Add(Convert.ToString(Percentage));
                        string Grade;
                        if(Percentage >= 80)
                        {
                            Grade = "A+";
                        }
                        else if(Percentage >= 75)
                        {
                            Grade = "A";
                        }
                        else if (Percentage >= 70)
                        {
                            Grade = "A-";
                        }
                        else if (Percentage >= 65)
                        {
                            Grade = "B+";
                        }
                        else if (Percentage >= 60)
                        {
                            Grade = "B";
                        }
                        else if (Percentage >= 55)
                        {
                            Grade = "B-";
                        }
                        else if (Percentage >= 50)
                        {
                            Grade = "C+";
                        }
                        else if (Percentage >= 45)
                        {
                            Grade = "C";
                        }
                        else if (Percentage >= 40)
                        {
                            Grade = "D";
                        }
                        else
                        {
                            Grade = "F";
                        }
                        GRADE_BOX.Items.Add(Grade);
                }
            }
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            string Search_Id = Search_Box.Text;

            var result = from id in students
                         where id.ID == Search_Id
                         select (id.Name, id.ID, id.Attendance, id.Quiz1, id.Quiz2, id.Quiz3, id.Quiz4, id.MID, id.Final, id.Viva, id.Percent, id.Grade, id.Total);
            //MessageBox.Show(typeof(result));
            //Attendance.Text = Convert.ToString(result[0]);
            //List <string> final_result = result.ToList();
            int x = 0;
            foreach(var item in result)
            {
                //Console.WriteLine(item.namwe);
                Attendance.Text = Convert.ToString(item.Attendance);
               
                    Quiz1.Text = Convert.ToString(item.Quiz1);
               
                    Quiz2.Text = Convert.ToString(item.Quiz2);
                
                    Quiz3.Text = Convert.ToString(item.Quiz3);
             
                    Quiz4.Text = Convert.ToString(item.Quiz4);
          
                    Mid.Text = Convert.ToString(item.MID);
               
                    Final.Text = Convert.ToString(item.Final);
              
                    Viva.Text = Convert.ToString(item.Viva);
         
                    Total.Text = Convert.ToString(item.Total);
               
                    Percentage.Text = Convert.ToString(item.Percent) + "%";
             
                    Grade.Text = Convert.ToString(item.Grade);
             
            }            
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
