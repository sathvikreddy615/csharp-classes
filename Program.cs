using System;
using System.Collections.Generic;

namespace CompanyInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.

            Company TennesseeTitans = new Company("Tennessee Titans", new DateTime(1998, 01, 01));

            // Create three employees

            Employee MarcusMariota = new Employee()
            {
                FirstName = "Marcus",
                LastName = "Mariota",
                Title = "Quarterback",
                StartDate = new DateTime(2015, 05, 01)
            };

            Employee DerrickHenry = new Employee()
            {
                FirstName = "Derrick",
                LastName = "Henry",
                Title = "Running Back",
                StartDate = new DateTime(2016, 05, 22)
            };

            Employee CoreyDavis = new Employee()
            {
                FirstName = "Corey",
                LastName = "Davis",
                Title = "Wide Receiver",
                StartDate = new DateTime(2017, 05, 11)
            };

            // Assign the employees to the company

            TennesseeTitans.listOfEmployees.Add(MarcusMariota);
            TennesseeTitans.listOfEmployees.Add(DerrickHenry);
            TennesseeTitans.listOfEmployees.Add(CoreyDavis);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */

            foreach (Employee employee in TennesseeTitans.listOfEmployees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} works for the {TennesseeTitans.Name} as a {employee.Title} since {employee.StartDate.ToShortDateString()}.");
            }
        }
    }
}
