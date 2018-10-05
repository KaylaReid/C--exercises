using System;
using System.Collections.Generic;

namespace Company // the namespace conects the files that all use this name
{
    class Program {
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

        Apple.EmployeeList.Add(Steve);
        Apple.EmployeeList.Add(Meg);
        Apple.EmployeeList.Add(Kimmy);

        /*
            Iterate the company's employee list and generate the
            simple report shown above
        */
        // the first "Employee" is the type the 2nd one could be taco as it represents the index the loop is on
        foreach (Employee Employee in Apple.EmployeeList){
            Console.WriteLine($"{Employee.FirstName} {Employee.LastName} {Employee.Title} {Employee.StartDate}");
        }
    }

}
}
