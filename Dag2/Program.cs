using System;
using System.Collections.Generic;
using System.Linq;

namespace Dag2
{
    class Program
    {
        delegate int voresDelegate(int a, int b);     // voresDelegate er en type ligesom en class vi definerer.
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<int> data = new List<int>() { 1, 2, 3, 4, 5, 6, 3 , 7, 4 };
            Student[] students =
            {
                new Student {   name = "Bo", age = 12,
                                subjectList = new List<Subject>()
                                {
                                    new Subject(){subjectName="SQL", subjectMark=71},
                                    new Subject(){subjectName="DB", subjectMark=82},
                                    new Subject(){subjectName="C#", subjectMark=93},
                                    new Subject(){subjectName="PHP", subjectMark=95},
                                }
                },
                new Student { name = "Palle", age = 12,
                    subjectList = new List<Subject>()
                    {
                        new Subject(){subjectName="SQL", subjectMark=75},
                        new Subject(){subjectName="DB", subjectMark=77},
                        new Subject(){subjectName="C#", subjectMark=65},
                        new Subject(){subjectName="PHP", subjectMark=67},
                    }
                },

                new Student { name = "Bo",age = 34,
                    subjectList = new List<Subject>()
                    {
                        new Subject(){subjectName="SQL", subjectMark=71},
                        new Subject(){subjectName="DB", subjectMark=80},
                        new Subject(){subjectName="C#", subjectMark=45},
                        new Subject(){subjectName="Test", subjectMark=55},
                    }
                },

                new Student { name = "Knud",age = 12,
                    subjectList = new List<Subject>()
                    {
                        new Subject(){subjectName="SQL", subjectMark=90},
                        new Subject(){subjectName="DB", subjectMark=98},
                        new Subject(){subjectName="C#", subjectMark=93},
                        new Subject(){subjectName="Test", subjectMark=95},
                    }
                },
                new Student { name = "Jan",age = 12,
                    subjectList = new List<Subject>()
                    {
                        new Subject(){subjectName="SQL", subjectMark=71},
                        new Subject(){subjectName="DB", subjectMark=82},
                        new Subject(){subjectName="C#", subjectMark=88},
                        new Subject(){subjectName="Test", subjectMark=65},
                    }
                },
            };

            #region temp
            //var result4 = students.Where((s) => s.age < 5).ToList();
            ////var result5 = students.Where((s) => s.subjectList.Select((subject) => subject.subjectName == "SQL")).ToList();
            ////var result5 = students.Where((s) => s.subjectList.Select(f=>f.subjectName))

            //var result5 = students.Select(s => s.subjectList).ToList();

            #endregion temp
            int gg = 6;
            //var result3 = data.FirstOrDefault((hest) => hest == 3);
            #region start
            // var benyttes primært til generic størrelser

            // (Func<int,bool> predicate) - en delegate, 4 forskellige delegates
            // hvad er delegates => reference til en metode (php function)

            // calling Where(anonymous method)
            // anonymous = lambda expression
            var result = data.Where((obj) => obj == 2);

            var result1 = data.Where((obj) => obj == 2 || obj == 3); // tænk if sætning
            
            int tal2 = 9;
            if(tal2 == 2 || tal2 == 7)
            {
                Console.WriteLine("dette kommer til at ske");
            }

                // hvis tal2 er 9 eller tal2 er 7, så er jeg glad!!

            // create variable of voresDelegate
            //voresDelegate name = ourMethod(4, 6); // jeg har fejlet!! hvorfor
            //voresDelegate name = 2;
            // jeg skriver det forkert, den skal pege på noget !!
           
            voresDelegate name = ourMethod; //hex adr
            // then we invoke our method
            int tal = name(3, 7);
            

            //// denne fejler hvis der er mere end et resultat
            var result2 = data.SingleOrDefault((hest) => hest == 1);

            int ged = 99;
            #endregion start

            #region query syntax
            var result6 = (from s in students // foreach(Student s in students)
                          where s.name == "Bo" // en slags if
                          select s).ToList();
            // husk at Execute jeres result6

            var result7 = from obj in students
                          where obj.name == "Palle"
                          select obj;


            #endregion query syntax

            #region Select anonymous
            var result8 = (from obj in students
                          where obj.name == "Palle"
                          select new { // dette minder om noget på H2!! (MVVM)
                              kaffe = obj.name
                          }).ToList();

            var result9 = from obj in students
                          where obj.name == "Bo"
                          select new
                          {
                              obj.name,
                              myAge = obj.age
                          };

                          #endregion Select anonymous
            int ggg = 99;
            //var result9 = students.Where(s=>s.name)
            //    .Select
            #region method syntax
            //var result12 = students.Where((stud) => stud.subjectList.Select((g) => g.subjectName == "SQL"));
            // hvad søren gør vi, kan vi gøre det anderledes? ja det kan vi.
            #endregion method syntax

        }

        public static int ourMethod(int number1, int number2)
        {
            return 2;
        }
    }
}
