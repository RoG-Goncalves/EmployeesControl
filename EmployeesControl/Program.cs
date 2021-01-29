using System;
using System.Collections.Generic;

namespace EmployeesControl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int HowManyEmployees = int.Parse(Console.ReadLine());

            for (int i = 0; i < HowManyEmployees; i++)
            {
                Console.Write("Id: ");
                int Id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string Name = Console.ReadLine();

                Console.Write("Salary: ");
                double Salary = double.Parse(Console.ReadLine());

                Employees.Add(new Employee(Id, Name, Salary));
            }

            Console.WriteLine("--------------------------");
            Console.Write("Enter the Id of the employee to increase the salary: ");
            int IdToIncreaseSalary = int.Parse(Console.ReadLine());
            

            Employee EmployeeThatWillGetARaise = 
                Employees.Find(employee => employee.Id == IdToIncreaseSalary);
            Console.WriteLine("--------------------------");
            Console.WriteLine(EmployeeThatWillGetARaise);
            Console.WriteLine("--------------------------");

            if (EmployeeThatWillGetARaise != null)
             {
                Console.Write("Enter the percentage: ");
                double Percentage = double.Parse(Console.ReadLine());
                EmployeeThatWillGetARaise.IncreaseSalary(Percentage);
             }
            else
            {
                Console.WriteLine("Employee not found!");
            }
            Console.WriteLine("--------------------------");

            foreach (Employee employee in Employees)
             {
                 Console.WriteLine(employee);
             }
        }
    }
}
