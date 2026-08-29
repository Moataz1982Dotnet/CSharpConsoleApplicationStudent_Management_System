using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    public class Grade
    {
        public string GradeName { get; set; }
        public decimal GradeValueFrom { get; set; }
        public decimal GradeValueTo { get; set; }
        public Grade(string gradename, decimal gradevaluefrom,decimal gradevalueto)
        {
            gradename = GradeName;
            gradevaluefrom = GradeValueFrom;
            gradevalueto = GradeValueTo;
        }
    }
}
