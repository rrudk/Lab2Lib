using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2Lib;

namespace Lab2App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть кількість студентів: ");
            int numberOfStudents = int.Parse(Console.ReadLine());

            ClassLib[] students = new ClassLib[numberOfStudents];

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine($"\nВведіть дані для студента {i + 1}:");

                Console.Write("Введіть ім'я студента: ");
                string firstName = Console.ReadLine();

                Console.Write("Введіть прізвище студента: ");
                string lastName = Console.ReadLine();

                Console.Write("Введіть вік студента: ");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Введіть назву університету: ");
                string university = Console.ReadLine();

                Console.Write("Введіть спеціальність: ");
                string major = Console.ReadLine();

                Console.Write("Введіть рік навчання: ");
                int yearOfStudy = int.Parse(Console.ReadLine());

                Console.Write("Введіть кількість оцінок: ");
                int numberOfGrades = int.Parse(Console.ReadLine());
                double[] grades = new double[numberOfGrades];

                for (int j = 0; j < numberOfGrades; j++)
                {
                    Console.Write($"Введіть оцінку {j + 1}: ");
                    grades[j] = double.Parse(Console.ReadLine());
                }

                students[i] = new ClassLib
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    University = university,
                    Major = major,
                    YearOfStudy = yearOfStudy,
                    Grades = grades
                };

                students[i].CheckScholarship();
            }

            Console.WriteLine("\nДані про студентів:");
            foreach (ClassLib student in students)
            {
                double averageGrade = student.CalculateAverageGrade();
                Console.WriteLine("\nІм'я: " + student.FirstName);
                Console.WriteLine("Прізвище: " + student.LastName);
                Console.WriteLine("Вік: " + student.Age);
                Console.WriteLine("Університет: " + student.University);
                Console.WriteLine("Спеціальність: " + student.Major);
                Console.WriteLine("Рік навчання: " + student.YearOfStudy);
                Console.WriteLine("Середній бал: " + averageGrade.ToString("0.00"));
                Console.WriteLine("Отримує стипендію: " + (student.Scholarship ? "Так" : "Ні"));
            }

            Console.ReadKey();
        }
    }
}
