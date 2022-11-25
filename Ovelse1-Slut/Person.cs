using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovelse1_Slut
{
    public abstract class Person
    {
        public string FirstName;
        public string Mellemnavn;
        public string LastName;

        public DateTime DateOfBirth { get; set; }

        public int Age { get; set; }
        public Person(int _StudentId, string _FirstName, string _LastName, DateTime _DateofBirth)
        {

            FirstName = _FirstName;
            LastName = _LastName;
            DateOfBirth = _DateofBirth;
            Age = (int)(DateTime.Now - DateOfBirth).TotalDays / 365;


        }
        public void GetAge()
        {
            Console.WriteLine(Age);
        }
        internal abstract void GetAllCourse(Enrollment en);

        internal virtual void GetStudentName(Enrollment N)
        {


        }

        internal abstract List<string> GetAllCourse(List<Enrollment> en);


    }

}




