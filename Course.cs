using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    // --- ENCAPSULATION: Course Class ---
    public class Course
    {
        public string Course_ID { get; set; }
        public string CourseName { get; set; }
        public int CreditHours { get; set; }

        public Course(string courseid, string coursename, int credithours)
        {
            Course_ID = courseid;
            CourseName = coursename;
            CreditHours = credithours;
        }
    }
}
