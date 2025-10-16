using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
 {
                new Employee { Id = 1, Name = "Ali", Department = "IT", Age = 25, Salary = 20000 },
                new Employee { Id = 2, Name = "Sara", Department = "HR", Age = 29, Salary = 40000 },
                new Employee { Id = 3, Name = "Hassan", Department = "IT", Age = 35, Salary = 80000 },
                new Employee { Id = 4, Name = "Ayesha", Department = "Finance", Age = 32, Salary = 70000 },
                new Employee { Id = 5, Name = "Bilal", Department = "IT", Age = 22, Salary = 40000 }
            };

            var It_Emp = employees.Where(e => e.Department == "IT");

            Console.WriteLine("Employees in IT Department:");
            
            foreach (var emp in It_Emp)
            {
                Console.WriteLine($"{emp.Name} - {emp.Department}");
            }
            Console.WriteLine();
            Console.WriteLine();

            //Employes with same salary. exp  40000   /// filter with desc

            var Salary_Filter = employees.Where(e => e.Salary >= 40000).OrderByDescending(e => e.Salary);
            Console.WriteLine("Employe With Salary more than 40000: ");

            foreach (var emp in Salary_Filter)
            {
                Console.WriteLine($"Id: {emp.Id} - Name: {emp.Name} - Salary: {emp.Salary}");   
            }

            //Counting how many are in IT dept
            Console.WriteLine();

            var CountIt = employees.Count(e => e.Department == "IT");
            Console.WriteLine($"There are {CountIt} employees in IT department");

            //Checking highest salary earning person 
            Console.WriteLine();

            var HighSal = employees.OrderByDescending(e => e.Salary).First();
            Console.WriteLine($"{HighSal.Name} have the highest salary ");
        }
    }
}