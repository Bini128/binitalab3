
using System;
using System.Collections.Generic;
using System.Linq;

namespace binitalab3
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
    }

    class question2
    {
        //static void Main(string[] args)
        //{
        //    List<Employee> employees = new List<Employee>
        //    {
        //        new Employee { Id = 1, Name = "Binita", Salary = 60000, Address = "Kathmandu" },
        //        new Employee { Id = 2, Name = "Susma", Salary = 45000, Address = "Pokhara" },
        //        new Employee { Id = 3, Name = "Ram", Salary = 70000, Address = "Kathmandu" },
        //        new Employee { Id = 4, Name = "Hari", Salary = 80000, Address = "Kathmandu" },
        //        new Employee { Id = 5, Name = "Bikash", Salary = 40000, Address = "Chitwan" }
        //    };

        //    var result = from e in employees
        //                 where e.Salary > 50000 && e.Address == "Kathmandu"
        //                 select e;

        //    foreach (var emp in result)
        //    {
        //        Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary}, Address: {emp.Address}");
        //    }

        //    Console.ReadLine();
        //    Console.ReadKey();
        //}
    }
}
