using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace waMvc5Day13.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName  { get; set; }
        public string Gender { get; set; }
        public int Ages { get; set; }

        public static List<Student> AmbilData()
        {
            List<Student> paket = new List<Student>();
            paket.Add(new Student() { StudentId = 1, StudentName = "Fullan", Ages = 15, Gender = "Male" });
            paket.Add(new Student() { StudentId = 2, StudentName = "Fullan2", Ages = 25, Gender = "Female" });
            paket.Add(new Student() { StudentId = 3, StudentName = "Fullan3", Ages = 35, Gender = "Male" });
            paket.Add(new Student() { StudentId = 4, StudentName = "Fullan4", Ages = 45, Gender = "Female" });
            return paket;
        }
    }
}