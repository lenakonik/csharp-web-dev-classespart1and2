using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student lucy = new Student("Lucy", 1, 4.0);
            Console.WriteLine(lucy.Name + ". Student ID: " + lucy.StudentId + ". GPA: " + lucy.Gpa);

            Student sam = new Student("Sam");
            sam.Gpa = 3.9;
            Console.WriteLine(sam.Name + ". Student ID: " + sam.StudentId + ". GPA: " + sam.Gpa);
        }
    }
}
