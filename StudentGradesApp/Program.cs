using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents;
            string[] names;
            double[] grades;
            Console.WriteLine("Enter the number of students:");
            if (!int.TryParse(Console.ReadLine(), out numberOfStudents))
            {
                Console.WriteLine("Invalid input. Exiting...");
                return;
            }
            if (numberOfStudents <= 0)
            {
                Console.WriteLine("Invalid number of students. Exiting...");
                return;
            }
            names = new string[numberOfStudents];
            grades = new double[numberOfStudents];

            if (names.Length != grades.Length)
            {
                Console.WriteLine("Array lengths do not match. Exiting...");
                return;
            }
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine($"Enter the name of student {i + 1}:");
                names[i] = Console.ReadLine();
                if (string.IsNullOrEmpty(names[i]))
                {
                    Console.WriteLine("Invalid name. Exiting...");
                    return;
                }
                Console.WriteLine($"Enter the grade of student {i + 1}:");
                if (!double.TryParse(Console.ReadLine(), out grades[i]))
                {
                    Console.WriteLine("Invalid grade. Exiting...");
                    return;
                }
            }
            Console.WriteLine("Student Grades:");
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine($"{names[i]}: {grades[i]}");
            }
            double average = Average.CalculateAverage(grades);
            Console.WriteLine($"Average grade: {average}");

            double highest = Highest.CalculateHighest(grades);
            Console.WriteLine($"Highest grade: {highest}");

            double lowest = Lowest.CalculateLowest(grades);
            Console.WriteLine($"Lowest grade: {lowest}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }

    public static class Lowest
    {
        public static double CalculateLowest(double[] grades)
        {
            return grades.Min();
        }
    }
}
