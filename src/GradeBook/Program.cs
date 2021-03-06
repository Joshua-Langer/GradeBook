﻿using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Ryan's GradeBook");
            book.AddGrade(99.0);
            book.AddGrade(89.1);
            book.AddGrade(77.5);
            book.AddGrade(48.2);

            var stats = book.GetStatistics();
            
            Console.WriteLine($"The lowest grade is {stats.Low:N1}");
            Console.WriteLine($"The highest grade is {stats.High:N1}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
        }
    }
}

