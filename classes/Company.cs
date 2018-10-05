using System;
using System.Collections.Generic;

namespace Company // the namespace conects the files that all use this name
{
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
        public List<Employee> EmployeeList = new List<Employee>();
    }
}