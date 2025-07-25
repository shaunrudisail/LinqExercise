﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            
            Console.WriteLine($"Sum: {numbers.Sum()}");

            //TODO: Print the Average of numbers

            Console.WriteLine($"Average: {numbers.Average()}");

            //TODO: Order numbers in ascending order and print to the console

            var orderedNumbers = numbers.OrderBy(n => n).ToArray();
            Console.WriteLine("Numbers in ascending order:");
            foreach (var n in orderedNumbers)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine();

            //TODO: Order numbers in descending order and print to the console

            var descendingNumbers = numbers.OrderByDescending(n => n).ToArray();
            Console.WriteLine("Numbers in descending order:");
            foreach (var n in descendingNumbers)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine();

            //TODO: Print to the console only the numbers greater than 6

            var greaterThanSix = numbers.Where(n => n > 6);
            Console.WriteLine("Numbers greater than six from the Numbers array:");
            foreach (var n in greaterThanSix)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine();

            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**

            Console.WriteLine("Only four numbers:");
            var prints4 = numbers.OrderBy(n => n).Take(4);
            
            foreach (var item in prints4)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order

            Console.WriteLine("Modified value at index 4 and numbers in descending order:");
            numbers[4] = 35;
            var numDescent = numbers.OrderByDescending(n => n);

            foreach (var item in numDescent)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.

            Console.WriteLine($"First name in ascending order beginning with a C or an S:");

            employees.Where(x => x.FirstName[0] == 'C' || x.FirstName[0] == 'S')
                .OrderBy(x => x.FirstName)
                .ToList().ForEach(x => Console.WriteLine(x.FullName));

            Console.WriteLine();
            
            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            Console.WriteLine("List of employees by name and age who are over the age of 26:");
            
            employees.Where(x => x.Age > 26).OrderBy(x => x.Age).
                ThenBy(x => x.FirstName).ToList()
                .ForEach(x => Console.WriteLine(x.FullName, x.Age));

            Console.WriteLine();

            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            Console.WriteLine("Sum of employees' years of experience with parameters:");

            var sumYoe = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).ToList();
            Console.WriteLine(sumYoe.Sum(x => x.YearsOfExperience));

            Console.WriteLine();

            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            Console.WriteLine("Average of employees' years of experience with parameters:");

            var sumYoe2 = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).ToList();
            Console.WriteLine(sumYoe2.Average(x => x.YearsOfExperience));

            Console.WriteLine();

            //TODO: Add an employee to the end of the list without using employees.Add()

            Employee newEmployee = new Employee()
            {
                FirstName = "Shaun",
                LastName = "Rudisail",
                Age = 35,
                YearsOfExperience = 1
            };

            employees.Append(newEmployee).ToList().ForEach(x => Console.WriteLine(x.FullName));

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
