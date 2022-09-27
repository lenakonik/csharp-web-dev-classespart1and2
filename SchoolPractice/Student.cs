using System;

namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1; //static field state is shared among all class instances - i.e. it can increment
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = nextStudentId;   //first time Id is 1
            nextStudentId++; //increment Id for next time
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;

        }

        public Student(string name): this(name, 0, 0){ }
        
    }
}
