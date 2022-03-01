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

namespace CSV_FILE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List <Employee> employees = new List<Employee>();
        private void Form1_Load(object sender, EventArgs e)
        {
            using (var reader = new StreamReader(@"E:\CLASSWORKS\SWE OOP LAB\CSV FILE\employees.csv"))
            {
                
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');  
                    
                    Employee emp = new Employee();
                    emp.EMPLOYEE_ID = values[0];
                    emp.FIRST_NAME = values[1];
                    emp.LAST_NAME = values[2];
                    emp.EMAIL = values[3];
                    emp.PHONE_NUMBER = values[4];
                    emp.HIRE_DATE = values[5];
                    emp.JOB_ID = values[6];
                    emp.SALARY = values[7];
                    emp.COMMISSION_PCT = values[8];
                    emp.MANAGER_ID = values[9];
                    emp.DEPARTMENT_ID = values[10];

                    employees.Add(emp);
                    List_box.Items.Add(emp.EMPLOYEE_ID + "\t" + emp.FIRST_NAME + " " + emp.LAST_NAME);
                }
            }
        }

        string path = @"E:\CLASSWORKS\SWE OOP LAB\CSV FILE\Search_Results.txt";
        private void Search_Button_Click(object sender, EventArgs e)
        {
            bool f = false;
            foreach(Employee emp in employees)
            {
                if(emp.EMPLOYEE_ID == Search_Box.Text)
                {
                    Name_Box.Text = emp.FIRST_NAME + " " + emp.LAST_NAME;
                    Id_Box.Text = emp.JOB_ID;
                    Hiring_Date_Box.Text = emp.HIRE_DATE;
                    Salary_Box.Text = emp.SALARY;
                    f = true;
                    using (StreamWriter sr = File.AppendText(path))
                    {
                        string s = emp.EMPLOYEE_ID + "\t" + emp.FIRST_NAME + "\t" + emp.LAST_NAME + "\t" + emp.SALARY;
                        sr.WriteLine(s);


                    }
                    break;
                }
            }

            if(f == false)
            {
                using (StreamWriter sr = File.AppendText(path))
                {
                    string s = "Not Found";
                    sr.WriteLine(s);

                }
                MessageBox.Show("Employee Not found");
            }
        }
    }
}
