using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPIWithDB.Model
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int rollNo { get; set; }
        public int marks { get; set; }
    }
}
