using Ovelse1_Slut;
using System;
using System.Collections.Generic;

namespace Ovelse_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            
            


       
       
            Teacher t1 = new Teacher(1, "- Niels", " Olsen ", new DateTime(1991, 03, 01));
            Teacher t2 = new Teacher(1, "- Peter", "Jensen   ", new DateTime(1996, 04, 01));
            Teacher t3 = new Teacher(1, "- Tom", "HAnsen  ", new DateTime(1992, 02, 04));



            Course oop = new Course(Subject.OOP, t1);
            Course studieteknik = new Course(Subject.Studieteknik, t2);
            Course grprog = new Course(Subject.Grprog, t3);

            try
            {

                Enrollment e1 = new();

                bool Stop = false;
                while (!Stop)
                {

                    Console.WriteLine("Angive Elevns Id");
                    int id = int.Parse(Console.ReadLine());

                    Console.WriteLine("Angiv Elevns Navn");
                    string fornavn = Console.ReadLine();

                    Console.WriteLine("Angiv Elevns EfterNavn");
                    string efteravn = Console.ReadLine();

                    Console.WriteLine("Angiv Fødselsdag");
                    DateTime fødselsdag = Convert.ToDateTime(Console.ReadLine());

                    Console.WriteLine("Angiv Fag: (Vælg mellem disse fag) Husk  med stor bogstaver ");
                    Console.WriteLine("Studieteknik  , Grprog ,OOP");
                    string fag = Console.ReadLine();

                    Student s1 = new Student(id, fornavn, efteravn, fødselsdag);
                    Console.WriteLine("Indtast Q for at stoppe  ,eller tryk for at forsæte ");
                    string i = Console.ReadLine();
             

                    if (i == "Q")
                    {
                        Stop = true;
                    }



                    if (fag == Subject.Studieteknik.ToString())
                    {

                        e1.Enrollments.Add(new Enrollment(s1, studieteknik));

                    }

                    else if (fag == Subject.Grprog.ToString())
                    {

                        e1.Enrollments.Add(new Enrollment(s1, grprog));
                    }

                    else if (fag == Subject.OOP.ToString())
                    {

                        e1.Enrollments.Add(new Enrollment(s1, oop));
                    }
                }


                //e1.Enrollments.Sort();
                try
                {
                        foreach (Enrollment items in e1.Enrollments)

                        {
                            Console.WriteLine($"{items.StudentInfo.FirstName} , {items.StudentInfo.LastName} er tilmedt {items.CourseInfo.CourseName}");
                         
                            if (items.CourseInfo.CourseName == Subject.Studieteknik)
                            {
                                List<Enrollment> lst1 = e1.Enrollments.Where(x => x.CourseInfo.CourseName == Subject.OOP).ToList();
                                int c=lst1.Count();
                                if(c > 16)
                                {
                                    throw new Exception("Det er for mange tilmedninger");
                                }
                                if (c < 8)
                                {
                                    throw new Exception("Det er ikke nok tilmedning");
                                }
                            }
                            if (items.CourseInfo.CourseName == Subject.Grprog)
                            {
                                 List<Enrollment> lst2 = e1.Enrollments.Where(x => x.CourseInfo.CourseName == Subject.OOP).ToList();

                                int c1 = lst2.Count();
                                if (c1 > 16)
                                {
                                    throw new Exception("Det er for mange tilmedninger");
                                }
                                if (c1 < 8)
                                {
                                    throw new Exception("Det er ikke nok tilmedning");
                                }
                            }
                            if (items.CourseInfo.CourseName == Subject.OOP)
                            {
                                List<Enrollment> lst3 = e1.Enrollments.Where(x => x.CourseInfo.CourseName == Subject.OOP).ToList();
                                int c2 = lst3.Count();

                                if (c2 > 16)
                                {
                                    throw new Exception("Det er for mange tilmedninger");
                                }
                                if (c2 < 8)
                                {
                                    throw new Exception("Det er ikke nok tilmedning");
                                }

                            }





                        }



                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }






















                    //if (e1.Enrollments.Count < 8)
                    //{
                    //    throw new Exception("Det er ikke nok elever");
                    //}
                    //if (e1.Enrollments.Count > 16)
                    //{
                    //    throw new Exception("Det er for mange elver");
                    //}

                    // s10.GetAge();   Age

                    // s1.GetAllCourse(e1);


                    //     s5.GetStudentName(e1);
                    //    s1.GetAllCourse(e1);


                    Console.ReadLine();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }





        }


    }
}