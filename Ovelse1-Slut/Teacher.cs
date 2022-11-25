using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovelse1_Slut
{
    public sealed class Teacher : Person  // Her Låser jeg Teacher og  base  længere ned , således at man ikke kan instantiere den det betyder at klassen er låst så  andre klasser ikke kan arve fra klassen
    {

        public int Department;


        public Teacher(int _Department, string _FirstName, string _LastName, DateTime _DateofBirth) : base(_Department, _FirstName, _LastName, _DateofBirth)    // Her bruger jeg Arv metoden //
        {                                                                                                                                                 // Jeg bruger også  base klasse constructor til at vider sende data fra Person  vider til base klassen Techer.
            Department = _Department;



        }
        public override string ToString()  // ToString  gør at teksten kommer frem hver gang jeg kører programmet //
        {
            return Department + " Lærer " + FirstName + LastName + DateOfBirth.ToString("dd/MM/yyyy") + " Age:" + Age;
        }

        public void GetDep()
        {
            Console.WriteLine(Department);
        }
        internal override void GetAllCourse(Enrollment en)
        {

            foreach (Enrollment item in en.Enrollments)
            {
                if (item.CourseInfo.Teacherinfo.FirstName == FirstName && item.CourseInfo.Teacherinfo.LastName == LastName)



                    Console.WriteLine($"\n{item.CourseInfo.CourseName}   ");

            }
        }
        internal override List<string> GetAllCourse(List<Enrollment> en)
        {
            List<string> result = new List<string>();
            foreach (Enrollment enrollment in en)
            {



                foreach (Enrollment item in enrollment.Enrollments)
                {
                    if (item.CourseInfo.Teacherinfo.FirstName == FirstName && item.CourseInfo.Teacherinfo.LastName == LastName)



                        result.Add($"\n  {item.CourseInfo.CourseName} ");

                }

            }
            return result;
        }
    }
}
