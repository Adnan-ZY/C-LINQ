# LinqDemo

[![C#](https://img.shields.io/badge/C%23-Visual%20Studio-blue)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![.NET](https://img.shields.io/badge/.NET-Console%20App-green)](https://dotnet.microsoft.com/)
[![License](https://img.shields.io/badge/License-MIT-yellow)](https://opensource.org/licenses/MIT)

A simple C# console application demonstrating **LINQ** (Language Integrated Query) to query and manipulate collections of employees.

---

## Features

- List all employees in the **IT** department.
- Filter employees with a **salary greater than or equal to 40,000**, sorted in descending order.
- Count the number of employees in the IT department.
- Identify the employee with the **highest salary**.

---

## Technologies

- C#  
- .NET (Console Application)  
- LINQ  

---

## Project Structure

LinqDemo/
│
├─ Program.cs # Main program with LINQ examples
├─ Employee.cs # Employee class definition
├─ LinqDemo.sln # Solution file

---

## How to Run

1. Clone the repository:

(```bash
git clone https://github.com/Adnan-ZY/C-LINQ.git
)
Open the solution in Visual Studio or VS Code.

Build the project.

Run the console application.

You should see output for IT employees, filtered salary results, count of IT employees, and the employee with the highest salary.
Example Output
Employees in IT Department:
Ali - IT
Hassan - IT
Bilal - IT

Employe With Salary more than 40000:
Id: 3 - Name: Hassan - Salary: 80000
Id: 4 - Name: Ayesha - Salary: 70000
Id: 2 - Name: Sara - Salary: 40000
Id: 5 - Name: Bilal - Salary: 40000

There are 3 employees in IT department
Hassan have the highest salary

