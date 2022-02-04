using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    internal class Employee
    {
        public string Name;
        public string Id;
        public string Contact;
        public string Date_of_joining;
        public int Leaves;

        public virtual int getBonus(int n)
        {
            return n;
        }
    }
}
