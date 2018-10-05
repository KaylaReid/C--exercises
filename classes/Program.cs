using System;
using System.Collections.Generic;

namespace Company // the namespace conects the files that all use this name
{
    // blue print, all empolyeess will be build in this way
    public class Employee {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
    }
    public class Company {

        // Create a constructor method that accepts two arguments:
        //     1. The name of the company
        //     2. The date it was created
        // The constructor will set the value of the public properties

        // method (function) to build new instances of a company 
        public Company(string CompanyName, DateTime CompanyCreatedOn){
            Name = CompanyName;
            CreatedOn = CompanyCreatedOn;
        }

        // blue prints for a company 
        public string Name { get; } 
        public DateTime CreatedOn { get; } 

        // Create a public property for holding a list of current employees
        public List<Employee> employees = new List<Employee>();
        
    }

    class Program
{
    static void Main(string[] args)
    {
        // Create an instance of a company. Name it whatever you like.
        Company Apple = new Company ("Apple", DateTime.Now);

        // Create three employees
        Employee Steve = new Employee ();
        Steve.FirstName = "Steve";
        Steve.LastName = "Brownlee";
        Steve.Title = "fish manager";
        Steve.StartDate = new DateTime (2012, 12, 19);

        Employee Meg = new Employee ();
        Meg.FirstName = "Meg";
        Meg.LastName = "Ducharme";
        Meg.Title = "Leader";
        Meg.StartDate = new DateTime (2009, 11, 30);

        Employee Kimmy = new Employee ();
        Kimmy.FirstName = "Kimmy";
        Kimmy.LastName = "Bird";
        Kimmy.Title = "New Awesome TA";
        Kimmy.StartDate = new DateTime (2016, 3, 7);

        // Assign the employees to the company

        /*
            Iterate the company's employee list and generate the
            simple report shown above
        */
    }
}
}
