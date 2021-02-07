using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        List<double> grades;
        string name = "";
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var averageGrade = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach(var grade in grades)
            {
                highGrade = Math.Max(grade, highGrade);
                lowGrade = Math.Min(grade, lowGrade);
                averageGrade += grade;
            }

            averageGrade /= grades.Count;
            
            Console.WriteLine(name);
            Console.WriteLine($"The lowest grade is {lowGrade:N1}");
            Console.WriteLine($"The highest grade is {highGrade:N1}");
            Console.WriteLine($"The average grade is {averageGrade:N1}");
        }
    }
    
}