using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student student1 = new Student("Maria");
    
            student1.AddGrade(2, 4.0);
            student1.AddGrade(2, 3.0);

            Console.WriteLine(student1);
            Console.WriteLine(student1.GetGradeLevel(student1.NumberOfCredits));

        }
    }
}