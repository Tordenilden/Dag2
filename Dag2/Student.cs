using System;
using System.Collections.Generic;
using System.Text;

namespace Dag2
{
    public class Student //DTO (Data Transfer Object)
    {
        public int id { get; set; }
        public string name { get; set; }
        public int? age { get; set; } // accpetere null, nullable
        public List<Subject> subjectList { get; set; } // 1-M

        // array static dimension
        // List dynamic dimension



        
    }
}
