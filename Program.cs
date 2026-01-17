using System;
using System.Collections.Generic;

namespace StudentGradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("  STUDENT GRADE CALCULATOR"); Console.WriteLine("Welcome! This calculator helps you compute student grades.\n");
            Console.WriteLine("=================================\n");

            // Get student name
            Console.Write("Enter student name: ");
            string studentName = Console.ReadLine();

            // Get number of subjects
            Console.Write("Enter number of subjects: ");
            int numSubjects = int.Parse(Console.ReadLine());

            // Store grades
            List<double> grades = new List<double>();
            List<string> subjects = new List<string>();

            // Input grades for each subject
            for (int i = 0; i < numSubjects; i++)
            {
                Console.Write($"\nEnter subject {i + 1} name: ");
                string subject = Console.ReadLine();
                subjects.Add(subject);

                Console.Write($"Enter grade for {subject}: ");
                double grade = double.Parse(Console.ReadLine());
                grades.Add(grade);
            }

            // Calculate average
            double average = CalculateAverage(grades);
            string letterGrade = GetLetterGrade(average);

            // Display results
            DisplayResults(studentName, subjects, grades, average, letterGrade);
        }

        static double CalculateAverage(List<double> grades)
        {
            double sum = 0;
            foreach (double grade in grades)
            {
                sum += grade;
            }
            return sum / grades.Count;
        }

        static string GetLetterGrade(double average)
        {
            if (average >= 90) return "A - Excellent";
            else if (average >= 85) return "B+ - Very Good";
            else if (average >= 80) return "B - Good";
            else if (average >= 75) return "C - Fair";
            else return "F - Failed";
        }

        static void DisplayResults(string name, List<string> subjects, List<double> grades, double average, string letterGrade)
        {
            Console.WriteLine("\n=================================");
            Console.WriteLine("         GRADE REPORT");
            Console.WriteLine("=================================");
            Console.WriteLine($"Student: {name}");
            Console.WriteLine("---------------------------------");
            
            for (int i = 0; i < subjects.Count; i++)
            {
                Console.WriteLine($"{subjects[i]}: {grades[i]}");
            }
            
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Average: {average:F2}");
            Console.WriteLine($"Letter Grade: {letterGrade}");
            Console.WriteLine("=================================\n");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}