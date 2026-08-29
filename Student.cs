using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    // --- INHERITANCE & ENCAPSULATION: Student Class ---
    public class Student 
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Student(string id, string name,int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("The Student Id : {0}, The Student Age : {1} , The Student Age : {2}", Id, Name, Age);
        }
    }
}
