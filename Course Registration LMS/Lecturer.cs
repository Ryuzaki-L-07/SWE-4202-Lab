using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Registration_LMS
{
    internal class Lecturer : Teacher
    {
        public List <Course> Lecturer_Courses = new List <Course> ();

        public int getCredit()
        {
            int x = 0;
            for(int i = 0; i < Lecturer_Courses.Count; i++)
            {
                char c = Lecturer_Courses[i].Course_Code[0];
                int p = c - '0';
                x += p;
            }
            return x;
        }
    }
}
