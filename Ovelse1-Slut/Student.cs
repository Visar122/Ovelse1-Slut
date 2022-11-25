using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovelse1_Slut
{
    public sealed class Student : Person
    {
        public int SudentID { get; set; }


    
        public Student(int _StudentId, string _FirstName, string _LastName, DateTime _DateofBirth) : base(_StudentId, _FirstName, _LastName, _DateofBirth)
        {
            SudentID = _StudentId;

        

        }

      
        public override string ToString()  // ToString  gør at teksten kommer frem hver gang jeg kører programmet //
        {
            return +SudentID + FirstName + Mellemnavn + LastName + DateOfBirth.ToString("dd/MM/yyyy") + " Age:" + Age;



        }
        internal override void GetAllCourse(Enrollment en)
        {


            foreach (Enrollment item in en.Enrollments)
            {
                if (item.StudentInfo.FirstName == FirstName && item.StudentInfo.LastName == LastName)



                    Console.WriteLine($"\n  {item.CourseInfo.CourseName} ");

            }
        }
        internal override void GetStudentName(Enrollment N)
        {
            foreach (Enrollment item in N.Enrollments)
            {
                if (item.StudentInfo.FirstName == FirstName)

                    Console.WriteLine($"{item.StudentInfo.FirstName}");
            }
        }
        internal override List<string> GetAllCourse(List<Enrollment> en)
        {
            List<string> result = new List<string>();
            foreach (Enrollment enrollment in en)
            {



                foreach (Enrollment item in enrollment.Enrollments)
                {
                    if (item.StudentInfo.FirstName == FirstName && item.StudentInfo.LastName == LastName)



                        result.Add($"\n  {item.CourseInfo.CourseName} ");

                }

            }

            return result;

        }
    }
}
