using System;
using System.Collections.Generic;

namespace companyEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Company BigCorp = new Company("BigCorp", DateTime.Now);
            Employee Jim = new Employee("Jimothee", "McJim", "Floor Washer");
            Employee Dave = new Employee("Davina", "Good", "Drag superstar of the world");
            Employee Drew = new Employee("Drewcilla", "Pointytooth", "Vampire in residence");
            BigCorp.EmployeeList.Add(Jim);
            BigCorp.EmployeeList.Add(Dave);
            BigCorp.EmployeeList.Add(Drew);
            BigCorp.EmployeeReport();
        }
        public class Company
        {

            // Some readonly properties (let's talk about gets, baby)
            public string Name { get; }
            public DateTime CreatedOn { get; }

            // Create a public property for holding a list of current employees
            public List<Employee> EmployeeList {get; set;} = new List<Employee>();

            public Company(string name, DateTime date){
                Name = name;
                CreatedOn = date;
            }

            public void EmployeeReport(){
                 Console.WriteLine("***Employee Roster***");
                foreach (Employee oneEmployee in EmployeeList)
                {
                    Console.WriteLine($"{oneEmployee.FirstName} {oneEmployee.LastName} is currently the {oneEmployee.Title}");
                }
            }

        }
        public class Employee
        {
            public string FirstName {get; set;}

            public string LastName {get; set;}

            public string Title {get; set;}

            public Employee(string firstname, string lastname, string title){
                    FirstName = firstname;
                    LastName = lastname;
                    Title = title;
            }
        }

    }
}
