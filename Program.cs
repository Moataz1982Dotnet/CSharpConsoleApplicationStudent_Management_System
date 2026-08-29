using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Student_Management_System
{
    class Program
    {
        public static List<Student> Students = new List<Student>();
        public static List<Course> Cources = new List<Course>();
        public static List<Grade> Gradesx = new List<Grade>();
        public static List<StuCources> StuCourcesx = new List<StuCources>();
        static void AddStudent()
        {
            Console.Clear();
            Console.WriteLine("\n   ");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + "\n\n");
            Console.WriteLine("\t\t\t\t    Moataz Student Management System  ");
            Console.WriteLine("\t\t\t\t    ================================  \n\n");
            Console.WriteLine("\t\t\t\t      Students : Add Form          ");
            Console.WriteLine("\t\t\t\t          ========      \n\n\n\n");
            Console.Write("\t\tEnter the Count of Students you want to Add  :   ");
            int StuCount = 0;
            try
            {
                StuCount = int.Parse(Console.ReadLine());
            }
            catch (Exception )
            {
                Console.WriteLine("You Entered An Invalid numbers >>>> Please Enter a Number From 1 - 10 ");
                Thread.Sleep(1000);
                AddStudent();
            }
            for (int i = 0; i < StuCount; i++)
            {
                Console.Write("\t\t\tEnter the Student #{0} Name : ", i + 1);
                string StuName = Console.ReadLine();
                Console.Write("\t\t\tEnter the Student #{0} Age : ", i + 1);
                int StuAge = 0;
                try
                {
                    StuAge = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("You Entered An Invalid Age ");
                    Console.Write("\t\t\tEnter the Student #{0} Age : ", i + 1);
                    StuAge = int.Parse(Console.ReadLine());
                }
                Console.Write("\n");
                int idx = i + 1;
                Student studenta = new Student("ST" + idx, StuName, StuAge);
                Students.Add(studenta);
            }
            Console.Write("\n\t Do you want to do anything else or logout ? (say <yes> or <no>)  :  ");
            string answer1 = Console.ReadLine();
            if ((answer1 == "yes")|| (answer1 == "y"))
            {
                Console.Clear();
                StartPage();
            }
            else if ((answer1 == "no") || (answer1 == "n"))
            {
                Console.Clear();
                EndPage();
            }
            Console.ReadKey();
        }
        static void UpdateStudent()
        {
            Console.Clear();
            Console.WriteLine("\n   ");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + "\n\n");
            Console.WriteLine("\t\t\t\t    Moataz Student Management System  ");
            Console.WriteLine("\t\t\t\t    ================================  \n\n");
            Console.WriteLine("\t\t\t\t      Students : Update Form          ");
            Console.WriteLine("\t\t\t\t          ========      \n\n\n\n");
            Console.Write("\t\tEnter the Name of Student You Want To Update : ");
            string SearchName = Console.ReadLine();

            for (int i = 0; i < Students.Count; i++)
            {
                if (Students [i].Name== SearchName)
                {
                    Console.Write("\n\n\t\t\tEnter the Student #{0} Name : ", Students[i].Id);
                    string StuName = Console.ReadLine();
                    Students[i].Name = StuName;
                    
                    Console.Write("\t\t\tEnter the Student #{0} Age : ", i + 1);
                    int StuAge = 0;
                    try
                    {
                        StuAge = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("You Entered An Invalid Age ");
                        Console.Write("\t\t\tEnter the Student #{0} Age : ", i + 1);
                        StuAge = int.Parse(Console.ReadLine());
                    }
                    Students[i].Age = StuAge;
                }
            }
            Console.Write("\n\t Do you want to do anything else or logout ? (say <yes> or <no>)  :  ");
            string answer1 = Console.ReadLine();
            if ((answer1 == "yes") || (answer1 == "y"))
            {
                Console.Clear();
                StartPage();
            }
            else if ((answer1 == "no") || (answer1 == "n"))
            {
                Console.Clear();
                EndPage();
            }
            Console.ReadKey();
        }
        static void DeleteStudent()
        {
            Console.Clear();
            Console.WriteLine("\n   ");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + "\n\n");
            Console.WriteLine("\t\t\t\t    Moataz Student Management System  ");
            Console.WriteLine("\t\t\t\t    ================================  \n\n");
            Console.WriteLine("\t\t\t\t      Students : Delete Form          ");
            Console.WriteLine("\t\t\t\t          ========      \n\n\n\n");
            Console.Write("\t\tEnter the Name of Student You Want To Delete : ");
            string SearchName = Console.ReadLine();
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].Name == SearchName)
                {
                    Students.RemoveAt(i);
                }
            }
            Console.Write("\n\t Do you want to do anything else or logout ? (say <yes> or <no>)  :  ");
            string answer1 = Console.ReadLine();
            if ((answer1 == "yes") || (answer1 == "y"))
            {
                Console.Clear();
                StartPage();
            }
            else if ((answer1 == "no") || (answer1 == "n"))
            {
                Console.Clear();
                EndPage();
            }
            Console.ReadKey();
        }
        static void AddCourse()
        {
            Console.Clear();
            Console.WriteLine("\n   ");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + "\n\n");
            Console.WriteLine("\t\t\t\t    Moataz Student Management System  ");
            Console.WriteLine("\t\t\t\t    ================================  \n\n");
            Console.WriteLine("\t\t\t\t      Courses : Add Form          ");
            Console.WriteLine("\t\t\t\t          ========      \n\n\n\n");
            Console.Write("\t\tEnter the Count of Cources you want to Add  :   ");
            int CouCount = 0;
            try
            {
                CouCount = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("You Entered An Invalid numbers >>>> Please Enter a Number From 1 - 10 ");
                Thread.Sleep(1000);
                AddCourse();
            }
            for (int i = 0; i < CouCount; i++)
            {
                Console.Write("\n\n\t\t\tEnter the Course #{0} Name : ", i + 1);
                string CoName = Console.ReadLine();
                Console.Write("\n\n\t\t\tEnter the Course #{0} Credit Hours : ", i + 1);
                int CH = int.Parse(Console.ReadLine());
                int idx = i + 1;
                Course Coursea = new Course("C" +idx, CoName, CH);
                Cources.Add(Coursea);
            }
            Console.Write("\n\t Do you want to do anything else or logout ? (say <yes> or <no>)  :  ");
            string answer1 = Console.ReadLine();
            if ((answer1 == "yes") || (answer1 == "y"))
            {
                Console.Clear();
                StartPage();
            }
            else if ((answer1 == "no") || (answer1 == "n"))
            {
                Console.Clear();
                EndPage();
            }
            Console.ReadKey();
        }
        static void UpdateCourse()
        {
            Console.Clear();
            Console.WriteLine("\n   ");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + "\n\n");
            Console.WriteLine("\t\t\t\t    Moataz Student Management System  ");
            Console.WriteLine("\t\t\t\t    ================================  \n\n");
            Console.WriteLine("\t\t\t\t      Courses : Update Form          ");
            Console.WriteLine("\t\t\t\t          ========      \n\n\n\n");
            Console.Write("\t\tEnter the Name of Course You Want To Update : ");
            string SearchName = Console.ReadLine();
            
            for (int i = 0; i < Cources.Count; i++)
            {
                if (Cources[i].CourseName == SearchName)
                {
                    Console.Write("\n\n\t\t\tEnter the Course #{0} Name : ", Cources[i].CourseName);
                    string CourseName = Console.ReadLine();
                    Cources[i].CourseName = CourseName;
                    Console.Write("\n\n\t\t\tEnter the Course #{0} Credit Hours : ", Cources[i].CreditHours);
                    int CH = int.Parse(Console.ReadLine());
                    Cources[i].CreditHours = CH;
                }
            }
            Console.Write("\n\t Do you want to do anything else or logout ? (say <yes> or <no>)  :  ");
            string answer1 = Console.ReadLine();
            if ((answer1 == "yes") || (answer1 == "y"))
            {
                Console.Clear();
                StartPage();
            }
            else if ((answer1 == "no") || (answer1 == "n"))
            {
                Console.Clear();
                EndPage();
            }
            Console.ReadKey();
        }
        static void DeleteCourse()
        {
            Console.Clear();
            Console.WriteLine("\n   ");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + "\n\n");
            Console.WriteLine("\t\t\t\t    Moataz Student Management System  ");
            Console.WriteLine("\t\t\t\t    ================================  \n\n");
            Console.WriteLine("\t\t\t\t      Courses : Delete Form          ");
            Console.WriteLine("\t\t\t\t          ========      \n\n\n\n");
            Console.Write("\t\tEnter the Name of Course You Want To Delete : ");
            string SearchName = Console.ReadLine();
            for (int i = 0; i <Cources.Count; i++)
            {
                if (Cources[i].CourseName == SearchName)
                {
                    Cources.RemoveAt(i);
                }
            }
            Console.Write("\n\t Do you want to do anything else or logout ? (say <yes> or <no>)  :  ");
            string answer1 = Console.ReadLine();
            if ((answer1 == "yes") || (answer1 == "y"))
            {
                Console.Clear();
                StartPage();
            }
            else if ((answer1 == "no") || (answer1 == "n"))
            {
                Console.Clear();
                EndPage();
            }
            Console.ReadKey();
        }
        static void AddGrade()
        {
            Console.Clear();
            Console.WriteLine("\n   ");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + "\n\n");
            Console.WriteLine("\t\t\t\t    Moataz Student Management System  ");
            Console.WriteLine("\t\t\t\t    ================================  \n\n");
            Console.WriteLine("\t\t\t\t      Grade : Add Form          ");
            Console.WriteLine("\t\t\t\t          ========      \n\n\n\n");
            Console.Write("\t\tEnter the Count of Grades you want to Add  :   ");
            int GradCount = 0;
            try
            {
                GradCount = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("You Entered An Invalid numbers >>>> Please Enter a Number From 1 - 10 ");
                Thread.Sleep(1000);
                AddGrade();
            }
            for (int i = 0; i < GradCount; i++)
            {
                Console.Write("\n\n\t\t\tEnter the Grade #{0} Name : ", i + 1);
                string GradName = Console.ReadLine();
                Console.Write("\n\n\t\t\tEnter the Grade #{0} Value From : ", i + 1);
                decimal Gradevaluefrom = decimal.Parse(Console.ReadLine());
                Console.Write("\n\n\t\t\tEnter the Grade #{0} Value To : ", i + 1);
                decimal Gradevalueto = decimal.Parse(Console.ReadLine());
                Grade Gradea = new Grade(GradName, Gradevaluefrom, Gradevalueto);
                Gradesx.Add(Gradea);
            }
            Console.Write("\n\t Do you want to do anything else or logout ? (say <yes> or <no>)  :  ");
            string answer1 = Console.ReadLine();
            if ((answer1 == "yes") || (answer1 == "y"))
            {
                Console.Clear();
                StartPage();
            }
            else if ((answer1 == "no") || (answer1 == "n"))
            {
                Console.Clear();
                EndPage();
            }
            Console.ReadKey();
        }
        static void UpdateGrade()
        {
            Console.Clear();
            Console.WriteLine("\n   ");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + "\n\n");
            Console.WriteLine("\t\t\t\t    Moataz Student Management System  ");
            Console.WriteLine("\t\t\t\t    ================================  \n\n");
            Console.WriteLine("\t\t\t\t       Grade : Update Form          ");
            Console.WriteLine("\t\t\t\t          ========      \n\n\n\n");
            Console.Write("\t\tEnter the Name of Grade You Want To Update : ");
            string SearchName = Console.ReadLine();

            for (int i = 0; i <Gradesx.Count; i++)
            {
                if (Gradesx[i].GradeName == SearchName)
                {
                    Console.Write("\n\n\t\t\tEnter the Grade #{0} Name : ", Gradesx[i].GradeName);
                    string GradName = Console.ReadLine();
                    Gradesx[i].GradeName = GradName;
                    Console.Write("\n\n\t\t\tEnter the Grade #{0} Value from : ", Gradesx[i].GradeValueFrom);
                    decimal GVf = decimal.Parse(Console.ReadLine());
                    Gradesx[i].GradeValueFrom = GVf;
                    Console.Write("\n\n\t\t\tEnter the Grade #{0} Value to : ", Gradesx[i].GradeValueTo);
                    decimal GVt = decimal.Parse(Console.ReadLine());
                    Gradesx[i].GradeValueTo = GVt;
                }
            }
            Console.Write("\n\t Do you want to do anything else or logout ? (say <yes> or <no>)  :  ");
            string answer1 = Console.ReadLine();
            if ((answer1 == "yes") || (answer1 == "y"))
            {
                Console.Clear();
                StartPage();
            }
            else if ((answer1 == "no") || (answer1 == "n"))
            {
                Console.Clear();
                EndPage();
            }
            Console.ReadKey();
        }
        static void DeleteGrade()
        {
            Console.Clear();
            Console.WriteLine("\n   ");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + "\n\n");
            Console.WriteLine("\t\t\t\t    Moataz Student Management System  ");
            Console.WriteLine("\t\t\t\t    ================================  \n\n");
            Console.WriteLine("\t\t\t\t      Grade : Delete Form          ");
            Console.WriteLine("\t\t\t\t          ========      \n\n\n\n");
            Console.Write("\t\tEnter the Name of Grade You Want To Delete : ");
            string SearchName = Console.ReadLine();
            for (int i = 0; i < Gradesx.Count; i++)
            {
                if (Gradesx[i].GradeName == SearchName)
                {
                    Gradesx.RemoveAt(i);
                }
            }
            Console.Write("\n\t Do you want to do anything else or logout ? (say <yes> or <no>)  :  ");
            string answer1 = Console.ReadLine();
            if ((answer1 == "yes") || (answer1 == "y"))
            {
                Console.Clear();
                StartPage();
            }
            else if ((answer1 == "no") || (answer1 == "n"))
            {
                Console.Clear();
                EndPage();
            }
            Console.ReadKey();
        }
        static void StartPage()
        {
           
            Console.Clear();
            Console.WriteLine("\n   ");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + "\n\n");
            Console.WriteLine("\t\t\t\t    Moataz Student Management System  ");
            Console.WriteLine("\t\t\t\t    ================================  \n\n");
            Console.WriteLine("\t\t\t\t          Main Form          ");
            Console.WriteLine("\t\t\t\t          =========      \n\n\n\n");
            Console.WriteLine("Please Select the id of Operation You Want To Do: ");
            Console.WriteLine("1-Add Student ");
            Console.WriteLine("2-Update Student ");
            Console.WriteLine("3-Delete Student ");
            Console.WriteLine("4-Add Course ");
            Console.WriteLine("5-Update Course ");
            Console.WriteLine("6-Delete Course ");
            Console.WriteLine("7-Add Grade ");
            Console.WriteLine("8-Update Grade ");
            Console.WriteLine("9-Delete Grade ");
            Console.WriteLine("10-View Student Details ");
            Console.WriteLine("11-Enroll Students in Courses");
            Console.WriteLine("12-Assign or Updates grades for student in Course ");
            int OperationId = 0;
            try
            {
                Console.Write("\nThe Operation id : ");
                OperationId = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("You Entered An Invalid Choice... Please Enter Numbers from 1-13 ");
            }
            if (OperationId == 1)
            {
                AddStudent();
            }
            else if (OperationId == 2)
            {
                UpdateStudent();
            }
            else if (OperationId == 3)
            {
                DeleteStudent();
            }
            else if (OperationId == 4)
            {
                AddCourse();
            }
            else if (OperationId == 5)
            {
                UpdateCourse();
            }
            else if (OperationId == 6)
            {
                DeleteCourse();
            }
            else if (OperationId == 7)
            {
                AddGrade();
            }
            else if (OperationId == 8)
            {
               UpdateGrade  ();
            }
            else if (OperationId == 9)
            {
               DeleteGrade ();
            }
            else if (OperationId == 10)
            {
                ViewStudentsDetails();
            }
            else if (OperationId == 11)
            {
                InsertStudentInCourse();
            }
            else if (OperationId == 12)
            {
                Assignupdategradesstudentscourse();
            }
            else
            {
                Console.WriteLine("You Entered an Invalid Operation Id...");
            }
        }
        static void ViewStudentsDetails()
        {
            Console.Clear();
            Console.WriteLine("\n   ");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + "\n\n");
            Console.WriteLine("\t\t\t\t    Moataz Student Management System  ");
            Console.WriteLine("\t\t\t\t    ================================  \n\n");
            Console.WriteLine("\t\t\t\t      Students : View Students Details          ");
            Console.WriteLine("\t\t\t\t          =======================      \n\n\n\n");

            for (int i = 0; i < Students.Count; i++)
            {
                    Console.WriteLine("The Student Id : {0}, The Student Age : {1} , The Student Age : {2}", Students[i].Id, Students[i].Name, Students[i].Age);
            }

            Console.Write("\n\t Do you want to do anything else or logout ? (say <yes> or <no>)  :  ");
            string answer1 = Console.ReadLine();
            if ((answer1 == "yes") || (answer1 == "y"))
            {
                Console.Clear();
                StartPage();
            }
            else if ((answer1 == "no") || (answer1 == "n"))
            {
                Console.Clear();
                EndPage();
            }
            Console.ReadKey();
        }
        static void ViewStudentsinCourse()
        {
            Console.Clear();
            Console.WriteLine("\n   ");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + "\n\n");
            Console.WriteLine("\t\t\t\t    Moataz Student Management System  ");
            Console.WriteLine("\t\t\t\t    ================================  \n\n");
            Console.WriteLine("\t\t\t\t      Students : View all students in a course          ");
            Console.WriteLine("\t\t\t\t          =======================      \n\n\n\n");
            Console.Write("\t\tEnter the Name of Course : ");
            string CourseName = Console.ReadLine();

            for (int i = 0; i < Cources.Count; i++)
            {
                Console.WriteLine("The Student Id : {0}, The Student Age : {1} , The Student Age : {2}", Students[i].Id, Students[i].Name, Students[i].Age);
            }

            Console.Write("\n\t Do you want to do anything else or logout ? (say <yes> or <no>)  :  ");
            string answer1 = Console.ReadLine();
            if ((answer1 == "yes") || (answer1 == "y"))
            {
                Console.Clear();
                StartPage();
            }
            else if ((answer1 == "no") || (answer1 == "n"))
            {
                Console.Clear();
                EndPage();
            }
            Console.ReadKey();
        }
        static void Viewstudentcompleteacademicrecord()
        {
            Console.Clear();
            Console.WriteLine("\n   ");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + "\n\n");
            Console.WriteLine("\t\t\t\t    Moataz Student Management System  ");
            Console.WriteLine("\t\t\t\t    ================================  \n\n");
            Console.WriteLine("\t\t\t\t      Students : View a student’s complete academic record.         ");
            Console.WriteLine("\t\t\t\t          =======================      \n\n\n\n");

            for (int i = 0; i < Students.Count; i++)
            {
                Console.WriteLine("The Student Id : {0}, The Student Name : {1} , The Student Age : {2}", Students[i].Id, Students[i].Name, Students[i].Age);
            }

            Console.Write("\n\t Do you want to do anything else or logout ? (say <yes> or <no>)  :  ");
            string answer1 = Console.ReadLine();
            if ((answer1 == "yes") || (answer1 == "y"))
            {
                Console.Clear();
                StartPage();
            }
            else if ((answer1 == "no") || (answer1 == "n"))
            {
                Console.Clear();
                EndPage();
            }
            Console.ReadKey();
        }
        static void StartPage2()
        {

            Console.Clear();
            Console.WriteLine("\n   ");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + "\n\n");
            Console.WriteLine("\t\t\t\t    Moataz Student Management System  ");
            Console.WriteLine("\t\t\t\t    ================================  \n\n");
            Console.WriteLine("\t\t\t\t          Main Form          ");
            Console.WriteLine("\t\t\t\t          =========      \n\n\n\n");
            Console.WriteLine("Please Select the id of Operation You Want To Do: ");
            Console.WriteLine("1- View My Courses Grades ");
            Console.WriteLine("2- View My Enrolled Cources ");
            int OperationId = 0;
            try
            {
                Console.Write("\nThe Operation id : ");
                OperationId = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("You Entered An Invalid Choice... Please Enter Numbers from 1-2 ");
            }
            if (OperationId == 1)
            {
                ViewMyCoursesGrades();
            }
            else if (OperationId == 2)
            {
                ViewMyCourses();
            }
        }
        static void PreStartPage()
        {

            Console.Clear();
            Console.WriteLine("\n   ");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + "\n\n");
            Console.WriteLine("\t\t\t\t    Moataz Student Management System  ");
            Console.WriteLine("\t\t\t\t    ================================  \n\n");
            Console.WriteLine("\t\t\t\t          Role Form          ");
            Console.WriteLine("\t\t\t\t          =========      \n\n\n\n");
            Console.WriteLine("Please Select the User Role : ");
            Console.WriteLine("1-Admin ");
            Console.WriteLine("2-Student ");
            int OperationId = 0;
            try
            {
                Console.Write("\nThe Operation id : ");
                OperationId = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("You Entered An Invalid Choice... Please Enter Numbers from 1-2 ");
            }
            if (OperationId == 1)
            {
                StartPage();
            }
            else if (OperationId == 2)
            {
                StartPage2();
            }
        }
        static void EndPage()
        {

            Console.Clear();
            Console.WriteLine("\n   ");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + "\n\n");
            Console.WriteLine("\t\t\t\t    Moataz Student Management System  ");
            Console.WriteLine("\t\t\t\t    ================================  ");
            Console.WriteLine("\t\t\t\t    ================================  ");
            Console.WriteLine("\t\t\t\t              The End                 ");
            Console.WriteLine("\t\t\t\t    ================================  ");
            Console.WriteLine("\t\t\t\t    ================================  ");
            Console.WriteLine("\t\t\t\t    ================================  ");
            Console.WriteLine("\t\t\t\t    ================================  ");
            Console.ReadKey();
        }
        static void InsertStudentInCourse()
        {
            Console.Clear();
            Console.WriteLine("\n   ");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + "\n\n");
            Console.WriteLine("\t\t\t\t    Moataz Student Management System  ");
            Console.WriteLine("\t\t\t\t    ================================  \n\n");
            Console.WriteLine("\t\t\t\t      Students : Enroll students in courses          ");
            Console.WriteLine("\t\t\t\t          =======================      \n\n\n\n");
            Console.Write("\t\tEnter the Name of Course you want To Enrolle Student In : ");
            string CourseName = Console.ReadLine();
            Console.Write("\t\tEnter the Name of Student : ");
            string StudentName = Console.ReadLine();
            Student Stu=null;
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].Name == StudentName)
                {
                    Stu = Students[i];
                }
            }
            Course Cours =null;
            for (int i = 0; i <Cources.Count; i++)
            {
                if (Cources[i].CourseName == CourseName)
                {
                    Cours = Cources[i];
                }
            }
            Grade grad = null;
            StuCources x = new StuCources(Stu, Cours,grad);
            StuCourcesx.Add(x);


            Console.Write("\n\t Do you want to do anything else or logout ? (say <yes> or <no>)  :  ");
            string answer1 = Console.ReadLine();
            if ((answer1 == "yes") || (answer1 == "y"))
            {
                Console.Clear();
                StartPage();
            }
            else if ((answer1 == "no") || (answer1 == "n"))
            {
                Console.Clear();
                EndPage();
            }
            Console.ReadKey();
        }
        static void Assignupdategradesstudentscourse()
        {
            // 
            Console.Clear();
            Console.WriteLine("\n   ");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + "\n\n");
            Console.WriteLine("\t\t\t\t    Moataz Student Management System  ");
            Console.WriteLine("\t\t\t\t    ================================  \n\n");
            Console.WriteLine("\t\t\t\t      Students : Assign and update grades for students in specific courses          ");
            Console.WriteLine("\t\t\t\t          =======================      \n\n\n\n");
            Console.Write("\t\tEnter the Name of Course you want To Enrolle Student In : ");
            string CourseName = Console.ReadLine();
            Console.Write("\t\tEnter the Name of Student : ");
            string StudentName = Console.ReadLine();
            Console.Write("\t\tEnter the Grade : ");
            string GradeName = Console.ReadLine();
            Student Stu = null;
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].Name == StudentName)
                {
                    Stu = Students[i];
                }
            }
            Course Cours = null;
            for (int i = 0; i < Cources.Count; i++)
            {
                if (Cources[i].CourseName == CourseName)
                {
                    Cours = Cources[i];
                }
            }
            Grade gradx = null;
            for (int i = 0; i < Gradesx.Count; i++)
            {
                if (Gradesx[i].GradeName == GradeName)
                {
                    gradx = Gradesx[i];
                }
            }
            StuCources x = new StuCources(Stu, Cours,gradx);
            StuCourcesx.Add(x);


            Console.Write("\n\t Do you want to do anything else or logout ? (say <yes> or <no>)  :  ");
            string answer1 = Console.ReadLine();
            if ((answer1 == "yes") || (answer1 == "y"))
            {
                Console.Clear();
                StartPage();
            }
            else if ((answer1 == "no") || (answer1 == "n"))
            {
                Console.Clear();
                EndPage();
            }
            Console.ReadKey();
        }
        static void ViewMyCourses()
        {
            Console.Clear();
            Console.WriteLine("\n   ");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + "\n\n");
            Console.WriteLine("\t\t\t\t    Moataz Student Management System  ");
            Console.WriteLine("\t\t\t\t    ================================  \n\n");
            Console.WriteLine("\t\t\t\t      Students : View My Enrolles Courses          ");
            Console.WriteLine("\t\t\t\t          =======================      \n\n\n\n");
            Console.Write("\t\tEnter the Name of Student : ");
            string StudentName = Console.ReadLine();
            
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].Name == StudentName)
                {
                    Console.WriteLine("The Student Id : {0}, The Student Age : {1} , The Student Age : {2}", Students[i].Id, Students[i].Name, Students[i].Age);
                    Console.WriteLine("=====================================================================================");
                }
            }
            List<Course> gg = new List<Course>();
            for (int i = 0; i < StuCourcesx.Count; i++)
            {
                if (StuCourcesx[i].Stud.Name == StudentName)
                {
                    gg.Add(StuCourcesx[i].Cour);
                }
            }
            for (int i = 0; i < gg.Count; i++)
            {
                    gg.Add(StuCourcesx[i].Cour);
                    Console.WriteLine("The Course Name : {0}, The Course Credit hours : {1}",  gg[i].CourseName, gg[i].CreditHours);
            }

            Console.Write("\n\t Do you want to do anything else or logout ? (say <yes> or <no>)  :  ");
            string answer1 = Console.ReadLine();
            if ((answer1 == "yes") || (answer1 == "y"))
            {
                Console.Clear();
                StartPage2();
            }
            else if ((answer1 == "no") || (answer1 == "n"))
            {
                Console.Clear();
                EndPage();
            }
            Console.ReadKey();
        }
        static void ViewMyCoursesGrades()
        {
            Console.Clear();
            Console.WriteLine("\n   ");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + "\n\n");
            Console.WriteLine("\t\t\t\t    Moataz Student Management System  ");
            Console.WriteLine("\t\t\t\t    ================================  \n\n");
            Console.WriteLine("\t\t\t\t      Students : View My Courses Grades          ");
            Console.WriteLine("\t\t\t\t          =======================      \n\n\n\n");
            Console.Write("\t\tEnter the Name of Student : ");
            string StudentName = Console.ReadLine();

            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].Name == StudentName)
                {
                    Console.WriteLine("The Student Id : {0}, The Student Age : {1} , The Student Age : {2}", Students[i].Id, Students[i].Name, Students[i].Age);
                    Console.WriteLine("=====================================================================================");
                }
            }
            List<Course> gg = new List<Course>();
            List<Grade> gg2 = new List<Grade>();
            for (int i = 0; i < StuCourcesx.Count; i++)
            {
                if (StuCourcesx[i].Stud.Name == StudentName)
                {
                    gg.Add(StuCourcesx[i].Cour);
                    gg2.Add(StuCourcesx[i].Grad);
                }
            }
           
            for (int i = 0; i < gg.Count; i++)
            {
                    Console.WriteLine("The Course Name : {0}, The Course Credit hours : {1}, The Course Grade : {1}", gg[i].CourseName, gg[i].CreditHours,gg2[i].GradeName);
            }

            Console.Write("\n\t Do you want to do anything else or logout ? (say <yes> or <no>)  :  ");
            string answer1 = Console.ReadLine();
            if ((answer1 == "yes") || (answer1 == "y"))
            {
                Console.Clear();
                StartPage2();
            }
            else if ((answer1 == "no") || (answer1 == "n"))
            {
                Console.Clear();
                EndPage();
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            PreStartPage();
            Console.ReadKey();
        }
    }
}
