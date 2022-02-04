using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    internal class Manager : Employee
    {
        public string Type; 
        public int Salary = 0;

        public override int getBonus(int Salary)
        {
            return this.Salary = Salary + Salary * 15 / 100;
        }
    }
}
