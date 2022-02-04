using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class Form1 : Form
    {
        class Invalid_ID : Exception
        {
            public Invalid_ID(string Message) : base(Message)
            {

            }
        }

        public Form1()
        {
            InitializeComponent();
        }
        string ID = "1";
        List<Manager> MANAGER = new List<Manager>();
        List<Salesperson> SALESPERSON = new List<Salesperson>();
        List<Typewriter> TYPEWRITER = new List<Typewriter>();
        private void Employee_Add_Button_Click(object sender, EventArgs e)
        {
            
            if(Employee_Type_Box.Text == "Manager")
            {
                Manager dummy = new Manager();

                dummy.Name = Employee_Name_Box.Text;
                dummy.Type = Employee_Type_Box.Text;
                dummy.Contact = Employee_Contact_Box.Text;
                dummy.Date_of_joining = Employee_Joining_Date_Box.Text;
                dummy.Salary = Convert.ToInt32(Employee_Salary_Box.Text);
                dummy.Leaves = Convert.ToInt32(Employee_Leaves_Box.Text);
                dummy.Id = ID;
                
                ID = ID + 1;
                MANAGER.Add(dummy);


                MessageBox.Show("Employee Added, ID = " + dummy.Id);
            }
            else if(Employee_Type_Box.Text == "Salesperson")
            {
                Salesperson dummy = new Salesperson();

                dummy.Name = Employee_Name_Box.Text;
                dummy.Type = Employee_Type_Box.Text;
                dummy.Contact = Employee_Contact_Box.Text;
                dummy.Date_of_joining = Employee_Joining_Date_Box.Text;
                dummy.Salary = Convert.ToInt32(Employee_Salary_Box.Text);
                dummy.Leaves = Convert.ToInt32(Employee_Leaves_Box.Text);
                dummy.Id = ID;

                ID = ID + 1;
                SALESPERSON.Add(dummy);


                MessageBox.Show("Employee Added, ID = " + dummy.Id);
            }
            else if(Employee_Type_Box.Text == "Typewriter")
            {
                Typewriter dummy = new Typewriter();

                dummy.Name = Employee_Name_Box.Text;
                dummy.Type = Employee_Type_Box.Text;
                dummy.Contact = Employee_Contact_Box.Text;
                dummy.Date_of_joining = Employee_Joining_Date_Box.Text;
                dummy.Salary = Convert.ToInt32(Employee_Salary_Box.Text);
                dummy.Leaves = Convert.ToInt32(Employee_Leaves_Box.Text);
                dummy.Id = ID;

                ID = ID + 1;
                TYPEWRITER.Add(dummy);

                MessageBox.Show("Employee Added, ID = " + dummy.Id);
            }
        }

        private void Info_ID_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void SEARCH_Button_Click(object sender, EventArgs e)
        {
            Info_Listbox.Items.Clear();
            if(Info_Type_Box.Text == "Manager")
            {
                bool f = false;
                foreach(Manager m in MANAGER)
                {
                    if(m.Id == Info_ID_Box.Text)
                    {
                        Info_Listbox.Items.Add(m.Name + "\t" + m.Id + "\t" + m.Type + "\t" + m.Salary);
                        Info_Bonus_Box.Text = Convert.ToString(m.getBonus(m.Salary));
                        f = true;
                        break;
                    }
                }

                try
                {
                    if (f == false)
                    {
                        throw new Invalid_ID("Employee Not Found");
                    }
                }
                catch (Invalid_ID x)
                {
                    MessageBox.Show(x.Message);
                }
            }

            else if(Info_Type_Box.Text == "Salesperson")
            {
                bool f = false;
                foreach(Salesperson s in SALESPERSON)
                {
                    if(s.Id == Info_ID_Box.Text)
                    {
                        Info_Listbox.Items.Add(s.Name + "\t" + s.Id + "\t" + s.Type + "\t" + s.Salary);

                        Info_Bonus_Box.Text = Convert.ToString(s.getBonus(s.Salary));
                        f = true;
                        break;
                    }
                }

                try
                {
                    if (f == false)
                    {
                        throw new Invalid_ID("Employee Not Found");
                    }
                }
                catch (Invalid_ID x)
                {
                    MessageBox.Show(x.Message);
                }
            }

            else if (Info_Type_Box.Text == "Typewriter")
            {
                bool f = false;
                foreach (Typewriter t in TYPEWRITER)
                {
                    if (t.Id == Info_ID_Box.Text)
                    {
                        Info_Listbox.Items.Add(t.Name + "\t" + t.Id + "\t" + t.Type + "\t" + t.Salary);

                        Info_Bonus_Box.Text = Convert.ToString(t.getBonus(t.Salary));
                        f = true;
                        break;
                    }
                }

                try
                {
                    if (f == false)
                    {
                        throw new Invalid_ID("Employee Not Found");
                    }
                }
                catch (Invalid_ID x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }

        private void EDIT_BUTTON_Click(object sender, EventArgs e)
        {
            if(Edit_Type_Box.Text == "Manager")
            {
                bool f = false;
                foreach(Manager m in MANAGER)
                {
                    if(m.Id == Edit_ID_Box.Text)
                    {
                        m.Name = Edit_Name_Box.Text;
                        m.Salary =Convert.ToInt32(Edit_Salary_Box.Text);
                        m.Date_of_joining = Edit_Date_Joining_Box.Text;
                        m.Leaves = Convert.ToInt32(Edit_Leaves_Box.Text);
                        m.Contact = Edit_Contact_Box.Text;
                        
                        f = true;
                        MessageBox.Show("Info Edited");
                        break;
                    }
                }


                try
                {
                    if (f == false)
                    {
                        throw new Invalid_ID("Employee Not Found");
                    }
                }
                catch (Invalid_ID x)
                {
                    MessageBox.Show(x.Message);
                }
            }

            else if(Edit_Type_Box.Text == "Salesperson")
            {
                bool f = false;
                foreach (Salesperson m in SALESPERSON)
                {
                    if (m.Id == Edit_ID_Box.Text)
                    {
                        m.Name = Edit_Name_Box.Text;
                        m.Salary = Convert.ToInt32(Edit_Salary_Box.Text);
                        m.Date_of_joining = Edit_Date_Joining_Box.Text;
                        m.Leaves = Convert.ToInt32(Edit_Leaves_Box.Text);
                        m.Contact = Edit_Contact_Box.Text;

                        f = true;
                        MessageBox.Show("Info Edited");
                        break;
                    }
                }


                try
                {
                    if (f == false)
                    {
                        throw new Invalid_ID("Employee Not Found");
                    }
                }
                catch (Invalid_ID x)
                {
                    MessageBox.Show(x.Message);
                }
            }

            else if(Edit_Type_Box.Text == "Typewriter")
            {
                bool f = false;
                foreach (Typewriter m in TYPEWRITER)
                {
                    if (m.Id == Edit_ID_Box.Text)
                    {
                        
                        m.Name = Edit_Name_Box.Text;
                        m.Salary = Convert.ToInt32(Edit_Salary_Box.Text);
                        m.Date_of_joining = Edit_Date_Joining_Box.Text;
                        m.Leaves = Convert.ToInt32(Edit_Leaves_Box.Text);
                        m.Contact = Edit_Contact_Box.Text;

                        f = true;
                        MessageBox.Show("Info Edited");
                        break;
                    }
                }


                try
                {
                    if (f == false)
                    {
                        throw new Invalid_ID("Employee Not Found");
                    }
                }
                catch (Invalid_ID x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }
    }
}
