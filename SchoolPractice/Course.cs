using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    internal class Course
    {
        public string Name { get; set; }
        public string Teacher { get; set; }
        public List<Student> EnrolledStudents { get; set; } 
        
        public Course(string name, string teacher)
        {
            Name = name;
            Teacher = teacher;
            EnrolledStudents = new List<Student>();
        }

        public void AddStudent(Student s)
        {
            EnrolledStudents.Add(s);
        }
    }

}
