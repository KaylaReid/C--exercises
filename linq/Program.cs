﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

            // IEnumerable<string> LFruits = from fruit in fruits
            // where fruit.StartsWith("L")
            // select fruit;
            // foreach (string LF in LFruits)
            // {
            //     Console.WriteLine($"{LF}");
            // }

            IEnumerable<string> LFruits = from fruit in fruits
            where fruit[0] == 'L'
            select fruit;
            foreach (string LF in LFruits)
            {
                Console.WriteLine($"{LF}");
            }

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            IEnumerable<int> fourSixMultiples = numbers.Where(n => n % 4 == 0 || n % 6 == 0);
            {
                foreach (int n in fourSixMultiples)
                {
                    Console.WriteLine($"{n}");
                }
            }

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

            List<string> descend = names.OrderByDescending(n => n).ToList();

            foreach (string name in descend)
            {
                Console.WriteLine($"{name}");
            }

            // Build a collection of these numbers sorted in ascending order
            List<int> randomNumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            IEnumerable<int> accendingNumbers = from nums in randomNumbers
            orderby nums ascending
            select nums;

            foreach (int N in accendingNumbers)
            {
                Console.WriteLine($"{N}");
            }
           
            // Output how many numbers are in this list
            List<int> numbers3 = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            Console.WriteLine($"There are {numbers3.Count()} numbers in this list");

            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };

            Console.WriteLine($"The sum of these numbers is {purchases.Sum()}");

            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };

            Console.WriteLine($"The most expensive product is {prices.Max()}");

            /*
            Store each number in the following List until a perfect square
            is detected.

            Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
                */
            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };

            List<int> nonSquare = wheresSquaredo.TakeWhile(n => Math.Sqrt(n) % 1 != 0).ToList();
            foreach (int n in nonSquare)
            {
                Console.WriteLine($"List of sqrt {n}");
            }

            /*
                TASK:
                As in the previous exercise, you're going to output the millionaires,
                but you will also display the full name of the bank. You also need
                to sort the millionaires' names, ascending by their LAST name.

                Example output:
                    Tina Fey at Citibank
                    Joe Landy at Wells Fargo
                    Sarah Ng at First Tennessee
                    Les Paul at Wells Fargo
                    Peg Vale at Bank of America
            */



            // Create some banks and store in a List
            List<Bank> banks = new List<Bank>() {
                new Bank(){ Name="First Tennessee", Symbol="FTB"},
                new Bank(){ Name="Wells Fargo", Symbol="WF"},
                new Bank(){ Name="Bank of America", Symbol="BOA"},
                new Bank(){ Name="Citibank", Symbol="CITI"},
            };

            // Build a collection of customers who are millionaires
            List<Customer> customers = new List<Customer>() {
                new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
                new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
                new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
                new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
                new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
                new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
                new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
                new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
                new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
                new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            };

            /*
                You will need to use the `Where()`
                and `Select()` methods to generate
                instances of the following class.

                public class ReportItem
                {
                    public string CustomerName { get; set; }
                    public string BankName { get; set; }
                }
            */
            List<Customer> millionaireReport = customers.Where(c => c.Balance >= 1_000_000)
                .OrderBy(n => n.Name.Split(" ")[1])
                .Select(c => new Customer()
                {
                    Name = c.Name,
                    Bank = banks.Find(BankId => BankId.Symbol == c.Bank).Name,
                    Balance = c.Balance
                }).ToList();

            foreach (Customer customer in millionaireReport)
            {
                Console.WriteLine($"{customer.Name} at {customer.Bank}");
            }





            // first step
            // var millionaires = customers.Where(c => c.Balance >= 1_000_000);

            // foreach(Customer MC in millionaires)
            // {
            //     Console.WriteLine($"Mil customer {MC.Name} {MC.Balance}");
            // }

            /*
                Given the same customer set, display how many millionaires per bank.
                Ref: https://stackoverflow.com/questions/7325278/group-by-in-linq

                Example Output:
                WF 2
                BOA 1
                FTB 1
                CITI 1
            */

            // second step
            // var millionaires = from mill in customers
            // where mill.Balance >= 1_000_000
            // group mill by mill.Bank into MCByBank
            // select new {
            //     MillCustomersBank = MCByBank.Key,
            //     MillCustomers = MCByBank.ToList()
            // };

            // foreach (var MC in millionaires)
            // {
            //     Console.WriteLine($"this them {MC.MillCustomersBank} {MC.MillCustomers.Count()}");
            // }
        }
    }
}
