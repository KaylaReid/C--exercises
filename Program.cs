
using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main() {
        /*
            Start with a collection that is of type IEnumerable, which
            List is and initialize it with some values. This is the
            class sizes for a selection of NSS cohorts.
        */
        // List<int> cohortStudentCount = new List<int>()
        // {
        //     25, 12, 28, 22, 11, 25, 27, 24, 19
        // };

        /*
            Now we need to determine which cohorts fell within the range
            of acceptable size - between 20 and 26 students. Also, sort
            the new enumerable collection in ascending order.
        */

        // filter oporation in linq
        // IEnumerable<int> taco = cohortStudentCount.Where(
        //     studentCount => studentCount < 27 && studentCount > 19
        // )
        // .OrderBy(count => count);

        //  this is linq for each statement
        // IEnumerable is a lightweight list mothods syntax it preferred 
        // IEnumerable<int> idealSizes = from count in cohortStudentCount
            // if / filter statement 
            // you can run many methods off of this
            // where count < 27 && count > 19
            // orderby count ascending
            // select means you are done running things on it and you now want the data back it MUST come last (thing of it as a return statement)
            // select count;

        // Display each number that was the acceptable size
        // foreach (int c in idealSizes)
        // {
        //     Console.WriteLine($"{c}");
        // }

        // Aggergation Methods
        List<int> cohortStudentCount = new List<int>()
        {
            25, 12, 28, 22, 11, 25, 27, 24, 19
        };
        Console.WriteLine($"Largest cohort was {cohortStudentCount.Max()}");
        Console.WriteLine($"Smallest cohort was {cohortStudentCount.Min()}");
        Console.WriteLine($"Total students is {cohortStudentCount.Sum()}");
        Console.WriteLine($"Total students is {cohortStudentCount.Average()}");

        IEnumerable<int> idealSizes = from count in cohortStudentCount
            where count < 27 && count > 19
            orderby count ascending
            select count;

        Console.WriteLine($"Average ideal size is {idealSizes.Average()}");

        // The @ symbol lets you create multi-line strings in C#
        Console.WriteLine($@"
        There were {idealSizes.Count()} ideally sized cohorts
        There have been {cohortStudentCount.Count()} total cohorts");
    }
}