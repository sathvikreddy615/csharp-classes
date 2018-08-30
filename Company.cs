using System;
using System.Collections.Generic;

namespace CompanyInfo 
{
    public class Company
    {

    // Some readonly properties (let's talk about gets, baby)
    public string Name { get; set; }
    public DateTime DateFounded { get; set; }

    public List<Employee> listOfEmployees = new List<Employee>();

    // Create a public property for holding a list of current employees

    
    /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created

        The constructor will set the value of the public properties
    */

        public Company(string companyName, DateTime datefounded) {
            Name = companyName;
            DateFounded = datefounded;
        }
    }
}
