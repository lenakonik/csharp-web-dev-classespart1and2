using System;
namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId, int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId): this(name, studentId, 0, 0) { }

        public Student(string name): this(name, nextStudentId)
        {
            nextStudentId++;
        }

        // TODO: Complete the AddGrade method.
        public void AddGrade(int courseCredits, double grade)
        {
            // QtyScore before the course
            double totalQtyScore = Gpa * NumberOfCredits;
            // QtyScore after the course
            totalQtyScore += courseCredits * grade;

            // Update the appropriate properties: NumberOfCredits, Gpa
            NumberOfCredits += courseCredits;
            Gpa = totalQtyScore / NumberOfCredits;
        }

        // Determine the grade level of the student based on NumberOfCredits
        public string GetGradeLevel(int credits)
        {
            if (credits < 30)
            {
                return "Freshman";
            }
            else if (credits < 60)
            {
                return "Sophomore";
            }
            else if (credits < 90)
            {
                return "Junior";
            }
            else
            {
                return "Senior";
            }
            
        }

        // custom 'ToString' method returns a well-formatted string rather than just the class fields.
        public override string ToString()
        {
            return Name + " (Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";
        }

        // custom 'Equals' and "GetHashCode" methods
        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   Name == student.Name &&
                   StudentId == student.StudentId &&
                   NumberOfCredits == student.NumberOfCredits &&
                   Gpa == student.Gpa;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, StudentId, NumberOfCredits, Gpa);
        }

    }
}