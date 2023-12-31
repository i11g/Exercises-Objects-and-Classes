﻿namespace Students
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents=int.Parse(Console.ReadLine());

            List<Students> students = new List<Students>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string [] info = Console.ReadLine().Split(' ').ToArray();
                string firstName = info[0];
                string lastName = info[1];
                double grade = double.Parse(info[2]);

                Students currentStudent = new Students(firstName,lastName,grade);

                students.Add(currentStudent);                
            }

            students=students.OrderByDescending(x=>x.Grade).ToList();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }

    public class Students
    {
        public Students (string firstName,string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
}