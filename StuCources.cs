using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    public class StuCources
    {
        // Properties linking to the other two classes
        public Student Stud { get; set; }
        public Course Cour { get; set; }
        public Grade Grad { get; set; }
        // Constructor injection
        public StuCources(Student stud, Course cour, Grade grad)
        {
            stud = Stud;
            cour = Cour;
            grad = Grad;
        }

        public void DisplayAllStudentsinCourse()
        {
            Console.WriteLine($"The Course Id : {Cour.Course_ID} | The Course Name : {Cour.CourseName} | The Course credit hours : {Cour.CreditHours} ");
        }
    }
}
