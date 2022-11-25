using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovelse1_Slut
{
    internal class Enrollment : IComparable<Enrollment>
    {
        public Student StudentInfo { get; set; }
        public Course CourseInfo { get; set; }
        public Enrollment(Student studentInfo, Course courseInfo)
        {
            StudentInfo = studentInfo;
            CourseInfo = courseInfo;

        }
        public List<Enrollment> Enrollments { get; set; }

        public Enrollment()
        {
            Enrollments=new List<Enrollment>();
        }

        public int CompareTo(Enrollment? other) //Sort
        {
            if (other != null)
                return string.Compare(StudentInfo.FirstName, other.StudentInfo.FirstName);
            else
                return 0;

        }
    }
}
