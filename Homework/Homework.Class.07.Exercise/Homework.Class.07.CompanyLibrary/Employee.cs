using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Homework.Class._07.CompanyLibrary
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        protected double Salary { get; set; }

        public Employee(string firstName, string lastName, Role role, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Salary = salary;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} with Role: {Role} has Salary of {Salary}");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
