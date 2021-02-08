using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        List<double> grades;
        public string Name = "";
        public Book(string name)
        {
            Name = name;
            grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0) 
            {
                grades.Add(grade);    
            }
            else
            {
                Console.WriteLine("Invalid value");
            }
            
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            
            for(var i = 0; i < grades.Count; i++)
            {
                result.High = Math.Max(grades[i], result.High);
                result.Low = Math.Min(grades[i], result.Low);
                result.Average += grades[i];
            }

            result.Average /= grades.Count;
            return result;
        }
    }
    
}